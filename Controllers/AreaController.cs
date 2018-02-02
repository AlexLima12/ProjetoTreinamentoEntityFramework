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
    public class AreaController : Controller
    {
        Areas areas = new Areas();
        readonly TreinamentosContexto contexto;

        
        public AreaController(TreinamentosContexto contexto){
            this.contexto = contexto;
        }

        [HttpGet]
        public IEnumerable<Areas> Listar()
        {
            return contexto.Areas.ToList();
        }

        [HttpGet("{Id}")]
        public Areas Listar(int id){
            return contexto.Areas.Where(x=>x.IdAreas==id).FirstOrDefault();
        }
        
        [HttpPost]
        public IActionResult Post([FromBody]Areas area)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            contexto.Areas.Add(area);
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


         [HttpPut("{Id}")]
        public IActionResult Put(int Id, [FromBody]Areas area)
        {
            if (area == null || area.IdAreas != Id)
            {
                return BadRequest();
            }

            var ar = contexto.Areas.Where(a => a.IdAreas == Id).FirstOrDefault();
            if (ar == null)
            {
                return NotFound();
            }

            ar.Nome = area.Nome;
            

            contexto.Areas.Update(ar);
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

         [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var area = contexto.Areas.Where(ar => ar.IdAreas == Id).FirstOrDefault();
            if (area == null)
            {
                return NotFound();
            }

            contexto.Areas.Remove(area);
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