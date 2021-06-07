using System;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Pelé chutou";
        }

        public string Corre()
        {
           return "Pelé correu";
        }

        public string Passe()
        {
           return "Pelé passou";
        }
    }
}