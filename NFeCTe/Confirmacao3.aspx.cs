using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contabil;
using System.IO;

namespace NFeCTe
{
    public partial class Confirmacao3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VerificarArqSaida();
        }

        private void VerificarArqSaida()
        {
            var primeiro = new LogXML();
            var ultimo = new LogXML();
            var log = Conf.listaLog.Where(x => x.Estatus != (TipoStatus.Erro.ToString())).OrderBy(x => x.NumNf);

            primeiro = log.FirstOrDefault(x => x.TipoNF.Equals(TiposOperacao.SAIDA.ToString()));
            ultimo = log.LastOrDefault(x => x.TipoNF.Equals(TiposOperacao.SAIDA.ToString()));

            for (int i = primeiro.NumNf; i < ultimo.NumNf; i++)
            {
                if (!Conf.listaLog.Exists(x => x.NumNf.Equals(i)))
                {
                    lbFaltantes.Items.Add(i.ToString());
                }
            }
            if(lbFaltantes.Items != null)
                ComFaltantes();
            else
                SemFaltantes();
            lbVer.Visible = true;
            lbRes.Visible = true;
        }

        private void SemFaltantes()
        {
            lbVer.Text = "Todos arquivos encontrados";
            lbRes.Text = "Clique em 'Enviar'";
        }

        private void ComFaltantes()
        {
            lbVer.Text = "Arquivos de Saída não encontrados:";
            lbRes.Text = "Se essas notas foram canceladas clique em 'Enviar', caso esteja faltando clique em 'Voltar' e adicione-a(s).";
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            FileInfo[] files = (FileInfo[])Session["Cliente"];
            
            CopiarArquivos cop = new CopiarArquivos();
            cop.Copiar(files);

            Response.Redirect("Sucesso.aspx");
        }
    }
}