namespace Tipos;
class Program
{
    static void Main(string[] args)
    {
      Retangulo retangulo = new Retangulo(20,30);
      var pessoa1 = new Funcionario(nome : "Fulano", sobreNome: "Scottiere",idade: 31, altura : 1.80, salario : 5000);
      
     
      Console.WriteLine(retangulo.CalcularArea());
      System.Console.WriteLine(pessoa1.Andar());

      
    }
}
