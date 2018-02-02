using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Treinamentos.Models
{
    public class Cursos
    {
        [Key]        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [StringLength(100, MinimumLength=2)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataInicial { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataFinal { get; set; }

        [Required]
        [StringLength(100, MinimumLength=2)]
        public string DiaSemana { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime HoraInicial { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime HoraFinal { get; set; }

         [Required]
        public int IdAreas { get; set; }

        //public Areas Areas  { get; set; }

        

        public Cursos(){

        }

        public Cursos( int IdAreas, string Nome, DateTime DataInicial, DateTime DataFinal, string DiaSemana, DateTime HoraInicial, DateTime HoraFinal){

            this.IdAreas = IdAreas;
            this.Nome = Nome;
            this.DataInicial = DataInicial;
            this.DataFinal = DataFinal;
            this.DiaSemana = DiaSemana;
            this.HoraInicial = HoraInicial;
            this.HoraFinal  = HoraFinal;
            
        }
    }
}