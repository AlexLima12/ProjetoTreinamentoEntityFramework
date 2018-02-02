using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Treinamentos.Models
{
    public class Areas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAreas { get; set; }

        [Required]
        [StringLength(100, MinimumLength=2)]
        public string Nome { get; set; }

        //public ICollection<Cursos> Cursos { get; set; }
        
        public Areas(){

        }

        public Areas(string Nome){
            this.Nome = Nome;
        }


        


    }
}