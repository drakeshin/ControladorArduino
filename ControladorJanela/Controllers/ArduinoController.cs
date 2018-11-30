using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ControladorJanela.Com;

namespace ControladorJanela.Controllers
{
    [Produces("application/json")]
    [Route("api/Arduino")]
    public class ArduinoController : Controller
    {
        // GET: api/Arduino
        [HttpGet(Name = "Portas")]
        public IEnumerable<string> GetPorts()
        {
            try
            {
                ArduinoConnector com = new ArduinoConnector();
                return com.PortNames();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost("{port}", Name = "Comando")]
        public int SetCommands(string port, [FromBody]dynamic comando)
        {
            try
            {
                ArduinoConnector com = new ArduinoConnector();
                com.PortConnect(port);
                return com.WriteToPort(data: comando.comando.ToString());
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        
    }
}
