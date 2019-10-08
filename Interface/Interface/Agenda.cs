using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    class Agenda:Relogio, Calendario {
        public DateTime InicializaDataHora(string xData, string xHora) {
            int Dia, Mes, Ano;
            int Hora, Minuto;
            Dia = Convert.ToInt16(xData.Substring(0, 2));
            Mes = Convert.ToInt16(xData.Substring(3, 2));
            Ano = Convert.ToInt16(xData.Substring(6, 4));
            Hora = Convert.ToInt16(xHora.Substring(0, 2));
            Minuto = Convert.ToInt16(xHora.Substring(3, 2));
            return new DateTime(Ano, Mes, Dia, Hora, Minuto, 0);
        }

        public string SubtraiDatas(DateTime Data1, DateTime Data2) {
            TimeSpan Resultado = Data2 - Data1;
            return Resultado.Days.ToString();
        }
        public string SubtraiHoras(DateTime Hora1, DateTime Hora2) {
            TimeSpan Resultado = Hora2 - Hora1;
            return Resultado.Hours +
                ":" +
                (Resultado.Minutes < 10 ? "0" : "") +
                Resultado.Minutes;
        }
    }
}
