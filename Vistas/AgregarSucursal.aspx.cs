using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Entidades;

namespace PR3TP05
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        private Sucursal _sucursal = new Sucursal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                _sucursal.CargarProvincias(ddl_ProvinciaSucursal);
            }

        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string Nombre = txtbx_NombreSucursal.Text.Trim();
            string Descripcion = txtbx_DescripcionSucursal.Text.Trim();
            string Provincia = ddl_ProvinciaSucursal.SelectedValue; 
            string Direccion = txtbx_DireccionSucursal.Text.Trim();

            string consulta = $"insert into Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) values( '{Nombre}', '{Descripcion}', '{Provincia}', '{Direccion}')";

            
            int Filas = _sucursal.AgregarSucursal(consulta);

            if(Filas == 0)
            {
                lblMensaje.Text = "No se ha podido agregar la sucursal";
                //no se agrego
            }
            else
            {
                lblMensaje.Text = "La sucursal se ha agregado con exito";
                //se agrego
            }

            //Limpio las textbox
            Limpiar();           
        }

        public void Limpiar()
        {
            txtbx_DescripcionSucursal.Text = txtbx_DireccionSucursal.Text = txtbx_NombreSucursal.Text = null;

        }
    }
}