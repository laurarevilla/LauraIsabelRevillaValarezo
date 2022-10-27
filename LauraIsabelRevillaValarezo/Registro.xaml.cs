using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LauraIsabelRevillaValarezo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string Usuario;
        public Registro(string usuarioLogueado)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado:" + usuarioLogueado;
            Usuario = usuarioLogueado;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double costoCurso = 3000;
            double costoExtra = costoCurso * 0.05;

            if (!String.IsNullOrEmpty(entMontoInicial.Text))
            {
                double montoInicial = Convert.ToInt32(entMontoInicial.Text);
                double valorCuota = (((costoCurso - Convert.ToDouble(montoInicial)) / 5) + costoExtra);
                entPagoMensual.Text = valorCuota.ToString();
                DisplayAlert("Notificación", "Cuota Calculada es:" + valorCuota, "Cerrar");
            }
        }

        private void entPagoMensual_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(entMontoInicial.Text))
            {
                double montoInicial = Convert.ToDouble(entMontoInicial.Text);

                if (montoInicial < 0 || montoInicial > 3000)
                {
                    DisplayAlert("Notificación", "Ingrese un valor mayor a 0 y menor a 3000", "Cerrar");
                    entMontoInicial.Text = "";
                    entPagoMensual.Text = "";
                }
            }
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            double total, valorCuotas;
            if (!string.IsNullOrEmpty(entPagoMensual.Text))
            {
                if (!string.IsNullOrEmpty(entNombreEstudiante.Text))
                {
                    valorCuotas = (Convert.ToDouble(entPagoMensual.Text) * 5);
                    total = valorCuotas + Convert.ToDouble(entMontoInicial.Text);
                    Navigation.PushAsync(new Resumen(Usuario, total, entNombreEstudiante.Text));

                    DisplayAlert("Notificación", "Elemento guardado con éxito", "Cerrar");
                }
                else
                {
                    DisplayAlert("Notificación", "El nombre del estudiante es obligatorio", "Cerrar");
                    entNombreEstudiante.Focus();
                }
            }
            else
            {
                DisplayAlert("Notificación", "El pago mensual se debe calcular antes de guardar", "Cerrar");
                entPagoMensual.Focus();
            }
        }
    }
}