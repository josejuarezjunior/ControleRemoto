using System;

namespace ControleRemoto
{
    class Televisao : IControleRemoto
    {
        public string Marca;
        public string Modelo;
        private bool Ligada;
        private int NivelVolume;
        private int Canal;

        public Televisao(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Ligada = false;
            Canal = 0;
        }

        public virtual void ligar()
        {
            Ligada = true;
        }
        public virtual void desligar()
        {
            Ligada = false;
        }
        public virtual void aumentarVolume()
        {
            NivelVolume++;
        }
        public virtual void diminuirVolume()
        {
            NivelVolume--;
        }
        public virtual void avancar()
        {
            Canal++;
        }
        public virtual void retroceder()
        {
            Canal--;
        }
        public override string ToString()
        {
            string estado = Ligada ? "ligada" : "desligada";
            return "Televisão: " 
                +Marca
                +" "
                +Modelo
                + " "
                +estado; 
        }
    }
}
