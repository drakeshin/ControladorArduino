using System.ComponentModel.DataAnnotations;

namespace DTL.DTO
{
    public class TIPO_COMPONENTE
    {
        public int IdTipoComponente { get; set; }
        [Required]
        public string NomeTipoComponente { get; set; }
    }
}