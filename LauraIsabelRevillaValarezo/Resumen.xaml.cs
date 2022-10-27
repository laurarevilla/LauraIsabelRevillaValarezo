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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuarioLogueado, double valorTotal, string nombreEstudiante)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: " + usuarioLogueado;
            lblTotalPagar.Text = valorTotal.ToString();
            lblNombreEstudiante.Text = nombreEstudiante;
            

        }
    }
}