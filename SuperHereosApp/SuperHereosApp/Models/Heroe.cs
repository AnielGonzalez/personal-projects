using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHereosApp.Models
{
    internal abstract class Heroe
    {
        public abstract string name { get; set; }
        public abstract string SalvarElMundo();

        public virtual string SalvarWakanda()
        {
            return $"{name} ha salvado Wakanda!!";
        }
    }
}
