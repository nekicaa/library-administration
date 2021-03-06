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
    public class Clan : IEntity
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Kontakt { get; set; }

        [Browsable(false)]
        public string TableName => "Clan";
        [Browsable(false)]
        public string InsertValues => $"'{Ime}','{Prezime}','{DatumRodjenja}','{Kontakt}'";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "c";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => $"Id={Id}";
        [Browsable(false)]
        public string GetUpdateValues => $"Ime='{Ime}', Prezime='{Prezime}', DatumRodjenja='{DatumRodjenja}', Kontakt='{Kontakt}'";

        public string Uslov;

        [Browsable(false)]
        public string GeneralCondition => $"{Uslov}";
        [Browsable(false)]
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Clan
                {
                    Id = (int)reader[0],
                    Ime = (string)reader[1],
                    Prezime = (string)reader[2],
                    DatumRodjenja = (DateTime)reader[3],
                    Kontakt = (string)reader[4]
                });
            }
            return result;
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
