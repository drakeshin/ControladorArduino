using System;
using System.Collections.Generic;
using System.Text;

namespace DTL.DTO
{
    public class USUARIO
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string Token { get; set; }
        public bool Ativo { get; set; }
    }
}
