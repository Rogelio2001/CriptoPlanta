using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CriptoPlantas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Coleccion : ContentPage
    {
        public Coleccion()
        {
            InitializeComponent();
        }
        private void lsvGrupo_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Museos p = (Museos)e.Item;
            lbdescrip.Text = p.Descripcion;

            //((ListView) sender).SelectedItem = null;
        }

        /* Este evento se dispara cuando se ha seleccionado un NUEVO elemento
         * Si un elemento ya ha sido seleccionado, este evento ya no se dispara */
        private void lsvGrupo_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Museos p = (Museos)e.SelectedItem;

        }
    }
}