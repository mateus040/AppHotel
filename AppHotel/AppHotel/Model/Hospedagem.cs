using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Model
{
    public class Hospedagem
    {
        public CategoriaQuarto Quarto { get; set; }

        public int QuantidadeAdultos { get; set; }

        public int QuantidadeCriancas { get; set; }

        public int QuantidadeDias { get; set; }

        public DateTime DataCheckIn { get; set; }

        public DateTime DataCheckOut { get; set; }

        public double ValorTotal { get; set; }



        public static int CalcularTempoEstadia(DateTime checkin, DateTime checkout)
        {
            int total_dias = checkout.Subtract(checkin).Days;

            return total_dias;
        }


        public double CalcularValorEstadia()
        {
            double valor_adultos = (QuantidadeAdultos * Quarto.ValorDiariaAdulto) * QuantidadeDias;

            double valor_criancas = (QuantidadeCriancas * Quarto.ValorDiariaCrianca) * QuantidadeDias;

            double valor_hospedagem = valor_adultos + valor_criancas;

            return valor_hospedagem;
        }
    }


}
