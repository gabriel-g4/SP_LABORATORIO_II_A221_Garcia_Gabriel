using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public class XmlManager : IArchivos
    {
        public bool Guardar(string path, List<Barco> listaBarcos)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path, true))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Barco>));
                    serializer.Serialize(streamWriter, listaBarcos);
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return retorno;
           
            
        }

        public List<Barco> Leer(string path)
        {
            List<Barco> retorno = new List<Barco>();
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<Barco>));
                    retorno = (List<Barco>)deserializer.Deserialize(streamReader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return retorno;
        }
    }
}
