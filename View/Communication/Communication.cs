using Common;
using Domain;
using View.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace View.Communication
{
    public class Communication
    {
        private static Communication instance;

        private Socket socket;
        private CommunicationClient client;
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }
        private Communication()
        {

        }
        public void Connect()
        {
            if (socket != null && socket.Connected)
            {
                return;
            }
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9000);
            client = new CommunicationClient(socket);

        }

        internal void Disconnect()
        {
            socket.Close();
            socket = null;
        }

        //implementiraju se sistemske operacije

        internal Administrator Login(string korisnickoIme, string sifra)
        {
            Request request = new Request()
            {
                Operation = Operation.Login,
                RequestObject = new Administrator { KorisnickoIme = korisnickoIme, Sifra = sifra }
            };
            client.SendRequest(request);
            return (Administrator)client.GetResponseResult();
        }

        internal List<Autor> GetAutor()
        {
            Request request = new Request() { Operation = Operation.GetAutor };
            client.SendRequest(request);
            return (List<Autor>)client.GetResponseResult();
        }

        internal void SaveClan(Clan clan)
        {
            Request request = new Request() { Operation = Operation.SaveClan, RequestObject = clan };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal List<Clan> GetClan()
        {
            Request request = new Request() { Operation = Operation.GetClan };
            client.SendRequest(request);
            return (List<Clan>)client.GetResponseResult();
        }

        internal List<Clan> GetClanWithCondition(Clan clan)
        {
            Request request = new Request() { Operation = Operation.GetClanWithCondition, RequestObject = clan };
            client.SendRequest(request);
            return (List<Clan>)client.GetResponseResult();
        }

        internal Clan GetOneClan(Clan clan)
        {
            Request request = new Request() { Operation = Operation.GetOneClan, RequestObject = clan };
            client.SendRequest(request);
            return (Clan)client.GetResponseResult();
        }

        internal void UpdateClan(Clan clan)
        {
            Request request = new Request() { Operation = Operation.UpdateClan, RequestObject = clan };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void DeleteClan(Clan clan)
        {
            Request request = new Request() { Operation = Operation.DeleteClan, RequestObject = clan };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void SaveKnjiga(Knjiga knjiga)
        {
            Request request = new Request() { Operation = Operation.SaveKnjiga, RequestObject = knjiga };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal List<Knjiga> GetKnjiga()
        {
            Request request = new Request() { Operation = Operation.GetKnjiga };
            client.SendRequest(request);
            return (List<Knjiga>)client.GetResponseResult();
        }

        internal List<Knjiga> GetKnjigaWithCondition(Knjiga knjiga)
        {
            Request request = new Request() { Operation = Operation.GetKnjigaWithCondition, RequestObject = knjiga };
            client.SendRequest(request);
            return (List<Knjiga>)client.GetResponseResult();
        }

        internal Knjiga GetOneKnjiga(Knjiga knjiga)
        {
            Request request = new Request() { Operation = Operation.GetOneKnjiga, RequestObject = knjiga };
            client.SendRequest(request);
            return (Knjiga)client.GetResponseResult();
        }

        internal void DeleteKnjiga(Knjiga knjiga)
        {
            Request request = new Request() { Operation = Operation.DeleteKnjiga, RequestObject = knjiga };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void SaveIzdanje(Izdanje izdanje)
        {
            Request request = new Request() { Operation = Operation.SaveIzdanje, RequestObject = izdanje };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void SaveIznajmljivanje(Iznajmljivanje iznajmljivanje)
        {
            Request request = new Request() { Operation = Operation.SaveIznajmljivanje, RequestObject = iznajmljivanje };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal List<Iznajmljivanje> GetIznajmljivanje()
        {
            Request request = new Request() { Operation = Operation.GetIznajmljivanje };
            client.SendRequest(request);
            return (List<Iznajmljivanje>)client.GetResponseResult();
        }
        
        internal List<Iznajmljivanje> GetIznajmljivanjeWithCondition(Iznajmljivanje iznajmljivanje)
        {
            Request request = new Request() { Operation = Operation.GetIznajmljivanjeWithCondition, RequestObject = iznajmljivanje };
            client.SendRequest(request);
            return (List<Iznajmljivanje>)client.GetResponseResult();
        }

        internal Iznajmljivanje GetOneIznajmljivanje(Iznajmljivanje iznajmljivanje)
        {
            Request request = new Request() { Operation = Operation.GetOneIznajmljivanje, RequestObject = iznajmljivanje };
            client.SendRequest(request);
            return (Iznajmljivanje)client.GetResponseResult();
        }

        internal void DeleteIznajmljivanje(Iznajmljivanje iznajmljivanje)
        {
            Request request = new Request() { Operation = Operation.DeleteIznajmljivanje, RequestObject = iznajmljivanje };
            client.SendRequest(request);
            client.GetResponseResult();
        }

    }
}
