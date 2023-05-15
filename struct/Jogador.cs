namespace Struct;

public struct Jogador{

    public string  registrarNumerosCartoesAmarelos;
    public string registrarNumerosCartoesVermelhos;
    public string verificarVinculoClube;
    public string verificarNumeroCamisa;
    public string verificarnomejogador;
    public string verificarboladeouro;
    public string verificarposicao;
    
    public Jogador(string cartamarelo, string cartvermelho, string vinculoclube, string verificarnumerocamisa, string nomejogador, string boladeouro, string posicao){
        this.registrarNumerosCartoesAmarelos = cartamarelo;
        this.registrarNumerosCartoesVermelhos = cartvermelho;
        this.verificarVinculoClube = vinculoclube;
        this.verificarNumeroCamisa = verificarnumerocamisa;
        this.verificarnomejogador = nomejogador;
        this.verificarboladeouro = boladeouro;
        this.verificarposicao = posicao;

    }
    public string imprimir(){
        return "\nCartoesA: " + this. registrarNumerosCartoesAmarelos +
        "\nCartoesV: " + this.registrarNumerosCartoesVermelhos +
        "\nVinculo de clube: " + this.verificarVinculoClube + 
        "\nNumero da Camisa: " + this.verificarNumeroCamisa +
        "\nNome do Jogador: " + this.verificarnomejogador +
        "\nBola de ouro: " + this.verificarboladeouro +
        "\nPosição: " + this.verificarposicao;
         
    }
}