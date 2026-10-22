using System.Linq;
using System.Collections.Generic;
using ClinicaVida.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVida.Web.Controllers
{
    public class EspecialidadesController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<int, int> contagem =
                ClinicaEmMemoria.Medicos
                    .GroupBy(m => m.EspecialidadeId)
                    .ToDictionary(
                        grupo => grupo.Key,
                        grupo => grupo.Count()
                    );

            ViewBag.ContagemMedicos = contagem;

            var especialidades = ClinicaEmMemoria.Especialidades
                .OrderBy(e => e.Nome)
                .ToList();

            return View(especialidades);
        }
    }
}