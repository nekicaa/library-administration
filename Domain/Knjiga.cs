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
    public class Knjiga : IEntity
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string ISBN { get; set; }
        public string Zanr { get; set; }
        [Browsable(false)]
        public List<Izdanje> Izdanje { get; set; }  // da li lista ili samo jedno izdanje

        [Browsable(false)]
        public string TableName => "Knjiga";
        [Browsable(false)]
        public string InsertValues => $"'{Naziv}','{ISBN}','{Zanr}'";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "k";
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
                result.Add(new Knjiga
                {
                    Id = (int)reader[0],
                    Naziv = (string)reader[1],
                    ISBN = (string)reader[2],
                    Zanr = (string)reader[3]
                });
            }
            return result;
        }

        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
