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
    public partial class Confirmacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = (Conf.listaLog).Where(x => x.Estatus.Equals(TipoStatus.Sucesso.ToString())).Count();
            lbTotal.Text = count + " arquivos com sucesso, DANFE confere?";
            lbTotal.Visible = true;
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        protected bool VerificarArquivosSaida()
        {
            int cont = 0;
            foreach (var item in Conf.listaLog.Where(x => x.Estatus != TipoStatus.Erro.ToString()))
            {
                if(item.TipoNF.Equals(TiposOperacao.SAIDA.ToString()))
                {
                    cont++;
                }
            }
            if (cont > 1) return true;
            else return false;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if(VerificarArquivosSaida() == true)
                Response.Redirect("Confirmacao2.aspx");
            else
            {
                FileInfo[] files = (FileInfo[])Session["Cliente"];

                CopiarArquivos cop = new CopiarArquivos();
                cop.Copiar(files);

                Response.Redirect("Sucesso.aspx");
            }
        }
    }
}