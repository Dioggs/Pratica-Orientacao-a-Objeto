using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TesteApi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma pessoa e faça ela dizer a idade
            Pessoa pessoa = new Pessoa(19, "Diogo");
            pessoa.dizerIdade();
            Console.WriteLine();

            //Crie um aluno de 21 anos e faça ele irParaEscola, Cumprimentar, dizerIdade
            Aluno aluno = new Aluno(23, "Yan");
            aluno.irParaEscola();
            aluno.Cumprimentar();
            aluno.dizerIdade();
            Console.WriteLine();

            //Crie um professor de 30 anos e faça ele Cumprimentar, dizerIdade, e explicar sobre um determinado assunto
            Professor professor = new Professor(30, "Caio", "Uma suoer nova é uma estrela maciça que, num estágio avançado de sua evolução, explode, passando repentinamente a brilhar de modo muito intenso, para depois ir perdendo lentamente o seu fulgor");
            professor.Cumprimentar();
            professor.dizerIdade();
            professor.Explicar();

            //Pessoa e Seu apartamento
            Morador morador = new Morador(25, "Bryan", 55, "Vermelha");
            morador.Mostrar();
            morador.MostrarAp();


            Console.ReadKey();
        }

    }

    class Pessoa
    {
        public int idade { get; set; }
        public string nome { get; set; }

        public Pessoa(int idade, string nome)
        {
            this.idade = idade;
            this.nome = nome;
        }

        public void Cumprimentar()
        {
            Console.WriteLine("Olá! bom dia");
        }

        public void dizerIdade()
        {
            Console.WriteLine($"A minha idade é {this.idade}");
        }
    }

    class Aluno : Pessoa
    {
        public Aluno(int idade, string nome) : base(idade, nome) { } //params do aluno são passado na classe base?

        public void irParaEscola()
        {
            Console.WriteLine("Fui para a escola");
        }
    }

    class Professor : Pessoa
    {
        public string assunto { get; set; }

        public Professor(int idade, string nome, string assunto) : base(idade, nome)
        {
            this.assunto = assunto;
        }

        public void Explicar()
        {
            Console.WriteLine(assunto);
            Console.WriteLine();
        }
    }

    class Porta
    {
        public string Cor { get; set; }

        public Porta(string Cor)
        {
            this.Cor = Cor;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Eu sou uma porta e minha cor é {Cor}");
        }

    }

    class Habitação 
    {
        public double area { get; set; }
        public string cor_porta { get; set; }

        Porta porta;

        public Habitação(double area, string cor_porta) 
        {
            this.area = area;
            this.cor_porta = cor_porta;
            porta = new Porta(cor_porta);
        }

        //Porta porta = new Porta(cor_porta); pq não funciona?

        public void Mostrar()
        {
            Console.WriteLine($"Eu sou uma Habitação e minha área é de {this.area} m2 e a minha cor é {porta.Cor}");
        }
    }

    class Apartamento : Habitação
    {
        public Apartamento(double area, string cor_porta) : base(area, cor_porta){}
    }

    class Morador : Pessoa
    {
        public double área;
        public string cor;

        public Morador(int idade, string nome, double área, string cor) : base(idade, nome)
        {
            this.área = área;
            this.cor = cor;
        }

        public void Mostrar()
        {
            Console.WriteLine($"O meu nome é {nome} e eu tenho {idade} anos");
        }
        
        public void MostrarAp()
        {
            Apartamento ap = new Apartamento(área, cor);
            Console.WriteLine($"O meu apartamento tem uma área de {ap.area} e uma porta de cor {ap.cor_porta}");
        }

    }
}
