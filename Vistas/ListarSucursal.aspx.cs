using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PR3TP05
{
    public partial class ListarSucursal : System.Web.UI.Page
    {
        private Sucursal _sucursal = new Sucursal();


        String consulta = "SELECT Id_Sucursal as 'ID Sucursal', NombreSucursal as 'Nombre sucursal', " +
            "DescripcionSucursal as 'Descripcion', Provincia.DescripcionProvincia as 'Provincia' , DireccionSucursal as 'Direccion' " +
            "FROM Sucursal " +
            "INNER JOIN Provincia ON Provincia.Id_Provincia = Sucursal.Id_ProvinciaSucursal";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) _sucursal.CargarEnTabla(grdDatos, consulta);
 
        }

		protected void btnMostrar_Click(object sender, EventArgs e)
		{
            _sucursal.CargarEnTabla(grdDatos,consulta);
            txtSucursal.Text = "";
		}

		protected void btnFiltrar_Click(object sender, EventArgs e)
		{
            if (txtSucursal.Text.ToString().Trim() != "")
            {
                int dato = Int32.Parse(txtSucursal.Text);
                String consulta2 = "SELECT Id_Sucursal as 'ID Sucursal', NombreSucursal as 'Nombre sucursal', " +
                    "DescripcionSucursal as 'Descripcion', Provincia.DescripcionProvincia as 'Provincia' , DireccionSucursal as 'Direccion' " +
                    "FROM Sucursal " +
                    "INNER JOIN Provincia ON Provincia.Id_Provincia = Sucursal.Id_ProvinciaSucursal WHERE Id_sucursal=" + dato;


                if (_sucursal.verificarID(consulta2))
                {
                    _sucursal.CargarEnTabla(grdDatos, consulta2);
                    lbl_inexistente.Visible = false;
                }
                else { lbl_inexistente.Visible = true; }

            }
            else { lbl_inexistente.Visible = true; }

            
            txtSucursal.Text = "";
        }
	}
}