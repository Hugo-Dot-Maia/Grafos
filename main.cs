using System;
using System.Linq;
using System.Collections.Generic;

class Program {

  static int [,]grafo = new int[1,1];
  static List<string> verticesDesejados = new List<string>();
  static int numVertices = 0;
  static int tipoGrafo = 0;

  public static void insereArestaPonderadoNaoDirecionado(int [,]g, int origem, int destino) {
    Console.WriteLine("Informe o peso na aresta: " + origem + " => " + destino);
    int peso = Convert.ToInt32(Console.ReadLine());
    g[origem, destino] = peso;
	  g[destino,origem]= peso;
	}

 public static void insereArestaNaoPonderadoDirecionado(int [,]g, int origem, int destino) {
    g[origem,destino] = 1;
  }

  public static void insereArestaNaoPonderadoNaoDirecionado(int [,]g, int origem, int destino) {
    g[origem,destino] = 1;
    g[destino, origem]= 1;
  }

  public static void insereArestaPonderadoDirecionado(int [,]g, int origem, int destino) {
    Console.WriteLine("Informe o peso na aresta: " + origem + " => " + destino);
    int peso = Convert.ToInt32(Console.ReadLine());
    g[origem, destino] = peso;
	}

  public static int retornaOrigem(string auxSplit) {
    return (int) auxSplit.ElementAt(0);
	}

  public static int retornaDestino(String auxSplit) {
	  return (int) auxSplit.ElementAt(1);
	}

  public static void defineGrafo(){

    Console.WriteLine ("Escolha a definição do Grafo");
    Console.WriteLine("1) Grafo direcionado não-ponderado");
	  Console.WriteLine("2) Grafo não direcionado não ponderado");
	  Console.WriteLine("3) Grafo direcionado ponderado");
	  Console.WriteLine("4) Grafo não-direcionado ponderado");

    int tipoGrafo = Convert.ToInt32(Console.ReadLine());

    Console.Write("Qual a quantidade de vértices? ");
	  numVertices = Convert.ToInt32(Console.ReadLine());
	    
	  Console.WriteLine("Em quais vértices deseja aresta? ");

    for(;Console.ReadLine() != "N";){
      verticesDesejados.Add(Console.ReadLine();
      Console.WriteLine("Deseja inserir mais um vertice? [S:N]: ");
    }
  }
  public static string retornaTipoGrafo(int indice){
   string[] tipos = {
      "direcionado não-ponderado",
      "não direcionado não ponderado",
      "direcionado ponderado",
      "não-direcionado ponderado"
     };
    return tipos[indice];
  }
  
  public static void Main (string[] args) {
    
    for(;;){
      defineGrafo();
      grafo = new int[numVertices, numVertices];

      string[] auxSplit = verticesDesejados.ToArray();
	    Console.WriteLine("Grafo do tipo: "+retornaTipoGrafo(tipoGrafo));

      for (int i = 0; i < auxSplit.Length; i++){

        int origem = retornaOrigem(auxSplit[i]);
	      int destino = retornaDestino(auxSplit[i]);

        switch(tipoGrafo){

          case 1:
            insereArestaNaoPonderadoDirecionado(grafo, origem, destino);
            break;
          case 2:
            insereArestaNaoPonderadoNaoDirecionado(grafo, origem, destino);
            break;
          case 3:
            insereArestaPonderadoDirecionado(grafo, origem, destino);
            break;
          case 4:
             insereArestaPonderadoNaoDirecionado(grafo, origem, destino);
            break;
          default:
            break;
        }
        
      }
    }
  }
}