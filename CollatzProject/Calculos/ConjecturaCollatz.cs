using System.Collections.Generic;
using System.Linq;

/*
   Os metódos desta classe foram particionados para melhor reaproveitamento das funções  
*/
namespace CollatzProject.Calculos
{
    class conjecturaCollatz
    {
        //Aplicas as regras para segregar par/impar e calcular o próximo número do conjunto
        public static long proximoSequencia(List<long> sequencia, long inicio)
        {
            return sequencia.Aggregate(inicio, (s1, s2) => s2 = s2 % 2L == 0 ? s2 / 2L : s2 * 3 + 1);
        }

        //Gera o conjunto inteiro, contendo todas os números da sequência
        public static List<long> conjunto(long proximo)
        {
            List<long> listSequencia = new List<long>();
            while (proximo > 1)
            {                
                proximo = proximoSequencia(listSequencia, proximo);
                listSequencia.Add(proximo);
            }

            return listSequencia;
        }

        //Retorna o valor que produz o conjunto com maior sequência de números dado um intervalo
        public static long intervalo(long inicio, long limite)
        {
            long posicaoAtual = inicio;
            long numMaiorSequencia = inicio;
            List<long> tamanhoSequencia = new List<long>();
            
            while (posicaoAtual <= limite)
            {
                //Garante que o próximo número será subsequente
                inicio = posicaoAtual;
                //Guarda o tamanho de cada novo conjunto gerado
                tamanhoSequencia.Add(conjunto(inicio).Count);                
                numMaiorSequencia = tamanhoSequencia.Max() > conjunto(inicio).Count ? numMaiorSequencia : posicaoAtual;
                conjunto(inicio).RemoveAll(numero => true);
                posicaoAtual++;
            }        
            return numMaiorSequencia;
        }

    }
}
