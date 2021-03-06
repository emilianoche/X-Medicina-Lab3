﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Base.Entity;
using Domain.Core.Entities.Validation;

namespace Domain.Core.Entities
{
    [Table("Consulta")]
    [MetadataType(typeof(IConsulta))]
    public class Consulta : BaseEntity
    {
        // Propiedades
        public Guid MotivoConsultaId { get; set; }
        public Guid PacienteId { get; set; }
        public Guid ProfesionalId { get; set; }

        public DateTime Fecha { get; set; }

        //Medidas Basicas
        public decimal? Peso { get; set; }
        public decimal? Talle { get; set; }

        //Circunferencias
        public decimal? Cintura { get; set; }
        public decimal? Cadera { get; set; }

        public decimal? MitadBrazoRelajado { get; set; }
        public decimal? MitadBrazoContraido { get; set; }
        public decimal? Cuello { get; set; }
        public decimal? Muslo { get; set; }


        //Pliegues
        public decimal? Biceps { get; set; }
        public decimal? Triceps { get; set; }
        public decimal? Subescupular { get; set; }
        public decimal? Abdominal { get; set; }
        public decimal? MusloFrontal { get; set; }


        //Indices
        public decimal? IMC { get; set; }
        public decimal? IndiceCaderaCintura { get; set; }
        public decimal? IndiceGrasaCorporal { get; set; }
        public decimal? PesoIdeal { get; set; }

        // Propiedades de Navegacion
        [ForeignKey("MotivoConsultaId")]
        public MotivoConsulta MotivoConsulta { get; set; }

        [ForeignKey("PacienteId")]
        public Paciente Paciente { get; set; }

        [ForeignKey("ProfesionalId")]
        public virtual Empleado Profesional { get; set; }

        public virtual ICollection<ConsultaImagen> ConsultaImagenes  { get; set; }
    }
}
