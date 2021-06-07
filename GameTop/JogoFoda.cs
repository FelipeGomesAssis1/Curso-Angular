{
    
}
namespace GameTop
{
    public class JogoFoda
    {
       private readonly iJogador _jogador1; 
       private readonly iJogador _jogador2; 
       public JogoFoda (iJogador jogador1, iJogador jogador2){
          _jogador1 = jogador1;
          _jogador2 = jogador2;
       }
      

      public void IniciarJogo ()
      {
       System.Console.WriteLine(_jogador1.Corre());
       System.Console.WriteLine(_jogador1.Chuta());
       System.Console.WriteLine(_jogador1.Passe());

       System.Console.WriteLine(" Jogador 2");

       System.Console.WriteLine(_jogador2.Corre());
       System.Console.WriteLine(_jogador2.Chuta());
       System.Console.WriteLine(_jogador2.Passe());

      }

     }
    
}
