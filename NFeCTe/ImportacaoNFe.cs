using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NFeCTe;

namespace Contabil
{
    public class ImportacaoNFe
    {
        //CLASSE GESTORA
        //Intermedia os dois macro processos de Deserialização do XML, Serialização da NFe, Persistência no DB e Log de Ocorrências;

        public List<nfeProc> ListaNfeProc;
        public List<LogXML> ListaLog;
        //public List<NFe> ListaNFe;

        public LogXML log;

        public ImportacaoNFe(FileInfo[] arquivos)
        {
            ListaNfeProc = new List<nfeProc>();
            ListaLog = new List<LogXML>();
            //ListaNFe = new List<NFe>();

            loopArquivos(arquivos);
        }        

        private void loopArquivos(FileInfo[] arquivos)
        {
            for (int i = 0; i < arquivos.Count(); i++)
            {
                //Instanciar um Log
                log = new LogXML();
                if (arquivos[i].Extension != "xml")
                {
                    //Deserialização do XML em nfeProc e add a lista de nfeProc 
                    addListaNFeProc(arquivos[i], i);
                }
                else
                {
                    log.Estatus = TipoStatus.Erro.ToString();
                    log.Mensagem = "Arquivo não XML";
                }
                //Salvar o Log na Lista
                ListaLog.Add(log);               
            }
            Conf.listaLog = ListaLog;
            //Mensagens.Aviso("");            
        }
                
        private void addListaNFeProc(FileInfo arquivoXML, int contadorArq)
        {
            //Instancia um novo nfeProc e a Classe de Deserialização do XML e passar i como Id para o Log de ocorrência;
            nfeProc nfeProcObj = new nfeProc();
            GerenciadorSerializacaoXML GestorXML = new GerenciadorSerializacaoXML(ref log);
            //Se o retorno for diferente de um objeto nulo, salva na lista de nfeProc
            if ((nfeProcObj = GestorXML.DeserializarXML(arquivoXML, contadorArq)) != null)
            {
                //Verifica a redundância no LogXML retorna False antes de Salvar na ListaNfeProc
                if (vRedunLogXML())
                {
                    //CopiarArquivo(arquivoXML);
                    if (log.Estatus != TipoStatus.Aviso.ToString())
                    {
                        nfeProcObj.nomeArq = arquivoXML.Name;
                        ListaNfeProc.Add(nfeProcObj);
                    }
                }
            }
        }

        private bool vRedunLogXML()
        {
            if (ListaLog.Exists(c => c.ChaveXML == log.ChaveXML))
            {
                log.Estatus = "Erro";
                log.Mensagem = "Redundância de Arquivos. Esse XML já consta no lote importado";
                return false;
            }
            else
            {
                return true;
            }
        }

        public void CopiarArquivo(FileInfo arquivo)
        {
            if (!System.IO.Directory.Exists(log.CaminhoDestino))
                System.IO.Directory.CreateDirectory(log.CaminhoDestino);
            if (log.Estatus != TipoStatus.Erro.ToString())
                arquivo.CopyTo(log.CaminhoDestino + "\\" + arquivo, true);
        }
    }
}
