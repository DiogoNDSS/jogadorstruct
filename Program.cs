using System;
using Struct;

namespace STRUCTEXERCICIOS{
    class Program
{

static void Main(string[] args)
    {
        //Struct
      Jogador jogador1 = new();

      jogador1.verificarnomejogador="claudiao";
      jogador1.registrarNumerosCartoesAmarelos="3";
      jogador1.registrarNumerosCartoesVermelhos="1";
      jogador1.verificarVinculoClube="psg";
      jogador1.verificarNumeroCamisa="10";
      jogador1.verificarboladeouro="3";
      jogador1.verificarposicao="CF";
      
      Console.WriteLine(jogador1.imprimir());
    }
}
}