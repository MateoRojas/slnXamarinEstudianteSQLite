using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EjercicioClase
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnIngreso_Clicked(object sender, EventArgs e)
        {
            var medicina = new Medicina()
            {
                Marca = entMarca.Text,
                Nombre = entNombre.Text
            };

            using (var datos = new Database())
            {
                datos.IngresarMedicina(medicina);
                lsvEstudiantes.ItemsSource = datos.ConsultarEstudiante();
            }
        }
    }
}
