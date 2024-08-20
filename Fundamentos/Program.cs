using Fundamentos;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{


    private static void Main(string[] args)
    {

        //Livro livro1 = new Livro();
        //livro1.Titulo = "Heronbine o retorno";
        //livro1.Editora = "Editora mojang";
        //livro1.Autor = "rogerio";
        //livro1.AnoLancamento = 2001;

        //Livro livro2 = new Livro();
        //livro2.Titulo = "Mazzi o inicio";
        //livro2.Editora = "hilaria";
        //livro2.Autor = "bruno";
        //livro2.AnoLancamento = 2077;


        //Livro livro3 = new Livro();
        //livro3.Titulo = "Mazzi o fim de uma lenda";
        //livro3.Editora = "hilaria";
        //livro3.Autor = "bruno";
        //livro3.AnoLancamento = 2080;


        ////Instanciar um objeto do tipo Aluno
        //Aluno aluno1 = new Aluno();
        //Aluno aluno2 = new Aluno();
        //Aluno aluno3 = new Aluno();

        ////Preencher os atributos do objeto
        //aluno1.Nome = "Joaquim";
        //aluno1.RM = "4795";
        //aluno1.Email = "jotagesr@gmail.com";
        //aluno1.Nascimento = new DateOnly(2007, 08, 10);

        //aluno2.Nome = "Bruno Henrique Martins Alves";
        //aluno2.RM = "6666";
        //aluno2.Email = "bruno.contato2007@gmail.com";
        //aluno2.Nascimento = new DateOnly(2007, 08, 28);

        //aluno3.Nome = "João Rodolfo Fiamengui Costa";
        //aluno3.RM = "1234";
        //aluno3.Email = "jones@gmail.com";
        //aluno3.Nascimento = new DateOnly(2008, 05, 16);
        ////Imprimir na tela
        //Console.WriteLine("Aluno 1");
        //Console.WriteLine("Nome: " + aluno1.Nome);
        //Console.WriteLine("RM: " + aluno1.RM);
        //Console.WriteLine("Email: " + aluno1.Email);
        //Console.WriteLine("Nascimento: " + aluno1.Nascimento);
        //Console.WriteLine("===================================================");
        //Console.WriteLine("Aluno 2");
        //Console.WriteLine("Nome: " + aluno2.Nome);
        //Console.WriteLine("RM: " + aluno2.RM);
        //Console.WriteLine("Email: " + aluno2.Email);
        //Console.WriteLine("Nascimento: " + aluno2.Nascimento);
        //Console.WriteLine("===================================================");
        //Console.WriteLine("Aluno 3");
        //Console.WriteLine("Nome: " + aluno3.Nome);
        //Console.WriteLine("RM: " + aluno3.RM);
        //Console.WriteLine("Email: " + aluno3.Email);
        //Console.WriteLine("Nascimento: " + aluno3.Nascimento);
        //Console.WriteLine("===================================================");

        //// Instanciar um Objeto do tipo Produto
        //Produto p1 = new Produto();
        //p1.Codigo = 123456;
        //p1.Nome = "coca-cola 2 litros";
        //p1.preco = 12.99;
        //p1.Estoque = 96;
        //// Chamar o metodo QuantidadeEstoque
        //p1.QuantidadeEstoque();
        //p1.Estoque = 85;
        //p1.QuantidadeEstoque();

        //Console.WriteLine("===================================================");
        //Console.WriteLine(" ");

        //// Instanciar um objeto do tipo Carro
        //Carro carro1 = new Carro();

        //carro1.Marca = "peugeot";
        //carro1.Modelo = "206";
        //carro1.Velocidade = 260;
        //carro1.Acelerar();

        //Console.WriteLine("===================================================");
        //Console.WriteLine(" ");
        //Pessoa Pessoa1 = new Pessoa();

        //Pessoa1.Nome = "Mazzi";
        //Pessoa1.Idade = 20;

        //Pessoa1.Envelhecer(5);
        //Pessoa1.Envelhecer(1);
        //Pessoa1.Envelhecer(5);

        //Console.WriteLine("===================================================");
        //Console.WriteLine(" ");

        //Funcionario func1 = new Funcionario();
        //func1.Nome = "Gino";
        //func1.Idade = 20;
        //func1.Cargo = "Cantor";
        //func1.Salario = 7000.00;

        //func1.ApresentarSe();

        //Console.WriteLine("===================================================");
        //Console.WriteLine(" ");

        ////Animal animal = new Animal();

        ////animal.Especie = "dog mau";

        ////animal.emitirSom();

        ////Console.WriteLine("O animal " + animal.Especie + " emitiu um som.");

        //Gato gato1 = new Gato();
        //gato1.Nome = "Luci";
        //Console.WriteLine(gato1.Nome + " faz:");
        //gato1.emitirSom();

        //Porco porco1 = new Porco();
        //porco1.Nome = "Thiago mazzi";
        //Console.WriteLine(porco1.Nome + " faz:");
        //porco1.emitirSom();

        //Galinha galinha1 = new Galinha();
        //galinha1.Nome = "Emanuelly";
        //Console.WriteLine(galinha1.Nome + " faz:");
        //galinha1.emitirSom();

        //Console.WriteLine("===================================================");
        //Console.WriteLine(" ");
        Cavaleiro cavaleiro1 = new Cavaleiro();
        cavaleiro1.Categoria = "Cavaleiro";
        cavaleiro1.Nome = "Guts";
        cavaleiro1.Nivel = 100;
        cavaleiro1.Forca = 30;
        cavaleiro1.Agilidade = 35;
        cavaleiro1.Inteligencia = 20;
        cavaleiro1.Vida = 15 * 10;
        cavaleiro1.Apresentarse();
        Console.WriteLine("==================================");

        Mago mago1 = new Mago();
        mago1.Categoria = "Mago";
        mago1.Nome = "Merlin";
        mago1.Nivel = 132;
        mago1.Forca = 13;
        mago1.Agilidade = 50;
        mago1.Inteligencia = 60;
        mago1.Vida = 20 * 10;
        mago1.Apresentarse();
        Console.WriteLine("==================================");

        cavaleiro1.batalhar(mago1);
    }
}