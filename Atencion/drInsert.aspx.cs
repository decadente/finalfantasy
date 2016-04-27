using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class drInsert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnInsertDr_Click(object sender, EventArgs e)
    {
        DoctorBLL.Insertar(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtUsuario.Text));
        Response.Redirect("Doctor.aspx");
    }
}