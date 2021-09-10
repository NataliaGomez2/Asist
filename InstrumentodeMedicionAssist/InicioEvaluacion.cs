using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstrumentodeMedicionAssist
{
    public partial class InicioEvaluacion : Form
    {
        public InicioEvaluacion()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            double n1 = double.Parse(cmb1.Text);
            double n2 = double.Parse(cmb2.Text);
            double n3 = double.Parse(cmb3.Text);
            double n4 = double.Parse(cmb4.Text);
            double n5 = double.Parse(cmb5.Text);
            double n6 = double.Parse(cmb6.Text);
            double n7 = double.Parse(cmb7.Text);
            double n8 = double.Parse(cmb8.Text);
            double n9 = double.Parse(cmb9.Text);
            double n10= double.Parse(cmb10.Text);
            double Suma = 0;
            
                Suma = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10 ;
            
            MessageBox.Show("El resultado es");


        }
    }
}
