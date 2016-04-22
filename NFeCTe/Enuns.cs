using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabil
{
    public enum TiposXML
    {
        NFe= 55,
        CTe= 57
    }

    public enum TiposOperacao
    {
        ENTRADA = 0,
        SAIDA = 1
    }

    public enum TipoEmitente
    {
        PROPRIO = 0,
        TERCEIRO = 1
    }

    public enum TipoStatus
    {
        Aviso = 1,
        Erro = 2,
        Sucesso = 3
    }

    public enum NaturezaEmitente
    {
        FISICA = 1,
        JURIDICA = 2
    }  
}
