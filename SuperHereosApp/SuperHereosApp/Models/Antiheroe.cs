using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHereosApp.Models;

namespace SuperHereosApp.Models
{
    internal class Antiheroe: SuperHeroe
    {
        public string acciondeAntiheroe (string accion)
        {
            return $"El Antiheroe {namexIdentidad} esta realizando la accion de {accion}!";
        }
    }
}
