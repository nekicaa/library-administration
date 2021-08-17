using Common;
using Controller;
using Domain;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    internal class ClientHandler
    {
        private Socket client;
        private readonly BindingList<Administrator> administratori;
        private Administrator ulogovaniAdministrator;


        public ClientHandler(Socket client, BindingList<Administrator> administratori)
        {
            this.client = client;
            this.administratori = administratori;
        }

        internal void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(client);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response;
                    try
                    {
                        response = ProcessRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response();
                        response.IsSuccessful = false;
                        response.Error = ex.Message;
                    }
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                administratori.Remove(ulogovaniAdministrator);

            }
            catch (SerializationException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                //obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
                //drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan
                administratori.Remove(ulogovaniAdministrator);
            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            response.IsSuccessful = true;
            switch (request.Operation)
            {
                /*case Operation.Login:
                    Administrator a = Controller.Instance.Login((Administrator)request.RequestObject);
                    if (a != null)
                    {
                        a.StatusUlogavan = administratori.Any(aa => aa.Sifra == a.Sifra);
                        ulogovaniAdministrator = a;
                        administratori.Add(ulogovaniAdministrator);
                    }
                    response.Result = a;
                    //ulogovaniAdministrator = (Administrator)response.Result;
                    break;*/
                
            }
            return response;
        }

        internal void Stop()
        {
            client.Close();

        }
    }
}
