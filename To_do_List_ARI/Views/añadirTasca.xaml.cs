using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace To_do_List_ARI

{
    /// <summary>
    /// Lógica de interacción para añadirTasca.xaml
    /// </summary>
    public partial class añadirTasca : Window
    {
        public añadirTasca()
        {
            InitializeComponent();
        }
        //quan l'usuari clica sobre el button afegir
        private void btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            //afageix un nou item al listview
            lvTasca.Items.Add(new Tasca()
            {
                Name = txt_nomTasca.Text,
                Responsable = txt_responsable.Text,
                Descripcio = txt_descripcio.Text,
                Prioritat = txt_prioritat.Text,
                ata_Inici = txt_data_inici.Text,
                Data_final = txt_data_final.Text
            });
            //buida els camps
            /*txt_nomTasca.Text = "";
            txt_responsable.Text = "";
            txt_descripcio.Text = "";
            txt_prioritat.Text = "";
            txt_data_final.Text = "";
            txt_data_inici.Text = "";*/
        }

        private void btn_modificar_Click(object sender, RoutedEventArgs e)
        {

        }

        // quan l'usuari clica sobre el button eliminar
        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            try //faig un trycatch per asegurarme que l'usuari ha seleccionat un item previament
            {
                //elimina el item seleccionat
                lvTasca.Items.RemoveAt(lvTasca.SelectedIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("Has de seleccionar una tasca", "Informacio", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public class Tasca
        {
            public string Name { get; set; } //accesors
            public string Responsable { get; set; }
            public string Descripcio { get; set; }
            public string Data_final { get; set; }
            public string Prioritat { get; set; }
            public string ata_Inici { get; set; } //si poso data_inici em dona errors per iaxo he possat ata inici
        }

        private void btn_netejar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

