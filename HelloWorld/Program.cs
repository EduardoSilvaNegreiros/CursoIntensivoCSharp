using System;

namespace HelloWorld
{
    internal class Program
    {
        // ===============================
        // 1. ENUMERAÇÕES (ENUMS)
        // ===============================
        // Enums são tipos que representam um conjunto de constantes nomeadas.
        private enum Cor
        {
            Vermelho,
            Verde,
            Azul,
            Amarelo,
            Rosa
        }

        private enum Opcao
        {
            Criar = 1,
            Deletar,
            Editar,
            Listar,
            Atualizar
        }

        private static void Main(string[] args)
        {
            // ===============================
            // 2. TIPOS DE DADOS BÁSICOS
            // ===============================
            int numero = 1945;
            float velocidade = 300.5f;
            double preco = 199.99;
            decimal saldo = 1000.75m;
            bool status = true;
            string nome = "Eduardo";
            char letra = 'A';

            // ===============================
            // 3. EXIBIÇÃO DE VALORES
            // ===============================
            Console.WriteLine(numero);
            Console.WriteLine(velocidade);
            Console.WriteLine(preco);
            Console.WriteLine(saldo);
            Console.WriteLine(status);
            Console.WriteLine(nome);
            Console.WriteLine(letra);

            // ===============================
            // 4. ALTERAÇÃO DE VALORES
            // ===============================
            velocidade = 400.5f;
            nome = "Carlos";
            Console.WriteLine(velocidade);
            Console.WriteLine(nome);

            // ===============================
            // 5. VARIÁVEIS 'VAR' E 'DYNAMIC'
            // ===============================
            var idade = 25;
            var cidade = "São Paulo";
            dynamic variavelDinamica = "Texto";
            Console.WriteLine(idade);
            Console.WriteLine(cidade);
            Console.WriteLine(variavelDinamica);
            variavelDinamica = 123;
            Console.WriteLine(variavelDinamica);

            // ===============================
            // 6. CONSTANTES
            // ===============================
            const float PI = 3.14f;
            Console.WriteLine(PI);

            // ===============================
            // 7. ENTRADA DE DADOS
            // ===============================
            Console.WriteLine("Digite o seu nome: ");
            string nomeUsuario = Console.ReadLine();
            Console.WriteLine("Seu nome é: " + nomeUsuario);

            // ===============================
            // 8. OPERAÇÕES MATEMÁTICAS
            // ===============================
            int resultado1 = 10 + 10 - 80;
            int resultado2 = 10 * 90;
            float resultado3 = 5f / 2;
            int teste1 = 2 + 2 * 10;
            int teste2 = (2 + 2) * 10;

            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine(teste1);
            Console.WriteLine(teste2);

            // ===============================
            // 9. ESTRUTURA CONDICIONAL
            // ===============================
            int a = 10, b = 20, c = 200;
            if (a < b || a > c)
            {
                Console.WriteLine("É verdade!");
            }
            else if (a > c)
            {
                Console.WriteLine("Executou Elseif!");
            }
            else
            {
                Console.WriteLine("É mentira!");
            }

            // ===============================
            // 10. FUNÇÕES
            // ===============================
            ExibirMsg();
            GerarPreco(100);
            int soma = Somar(10, 20, 30);
            Console.WriteLine(soma);

            // ===============================
            // 11. SWITCH CASE
            // ===============================
            string cor = "Verde";
            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("A sua cor favorita é Vermelho");
                    break;

                case "Amarelo":
                    Console.WriteLine("A sua cor favorita é Amarelo");
                    break;

                case "Azul":
                    Console.WriteLine("A sua cor favorita é Azul");
                    break;

                case "Rosa":
                    Console.WriteLine("A sua cor favorita é Rosa");
                    break;

                default:
                    Console.WriteLine("Sua cor favorita eu não sei");
                    break;
            }

            // ===============================
            // 12. LOOP WHILE
            // ===============================
            int contador = 0;
            while (contador < 10)
            {
                Console.WriteLine("Rodando o While");
                contador++;
            }

            // ===============================
            // 13. LOOP DO WHILE
            // ===============================
            int contador2 = 0;
            do
            {
                Console.WriteLine("Rodando o Do While");
                contador2++;
            } while (contador2 < 10);

            // ===============================
            // 14. LOOP FOREACH
            // ===============================
            string[] palavras = { "asasassasasavasda", "bababa", "caacacacac", "dadadad" };
            foreach (string palavra in palavras)
            {
                Console.WriteLine(palavra);
            }

            Console.ReadLine();
        }

        // ===============================
        // 15. FUNÇÕES AUXILIARES
        // ===============================
        private static void ExibirMsg()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Estou usando funções!");
            Console.WriteLine("Bem Vindo!");
        }

        private static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("O valor final é: " + valorFinal);
        }

        private static int Somar(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}