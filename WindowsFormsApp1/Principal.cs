using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {            
            procesar();
        }
        public void procesar()
        {

            string fileName = "jurisdicciones.txt";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, fileName);
            int nroFactura = (int)nudPrimerFactura.Value;
            int vuelta = 0;
            string consulta;

            string[] lines = File.ReadAllLines(filePath);

            Service service = new Service();

            try
            {
                foreach (string line in lines)
                {
                    if (vuelta == 0)
                    {
                        consulta = "update IVAVentas set pciaid = '" + line + "' Where empresaid = 'RJ488_68E0JFEHD' AND nrocomprob = " + nroFactura;
                        service.ejecutar(consulta);
                        vuelta = 1;
                        nroFactura++;                   
                    }
                    else
                    {
                        consulta = "update IVAVentas set pciaid = '" + line + "' Where empresaid = 'RJ488_68E0JFEHD' AND nrocomprob = " + nroFactura;
                        service.ejecutar(consulta);
                        nroFactura++;
                    }
                }
                MessageBox.Show("Modificado exitosamente");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
