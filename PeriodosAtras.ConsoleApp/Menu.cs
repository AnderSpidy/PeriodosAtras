using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    public class Menu
    {
        Dia teste = new Dia();
        Semana teste2 = new Semana();
        Mes teste3 = new Mes();
        Ano teste4 = new Ano();
        public void VerificarData(DateTime data)
        {
            string mensagem = "";
            TimeSpan tempopassado = DateTime.Today - data;
            double dias = tempopassado.Days;
            while (dias != 0)
            {
                if (dias > 365)
                {
                    mensagem = mensagem + teste4.VerificarAno(dias);
                    dias = teste4.DescontarDias(dias);
                    if (dias != 0)
                    {
                        mensagem = mensagem + " e ";
                    }
                    continue;
                }
                if (dias >= 30)
                {
                    mensagem = mensagem + teste3.VerificarMes(dias);
                    dias = teste3.DescontarDias(dias);
                    if (dias != 0)
                    {
                        mensagem = mensagem + " e ";
                    }
                    continue;
                }
                if (dias >= 7)
                {
                    mensagem = mensagem + teste2.VerificarSemanas(dias);
                    dias = teste2.DescontarDias(dias);
                    if(dias != 0)
                    {
                        mensagem = mensagem + " e ";
                    }
                    continue;
                }
                //dias
                mensagem = mensagem + teste.VerificarDias(dias);
                break;
            }
            Console.WriteLine(mensagem + " atràs");
        }
    }
}
