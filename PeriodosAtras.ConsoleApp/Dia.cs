using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    public class Dia
    {

        public string VerificarDias(double dias)
        {
            string mensagem = "";
            
            if(dias == 1)
            {
                mensagem = "Um dia";
            }
            else if (dias == 2)
            {
                mensagem = "Dois dias";
            }
            else if (dias == 3)
            {
                mensagem = "Três dias";
            }
            else if (dias == 4)
            {
                mensagem = "Quatro dias";
            }
            else if (dias == 5)
            {
                mensagem = "Cinco dias"; 
            }
            else if (dias == 6)
            {
                mensagem = "Seis dias";
            }
            
            return mensagem;
        }
    }
}
