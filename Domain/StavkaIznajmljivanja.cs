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
        public int RedniBroj { get; set; }
        public int Kolicina { get; set; }
        public Knjiga Knjiga { get; set; }

        [Browsable(false)]
        public string TableName => "StavkaIznajmljivanja";
        [Browsable(false)]
        public string InsertValues => $"{Kolicina},{Knjiga.Id}";
        [Browsable(false)]
        public string IdName => "RedniBroj";
        [Browsable(false)]
        public string JoinCondition => "on (k.Id=si.KnjigaId)";
        [Browsable(false)]
        public string JoinTable => "join Knjiga k";
        [Browsable(false)]
        public string TableAlias => "si";
        [Browsable(false)]
        public object SelectValues => "si.RedniBroj, si.Kolicina, k.Id, k.Naziv, k.ISBN, k.Zanr";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string GetUpdateValues => "";

        public string Uslov;

        [Browsable(false)]
        public string GeneralCondition => $"'{Uslov}'";
        [Browsable(false)]
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new StavkaIznajmljivanja
                {
                    RedniBroj = (int)reader[0],
                    Kolicina = (int)reader[1],
                    Knjiga = new Knjiga() { Id=(int)reader[2], Naziv=(string)reader[3], ISBN=(string)reader[4], Zanr=(string)reader[5]}
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
