using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ControladorJanela.Com
{
    public class ArduinoConnector
    {

        /*
         -1 = Erro
         0 = Nome da porta nao especificado
         1 = Conectado
         2 = Porta ja aberta
         3 = Porta fechada
         4 = Porta ja fechada
             */
        private SerialPort com;

        public ArduinoConnector()
        {
            com = new SerialPort();
        }

        public string[] PortNames()
        {
            return SerialPort.GetPortNames();
        }

        public int PortConnect(string SerialPortName = null)
        {
            try
            {
                if (SerialPortName != null)
                {
                    com.PortName = SerialPortName;
                    if (!com.IsOpen)
                    {
                        com.Open();
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int PortDisconnect(string SerialPortName = null)
        {
            try
            {
                if (SerialPortName != null)
                {
                    com.PortName = SerialPortName;
                    if (com.IsOpen)
                    {
                        com.Close();
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int WriteToPort(string SerialPortName = null, string data = "")
        {
            try
            {
                if (com.IsOpen == true)
                {
                    com.Write(data);
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public string ReadFromPort(string SerialPortName = null)
        {
            try
            {
                //com.PortName = SerialPortName;
                return com.ReadExisting();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
