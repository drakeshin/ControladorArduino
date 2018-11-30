using System;
using System.Collections.Generic;
using System.Text;

namespace DTL.DTO
{
    public class ARDUINO_COMPONENTE
    {
        public int IdArduinoComponente { get; set; }
        public int IdArduino { get; set; }
        public ARDUINO ARDUINO { get; set; }
        public int IdComponente { get; set; }
        public COMPONENTE COMPONENTE { get; set; }


    }
}
