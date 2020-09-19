using System;
using System.Collections.Generic;
using System.Text;

namespace CollatzProject.Views
{
    class TelaPrincipal
    {

        public static void Cabecalho()
        {
            Console.WriteLine("     ********Conjectura de Collatz********");           
        }

        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("1 -  Número que resulta na maior sequência entre 1 e 1000000 ");
            Console.WriteLine("     Pressione qualquer tecla para começar");
            Console.ReadKey();
            Console.WriteLine("     Aguarde...");            
        }

    }
}
