using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contabil;

namespace NFeCTe
{
    public partial class Confirmacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (var item in (Conf.listaLog).Where(x => x.Estatus.Equals(TipoStatus.Aviso.ToString())))
            {
                lbAvisos.Items.Add(item.NomeArquivo+ " "+ item.Mensagem);
            }
            foreach (var item in (Conf.listaLog).Where(x => x.Estatus.Equals(TipoStatus.Erro.ToString())))
            {
                lbErros.Items.Add(item.NomeArquivo + " " + item.Mensagem);
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}