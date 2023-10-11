using SuperHereosApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHereosApp.Models
{
    class SuperHeroe : Heroe, Isuperheroe

    {
        private string _name;
        public int id { get; set; } = 1;
        public override string name {  
            get
            {
                return _name;
            }
            set
            {
                _name = value.Trim();
            }
        }
        public string namexIdentidad
        {
            get 
            { 
                return $"{name} ({identidadSecreta})";
            }
        }
        public string identidadSecreta { get; set; }
        public string ciudad { get; set; }
        public List<superPoder> SuperPoderes = new List<superPoder>();
        public bool puedovolar;

        public SuperHeroe()
        {
            id = 0;
            puedovolar = false;
            SuperPoderes = new List<superPoder>();
            name = "";
        }

        public string usarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)

            {
                sb.AppendLine($"{namexIdentidad} esta usando el superpoder de {item.Name}");
            }

            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{namexIdentidad} ha salvado el mundo!!";
        }

        public override string SalvarWakanda()
        {
            //return base.SalvarWakanda();
            return $"{namexIdentidad} ha salvado Wakanda!!";
        }
    }

    
}
