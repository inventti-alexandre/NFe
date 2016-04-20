using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabil
{
    public static class Utils
    {
        public static string ValorNullOrDefault(this object valor, string valorDefault)
        {
            //Se o Valor for Null
            if (valor == null)
            {
                GerenciadorSerializacaoXML.log.NaturezaEmitente = NaturezaEmitente.FISICA.ToString();
                return valorDefault;
            }
            //Se o Valor do DbNull
            if (valor == DBNull.Value) return valorDefault;

            GerenciadorSerializacaoXML.log.NaturezaEmitente = NaturezaEmitente.JURIDICA.ToString();
            return valor.ToString();
        }

        public static int ValorNullOrDefault(this object valor, int valorDefault)
        {
            //Se o Valor for Null
            if (valor == null) return valorDefault;

            //Se o Valor do DbNull
            if (valor == DBNull.Value) return valorDefault;

            return Convert.ToInt32(valor);
        }

        public static DateTime ValorDataNullOrDefault(this DateTime valor, DateTime dataDefault)
        {
            //Se a data não for valida
             if (valor.Year != 0001 ) return valor;

             return dataDefault;
        }

        public static Decimal ToDecimal(this Double valor)
        {
            //Converte valor Double para Decimal
            return Convert.ToDecimal(valor);
        }
    }
}
