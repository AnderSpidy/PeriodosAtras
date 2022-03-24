using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    public class Mes
    {
        public string VerificarMes(double mes)
        {
            string mensagemMes = "";

            if (mes > 360)
            {
                mensagemMes = "Onze Meses";
            }    
            else if (mes >= 330)
            {
                mensagemMes = "Dez Meses ";
            }
            else if (mes >= 300)
            {
                mensagemMes = "Nove Meses ";
            }
            else if (mes >= 270)
            {
                mensagemMes = "Oito Meses ";
            }
            else if (mes >= 210)
            {
                mensagemMes = "Sete Meses ";
            }
            else if (mes >= 180)
            {
                mensagemMes = "Seis Meses ";
            }
            else if (mes >= 150)
            {
                mensagemMes = "Cinco Meses ";
            }
            else if (mes >= 120)
            {
                mensagemMes = "Quatro Meses ";
            }
            else if (mes >= 90)
            {
                mensagemMes = "Três Meses ";
            }
            else if (mes >= 60)
            {
                mensagemMes = "Dois Meses ";
            }
            else if (mes >= 30)
            {
                mensagemMes = "Um Mês ";
            }
            return mensagemMes;
        }
        public double DescontarDias(double mes)
        {
            double mesdescontado = 0;

            if (mes > 360)
            {
                mesdescontado = mes - 360;
            }
            else if (mes >= 330)
            {
                mesdescontado = mes - 330;
            }
            else if (mes >= 300)
            {
                mesdescontado = mes - 300;
            }
            else if (mes >= 270)
            {
                mesdescontado = mes - 270;
            }
            else if (mes >= 210)
            {
                mesdescontado = mes - 210;
            }
            else if (mes >= 180)
            {
                mesdescontado = mes - 180;
            }
            else if (mes >= 150)
            {
                mesdescontado = mes - 150;
            }
            else if (mes >= 120)
            {
                mesdescontado = mes - 120;
            }
            else if (mes >= 90)
            {
                mesdescontado = mes - 90;
            }
            else if (mes >= 60)
            {
                mesdescontado = mes - 60;
            }
            else if (mes >= 30)
            {
                mesdescontado = mes - 30;
            }
            return mesdescontado;
        }
    }
}
