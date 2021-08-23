using Domain;
using Storage;
using Storage.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations.AdministratorSO;
using SystemOperations.AutorSO;
using SystemOperations.ClanSO;
using SystemOperations.IznajmljivanjeSO;
using SystemOperations.KnjigaSO;

namespace Controller
{
    public class Controller
    {
        private IGenericRepository repository;

        public Administrator Administrator { get; set; }

        #region singleton
        private static Controller instance;

        private static object _lock = new object();
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Controller();
                        }
                    }
                }
                return instance;
            }
        }

        private Controller()
        {
            repository = new GenericRepository();
        }
        #endregion

        // dodati SO

        public Administrator Login(Administrator administrator)
        {
            LoginSO so = new LoginSO();
            so.ExecuteTemplate(administrator);
            return so.Result;
        }

        public List<Autor> GetAutor()
        {
            VratiListuAutora so = new VratiListuAutora();
            so.ExecuteTemplate(new Autor());
            return so.Result;
        }

        public void SaveClan(Clan clan)
        {
            ZapamtiClana so = new ZapamtiClana();
            so.ExecuteTemplate(clan);
        }

        public List<Clan> GetClan()
        {
            VratiListuClanova so = new VratiListuClanova();
            so.ExecuteTemplate(new Clan());
            return so.Result;
        }

        public List<Clan> GetClanWithCondition(Clan clan)
        {
            PretraziClanove so = new PretraziClanove();
            so.ExecuteTemplate(clan);
            return so.Result;
        }

        public Clan GetOneClan(Clan clan)
        {
            UcitajOdabranogClana so = new UcitajOdabranogClana();
            so.ExecuteTemplate(clan);
            return so.Result;
        }

        public void UpdateClan(Clan clan)
        {
            SacuvajIzmeneClana so = new SacuvajIzmeneClana();
            so.ExecuteTemplate(clan);
        }

        public void DeleteClan(Clan clan)
        {
            ObrisiOdabranogClana so = new ObrisiOdabranogClana();
            so.ExecuteTemplate(clan);
        }

        public void SaveKnjiga(Knjiga knjiga)
        {
            ZapamtiKnjigu so = new ZapamtiKnjigu();
            so.ExecuteTemplate(knjiga);
        }

        public List<Knjiga> GetKnjiga()
        {
            VratiListuKnjiga so = new VratiListuKnjiga();
            so.ExecuteTemplate(new Knjiga());
            return so.Result;
        }

        public List<Knjiga> GetKnjigaWithCondition(Knjiga knjiga)
        {
            PretraziKnjige so = new PretraziKnjige();
            so.ExecuteTemplate(knjiga);
            return so.Result;
        }

        public Knjiga GetOneKnjiga(Knjiga knjiga)
        {
            UcitajOdabranuKnjigu so = new UcitajOdabranuKnjigu();
            so.ExecuteTemplate(knjiga);
            return so.Result;
        }

        public void DeleteKnjiga(Knjiga knjiga)
        {
            ObrisiOdabranuKnjigu so = new ObrisiOdabranuKnjigu();
            so.ExecuteTemplate(knjiga);
        }

        public void SaveIznajmljivanje(Iznajmljivanje izn)
        {
            ZapamtiIznajmljivanje so = new ZapamtiIznajmljivanje();
            so.ExecuteTemplate(izn);
        }

        public List<Iznajmljivanje> GetIznajmljivanje()
        {
            VratiListuIznajmljivanja so = new VratiListuIznajmljivanja();
            so.ExecuteTemplate(new Iznajmljivanje());
            return so.Result;
        }

        /*public List<StavkaIznajmljivanja> GetStavkeIznajmljivanja()
        {
            UcitajStavkeIznajmljivanja so = new UcitajStavkeIznajmljivanja();
            so.ExecuteTemplate(new StavkaIznajmljivanja());
            return so.Result;
        }*/

        public List<Iznajmljivanje> GetIznajmljivanjeWithCondition(Iznajmljivanje izn)
        {
            PretraziIznajmljivanje so = new PretraziIznajmljivanje();
            so.ExecuteTemplate(izn);
            return so.Result;
        }

        public Iznajmljivanje GetOneIznajmljivanje(Iznajmljivanje izn)
        {
            UcitajOdabranoIznajmljivanje so = new UcitajOdabranoIznajmljivanje();
            so.ExecuteTemplate(izn);
            return so.Result;
        }

        public void DeleteIznajmljivanje(Iznajmljivanje izn)
        {
            ObrisiIznajmljivanje so = new ObrisiIznajmljivanje();
            so.ExecuteTemplate(izn);
        }
    }
}
