using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Web.BridgeTechnology.Hotel.Models
{
    public class Hootel
    {
        [HiddenInput]
        public int Codigo { get; set; }

        [Display(Name = "Nome do Hotel")]
        public string NomeHotel { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Disponível")]
        public bool Disponivel { get; set; }

        [Display(Name = "Valor da diária")]
        public decimal PrecoDiaria { get; set; }

        [DataType(DataType.Date), Display(Name = "Data de Inauguração")]
        public DateTime DataInauguracao { get; set; }
        public string Unidade { get; set; }
        public Quarto Quarto { get; set; }
    }
    public enum Quarto { Solteiro, Casal, Luxo }
}
