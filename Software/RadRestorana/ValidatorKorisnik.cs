using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramskoIntenjerstvo
{
    public class ValidatorKorisnik
    {
        public bool ProvjeriKorisnickoIme(string korime)
        {
            Korisnik pomocni = null;
            using (var context = new Entities())
            {
                var query = from k in context.Korisnik
                            where k.korisnicko_ime == korime
                            select k;
                pomocni = query.SingleOrDefault();
            }
            if (pomocni == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
