using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Model
{
    public class Hospedagem
    {
        Suite quarto;
        int qnt_adultos;

        public int QntAdultos
        {
            get => qnt_adultos;

            set
            {
                if (value == 0)
                    throw new Exception("Por Favor, informe a quantidade de adultos");

                qnt_adultos = value;
            }
        }

        public int QntCriancas { get; set; }

        public Suite Quarto
        {
            get => quarto;

            set
            {
                if (value == null)
                    throw new Exception("Por Favor, selecione uma suíte.");

                quarto = value;
            }
        }

        public DateTime DataCheckIn { get; set; }

        public DateTime DataCkeckOut { get; set; }

        public int Estadia
        {
            get
            {
                return DataCkeckOut.Subtract(DataCheckIn).Days;
            }
        }

        public double ValorTotal
        {
            get => ((QntAdultos * Quarto.ValorDiariaAdulto) + (QntCriancas * Quarto.ValorDiariaCrianca)) * Estadia;
        }
    }


}
