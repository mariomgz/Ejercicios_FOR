using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = 1;
            while (n != 6)
            {



                Console.WriteLine("Seleccione una opción del MENU\n");
                Console.WriteLine("|*******  PREGUNTAS  *******| \n" +
                                  "|*                         *| \n" +
                                  "|*1. Tablas de Multiplicar *| \n" +
                                  "|*2. Par - Impar           *| \n" +
                                  "|*3. Divisores             *| \n" +
                                  "|*4. Número Mayor          *| \n" +
                                  "|*5. Número Primo          *| \n" +
                                  "|*6. EXIT                  *| \n" +
                                  "|*                         *| \n" +
                                  "|***************************| \n");

                n = Convert.ToInt32(Console.ReadLine());

                switch (n)

                {
                    case 1:

                        //Generar un programa que imprima las tablas de multiplicar 
                        //hasta el 10, que uno escoja que tabla quiere imprimir.

                        int t;

                        Console.Clear();
                        Console.WriteLine("Seleccione la Tabla de Multiplicar que quiere practicar\n");
                        Console.WriteLine("|********** MENU **********| \n" +
                                          "|*                        *| \n" +
                                          "|* 1. Tabla del 1         *| \n" +
                                          "|* 2. Tabla del 2         *| \n" +
                                          "|* 3. Tabla del 3         *| \n" +
                                          "|* 4. Tabla del 4         *| \n" +
                                          "|* 5. Tabla del 5         *| \n" +
                                          "|* 6. Tabla del 6         *| \n" +
                                          "|* 7. Tabla del 7         *| \n" +
                                          "|* 8. Tabla del 8         *| \n" +
                                          "|* 9. Tabla del 9         *| \n" +
                                          "|*10. Tabla del 10        *| \n" +
                                          "|*11. SALIR               *| \n" +
                                          "|*                        *| \n" +
                                          "|**************************| \n");

                        t = Convert.ToInt32(Console.ReadLine());

                        switch (t)


                        {

                            case 1:

                                Console.Clear();
                                Console.WriteLine("\nTabla de multiplicar del " + t);
                                Console.WriteLine("------------------------------");

                                for (i = 1; i <= 10; i++)

                                {

                                    Console.WriteLine(t + " X " + i + " = " + t * i);

                                }
                                
                                break;

                            case 2:

                                Console.Clear();
                                Console.WriteLine("\nTabla de multiplicar del " + t);
                                Console.WriteLine("------------------------------");

                                for (i = 1; i <= 10; i++)

                                {
                                    Console.WriteLine(t + " X " + i + " = " + t * i);
                                }

                                break;

                            case 3:

                                Console.Clear();
                                Console.WriteLine("\nTabla de multiplicar del " + t);
                                Console.WriteLine("------------------------------");

                                for (i = 1; i <= 10; i++)

                                {
                                    Console.WriteLine(t + " X " + i + " = " + t * i);
                                }

                                break;

                            case 4:

                                Console.Clear();
                                Console.WriteLine("\nTabla de multiplicar del " + t);
                                Console.WriteLine("------------------------------");

                                for (i = 1; i <= 10; i++)

                                {
                                    Console.WriteLine(t + " X " + i + " = " + t * i);
                                }

                                break;

                            case 5:

                                Console.Clear();
                                Console.WriteLine("\nTabla de multiplicar del " + t);
                                Console.WriteLine("------------------------------");

                                for (i = 1; i <= 10; i++)

                                {
                                    Console.WriteLine(t + " X " + i + " = " + t * i);
                                }

                                break;

                            case 6:

                                Console.Clear();
                                Console.WriteLine("\nTabla de multiplicar del " + t);
                                Console.WriteLine("------------------------------");

                                for (i = 1; i <= 10; i++)

                                {
                                    Console.WriteLine(t + " X " + i + " = " + t * i);
                                }

                                break;

                            case 7:

                                Console.Clear();
                                Console.WriteLine("\nTabla de multiplicar del " + t);
                                Console.WriteLine("------------------------------");

                                for (i = 1; i <= 10; i++)

                                {
                                    Console.WriteLine(t + " X " + i + " = " + t * i);
                                }

                                break;

                            case 8:

                                Console.Clear();
                                Console.WriteLine("\nTabla de multiplicar del " + t);
                                Console.WriteLine("------------------------------");

                                for (i = 1; i <= 10; i++)

                                {
                                    Console.WriteLine(t + " X " + i + " = " + t * i);
                                }

                                break;

                            case 9:

                                Console.Clear();
                                Console.WriteLine("\nTabla de multiplicar del " + t);
                                Console.WriteLine("------------------------------");

                                for (i = 1; i <= 10; i++)

                                {
                                    Console.WriteLine(t + " X " + i + " = " + t * i);
                                }

                                break;

                            case 10:

                                Console.Clear();
                                Console.WriteLine("\nTabla de multiplicar del " + t);
                                Console.WriteLine("------------------------------");

                                for (i = 1; i <= 10; i++)

                                {
                                    Console.WriteLine(t + " X " + i + " = " + t * i);
                                }

                                break;

                            default:

                                Console.Clear();
                                Console.WriteLine("Vuelva Pronto!");

                                break;

                        }
                        Console.ReadKey();
                        break;

                    case 2:

                        //Escriba un programa que pida 10 números enteros y 
                        //escriba qué números son pares y cuáles impares desde 
                        //el primero hasta el ultimo.

                        int pares;
                        int impares;
                        int var1 = 10;
                        int[] numeros = new int[var1];

                        Console.Clear();
                        Console.WriteLine("Ingrese " + var1 + " numeros enteros");

                        for (i = 0; i < var1; i++)

                        {                                                      
                            numeros[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.Clear();
                        Console.WriteLine("Los números pares son:");

                        for (i = 0; i < var1; i++)
                        {
                                
                                if (numeros[i] % 2 == 0)

                                {
                                pares = numeros[i];                                
                                Console.WriteLine(pares);

                                 }
                            
                        }
                                                
                        Console.WriteLine("\nLos números impares son:");
                        
                        for (i = 0; i < var1; i++)

                        {
                            
                            if(numeros[i] % 2 > 0)
                            {
                                
                                impares = numeros[i];
                                Console.WriteLine(impares);

                            }
                                                        
                         }    
                        
                        Console.ReadKey();
                        break;

                    case 3:

                        //Escriba un programa que pida un número entero mayor que cero
                        //y que escriba sus divisores.   

                        int entero;
                        
                        Console.Clear();

                        Console.WriteLine("Escriba un número entero mayor que cero");
                        entero = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        if (entero > 0)

                        {
                            Console.WriteLine("Los divisores de " + entero + " son:\n ");

                            for (i = 1; i <= entero; i++)

                            {
                                if (entero % i == 0)

                                    Console.WriteLine(i);

                            }


                        }

                        else

                            Console.WriteLine("*Error: El número entero debe ser mayor que cero*");
                        Console.ReadKey();
                        break;

                    case 4:

                        //Escriba un programa que pregunte cuántos números se van a 
                        //introducir, pida esos números, y muestre un mensaje cada vez 
                        //que un número no sea mayor que el primero.


                        int campos, num1, num2;
                        Console.Clear();

                        Console.WriteLine("Especifique cuántos números va a ingresar");
                        campos = Convert.ToInt32(Console.ReadLine());
                                                
                        Console.WriteLine("Escriba el numero INICIAL");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        for (i = 0; i < campos; i++)
                            
                        {
                            Console.WriteLine("\nEscriba el número "+(i+1)+" que debe ser mayor que el número INICIAL");
                            num2 = Convert.ToInt32(Console.ReadLine());


                            if (num2 <= num1)
                            {
                                Console.WriteLine("**Error: El número " + num2 + " no es mayor que " + num1 + "**");

                            }

                            else

                                Console.WriteLine("Correcto!");

                        }
                        Console.ReadKey();
                        break;

                    case 5:

                        //Escriba un programa que pida un número entero mayor que 1 
                        //y que escriba si el número es un número primo o no.

                        int numero;
                        int contador = 0;
                        
                        Console.Clear();

                        Console.WriteLine("Escriba un número entero mayor que 1");
                        numero = Convert.ToInt32(Console.ReadLine());

                        if (numero > 1)

                        {

                            for (i = 1; i <= numero; i++)
                            {

                                int modulo = numero % i;
                                
                                if (modulo==0)
                                                                    
                                {
                                    contador= contador + 1;
                                                                            
                                }

                                if (contador > 2)

                                {
                                    Console.WriteLine("El número " + numero + " no es Primo");
                                    
                                }

                                if (numero == i && contador <=2)
                                {
                                    Console.WriteLine("El número " + numero + " es Primo");

                                }
                                                                

                            }


                        }

                        else

                            Console.WriteLine("**Error: El número debe ser mayor que 1**");
                                                        
                        Console.ReadKey();
                        break;

                    default:

                        Console.Clear();
                        Console.WriteLine("Vuelva Pronto!!");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
            Console.ReadKey();


        }
                
                
    }
}
