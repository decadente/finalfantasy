using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Doctor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton botonClikeado = (LinkButton)sender;
        int doctor_id = Convert.ToInt32(botonClikeado.CommandArgument);
        DoctorBLL.Delete(doctor_id);
        GridView1.DataBind();
    }
}