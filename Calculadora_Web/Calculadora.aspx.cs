using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora_Web
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rsuma.Checked = true;
            csuma.Checked = true;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Metodo_RadioButton();
            Metodo_ListaDesplegable();
            Metodo_Checkbox();



        }

        public void Metodo_Checkbox()
        {
            float num1 = 0, num2 = 0, total = 0;

            num1 = float.Parse(tvalor1.Text);
            num2 = float.Parse(tvalor2.Text);

            string valor = "";

            if (csuma.Checked)
            {
                total = num1 + num2;
                valor = "Suma = " + total.ToString() + valor;

            }

            if (cresta.Checked)
            {
                total = num1 - num2;
                valor = "Resta = " + total.ToString() + valor;
            }

            if (cmultiplicacion.Checked)
            {
                total = num1 * num2;
                valor = "Multiplicacion = " + total.ToString() + valor;
            }

            if (cdivision.Checked)
            {
                total = num1 / num2;
                valor = "Division = " + total.ToString() + valor;
            }

            lresultado.Text = valor;
        }

        public void Metodo_ListaDesplegable()
        {
            float num1 = 0, num2 = 0, total = 0;

            num1 = float.Parse(tvalor1.Text);
            num2 = float.Parse(tvalor2.Text);

            if (DLista.SelectedIndex == 0)
            {
                total = num1 + num2;
            }
            else if (DLista.SelectedIndex == 1)
            {
                total = num1 - num2;

            }
            else if (DLista.SelectedIndex == 2)
            {
                total = num1 * num2;
            }
            else if (DLista.SelectedIndex == 3)
            {
                total = num1 / num2;
            }

            lresultado.Text = total.ToString();
        }

        public void Metodo_RadioButton()
        {
            float num1 = 0, num2 = 0, total = 0;

            num1 = float.Parse(tvalor1.Text);
            num2 = float.Parse(tvalor2.Text);

            if (rsuma.Checked)
            {
                total = num1 + num2;

            }
            else if (rresta.Checked)
            {
                total = num1 - num2;
            }
            else if (rmultiplicar.Checked)
            {
                total = num1 * num2;
            }
            else if (rdivision.Checked)
            {
                total = num1 / num2;
            }
            lresultado.Text += total.ToString();
        }
    }
}