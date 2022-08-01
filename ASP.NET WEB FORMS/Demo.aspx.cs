using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_WEB_FORMS
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dispfname.Visible = false;
            displname.Visible = false;
            dispemail.Visible = false;
            dispcity.Visible = false;
            dispgender.Visible = false;
            dispskill.Visible = false;
        }

       public void btnsubmit_Click(object sender, EventArgs e)
        {
            dispfname.Visible = true;
            dispfname.Text = txtfname.Text;

            displname.Visible = true;
            displname.Text = txtlname.Text;

            dispemail.Visible = true;
            dispemail.Text = txtemail.Text;

            dispcity.Visible = true;
            dispcity.Text = lbcity.SelectedValue;

            if(rbmale.Checked)
            {
                dispgender.Visible = true;
                dispgender.Text = rbmale.Text;
            }
            else
            {
                dispgender.Visible = true;
                dispgender.Text = rbfemale.Text;

            }

            if(cbcsharp.Checked)
            {
                dispskill.Visible = true;
                dispskill.Text = cbcsharp.Text;
            }
            else if(cbjava.Checked)
            {
                dispskill.Visible = true;
                dispskill.Text = cbjava.Text;
            }
            else if(cbpython.Checked)
            {
                dispskill.Visible = true;
                dispskill.Text = cbpython.Text;
            }
            else
            {
                dispskill.Visible = true;
                dispskill.Text = cbphp.Text;
            }

            if (FileUpload1.HasFile)
            {
                //FileUpload1.SaveAs(@"D:\" + FileUpload1.FileName);
                string fn = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                string SaveLocation = Server.MapPath("upload") + "\\" + fn;
                FileUpload1.PostedFile.SaveAs(SaveLocation);
                filestatus.Text = "You have uploaded file successfully";
            }
            else
            {
                filestatus.Text = "Please select a file to upload.";
            }



        }
    }
}