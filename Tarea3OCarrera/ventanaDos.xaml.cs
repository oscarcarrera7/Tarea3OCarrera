using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea3OCarrera
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ventanaDos : ContentPage
    {
        public ventanaDos( String user, String pass)
        {
            InitializeComponent();
            lblUser.Text = "Bienvenido: " + user;

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double dato1 = Convert.ToDouble(txtSeguimiento1.Text);
                double dato2 = Convert.ToDouble(txtExamen1.Text);
                double dato3 = Convert.ToDouble(txtSeguimiento2.Text);
                double dato4 = Convert.ToDouble(txtExamen2.Text);

                double suma = ((dato1 * 0.3) + (dato2 * 0.2));
                double suma2 = ((dato3 * 0.3) + (dato4 * 0.2));
                double suma3 = suma + suma2;

                txtParcial1.Text = suma.ToString();
                txtParcial2.Text = suma2.ToString();
                txtNota.Text = suma3.ToString();

                if (suma3 >= 7)
                {
                    DisplayAlert("Mensaje Final", "Aprobado", "Gracias");
                }
                else if (suma3 >= 5 && suma3 <= 6.9)
                {
                    DisplayAlert("Mensaje Final", "Complementrio", "Gracias");
                }
                else if (suma3 < 4.9)
                {
                    DisplayAlert("Mensaje Final", "Reprobado", "Gracias");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }

        }
    }
}