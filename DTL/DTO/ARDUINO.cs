using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTL.DTO
{
    public class ARDUINO
    {
        public int IdArduino { get; set; }
        public string ApelidoArduino { get; set; }
        [Required]
        public string COM { get; set; }
        public bool Ativo { get; set; }

        public ICollection<ARDUINO_COMPONENTE> ARDUINO_COMPONENTE { get; set; }
    }
}
