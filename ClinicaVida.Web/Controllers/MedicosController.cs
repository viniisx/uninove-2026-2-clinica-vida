using System.Linq;
using ClinicaVida.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVida.Web.Controllers
{
    public class MedicosController : Controller
    {
        public IActionResult Index(int? especialidadeId)
        {
            var consulta = ClinicaEmMemoria.Medicos.AsEnumerable();

            if (especialidadeId.HasValue)
            {
                consulta = consulta.Where(m =>
                    m.EspecialidadeId == especialidadeId.Value);
            }

            var medicos = consulta
                .OrderBy(m => m.Nome)
                .Select(m => new Medico
                {
                    Id = m.Id,
                    Nome = m.Nome,
                    Crm = m.Crm,
                    EspecialidadeId = m.EspecialidadeId,
                    Especialidade = ClinicaEmMemoria.Especialidades
                        .FirstOrDefault(e => e.Id == m.EspecialidadeId)
                })
                .ToList();

            ViewBag.Especialidades = ClinicaEmMemoria.Especialidades;
            ViewBag.EspecialidadeSelecionada = especialidadeId;

            return View(medicos);
        }

        public IActionResult Details(int id)
        {
            var medicoOriginal = ClinicaEmMemoria.Medicos
                .FirstOrDefault(m => m.Id == id);

            if (medicoOriginal == null)
            {
                return NotFound();
            }

            var medico = new Medico
            {
                Id = medicoOriginal.Id,
                Nome = medicoOriginal.Nome,
                Crm = medicoOriginal.Crm,
                EspecialidadeId = medicoOriginal.EspecialidadeId,
                Especialidade = ClinicaEmMemoria.Especialidades
                    .FirstOrDefault(e => e.Id == medicoOriginal.EspecialidadeId)
            };

            return View(medico);
        }
    }
}