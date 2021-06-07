
namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
         public  readonly string _Nome;
        
        public  Jogador1 (string nome){

            _Nome = nome;
        }
       
       public string Corre()
        {
            return $"{_Nome} esta correndo";
        }

        public string Chuta()
        {
           return $"{_Nome} esta chutando";
        }

        public string Passe()
        {
             return $"{_Nome} esta passando";
        }
    }
}