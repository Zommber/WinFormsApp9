using System;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Calculate(); // inicializa los resultados al arrancar
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = string.Empty;
            txtNumber2.Text = string.Empty;
        }

        private void Calculate()
        {
            var culture = CultureInfo.CurrentCulture;
            bool ok1 = double.TryParse(txtNumber1.Text, System.Globalization.NumberStyles.Float | System.Globalization.NumberStyles.AllowThousands, culture, out double n1);
            bool ok2 = double.TryParse(txtNumber2.Text, System.Globalization.NumberStyles.Float | System.Globalization.NumberStyles.AllowThousands, culture, out double n2);

            // Si hay texto no numérico en alguna caja mostrar error
            if ((!ok1 && !string.IsNullOrWhiteSpace(txtNumber1.Text)) ||
                (!ok2 && !string.IsNullOrWhiteSpace(txtNumber2.Text)))
            {
                lblSumResult.Text = "Error";
                lblSubResult.Text = "Error";
                lblMulResult.Text = "Error";
                return;
            }

            if (!ok1) n1 = 0;
            if (!ok2) n2 = 0;

            lblSumResult.Text = (n1 + n2).ToString(culture);
            lblSubResult.Text = (n1 - n2).ToString(culture);
            lblMulResult.Text = (n1 * n2).ToString(culture);
        }
    }
}
