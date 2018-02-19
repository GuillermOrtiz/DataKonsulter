using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador1
{
    public partial class Navegador : UserControl
    {

        /*Create the events*/
        public event EventHandler addButton;
        public event EventHandler cancelButton;
        public event EventHandler helpButton;
        public event EventHandler searchButton;
        public event EventHandler saveButton;
        public event EventHandler printButton;
        public event EventHandler last1Button;
        public event EventHandler last2Button;
        public event EventHandler next1Button;
        public event EventHandler next2Button;


        public Navegador()
        {
            InitializeComponent();
        }



        // 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.addButton != null)
            {
                this.addButton(this, e);
            }

        }


    }
}
