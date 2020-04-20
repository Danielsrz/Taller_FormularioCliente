using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormularioClientes
{
    public partial class Form1 : Form
    {
        public object IDCliente { get; private set; }

        public Form1()
        {
            InitializeComponent();
            actualizarForm(this);
        }

        private class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Fecha_Nac { get; set; }
            public string Direccion { get; set; }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            string strNombre, strApellido, strFechaNacimiento, strDireccion, consulta;
            strNombre = textboxNombre.Text;
            strApellido = textboxApellido.Text;
            strFechaNacimiento = datePicker.Value.Year.ToString() + '/' + datePicker.Value.Month.ToString() + '/' + datePicker.Value.Day.ToString();
            strDireccion = textboxDireccion.Text;

            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QN49N6K\\DANIELDB;Initial Catalog=Taller;Integrated Security=true;");

            if (IDCliente.Equals(0))
            {
                consulta = string.Format("Insert into clientes (Nombre, Apellido, Fecha_Nacimiento, Direccion) values ('{0}','{1}','{2}','{3}')",
                strNombre, strApellido, strFechaNacimiento, strDireccion);
                MessageBox.Show("Cliente guardado exitosamente", "Registro Exitoso");
            }
            else
            {
                consulta = string.Format("Update clientes set Nombre = '{0}', Apellido =  '{1}' , Fecha_Nacimiento =  '{2}', Direccion = '{3}' where IDCliente =  '{4}'",
                    strNombre, strApellido, strFechaNacimiento, strDireccion, IDCliente);
            }

            SqlCommand comando = new SqlCommand(consulta, conectar);

            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
            actualizarForm(this);
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (IDCliente.Equals(0))
            {
                MessageBox.Show("Por favor seleccione un Cliente");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QN49N6K\\DANIELDB;Initial Catalog=Taller;Integrated Security=true;");

                    string consulta = string.Format("delete from clientes where IDCliente = '{0}' ", IDCliente);

                    SqlCommand comando = new SqlCommand(consulta, conectar);

                    conectar.Open();
                    comando.ExecuteNonQuery();
                    conectar.Close();

                    actualizarForm(this);
                    MessageBox.Show("Cliente eliminado", "Registro Exitoso");
                }
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            actualizarForm(this);
        }

        private void dgvBuscar_Click_1(object sender, EventArgs e)
        {
            IDCliente = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
            textboxNombre.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[1].Value);
            textboxApellido.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[2].Value);
            datePicker.Value = Convert.ToDateTime(dgvBuscar.CurrentRow.Cells[3].Value);
            textboxDireccion.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[4].Value);
            botonGuardar.Text = "Guardar";
        }


        private void actualizarForm(Control control)
        {
            //Establece el ID en 0 y el boton en Nuevo
            IDCliente = 0;
            botonGuardar.Text = "Nuevo";

            //Actualiza el GRID desde la DB
            List<Cliente> lista = new List<Cliente>();

            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QN49N6K\\DANIELDB;Initial Catalog=Taller;Integrated Security=true;");
            String consulta = "SELECT IdCliente, Nombre, Apellido, Fecha_Nacimiento, Direccion FROM clientes";
            SqlCommand comando = new SqlCommand(consulta, conectar);

            conectar.Open();
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = reader.GetInt32(0);
                pCliente.Nombre = reader.GetString(1);
                pCliente.Apellido = reader.GetString(2);
                pCliente.Fecha_Nac = reader.GetString(3);
                pCliente.Direccion = reader.GetString(4);

                lista.Add(pCliente);
            }
            conectar.Close();
            dgvBuscar.DataSource = lista;

            //Limpia los formularios
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is DateTimePicker)
                {
                    ((DateTimePicker)txt).Value = System.DateTime.Today;
                }
            }
        }

    }
}
