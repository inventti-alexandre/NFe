//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NFeCTe
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPRESA
    {
        public int EMPRESA_ID { get; set; }
        public string EMPRESA_CONTAFIX { get; set; }
        public Nullable<int> ENTIDADE_ID { get; set; }
        public string ATIVO_SN { get; set; }
        public string TIPO_PESSOA { get; set; }
        public string NOME_RAZAO { get; set; }
        public string NOME_FANTASIA { get; set; }
        public string ENDERECO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string MUNICIPIO { get; set; }
        public Nullable<int> COD_MUN { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string CNPJ_CPF { get; set; }
        public string INSCR_ESTADUAL { get; set; }
        public string INSCR_MUNICIPAL { get; set; }
        public string COD_ISS { get; set; }
        public string TIPO_TELEFONE1 { get; set; }
        public string TELEFONE1 { get; set; }
        public string TIPO_TELEFONE2 { get; set; }
        public string TELEFONE2 { get; set; }
        public string TIPO_TELEFONE3 { get; set; }
        public string TELEFONE3 { get; set; }
        public string CONTATO { get; set; }
        public string EMAIL { get; set; }
        public string HOME_PAGE { get; set; }
        public string OBSERVACAO { get; set; }
        public Nullable<System.DateTime> DATA_CADASTRO { get; set; }
        public Nullable<System.DateTime> DATA_ALTERACAO { get; set; }
        public Nullable<int> USUARIO_ID { get; set; }
        public string RAPUR { get; set; }
        public string NIRE { get; set; }
        public Nullable<System.DateTime> SESSAO { get; set; }
        public Nullable<System.DateTime> DT_INI_CONTRATO { get; set; }
        public Nullable<System.DateTime> DT_FIM_CONTRATO { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
    }
}
