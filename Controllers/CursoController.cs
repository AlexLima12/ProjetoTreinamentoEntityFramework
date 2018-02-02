using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Treinamentos.Dados;
using Treinamentos.Models;


namespace Treinamentos.Controllers
{
    [Route("API/[controller]")]
    public class CursoController : Controller
    {
        Cursos cursos = new Cursos();
        readonly TreinamentosContexto contexto;

         public CursoController(TreinamentosContexto contexto){
            this.contexto = contexto;
        }

        [HttpGet]
        public IEnumerable<Cursos> Listar()
        {
            return contexto.Cursos.ToList();
        }

        [HttpGet("{Id}")]
        public Cursos Listar(int id){
            return contexto.Cursos.Where(x=>x.Id==id).FirstOrDefault();
        }

            //Inserir
         [HttpPost]
        public IActionResult Post([FromBody]Cursos curso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            contexto.Cursos.Add(curso);
            int x = contexto.SaveChanges();
            if (x > 0)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}