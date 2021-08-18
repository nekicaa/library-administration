﻿using Common;
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

        //implementiraju se sistemske operacije
    }
}
