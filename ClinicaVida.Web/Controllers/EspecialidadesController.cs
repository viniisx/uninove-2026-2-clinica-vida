using Microsoft.AspNetCore.Mvc;
using ClinicaVida.Web.Models;

namespace ClinicaVida.Web.Controllers;

public class EspecialidadesController : Controller
{
    public IActionResult Index()
    {
        var contagem = new Dictionary<int, int>();

        foreach (var e in ClinicaEmMemoria.Especialidades)
        {
            contagem[e.Id] = ClinicaEmMemoria.Medicos.Count(m => m.EspecialidadeId == e.Id);
        }

        ViewBag.MedicosPorEspecialidade = contagem;

        return View(ClinicaEmMemoria.Especialidades);
    }

    public IActionResult Details(int id, string nome)
    {
        if (id < 1 || id > 3)
        {
            return NotFound();
        }

        ViewData["Id"] = id;
        ViewData["Nome"] = nome;

        return View();
    }
}