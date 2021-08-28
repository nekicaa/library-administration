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
    public class Iznajmljivanje : IEntity
    {
        [Browsable(false)]
        public int Id { get; set; }
        public DateTime DatumIznajmljivanja { get; set; }
        public DateTime RokZaRazduzivanje { get; set; }
        public Clan Clan { get; set; }
        [Browsable(false)]
        public List<StavkaIznajmljivanja> Stavke { get; set; }

        [Browsable(false)]
        public string TableName => "Iznajmljivanje";
        [Browsable(false)]
        public string InsertValues => $"'{DatumIznajmljivanja}','{RokZaRazduzivanje}',{Clan.Id}";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "on (c.Id=iz.ClanId)";
        [Browsable(false)]
        public string JoinTable => "join Clan c";
        [Browsable(false)]
        public string TableAlias => "iz";
        [Browsable(false)]
        public object SelectValues => "iz.Id, iz.DatumIznajmljivanja, iz.RokZaRazduzivanje, c.Id, c.Ime, c.Prezime, c.DatumRodjenja, c.Kontakt";
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
                result.Add(new Iznajmljivanje
                {
                    Id = (int)reader[0],
                    DatumIznajmljivanja = (DateTime)reader[1],
                    RokZaRazduzivanje = (DateTime)reader[2],
                    Clan = new Clan() { Id=(int)reader[3], Ime=(string)reader[4], Prezime=(string)reader[5], DatumRodjenja=(DateTime)reader[6], Kontakt=(string)reader[7]}

                });
            }
            return result;
        }

        public override string ToString()
        {
            return $"{Clan.Ime} {Clan.Prezime} - {DatumIznajmljivanja}";
        }
    }
}
