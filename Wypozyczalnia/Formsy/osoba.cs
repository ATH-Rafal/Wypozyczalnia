using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Formsy
{
    public class osoba : IEquatable<osoba>
    {
        private int id_osoby, id_roli;

        public osoba(int _id_osoby, int _id_roli)
        {
            id_osoby = _id_osoby;
            id_roli = _id_roli;
        }

        public int _id_osoby
        {
            get
            {
                return id_osoby;
            }
            set
            {
                id_osoby = value;
            }
        }

        public int _id_roli
        {
            get
            {
                return id_roli;
            }
            set
            {
                id_roli = value;
            }
        }

        public bool Equals(osoba other)
        {
            return this.id_osoby == other.id_osoby &&
               this.id_roli == other.id_roli;          
        }
    }
}
