using System;
using static System.Console;
using System.Diagnostics;

namespace Atividade2EDA
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            
            int relevantes = 0;
            int n = 1000;
            int contador = 4;

            if(n <= n/10){
                contador++;

            }else if(n <= n/5){

                for(int a=0; a<n; a++)
                {
                    contador++;
                }
                
            }else{ // O pior caso dessa estrutura de decisão é o else, por isso ele que vai ser utilizado para encontrar a fórmula
 
                for(int a=0; a<n; a++) // f(n) -> n
                {
                    contador++;

                    for(int b=0; b<n/2; b++) // f(n) -> n/2
                    {
                        contador++;
                        relevantes++; // Como existem dois laços concatenados será utilizado o segundo para marcar um ponto relevante

                        // A fórmula será a multiplicação da fórmula do primeiro laço, pela da segundo                        
                        // f(n) = n*(n-2) -> (n^2)/2 
                    }
                }
            }
            n = n/5; // Nesse ponto o n se torna n/5
            contador++;
            if(n <= n/10){
                contador++;

            }else if(n <= n/5){

                for(int a=0; a<n; a++)
                {
                    contador++;
                }
                
            }else{ // Novamente será utilizado o pior caso (else) para definir a fórmula

                for(int a=0; a<n; a++)
                {
                    contador++;

                    for(int b=0; b<n/2; b++)
                    {
                        contador++;
                        relevantes++;

                        // A Fórmula nesse caso também séria (n^2)/2, porém o nosso "n" agora é n/5
                        // Logo temos f(n) -> ((n/5)^2)/2 = (n^2)/50
                        
                    }
                }
            }
            
            /*
            Até esse trecho do código a nossa fórmula é: (n^2)/2  + (n^2)/50 -> f(n) = (0,52*n^2)
            Logo, nossa complexidade é O(n^2)
            
            À partir desse ponto o código se repete 5 vezes alterando os valores de n para n*5 ( que resulta no valor inicial de n) e n/5 (que resulta no valor atual)
            Logo podemos multiplicar por 5 a nossa fórmula atual
            f(n) -> 5*(0,52*n^2)
            f(n) -> 2,6*(n^2)
            Logo, a complexidade continua sendo O(n^2)
            
            */
            n = n*5;
            contador++;
            if(n <= n/10){
                contador++;

            }else if(n <= n/5){

                for(int a=0; a<n; a++)
                {
                    contador++;
                }
                
            }else{

                for(int a=0; a<n; a++)
                {
                    contador++;

                    for(int b=0; b<n/2; b++)
                    {
                        contador++;
                        relevantes++;
                    }
                }
            }
            n = n/5;
            contador++;
            if(n <= n/10){
                contador++;

            }else if(n <= n/5){

                for(int a=0; a<n; a++)
                {
                    contador++;
                }
                
            }else{

                for(int a=0; a<n; a++)
                {
                    contador++;

                    for(int b=0; b<n/2; b++)
                    {
                        contador++;
                        relevantes++;
                    }
                }
            }
            n = n*5;
            contador++;
            if(n <= n/10){
                contador++;

            }else if(n <= n/5){

                for(int a=0; a<n; a++)
                {
                    contador++;
                }
                
            }else{

                for(int a=0; a<n; a++)
                {
                    contador++;

                    for(int b=0; b<n/2; b++)
                    {
                        contador++;
                        relevantes++;
                    }
                }
            }
            n = n/5;
            contador++;
            if(n <= n/10){
                contador++;

            }else if(n <= n/5){

                for(int a=0; a<n; a++)
                {
                    contador++;
                }
                
            }else{

                for(int a=0; a<n; a++)
                {
                    contador++;

                    for(int b=0; b<n/2; b++)
                    {
                        contador++;
                        relevantes++;
                    }
                }
            }
            n = n*5;
            contador++;
            if(n <= n/10){
                contador++;

            }else if(n <= n/5){

                for(int a=0; a<n; a++)
                {
                    contador++;
                }
                
            }else{

                for(int a=0; a<n; a++)
                {
                    contador++;

                    for(int b=0; b<n/2; b++)
                    {
                        contador++;
                        relevantes++;
                    }
                }
            }
            n = n/5;
            contador++;
            if(n <= n/10){
                contador++;

            }else if(n <= n/5){

                for(int a=0; a<n; a++)
                {
                    contador++;
                }
                
            }else{

                for(int a=0; a<n; a++)
                {
                    contador++;

                    for(int b=0; b<n/2; b++)
                    {
                        contador++;
                        relevantes++;
                    }
                }
            }
            n = n*5;
            contador++;
            if(n <= n/10){
                contador++;

            }else if(n <= n/5){

                for(int a=0; a<n; a++)
                {
                    contador++;
                }
                
            }else{

                for(int a=0; a<n; a++)
                {
                    contador++;

                    for(int b=0; b<n/2; b++)
                    {
                        contador++;
                        relevantes++;
                    }
                }
            }
            n = n/5;
            contador++;
            if(n <= n/10){
                contador++;

            }else if(n <= n/5){

                for(int a=0; a<n; a++)
                {
                    contador++;
                }
                
            }else{

                for(int a=0; a<n; a++)
                {
                    contador++;

                    for(int b=0; b<n/2; b++)
                    {
                        contador++;
                        relevantes++;
                    }
                }
            }
            n = n*5;
            contador++;

            stopwatch.Stop();
            Console.WriteLine($"Tempo de execução: {stopwatch.ElapsedTicks}ns"); 
            Console.WriteLine($"Instruções executadas: {contador}");
            Console.WriteLine($"Instruções relevantes executadas: {relevantes}");
            Console.WriteLine($"Entradas: {n}");
        }
    }
}
