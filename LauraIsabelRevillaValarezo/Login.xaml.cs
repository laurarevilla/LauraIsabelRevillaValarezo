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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(entUsuario.Text) )
            {
                if (!String.IsNullOrEmpty(entContrasena.Text))
                {
                    string usuario = "LauraRevilla2022";
                    string contraseña = "uisrael2022";
                    if (usuario == entUsuario.Text)
                    {
                        if (contraseña == entContrasena.Text)
                        {
                            DisplayAlert("Notificación", "Acceso correcto.", "Cerrar");
                            Navigation.PushAsync(new Registro(entUsuario.Text));
                        }
                        else
                        {
                            DisplayAlert("Notificación", "Dato incorrecto [Contraseña]", "Cerrar");
                        }
                    }
                    else
                    {
                        DisplayAlert("Notificación", "Dato Incorrecto [Usuario]", "Cerrar");
                    }
                }
                else
                {
                    DisplayAlert("Notificación", "Debe ingresar la contraseña.", "Cerrar");
                }
            }
            else
            {
                DisplayAlert("Notificación", "Debe ingresar el usuario", "Cerrar");
            }
        }
    }
}