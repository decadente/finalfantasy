using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class drActualizar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) { 
        int doctor_id = Convert.ToInt32(Request.QueryString["doctor_id"]);
        Doctor objDoctor = DoctorBLL.Select(doctor_id);
        txtNombre.Text = objDoctor.nombre;
        txtApellido.Text = objDoctor.apellido;
        txtUsuario.Text = objDoctor.usuario_id.ToString();
        hidenId.Value = doctor_id.ToString();
        }
    }

    protected void btnActualizar_Click(object sender, EventArgs e)
    {

        DoctorBLL.Update(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtUsuario.Text), Convert.ToInt32(hidenId.Value));
        Response.Redirect("Doctor.aspx");
    }
}