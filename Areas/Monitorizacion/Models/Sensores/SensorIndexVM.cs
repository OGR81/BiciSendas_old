using BiciSendas.Recursos;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;



namespace BiciSendas.Areas.Monitorizacion.Models.Sensores
{
    [Serializable]
    public class SensorIndexVM
    {
        public byte? NumPagina { get; set; }
        public List<SensorGridVM>? Sensores { get; set; }

        public List<Categoria>? Categorias { get; set; }
        public List<SelectListItem>? Paginas { get; set; }
    }
}
