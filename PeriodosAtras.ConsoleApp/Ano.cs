using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    public class Ano
    {
        public string VerificarAno(double ano)
        {
            string mensagemAno = "";


            if (ano >= 3650)
            {
                mensagemAno = "Dez Anos ";
            }
            else if (ano >= 3285)
            {
                mensagemAno = "Nove Anos ";
            }
            else if (ano >= 2920)
            {
                mensagemAno = "Oito Anos ";
            }
            else if (ano >= 2555)
            {
                mensagemAno = "Sete Anos ";
            }
            else if (ano >= 2190)
            {
                mensagemAno = "Seis Anos ";
            }
            else if (ano >= 1825)
            {
                mensagemAno = "Cinco Anos ";
            }
            else if (ano >= 1460)
            {
                mensagemAno = "Quatro Anos ";
            }
            else if (ano >= 1095)
            {
                mensagemAno = "Três Anos ";
            }
            else if (ano >= 730)
            {
                mensagemAno = "Dois Anos ";
            }
            else if (ano >= 365)
            {
                mensagemAno = "Um Ano ";
            }
            return mensagemAno;
        }
        public double DescontarDias(double ano)
        {
            double anodescontado = 0;

            if (ano > 3650)
            {
                anodescontado = ano - 3650;
            }
            else if (ano >= 3285)
            {
                anodescontado = ano - 3285;
            }
            else if (ano >= 2920)
            {
                anodescontado = ano - 2920;
            }
            else if (ano >= 2555)
            {
                anodescontado = ano - 2555;
            }
            else if (ano >= 2190)
            {
                anodescontado = ano - 2190;
            }
            else if (ano >= 1825)
            {
                anodescontado = ano - 1825;
            }
            else if (ano >= 1460)
            {
                anodescontado = ano - 1460;
            }
            else if (ano >= 1095)
            {
                anodescontado = ano - 1095;
            }
            else if (ano >= 730)
            {
                anodescontado = ano - 730;
            }
            else if (ano >= 365)
            {
                anodescontado = ano - 365;
            }
            return anodescontado;
        }
    }
        
}
