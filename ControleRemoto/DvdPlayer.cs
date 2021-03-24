using System;

namespace ControleRemoto
{
    class DvdPlayer : IControleRemoto
    {
        public string Marca;
        public string Modelo;
        private bool Ligado;
        private bool Open;
        private int Capitulo;

        public DvdPlayer(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Ligado = false;
            Capitulo = 1;
        }

        public virtual void ligar()
        {
            Ligado = true;
        }
        public virtual void desligar()
        {
            Ligado = false;
        }
        public virtual void aumentarVolume()
        {
            Open = true;
        }
        public virtual void diminuirVolume()
        {
            Open = false;
        }
        public virtual void avancar()
        {
            Capitulo++;
        }
        public virtual void retroceder()
        {
            Capitulo--;
        }
        public override string ToString()
        {
            string estado = Ligado ? "ligado" : "desligado";
            string combo = Open ? "Combo aberto " : "Combo fechado ";
            return "DvdPlayer: "
                + Marca
                + " "
                + Modelo
                + " "
                + estado
                +" bandeja "
                +combo
                +"Capítulo: "
                +Capitulo;
        }
    }
}
