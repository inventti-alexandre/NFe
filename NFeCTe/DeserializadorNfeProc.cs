using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Contabil
{
    public class DeserializadorNfeProc
    {
        //CLASSE MOTOR

        //Essa classe recebe um XML qualquer;
        //Verifica se é uma NFe/CTe e devolve o objeto servializado;
        //Caso não seja um XML valido, não seja um XML ou não seja uma NFe/CTe, return NULL;
        

        //********* OBS.: Criar um metodo para encerrar o arquivo READER;
        public static FileStream _reader;
        public static nfeProc Deserializar(string path)
        {
            try
            {
                _reader = new FileStream(path, FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(nfeProc));
                nfeProc nfe = (nfeProc)serializer.Deserialize(_reader);
                _reader.Dispose();
                return nfe;
            }
            catch (Exception ex)
            {
                _reader.Dispose();
                return null;
            }
        }

        
    }
}
