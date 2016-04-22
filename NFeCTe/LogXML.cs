using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFeCTe;

namespace Contabil
{
    public class LogXML
    {
        //Esse log acompanha o processo de importação de cada arquivo. Registrará as ocorrência de Erro, Aviso, Sucesso no que se 
        //refere a importação e integração no DB.

        public int Id { get; set; }// Valor indice
        public string NomeArquivo { get; set; } //Nome do arquivo no disco
        public string Caminho { get; set; } //Diretório de salvamento
        public string NaturezaFiscal { get; set; } //NFe, CTe ou outro modelo XML (portal NFe)
        public string TipoNF { get; set; } // Entrada ou Saida
        public string TipoEmitente { get; set; } // Proprio ou Terceiro
        public string NaturezaEmitente { get; set; } //Pessoa Fisica ou Jurídica
        public string ChaveXML { get; set; }
        public int NumNf { get; set; } //Número da Nota FIscal

        // Campo para Dialogo com o usuario
        private string _mensagem;
        public string Mensagem { 
            get { return _mensagem ;}
            set { _mensagem = String.Concat(_mensagem,".*.", value); }
        }
        public string Estatus { get; set; } //Se é Erro ou Aviso (Erro não importa e nem salva em disco // Aviso não importa, mas salva em disco)
        public string CaminhoDestino { get; set; } //Caminho do direitório do disco onde será movido o arquivo




        public LogXML primeiro;
        public LogXML ultimo;

        public List<LogXML> GetLog()
        {
            return Conf.listaLog.OrderBy(x => x.Estatus).ToList();
        }

        public List<LogXML> XmlSaida()
        {
            primeiro = new LogXML();
            ultimo = new LogXML();
            var log = Conf.listaLog.Where(x => x.Estatus != (TipoStatus.Erro.ToString())).OrderBy(x => x.NumNf);
                
            primeiro = log.FirstOrDefault(x => x.TipoNF.Equals(TiposOperacao.SAIDA.ToString()));
            ultimo = log.LastOrDefault(x => x.TipoNF.Equals(TiposOperacao.SAIDA.ToString()));
            List<LogXML> Lista = new List<LogXML>();
            Lista.Add(primeiro);
            Lista.Add(ultimo);
            return Lista;
        }
        public List<int> XmlFaltantes()
        {
            primeiro = new LogXML();
            ultimo = new LogXML();
            var log = Conf.listaLog.Where(x => x.Estatus != (TipoStatus.Erro.ToString())).OrderBy(x => x.NumNf);

            primeiro = log.FirstOrDefault(x => x.TipoNF.Equals(TiposOperacao.SAIDA.ToString()));
            ultimo = log.LastOrDefault(x => x.TipoNF.Equals(TiposOperacao.SAIDA.ToString()));
            List<int> faltantes = new List<int>();

            for (int i = primeiro.NumNf; i < ultimo.NumNf; i++)
            {
                if(!Conf.listaLog.Exists(x => x.NumNf.Equals(i)))
                {
                    faltantes.Add(i);
                }
            }
            return faltantes;
        }
    }    
}
