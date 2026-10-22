using System.Collections.Generic;

namespace ClinicaVida.Web.Models
{
    public static class ClinicaEmMemoria
    {
        public static List<Especialidade> Especialidades { get; } = new()
        {
            new Especialidade
            {
                Id = 1,
                Nome = "Cardiologia",
                Descricao = "Cuidados com o coração"
            },
            new Especialidade
            {
                Id = 2,
                Nome = "Pediatria",
                Descricao = "Atendimento médico infantil"
            },
            new Especialidade
            {
                Id = 3,
                Nome = "Dermatologia",
                Descricao = "Cuidados com a pele"
            },
            new Especialidade
            {
                Id = 4,
                Nome = "Ortopedia",
                Descricao = "Cuidados com ossos e articulações"
            }
        };

        public static List<Medico> Medicos { get; } = new()
        {
            new Medico
            {
                Id = 1,
                Nome = "Ana Prado",
                Crm = "CRM-SP 112233",
                EspecialidadeId = 1
            },
            new Medico
            {
                Id = 2,
                Nome = "Bruno Almeida",
                Crm = "CRM-SP 223344",
                EspecialidadeId = 2
            },
            new Medico
            {
                Id = 3,
                Nome = "Carla Santos",
                Crm = "CRM-SP 334455",
                EspecialidadeId = 3
            },
            new Medico
            {
                Id = 4,
                Nome = "Daniel Costa",
                Crm = "CRM-SP 445566",
                EspecialidadeId = 4
            },
            new Medico
            {
                Id = 5,
                Nome = "Fernanda Lima",
                Crm = "CRM-SP 556677",
                EspecialidadeId = 1
            },
            new Medico
            {
                Id = 6,
                Nome = "Gustavo Rocha",
                Crm = "CRM-SP 667788",
                EspecialidadeId = 2
            }
        };
    }
}