using System;

class Program {
  public static void Main (string[] args) {
    string nome;
    int nota_um;
    float nota_dois;
    float nota_tres;
    float resultado;

    //Console.Clear();
    
    Console.WriteLine ("Insira o nome do aluno");
    nome = Console.ReadLine();
    
    Console.WriteLine("O nome do Aluno é:" + nome);
    Console.WriteLine("Insira a Primeira nota");
    nota_um = (int)float.Parse ( (Console.ReadLine() ));
    
    Console.WriteLine("Insira a Segunda nota");
    nota_dois = float.Parse( (Console.ReadLine() ));
    
    Console.WriteLine("Insira a Ultima nota");
    nota_tres = float.Parse( (Console.ReadLine() ));
    resultado = ((nota_um + nota_dois + nota_tres)/3);

    Console.WriteLine("A média do aluno:"+ nome + ", é:" + resultado);
    

  }
}