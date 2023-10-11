using SuperHereosApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHereosApp
{
    internal class Info
    {
        public void ImprimirInfo (Isuperheroe SuperHeroe) {

            Console.WriteLine(SuperHeroe.GetSuperHeroe());
        }
    }
}
