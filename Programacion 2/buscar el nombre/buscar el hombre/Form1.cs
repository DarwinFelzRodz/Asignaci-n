using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace buscar_el_nombre
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {





            {
                var listado = new[]
                {
                    new {Nombre= "Jose", Apellido="Manuel" },
                    new {Nombre= "Mario", Apellido="Castaneda" },
                    new {Nombre= "Marcos", Apellido="Valencia" },
                    new {Nombre= "Ringo", Apellido="Martines"},
                    new {Nombre= "Yocelin", Apellido="Santana" },
                    new {Nombre= "Maria", Apellido="Matos"},
                    new {Nombre= "Santos", Apellido="Escobar", },
                    new {Nombre= "Pedro", Apellido="Valdez"},


                };

                XElement personas = new XElement("personas", // Este es la raiz
                    from a in listado
                    select new XElement("persona", new XAttribute("Nombre", a.Nombre),
                    new XElement("Apellido", a.Apellido)

                     )
                     );

                //TxtNombre.Text = personas.ToString();
                //txtApellido.Text = personas.ToString();
               
                string[] Listado = { "Listado" };
                
                IEnumerable<string> encontrados = from l in Listado
                                                  where l.Contains(TxtNombre.Text)
                                                  orderby l
                                                  select l;

                //mostramos los resultados
                foreach (string Nombre in encontrados)
                    DTG.Text = Nombre;
                //DTG = personas.ToString()


                //int e = DTG.Rows.Add();
                DTG.Rows[0].Cells[0].Value = new List<XElement>();
                //    Console.WriteLine(Nombre);
                //Console.WriteLine("_______");



                //Console.WriteLine(personas);
                personas.Save("Peronas.xml");










            }


        }
    }
}
