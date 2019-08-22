using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviacao
{
 
    public class Poltrona
    {
        public int Id { get; set; }

        public Voo Voo { get; set; }
        public int Coluna { get; set; }

        public int Fileira { get; set; }

        public Pessoa Passageiro { get; set; }
    }
}
