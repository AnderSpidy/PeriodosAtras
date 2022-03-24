using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    public class Semana
    {
        public string VerificarSemanas(double semana)
        {
            string mensagemSemana = "";

            if (semana >= 28)
            {
                mensagemSemana = "Quatro Semanas";
            }
            else if (semana >= 21)
            {
                mensagemSemana = "Três Semanas";
            }
            else if (semana >= 14)
            {
                mensagemSemana = "Duas Semanas";
            }
            else if (semana >= 7)
            {
                mensagemSemana = "Uma Semana";
            }
            return mensagemSemana;
        }
        public double DescontarDias(double semana)
        {
            double semanaDescontada = 0;
            
            if (semana >= 28)
            {
                semanaDescontada = semana - 28;
            }
            else if (semana >= 21)
            {
                semanaDescontada = semana - 21;
            }
            else if (semana >= 14)
            {
                semanaDescontada = semana - 14;
            }
            else if (semana >= 7)
            {
                semanaDescontada = semana - 7;
            }
            return semanaDescontada;
        }

    }
}
