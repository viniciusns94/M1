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
    public partial class ParOuImpar : ContentPage //Pages são como Activitys em Android
    {
        public ParOuImpar()
        {
            InitializeComponent();
            button_parimpar_executar.Clicked += Button_parimpar_executar_Clicked;
        }

        private void Button_parimpar_executar_Clicked(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(entry_parimpar_valor.Text);
            String resp = "O número " + entry_parimpar_valor.Text + " é ";
            if (n % 2 == 0)
                resp += "Par";
            else
                resp += "Impar";

            label_parimpar_resposta.Text = resp;
        }
    }
}