using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Memento
{
    class Memento
    {

        protected string _etat;

        public string etat
        {
            get { return _etat; }
            set { _etat = value; }
        }


    }
}