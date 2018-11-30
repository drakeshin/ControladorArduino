using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTL.DTO
{
    public class ACAO
    {
        public int IdAcao { get; set; }
        [Required]
        public string NomeAcao { get; set; }
        public string DescricaoAcao { get; set;}

        public ICollection<ACAO_COMPONENTE> ACAO_COMPONENTE { get; set; }
    }
}
