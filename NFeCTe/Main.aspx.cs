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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DadosLogin.empresa = new EMPRESA();
            DadosLogin.empresa.CNPJ_CPF = "123456789";
        }

        private void SaveFile(HttpPostedFile httpPostedFile)
        {
            string path = Server.MapPath(@"~\uploads\" + DadosLogin.empresa.CNPJ_CPF.ToString() + "\\");
            DirectoryInfo dir = new DirectoryInfo(path);
            if(!dir.Exists)
            {
                Directory.CreateDirectory(path);
            }
            foreach (var item in FileUpload1.PostedFiles)
            {
                if (item.ContentType == "text/xml")
                    item.SaveAs(path + item.FileName);
                else
                { }
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
                SaveFile(FileUpload1.PostedFile);
            else
            { }
        }            
    }      
}