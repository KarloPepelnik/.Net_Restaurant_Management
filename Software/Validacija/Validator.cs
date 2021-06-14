using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProgramskoIntenjerstvo
{
    public class Validator
    {
        private Regex RxLozinka { get; set; }
        private Regex RxEmail { get; set; }

        public Validator()
        {
            RxLozinka = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
            RxEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }

        public bool ProvjeriLozinku(string lozinka)
        {
            if(RxLozinka.Match(lozinka).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ProvjeriEmail(string email)
        {
            if (RxEmail.Match(email).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ProvjeriObadvijeLozinke(string lozinka1, string lozinka2)
        {
            if(lozinka1 == lozinka2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
