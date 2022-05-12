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
                new Plantas {Nombre="Poto", Foto="",Descripcion="" },
                new Plantas { Nombre = "", Foto = "", Descripcion = ""}
            };
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