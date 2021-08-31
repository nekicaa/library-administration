using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class StavkaIznajmljivanja : IEntity
    {
        [Browsable(false)]
        public Iznajmljivanje Iznajmljivanje { get; set; }
        public int RedniBroj { get; set; }
        public int Kolicina { get; set; }
        public Knjiga Knjiga { get; set; }

        [Browsable(false)]
        public string TableName => "StavkaIznajmljivanja";
        [Browsable(false)]
        public string InsertValues => $"{Iznajmljivanje.Id},{RedniBroj},{Kolicina},{Knjiga.Id}";
        [Browsable(false)]
        public string IdName => "RedniBroj";
        [Browsable(false)]
        public string JoinCondition => "on (k.Id=si.KnjigaId) join Iznajmljivanje iz on (iz.Id=si.IznajmljivanjeId)";
        [Browsable(false)]
        public string JoinTable => "join Knjiga k";
        [Browsable(false)]
        public string TableAlias => "si";
        [Browsable(false)]
        public object SelectValues => "si.IznajmljivanjeId, si.RedniBroj, si.Kolicina, k.Id, k.Naziv, k.ISBN, k.Zanr";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string GetUpdateValues => "";

        public string Uslov;

        [Browsable(false)]
        public string GeneralCondition => $"{Uslov}";
        [Browsable(false)]
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new StavkaIznajmljivanja
                {
                    Iznajmljivanje = new Iznajmljivanje
                    {
                        Id = (int)reader[0]
                    },
                    RedniBroj = (int)reader[1],
                    Kolicina = (int)reader[2],
                    Knjiga = new Knjiga() { Id=(int)reader[3], Naziv=(string)reader[4], ISBN=(string)reader[5], Zanr=(string)reader[6]}
                });
            }
            return result;
        }

        public override string ToString()
        {
            return $"{RedniBroj}. {Knjiga.Naziv} {Kolicina}";
        }
    }
}
