using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace M1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraSimples : ContentPage
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void ButtonCalculadoraSimples(object sender, EventArgs e)
        {

            Double a = 0, b = 0, t = 0;
            a = Convert.ToDouble(entry_calcularasimples_a.Text);
            b = Convert.ToDouble(entry_calcularasimples_b.Text);

            Button bt = (Button) sender; //cast conversão de tipo: converte o objeto sender em um objeto Button
            if(bt.Text == "+")
            {
                t = a + b;
            }
            if (bt.Text == "-")
            {
                t = a - b;
            }
            if (bt.Text == "/")
            {
                t = a / b;
            }
            if (bt.Text == "*")
            {
                t = a * b;
            }
            entry_calculadorasimples_resp.Text = t.ToString();
        }
    }
}