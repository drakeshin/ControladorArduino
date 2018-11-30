using System;
using System.Collections.Generic;
using System.Text;

namespace DTL.DTO
{
    public class ACAO_COMPONENTE
    {
        public int IdAcaoComponente { get; set; }
        public int IdAcao { get; set; }
        public int IdComponente { get; set; }
        public string ValorAcaoComponente { get; set; }
        public ACAO ACAO { get; set; }
        public COMPONENTE COMPONENTE { get; set; }
    }
}
