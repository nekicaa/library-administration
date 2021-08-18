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
    public class Izdanje : IEntity
    {
        public Knjiga Knjiga { get; set; }
        public Autor Autor { get; set; }
        public int RedniBroj { get; set; }
        public string GodinaStampe { get; set; }
        public string Izdavac { get; set; }

        [Browsable(false)]
        public string TableName => "Izdanje";
        [Browsable(false)]
        public string InsertValues => $"{Knjiga.Id},{Autor.Id},'{GodinaStampe}','{Izdavac}'";
        [Browsable(false)]
        public string IdName => "RedniBroj";
        [Browsable(false)]
        public string JoinCondition => "on (k.Id=i.KnjigaId) join Autor a on (a.Id=i.AutorId)";
        [Browsable(false)]
        public string JoinTable => "join Knjiga k";
        [Browsable(false)]
        public string TableAlias => "i";
        [Browsable(false)]
        public object SelectValues => "k.Id,k.Naziv,k.ISBN,k.Zanr,a.Id,a.Ime,a.Prezime,i.RedniBroj,i.GodinaStampe,i.Izdavac";
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
                result.Add(new Izdanje
                {
                    Knjiga = new Knjiga() { Id=(int)reader[0], Naziv=(string)reader[1], ISBN=(string)reader[2], Zanr=(string)reader[3]},
                    Autor = new Autor() { Id=(int)reader[4], Ime=(string)reader[5], Prezime=(string)reader[6]},
                    RedniBroj = (int)reader[7],
                    GodinaStampe = (string)reader[8],
                    Izdavac = (string)reader[9]
                });
            }
            return result;
        }

        public override string ToString()
        {
            return $"{RedniBroj}. {Knjiga.Naziv} - {Autor.Ime} {Autor.Prezime}";
        }
    }
}
