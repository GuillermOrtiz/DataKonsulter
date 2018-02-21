using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllconexion;
using AdministradorDeReportes;


namespace PruebaReporteador
{
    public partial class Form1 : Form
    {
        private static int rVista = 1;
        private static int numeroAplicacion = 3000;

        public Form1()
        {
            InitializeComponent();            
            navegador1.IdApp = 1;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void vistaPreviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navegador1.VistaReporte = 1;
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navegador1.VistaReporte = 0;
        }

        private void mantenimientoDeReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministradorDeReportes.Objetos.dbConexion.dbName = "bd_seguridad";
            AdministradorDeReportes.Objetos.dbConexion.dbServer = "localhost";
            AdministradorDeReportes.Objetos.dbConexion.dbUser = "root";
            AdministradorDeReportes.Objetos.dbConexion.dbPass = "";
            Mantenimiento rMante = new Mantenimiento();
            rMante.Show();
        }

        private void listadoReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                dllconexion.gReport.establecerParametrosDB("localhost", "root", "bd_seguridad", "");
                dllconexion.seleccionPath rLista = new dllconexion.seleccionPath(navegador1.IdApp, 0);
                rLista.Show();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Error Reportes."); }            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
