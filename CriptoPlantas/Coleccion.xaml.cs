using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CriptoPlantas.DataModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CriptoPlantas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Coleccion : ContentPage
    {
        ObservableCollection<Plantas> grupo;
        public Coleccion()
        {
            
            InitializeComponent();
            grupo = new ObservableCollection<Plantas>
            {
                new Plantas {Nombre="POTO", Foto="plantax",Descripcion="Estadisticas" +
                "\n -Producción: 30 kw/h" +
                "\n -Beneficio: 40 B/h" +
                "\n Riego:\t Cada 10 días en invierno y cada 5 días en verano" },

                new Plantas { Nombre = "CINTAS", Foto = "",Descripcion="Estadisticas" +
                "\n -Producción: 10 kw/h" +
                "\n -Beneficio: 4.5 B/h" +
                "\n Riego:\t Debe ser más frecuente en verano, de dos a tres veces por semana, y reducirse a una vez por semana en invierno"},

                new Plantas { Nombre = "LIRIO DE LA PAZ", Foto = "",Descripcion="Estadisticas" +
                "\n -Producción: 12.63 kw/h" +
                "\n -Beneficio: 4 B/h" +
                "\n Riego:\t Regularmente, en invierno una o dos veces por semana, en verano incluso 3-4 veces por semana" },

                new Plantas { Nombre = "LENGUA DE SUEGRA", Foto = "",Descripcion="Estadisticas" +
                "\n -Producción: 5.2 kw/h" +
                "\n -Beneficio: 62.5 B/h" +
                "\n Riego:\t solamente una o dos veces al mes, siempre cuidando que el sustrato quede seco," +
                " ya que el exceso de agua puede provocar la pudrición del tallo" },

                new Plantas { Nombre = "ARBOL DE JADE", Foto = "",Descripcion="Estadisticas" +
                "\n -Producción: 16.8 kw/h" +
                "\n -Beneficio: 16.2 B/h" +
                "\n Riego:\t Hay que regarla cada 15 días, ¡y evitando mojar las hojas! " },

                new Plantas { Nombre = "ANTURIO ROJO", Foto = "",Descripcion="Estadisticas" +
                "\n -Producción: 5.6 kw/h" +
                "\n -Beneficio: 0.26 B/h" +
                "\n Riego:\t La pauta ideal es de un riego a la semana durante el invierno. " +
                "Una cantidad que se incrementará en los meses de calor, en los que regaremos entre dos y tres veces a la semana" },

                new Plantas { Nombre = "FICUS", Foto = "",Descripcion="Estadisticas" +
                "\n -Producción: 6.95 kw/h" +
                "\n -Beneficio: 12.9 B/h" +
                "\n Riego:\t En verano, una vez por semana, y en invierno, cada 15 días, teniendo cuidado de no encharcar las raíces" },

                new Plantas { Nombre = "COSTILLA DE ADÁN", Foto = "",Descripcion="Estadisticas" +
                "\n -Producción: 52 kw/h" +
                "\n -Beneficio: 10.5 B/h" +
                "\n Riego:\t Serían unas 2 veces a la semana en verano y 1 vez a la semana en invierno" },

                new Plantas { Nombre = "ALOE VERA", Foto = "",Descripcion="Estadisticas" +
                "\n -Producción: 32.6 kw/h" +
                "\n -Beneficio: 40.865 B/h" +
                "\n Riego:\t Solamente es necesario que el sustrato esté ligeramente húmedo," +
                " mientras que en los meses de invierno se puede reducir el riego a una vez al mes." },

                new Plantas { Nombre = "CACTUS DE NAVIDAD", Foto = "",Descripcion="Estadisticas" +
                "\n -Producción: 43.25 kw/h" +
                "\n -Beneficio: 21.25 B/h" +
                "\n Riego:\t Necesita una media de dos riegos semanales, si es posible con agua no calcárea" }
            };
            lvgrupo.ItemsSource = grupo;
        }
        private void lsvGrupo_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Plantas p = (Plantas)e.Item;
            lbdescrip.Text = p.Descripcion;

            //((ListView) sender).SelectedItem = null;
        }

        /* Este evento se dispara cuando se ha seleccionado un NUEVO elemento
         * Si un elemento ya ha sido seleccionado, este evento ya no se dispara */
        private void lsvGrupo_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Plantas p = (Plantas)e.SelectedItem;

        }

        private void btnB_Clicked(object sender, EventArgs e)
        {

        }

        private void btnC_Clicked(object sender, EventArgs e)
        {

        }
    }
}