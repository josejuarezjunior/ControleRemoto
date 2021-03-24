using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleRemoto
{
    public interface IControleRemoto
    {
        void ligar();
        void desligar();
        void aumentarVolume();
        void diminuirVolume();
        void avancar();
        void retroceder();
    }
}
