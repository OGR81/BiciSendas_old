﻿using BiciSendas.Recursos;
using System.ComponentModel.DataAnnotations;


namespace BiciSendas.Areas.Monitorizacion.Models.Sensores
{
    [Serializable]
    public class SensorGridVM
    {
        [Display(Name = nameof(SensorStrings.Identificador), ResourceType = typeof(SensorStrings))]
        public string? Identificador { get; set; }

        [Display(Name = nameof(SensorStrings.Nombre), ResourceType = typeof(SensorStrings))]
        public string? Nombre { get; set; }
        [Display(Name = nameof(SensorStrings.Estado), ResourceType = typeof(SensorStrings))]
        public int? Estado { get; set; }
        [Display(Name = nameof(SensorStrings.Categoria), ResourceType = typeof(SensorStrings))]
        public int? Categoria { get; set; }
        [Display(Name = nameof(SensorStrings.Coordenadas), ResourceType = typeof(SensorStrings))]
        public string? Coordenadas { get; set; }
        [Display(Name = nameof(SensorStrings.FechaModificacion), ResourceType = typeof(SensorStrings))]
        public DateTime? FechaModificacion { get; set; }





    }
}
