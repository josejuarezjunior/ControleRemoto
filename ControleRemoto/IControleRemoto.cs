using System;

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
