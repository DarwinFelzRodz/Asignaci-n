using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace programa_final
{
    public partial class Form1 : Form
    {

        
    
        private readonly DataTable _tablaUsuarios = new DataTable();

        public Form1()
        {
            InitializeComponent();
            InicializarTablaUsuarios();
        }

        private void InicializarTablaUsuarios()



        {
            _tablaUsuarios.Columns.Add("Nombre");
            _tablaUsuarios.Columns.Add("Apellido");

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string valorBusqueda = txtNombre.Text;
            _tablaUsuarios.Clear();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_rutaArchivoXml);
            XmlNodeList usuarios = xmlDoc.GetElementsByTagName("Empleados");

            foreach (XmlNode usuario in usuarios)
            {
                string nombre = usuario.Attributes["nombre"].Value.Normalize(NormalizationForm.FormD).ToLower().Replace(" ", "");
                string apellido = usuario.Attributes["apellido"].Value.Normalize(NormalizationForm.FormD).ToLower().Replace(" ", "");


                if (nombre.Contains(valorBusqueda) || apellido.Contains(valorBusqueda))
                {
                    _tablaUsuarios.Rows.Add(nombre, apellido);
                }
            }
            DTG.DataSource = _tablaUsuarios;

            if (_tablaUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Sin resultados");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
