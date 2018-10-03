using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class User
    {
        private string _nom;
        private string _prenom;
        private int _age;

        public string nom
        {
            get => _nom;
            set => _nom = value.ToUpper();
        }
        public string prenom
        {
            get { return _prenom; }
            set { _prenom = value.ToLower(); }
        }
        public int age
        {
            get { return _age; }
            set { _age = value-5; }
        }

       
    }
}
