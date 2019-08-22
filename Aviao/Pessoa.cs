using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviacao
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Nome { get; set; }

        public IList<Passagem> Passagens { get; set; }
        public string DOcumento { get; set; }

        public DateTime Nascimento { get; set; }
        
        public String Telefone { get; set; }

    }
}
