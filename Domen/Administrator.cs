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
    public class Administrator : IEntity
    {
        public int Id { get; set; }
        public bool StatusUlogovan { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }

        [Browsable(false)]
        public string TableName => "Administrator";
        [Browsable(false)]
        public string InsertValues => $"{Id},'{Ime}','{Prezime}','{KorisnickoIme}','{Sifra}'";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "ad";
        [Browsable(false)]
        public object SelectValues => "*";
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
                result.Add(new Administrator
                {
                    Id = (int)reader[0],
                    Ime = (string)reader[1],
                    Prezime = (string)reader[2],
                    KorisnickoIme = (string)reader[3],
                    Sifra = (string)reader[4]
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
