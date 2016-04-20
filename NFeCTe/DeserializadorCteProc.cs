using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using CTe;

namespace Contabil
{
    public class DeserializadorCteProc
    {
        //CLASSE MOTOR

        //Essa classe recebe um XML qualquer;
        //Verifica se é uma NFe/CTe e devolve o objeto servializado;
        //Caso não seja um XML valido, não seja um XML ou não seja uma NFe/CTe, return NULL;


        //********* OBS.: Criar um metodo para encerrar o arquivo READER;

        public static cteProc Deserializar(string path)
        {
            try
            {
                FileStream reader = new FileStream(path, FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(cteProc));
                return (cteProc)serializer.Deserialize(reader);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
