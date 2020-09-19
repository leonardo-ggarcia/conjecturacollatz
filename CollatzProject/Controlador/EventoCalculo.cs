
using CollatzProject.Calculos;
using CollatzProject.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollatzProject.Controlador
{
    class EventoCalculo
    {
        public static void calcular()
        {
            TelaPrincipal.Cabecalho();
            TelaPrincipal.Menu();
            Console.Write("     O Resultado é: "+conjecturaCollatz.intervalo(1L, 1000000L));
        }
    }
}
