using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa()
            {
                Nome = "Lucass"

            };
            Cidade CWB = new Cidade() { Nome = "Curitiba" };
            Cidade BSB = new Cidade() { Nome = "Brasilia" };
            Cidade VIX = new Cidade() { Nome = "VITORIA" };
            Voo vooCWBBSB = new Voo();
            vooCWBBSB.Origen = CWB;
            vooCWBBSB.Destino = BSB;
            Voo vooBSBVIX = new Voo();
            vooBSBVIX.Origen = BSB;
            vooBSBVIX.Destino = VIX;
            Passagem passagem = new Passagem();
            passagem.Passageiro = pessoa;
            passagem.Trechos = new List<Voo>();
            passagem.Trechos.Add(vooCWBBSB);
            passagem.Trechos.Add(vooBSBVIX);
        }
    }
}
