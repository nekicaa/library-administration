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

        public void StartHandler()
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
                //obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
                //drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan
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
                case Operation.Login:
                    response.Result = Controller.Controller.Instance.Login((Administrator)request.RequestObject);
                    ulogovaniAdministrator = (Administrator)response.Result;
                    administratori.Add(ulogovaniAdministrator);
                    break;
                case Operation.SaveClan:
                    Controller.Controller.Instance.SaveClan((Clan)request.RequestObject);
                    break;
                case Operation.GetClan:
                    response.Result = Controller.Controller.Instance.GetClan();
                    break;
                case Operation.GetClanWithCondition:
                    response.Result = Controller.Controller.Instance.GetClanWithCondition((Clan)request.RequestObject);
                    break;
                case Operation.GetOneClan:
                    response.Result = Controller.Controller.Instance.GetOneClan((Clan)request.RequestObject);
                    break;
                case Operation.UpdateClan:
                    Controller.Controller.Instance.UpdateClan((Clan)request.RequestObject);
                    break;
                case Operation.DeleteClan:
                    Controller.Controller.Instance.DeleteClan((Clan)request.RequestObject);
                    break;
                case Operation.GetAutor:
                    response.Result = Controller.Controller.Instance.GetAutor();
                    break;
                case Operation.SaveKnjiga:
                    Controller.Controller.Instance.SaveKnjiga((Knjiga)request.RequestObject);
                    break;
                case Operation.GetKnjiga:
                    response.Result = Controller.Controller.Instance.GetKnjiga();
                    break;
                case Operation.GetKnjigaWithCondition:
                    response.Result = Controller.Controller.Instance.GetKnjigaWithCondition((Knjiga)request.RequestObject);
                    break;
                case Operation.GetOneKnjiga:
                    response.Result = Controller.Controller.Instance.GetOneKnjiga((Knjiga)request.RequestObject);
                    break;
                case Operation.DeleteKnjiga:
                    Controller.Controller.Instance.DeleteKnjiga((Knjiga)request.RequestObject);
                    break;
                case Operation.SaveIzdanje:
                    Controller.Controller.Instance.SaveIzdanje((Izdanje)request.RequestObject);
                    break;
                case Operation.SaveIznajmljivanje:
                    Controller.Controller.Instance.SaveIznajmljivanje((Iznajmljivanje)request.RequestObject);
                    break;
                case Operation.GetIznajmljivanje:
                    response.Result = Controller.Controller.Instance.GetIznajmljivanje();
                    break;
                case Operation.GetIznajmljivanjeWithCondition:
                    response.Result = Controller.Controller.Instance.GetIznajmljivanjeWithCondition((Iznajmljivanje)request.RequestObject);
                    break;
                case Operation.GetOneIznajmljivanje:
                    response.Result = Controller.Controller.Instance.GetOneIznajmljivanje((Iznajmljivanje)request.RequestObject);
                    break;
                case Operation.DeleteIznajmljivanje:
                    Controller.Controller.Instance.DeleteIznajmljivanje((Iznajmljivanje)request.RequestObject);
                    break;
            }
            return response;
        }

        internal void Stop()
        {
            client.Close();

        }
    }
}
