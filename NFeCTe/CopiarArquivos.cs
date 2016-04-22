using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Contabil;

namespace NFeCTe
{
    public class CopiarArquivos
    {
        public void Copiar(FileInfo[] arquivos)
        {
            foreach (var arquivo in arquivos)
            {
                var find = Conf.listaLog.FirstOrDefault(x => x.NomeArquivo.Equals(arquivo.Name));
                if (find.Estatus != TipoStatus.Erro.ToString())
                {
                    if (!System.IO.Directory.Exists(find.CaminhoDestino))
                        System.IO.Directory.CreateDirectory(find.CaminhoDestino);
                    
                        arquivo.CopyTo(find.CaminhoDestino + "\\" + arquivo, true);
                }
            }            
        }
    }
}