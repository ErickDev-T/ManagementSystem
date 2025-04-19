using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    class Empresa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RNC { get; set; } // Registro Nacional de Contribuyente
        public string Direcction { get; set; }
        public string Phone { get; set; }
    }
}
