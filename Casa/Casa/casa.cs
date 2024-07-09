using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casa.Casa
{
    public class casa
    {
        private string Color;
        private string Servicios;
        private string Hipoteca;

        public string Color1 { get => Color; set => Color = value; }
        public string Servicios1 { get => Servicios; set => Servicios = value; }
        public string Hipoteca1 { get => Hipoteca; set => Hipoteca = value; }
        public void Pintar(string Color)
        {
            this.Color1 = Color;
            MessageBox.Show("el color de la casa cambio a "+Color);
        }
        public void Cortarservicio()
        {
            MessageBox.Show("los servicios fuero cortados....");
        }
        public void Vender()
        {
            MessageBox.Show("La casa fue vendida...");
        }
        public void Hipotecar(string hipo)
        {
            this.Hipoteca1 = hipo;
            MessageBox.Show("la casa fue hipotecada por "+hipo);
        }
        public void Deshipotecar(String hipo)
        {
            this.Hipoteca1 = hipo;
            DialogResult result= MessageBox.Show("Desea Pagar la hipoteca ","deshipotecar ",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                MessageBox.Show("La hipoteca fue pagada puede estar  tranquilo");
            }
            else
            {
                MessageBox.Show("la hipoteca de valor "+hipo+" no ha sido pagada, procure pagar lo antes posible");
            }
        }
    }
}
