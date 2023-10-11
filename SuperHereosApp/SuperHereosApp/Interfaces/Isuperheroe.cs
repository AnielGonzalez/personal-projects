using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHereosApp.Interfaces
{
    internal interface Isuperheroe
    {
        int id {  get; set; }

        string name { get; set; }
        string identidadSecreta { get; set; }

        string ciudad {  get; set; } 


        string GetSuperHeroe()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID:{id}");
            sb.AppendLine($"Name:{name}");
            sb.AppendLine($"Identidad secreta: {identidadSecreta}");
            sb.AppendLine($"Ciudad: {ciudad}");
            return sb.ToString();
        }

    }
}
