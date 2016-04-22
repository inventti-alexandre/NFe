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
    public partial class Main : System.Web.UI.Page
    {
        public FileInfo[] _files;
        public string _path;
        protected void Page_Load(object sender, EventArgs e)
        {
            DadosLogin.usuario = new USUARIO();
            DadosLogin.usuario.USUARIO_ID = 4;
            DadosLogin.competencia = "01/2016";
            DadosLogin.empresa = new EMPRESA();
            DadosLogin.empresa.CNPJ_CPF = "64598857000138";
        }

        private void SaveFile(HttpPostedFile httpPostedFile)
        {
            int i = 0;            
            _path = Server.MapPath(@"~\uploads\" + DadosLogin.empresa.CNPJ_CPF.ToString() + "\\");
            DirectoryInfo dir = new DirectoryInfo(_path);
            if(!dir.Exists)
            {
                Directory.CreateDirectory(_path);
            }
            else
            {                
                Directory.Delete(_path,true);
                Directory.CreateDirectory(_path);
            }
            foreach (var item in FileUpload1.PostedFiles)
            {
                //if (item.ContentType == "text/xml")
                //{
                        item.SaveAs(_path + item.FileName);
                //}
                //else
                //{
                    
                //}
            }
        }
        private void SelecionarXML()
        {
            DirectoryInfo dir = new DirectoryInfo(_path);
            FileInfo[] files;
            files = new FileInfo[dir.GetFiles().Count()];
            files = dir.GetFiles();
            Session["Cliente"] = files;
            ImportacaoNFe imp = new ImportacaoNFe(files);
            Response.Redirect("Confirmacao.aspx");
        } 

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                SaveFile(FileUpload1.PostedFile);
                SelecionarXML();
            }
            else
            {
                Response.Write("Selecione os XML/NFe");
            }
        }                   
    }      
}