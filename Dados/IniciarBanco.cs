using System.Linq;
using System;
using Treinamentos.Dados;
using Treinamentos.Models;

namespace Treinamentos.Dados
{
    public class IniciarBanco
    {
        public static void Inicializar(TreinamentosContexto contexto)
        {
            contexto.Database.EnsureCreated();
            if (contexto.Areas.Any())
            {
                return;
            }

            var areas = new Areas("Teste2");
            contexto.Areas.Add(areas);
            contexto.SaveChanges();


            var cursos = new Cursos(areas.IdAreas, "Curso01", DateTime.Parse("31-01-2015"), DateTime.Parse("05-02-2015"),
             "Segunda", DateTime.Parse("11:00:00"), DateTime.Parse("12:00:00"));
            contexto.Cursos.Add(cursos);

            contexto.SaveChanges();
        }
        
    }
}