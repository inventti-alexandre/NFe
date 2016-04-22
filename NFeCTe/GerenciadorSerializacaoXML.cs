using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTe;

namespace Contabil
{
    public class GerenciadorSerializacaoXML
    {
        //CLASSE GESTORA
        //Essa classe será responsável por gerenciar todo o processo de importação de UM xml. Ela devolverá um Log
        //com todas as situações que identificar.

        private nfeProc nfe { get; set; }
        private cteProc cte { get; set; }
        public static LogXML log { get; set; }

        public GerenciadorSerializacaoXML(ref LogXML _log)
        {
            log = new LogXML();
            log = _log;
        }

        public nfeProc DeserializarXML(FileInfo arqXML, int contadorXML)
        {
            log.Estatus = "";
            abrirLog(arqXML, contadorXML);

            //Instancia um novo objeto nfeProc;
            nfe = new nfeProc();

             //Se o XML não for NFe/CTe, finaliza o processo;
            if (eNFeCTe(arqXML) == false) return null;
            //Se o XML não pertencer a empresa, finaliza o processo;
            if (pertenceEmpresa() == false) return null;            
            //se o XML estiver em competência inesperada, finaliza o processo;
            if (pertenceCompetencia() == false)
                if(log.Estatus.Equals(TipoStatus.Erro.ToString())) return null;
            string escrituracao;
            if (log.Estatus.Equals(TipoStatus.Aviso.ToString())) escrituracao = "Não Escriturados";
            else
            {
                escrituracao = "Escriturados";
                log.Estatus = TipoStatus.Sucesso.ToString();
            }            
            log.CaminhoDestino = @"D:\XML\" + DadosLogin.empresa.CNPJ_CPF + "\\" + DadosLogin.competencia.Substring(3,4)+DadosLogin.competencia.Substring(0,2) + "\\" + escrituracao + "\\" + log.NaturezaFiscal + "\\" + log.TipoNF;
            if(nfe != null) log.NumNf = nfe.NFe.infNFe.ide.nNF;
            else log.NumNf = cte.CTe.infCte.ide.nCT;
            return nfe;
        }

        private void abrirLog(FileInfo arqXML, int contadorXML)
        {
            //Neste momento foi aberto o Log do Arquivo para acompanhamento dos eventos.
            log.Id = contadorXML;
            log.NomeArquivo = arqXML.Name;
            log.Caminho = arqXML.DirectoryName;            
        }

        private bool eNFeCTe(FileInfo arqXML)
        {
            //Usará a Classe Deserializar para Saber se é um XML de NFe/CTe
            //Devolve informação se é ou não XML NFe.
      
            nfe = DeserializadorNfeProc.Deserializar(arqXML.FullName);
                if (nfe != null)
                {
                    log.NaturezaFiscal = TiposXML.NFe.ToString();
                    log.ChaveXML = nfe.NFe.infNFe.Id.Substring(3);
                    return true;
                }  
            cte = DeserializadorCteProc.Deserializar(arqXML.FullName);
                if(cte != null)
                {
                    log.NaturezaFiscal = TiposXML.CTe.ToString();
                    log.ChaveXML = cte.CTe.infCte.Id.Substring(3);
                    return true;
                }
                else
                {
                    log.NaturezaFiscal = "Não é NFe/CTe";
                    log.Mensagem = "Arquivo não é um XML de NFe/CTe. Removido da Importação";
                    log.Estatus = TipoStatus.Erro.ToString();
                    return false;
                }      
        }

        private bool pertenceEmpresa()
        {
            if (log.NaturezaFiscal == TiposXML.NFe.ToString())
            {
                if (pertenceEmpresaNFe() == true) return true;
            }
            if (log.NaturezaFiscal == TiposXML.CTe.ToString())
            {
                if (pertenceEmpresaCTe() == true) return true;
            }
            //Implementar o mesmo para FRETE

            return false;
        }

        private bool pertenceEmpresaNFe()
        {
            //Se forem NFe do Tipo 1 - SAIDAS
            if (nfe.NFe.infNFe.ide.tpNF == 1)
            {
                //Se o tipo for SAIDA e CNPJ Emitente Confere, a NFe será SAIDA para o nosso cliente
                if (DadosLogin.empresa.CNPJ_CPF == nfe.NFe.infNFe.emit.CNPJ.ValorNullOrDefault(nfe.NFe.infNFe.emit.CPF))
                {
                    log.TipoNF = TiposOperacao.SAIDA.ToString();
                    log.TipoEmitente = TipoEmitente.PROPRIO.ToString();
                    return true;
                }
                //Se o tipo for SAIDA e CNPJ Destinatário Confere, a NFe será de ENTRADA para o nosso cliente
                if (DadosLogin.empresa.CNPJ_CPF == nfe.NFe.infNFe.dest.CNPJ.ValorNullOrDefault(nfe.NFe.infNFe.dest.CPF))
                {
                    log.TipoNF = TiposOperacao.ENTRADA.ToString();
                    log.TipoEmitente = TipoEmitente.TERCEIRO.ToString();
                    return true;
                }
            }
            //Se forem NFe do Tipo 0 - ENTRADA: para essas NFs, o emitente ter que ser nosso cliente, senão a NF está errada.
            if (nfe.NFe.infNFe.ide.tpNF == 0)
            {
                //Se o tipo for SAIDA e CNPJ Emitente Confere, a NFe será SAIDA para o nosso cliente
                if (DadosLogin.empresa.CNPJ_CPF == nfe.NFe.infNFe.emit.CNPJ.ValorNullOrDefault(nfe.NFe.infNFe.emit.CPF))
                {
                    log.TipoNF = TiposOperacao.ENTRADA.ToString();
                    log.TipoEmitente = TipoEmitente.PROPRIO.ToString();
                    return true;
                }               
            }
            log.Mensagem = "Essa NFe não pertence a EMPRESA Logada. Analisar o arquivo importado!";
            log.Estatus = TipoStatus.Erro.ToString();
            return false;           
        }     

        private bool pertenceEmpresaCTe()
        {
            int tipoTomador = -1;
            //Se toma03 ou toma4 diferente de null => cliente é o tomador
            if (cte.CTe.infCte.ide.toma03 != null || cte.CTe.infCte.ide.toma4 != null)
            {
                if (cte.CTe.infCte.ide.toma03 != null) tipoTomador = cte.CTe.infCte.ide.toma03.toma;
                if (cte.CTe.infCte.ide.toma4 != null) tipoTomador = cte.CTe.infCte.ide.toma4.toma;
                //Se o tipo for SAIDA e CNPJ Destinatário Confere, a CTe será de ENTRADA para o nosso cliente
                switch (tipoTomador)
                {
                case 0://Quando o cliente for remetente
                    if (DadosLogin.empresa.CNPJ_CPF == cte.CTe.infCte.rem.CNPJ.ValorNullOrDefault(cte.CTe.infCte.rem.CPF))
                    {
                        log.TipoNF = TiposOperacao.ENTRADA.ToString();
                        log.TipoEmitente = TipoEmitente.TERCEIRO.ToString();
                        return true;
                    }
                    break;
                case 1://Quando o cliente for expeditor
                    if (DadosLogin.empresa.CNPJ_CPF == cte.CTe.infCte.exped.CNPJ.ValorNullOrDefault(cte.CTe.infCte.exped.CPF))
                    {
                        log.TipoNF = TiposOperacao.ENTRADA.ToString();
                        log.TipoEmitente = TipoEmitente.TERCEIRO.ToString();
                        return true;
                    }
                    break;
                case 2://Quando o cliente for recebedor
                    if (DadosLogin.empresa.CNPJ_CPF == cte.CTe.infCte.receb.CNPJ.ValorNullOrDefault(cte.CTe.infCte.receb.CPF))
                    {
                        log.TipoNF = TiposOperacao.ENTRADA.ToString();
                        log.TipoEmitente = TipoEmitente.TERCEIRO.ToString();
                        return true;
                    }
                    break;
                case 3:// Quando o cliente for destinatario
                    if (DadosLogin.empresa.CNPJ_CPF == cte.CTe.infCte.dest.CNPJ.ValorNullOrDefault(cte.CTe.infCte.dest.CPF))
                    {
                        
                        log.TipoNF = TiposOperacao.ENTRADA.ToString();
                        log.TipoEmitente = TipoEmitente.TERCEIRO.ToString();
                        return true;
                    }
                    break;
                case 4:// Outro tipo tomador
                    if (cte.CTe.infCte.ide.toma4.CNPJ == null && cte.CTe.infCte.ide.toma4.CPF == null) break;
                    if (DadosLogin.empresa.CNPJ_CPF == cte.CTe.infCte.ide.toma4.CNPJ.ValorNullOrDefault(cte.CTe.infCte.ide.toma4.CPF))
                    {
                        log.TipoNF = TiposOperacao.ENTRADA.ToString();
                        log.TipoEmitente = TipoEmitente.TERCEIRO.ToString();
                        return true;
                    }
                    break;
                    }
            }
            //Se o tipo for SAIDA e CNPJ Emitente Confere, a CTe será SAIDA para o nosso cliente
            // Cliente é o emitente
            if (DadosLogin.empresa.CNPJ_CPF == cte.CTe.infCte.emit.CNPJ.ValorNullOrDefault(cte.CTe.infCte.emit.CNPJ))
            {
                log.TipoNF = TiposOperacao.SAIDA.ToString();
                log.TipoEmitente = TipoEmitente.PROPRIO.ToString();
                return true;
            }
            else
            {
                log.Mensagem = "Essa CTe não pertence a EMPRESA Logada. Analisar o arquivo importado!";
                log.Estatus = TipoStatus.Erro.ToString();
                return false;
            }
        }        

        private bool pertenceCompetencia()
        { 
            DateTime DtIniComp = Convert.ToDateTime(String.Concat("01/",DadosLogin.competencia));
            DateTime DtFinComp = (Convert.ToDateTime(String.Concat("01/", DadosLogin.competencia, " 23:59:59"))).AddMonths(1).AddDays(-1);

            if (log.NaturezaFiscal.Equals(TiposXML.NFe.ToString()))
            {
                if (log.TipoEmitente.Equals(TipoEmitente.PROPRIO.ToString()))
                {
                    //Data de Emissão do XML
                    DateTime DtEmiXML = Convert.ToDateTime(nfe.NFe.infNFe.ide.dhEmi);

                    //Data XML inferior a competencia logada: Aviso
                    if (DtEmiXML < DtIniComp)
                    {
                        log.Estatus = TipoStatus.Aviso.ToString();
                        log.Mensagem = "NFe de Saída/Entrada de Emissão PROPRIA, cuja da data de EMISSÃO compreende-se em meses anteriores a competência logada. Xml salvo na pasta [Não Escriturados], mas não importado";
                        return false;
                    }
                    //Data XML superior a competencia logada: Erro
                    if (DtEmiXML > DtFinComp)
                    {
                        log.Estatus = TipoStatus.Erro.ToString();
                        log.Mensagem = "NFe de Saída/Entrada de Emissão PROPRIA, cuja da data de EMISSÃO compreende-se em meses posteriores a competência logada. Xml descartado.";
                        return false;
                    }
                    return true;
                }
                if (log.TipoEmitente.Equals(TipoEmitente.TERCEIRO.ToString()))
                {
                    //Data de Entrada/Saida ou Data de Emissão do XML
                    DateTime DtSaiXML = Convert.ToDateTime(nfe.NFe.infNFe.ide.dhSaiEnt).ValorDataNullOrDefault(Convert.ToDateTime(nfe.NFe.infNFe.ide.dhEmi));

                    //Data XML inferior a competencia logada: Aviso
                    if (DtSaiXML < DtIniComp)
                    {
                        log.Estatus = TipoStatus.Aviso.ToString();
                        log.Mensagem = "NFe de Entrada de Emissão TERCEIRO, cuja da data de ENTRADA/SAÍDA compreende-se em meses anteriores a competência logada. Xml salvo na pasta [Não Escriturados], mas não importado";
                        return false;
                    }
                    //Data XML superior a competencia logada: Erro
                    if (DtSaiXML > DtFinComp)
                    {
                        log.Estatus = TipoStatus.Erro.ToString();
                        log.Mensagem = "NFe de Entrada de Emissão TERCEIRO, cuja da data de ENTRADA/SAÍDA compreende-se em meses posteriores a competência logada. Xml descartado.";
                        return false;
                    }
                    return true;
                }
                return false;
            }
            if(log.NaturezaFiscal.Equals(TiposXML.CTe.ToString()))
            {
                //Data de Emissão do XML
                    DateTime DtEmiXML = Convert.ToDateTime(cte.CTe.infCte.ide.dhEmi);

                    //Data XML inferior a competencia logada: Aviso
                    if (DtEmiXML < DtIniComp)
                    {
                        log.Estatus = TipoStatus.Aviso.ToString();
                        log.Mensagem = "CTe de Saída/Entrada de Emissão PROPRIA, cuja da data de EMISSÃO compreende-se em meses anteriores a competência logada. Xml salvo na pasta [Não Escriturados], mas não importado";
                        return false;
                    }
                    //Data XML superior a competencia logada: Erro
                    if (DtEmiXML > DtFinComp)
                    {
                        log.Estatus = TipoStatus.Erro.ToString();
                        log.Mensagem = "CTe de Saída/Entrada de Emissão PROPRIA, cuja da data de EMISSÃO compreende-se em meses posteriores a competência logada. Xml descartado.";
                        return false;
                    }
                    return true;
               
                if (log.TipoEmitente.Equals(TipoEmitente.TERCEIRO.ToString()))
                {
                    //Data XML inferior a competencia logada: Aviso
                    if (DtEmiXML < DtIniComp)
                    {
                        log.Estatus = TipoStatus.Aviso.ToString();
                        log.Mensagem = "CTe de Entrada de Emissão TERCEIRO, cuja da data de ENTRADA/SAÍDA compreende-se em meses anteriores a competência logada. Xml salvo na pasta [Não Escriturados], mas não importado";
                        return false;
                    }
                    //Data XML superior a competencia logada: Erro
                    if (DtEmiXML > DtFinComp)
                    {
                        log.Estatus = TipoStatus.Erro.ToString();
                        log.Mensagem = "CTe de Entrada de Emissão TERCEIRO, cuja da data de ENTRADA/SAÍDA compreende-se em meses posteriores a competência logada. Xml descartado.";
                        return false;
                    }
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
