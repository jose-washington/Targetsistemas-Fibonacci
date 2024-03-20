using System;
using System.Security.Cryptography.X509Certificates;

namespace TesteFibonacci
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Verificar que se faz parte de sequencia Fibonacci");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Informe o numero que deseja verificar:");
            int numeroInformado = int.Parse(Console.ReadLine());

            int n1 = 0;

            int n2 = 1;

    
            int resultado = 1;


            do{
                resultado = n1 + n2;
                CheckFibo(resultado, numeroInformado);

                n1 = n2;

                n2 = resultado;
                
            }while(resultado < numeroInformado);


        }

        public static void CheckFibo(int n1,int numeroInformado){
            bool check = n1 == numeroInformado;
            
            bool check2 = n1 > numeroInformado && n1 != numeroInformado;

            switch(check)
            {
                case true: Console.WriteLine($"O numero {numeroInformado} pertence a sequência fibinacci"); break;
            }

            switch(check2)
            {
                case true: Console.WriteLine($"O numero {numeroInformado} Não pertence a sequência fibinacci"); break;
            }

            // if(n1 == numeroInformado)
            // {
            //     Console.WriteLine($"O numero {resultado} pertence a sequência fibinacci");
                

            // }else if(numeroInformado > n1){
            //     Console.WriteLine($"O numero {resultado} não pertence a sequência fibinacci");
            // }
        }

       
    }
}