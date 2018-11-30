using System;
using System.Collections.Generic;
using System.Text;

namespace DTL.DTO
{
    public class COMPONENTE
    {
        public int IdComponente { get; set; }
        public string NomeComponente { get; set; }
        public string ComComponente { get; set; }
        public bool Ativo { get; set; }

        public int IdTipoComponente { get; set; }
        public TIPO_COMPONENTE TIPO_COMPONENTE { get; set; }

        public ICollection<ARDUINO_COMPONENTE> ARDUINO_COMPONENTE { get; set; }
        public ICollection<ACAO_COMPONENTE> ACAO_COMPONENTE { get; set; }
    }
}
