using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Tutorial_12_ZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection mySqlConnection;

        public MainWindow()
        {

            InitializeComponent();

            //Verbindung zu der Datenbank "KaessDB" vorbereiten
            string connectionString = ConfigurationManager.ConnectionStrings["Tutorial_12_ZooManager.Properties.Settings.KaessDBConnectionString"].ConnectionString;
            //Auf Verbindung zur Datenbank "KaessDB" zugreifen
            mySqlConnection = new SqlConnection(connectionString);

            ShowZoos();
            ShowAnimals();
        }

        public void ShowZoos()
        {
            try
            {
                string quere = "select * from Zoo";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(quere, mySqlConnection);

                using (mySqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();
                    //Fülle zooTable mit Ergbnis aus mySqlDataAdapter (Ergbnis der quere = "select * from Zoo")
                    mySqlDataAdapter.Fill(zooTable);

                    //Welche Information der Tabelle in unserem DataTable "zooTable" soll in unsere Listbox angezeigt werden
                    lbxZooListe.DisplayMemberPath = "Location";
                    //Welcher Wert soll gegeben werden, wenn eines unserer Items von der Listbox ausgewählt wird
                    lbxZooListe.SelectedValuePath = "Id";
                    //Gibt die Ergbnistabelle (Inhalt von zooTable) in unserer Listbox "lbxZooListe" zurück
                    //Defaultview ist Quelle für Inhalt von "lbxZooListe"
                    lbxZooListe.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ShowAssociatedAnimals()
        {
            if (lbxZooListe.SelectedValue != null)
            {
                try
                {
                    //@ZooId ist eine Variable
                    string quere = "select * from Animal a inner join ZooAnimal za on a.Id = za.AnimalId where za.ZooId = @ZooId";
                    //Wichtig um weitere Parameter hinzuzufügen
                    SqlCommand mySqlCommand = new SqlCommand(quere, mySqlConnection);
                    SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(mySqlCommand);

                    using (mySqlDataAdapter)
                    {
                        mySqlCommand.Parameters.AddWithValue("@ZooId", lbxZooListe.SelectedValue);

                        DataTable AnimalTable = new DataTable();
                        //Fülle AnimalTable mit Ergbnis aus mySqlDataAdapter (Ergbnis der quere)
                        mySqlDataAdapter.Fill(AnimalTable);

                        //Welche Information der Tabelle in unserem DataTable "AnimalTable" soll in unsere Listbox angezeigt werden
                        lbxAssociatedAnimals.DisplayMemberPath = "AnimalName";
                        //Welcher Wert soll gegeben werden, wenn eines unserer Items von der Listbox ausgewählt wird
                        lbxAssociatedAnimals.SelectedValuePath = "Id";
                        //Gibt die Ergbnistabelle (Inhalt von AnimalTable) in unserer Listbox "lbxAssociatedAnimals" zurück
                        //Defaultview ist Quelle für Inhalt von "lbxAssociatedAnimals"
                        lbxAssociatedAnimals.ItemsSource = AnimalTable.DefaultView;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void lbxZooListe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
            ShowSelectedZooInTextBox(); 
        }

        public void ShowAnimals()
        {
            try
            {
                string quere = "select * from Animal";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(quere, mySqlConnection);

                using (mySqlDataAdapter)
                {
                    DataTable animalTable = new DataTable();
                    //Fülle animalTable mit Ergbnis aus mySqlDataAdapter (Ergbnis der quere = "select * from Animal")
                    mySqlDataAdapter.Fill(animalTable);

                    //Welche Information der Tabelle in unserem DataTable "animalTable" soll in unsere Listbox angezeigt werden
                    lbxAnimalListe.DisplayMemberPath = "AnimalName";
                    //Welcher Wert soll gegeben werden, wenn eines unserer Items von der Listbox ausgewählt wird
                    lbxAnimalListe.SelectedValuePath = "Id";
                    //Gibt die Ergbnistabelle (Inhalt von animalTable) in unserer Listbox "lbxAnimalListe" zurück
                    //Defaultview ist Quelle für Inhalt von "lbxAnimalListe"
                    lbxAnimalListe.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btZooDelete_Click(object sender, RoutedEventArgs e)
        {
             try
             {
                //quere zum löschen eines Zoos
                 string quere = "delete from Zoo where Id = @ZooId";
                 SqlCommand mySqlCommand = new SqlCommand(quere, mySqlConnection);
                 //Verbindung zur Datenbank  KaessDB öffnen
                 mySqlConnection.Open();
                 //setzen der Variable @ZooId = lbxZooListe.SelectedValue (ausgewählter Zoo)
                 mySqlCommand.Parameters.AddWithValue("@ZooId", lbxZooListe.SelectedValue);
                //Befehl zum Ausführen
                 mySqlCommand.ExecuteScalar();

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
             finally
             {
                 //Verbindung zur Datenbank KaessDB schließen
                 mySqlConnection.Close();
                 //Aktualisierung der Zooliste mittels Aufruf der ShowZoos() Methode
                 ShowZoos();
             }
        }

        private void btAnimalRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btZooAdd_Click(object sender, RoutedEventArgs e)
        {
            if (tbAddZooOrAnimal.Text != "")
            {
                try
                {
                    string quere = "insert into Zoo values (@Location)";
                    SqlCommand mySqlCommand = new SqlCommand(quere, mySqlConnection);
                    //Verbindung zur Datenbank  KaessDB öffnen
                    mySqlConnection.Open();
                    mySqlCommand.Parameters.AddWithValue("@Location", tbAddZooOrAnimal.Text);
                    //Befehl zum Ausführen
                    mySqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim hinzufügen: {0}", ex.ToString());
                }
                finally
                {
                    //Verbindung zur Datenbank KaessDB schließen
                    mySqlConnection.Close();
                    //Aktualisierung der Zooliste mittels Aufruf der ShowZoos() Methode
                    ShowZoos();
                }
            }   
        }

        private void btZooUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (lbxZooListe.SelectedValue != null)
            {
                try
                {
                    string quere = "update Zoo Set Location = @Location where Id = @ZooId";
                    SqlCommand mySqlCommand = new SqlCommand(quere, mySqlConnection);
                    //Verbindung zur Datenbank  KaessDB öffnen
                    mySqlConnection.Open();
                    mySqlCommand.Parameters.AddWithValue("@ZooID", lbxZooListe.SelectedValue);
                    mySqlCommand.Parameters.AddWithValue("@Location", tbAddZooOrAnimal.Text);
                    //Befehl zum Ausführen
                    mySqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim aktualisieren eines Zoo: {0}", ex.ToString());
                }
                finally
                {
                    //Verbindung zur Datenbank KaessDB schließen
                    mySqlConnection.Close();
                    //Aktualisierung der Liste Zoos mittels Aufruf der ShowZoos() Methode
                    ShowZoos();
                }
            } 
        }

        private void btAnimalAdd_Click(object sender, RoutedEventArgs e)
        {
            if (tbAddZooOrAnimal.Text != "")
            {
                try
                {
                    string quere = "insert into Animal values (@AnimalName)";
                    SqlCommand mySqlCommand = new SqlCommand(quere, mySqlConnection);
                    //Verbindung zur Datenbank  KaessDB öffnen
                    mySqlConnection.Open();
                    mySqlCommand.Parameters.AddWithValue("@AnimalName", tbAddZooOrAnimal.Text);
                    //Befehl zum Ausführen
                    mySqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim hinzufügen: {0}", ex.ToString());
                }
                finally
                {
                    //Verbindung zur Datenbank KaessDB schließen
                    mySqlConnection.Close();
                    //Aktualisierung der Tierliste mittels Aufruf der ShowAnimals() Methode
                    ShowAnimals();
                }
            }
        }

        private void btAnimalUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (lbxAnimalListe.SelectedValue != null)
            {
                try
                {
                    string quere = "update Animal Set AnimalName = @AnimalName where Id = @AnimalId";
                    SqlCommand mySqlCommand = new SqlCommand(quere, mySqlConnection);
                    //Verbindung zur Datenbank  KaessDB öffnen
                    mySqlConnection.Open();
                    mySqlCommand.Parameters.AddWithValue("@AnimalId", lbxAnimalListe.SelectedValue);
                    mySqlCommand.Parameters.AddWithValue("@AnimalName", tbAddZooOrAnimal.Text);
                    //Befehl zum Ausführen
                    mySqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim aktualisieren eines Tieres: {0}", ex.ToString());
                }
                finally
                {
                    //Verbindung zur Datenbank KaessDB schließen
                    mySqlConnection.Close();
                    //Aktualisierung der Liste Tiere mittels Aufruf der ShowAnimals() Methode
                    ShowAnimals();
                }
            }
        }

        private void btAnimalToZeeAdd_Click(object sender, RoutedEventArgs e)
        {
            if (lbxZooListe.SelectedValue != null && lbxAnimalListe.SelectedValue != null)
            {
                try
                {
                    string quere = "insert into ZooAnimal values (@ZooId, @AnimalId)";
                    SqlCommand mySqlCommand = new SqlCommand(quere, mySqlConnection);
                    //Verbindung zur Datenbank  KaessDB öffnen
                    mySqlConnection.Open();
                    mySqlCommand.Parameters.AddWithValue("@ZooID", lbxZooListe.SelectedValue);
                    mySqlCommand.Parameters.AddWithValue("@AnimalId", lbxAnimalListe.SelectedValue);
                    //Befehl zum Ausführen
                    mySqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim hinzufügen eines Tieres zu einem Zoo: {0}", ex.ToString());
                }
                finally
                {
                    //Verbindung zur Datenbank KaessDB schließen
                    mySqlConnection.Close();
                    //Aktualisierung der Liste "Tiere in ausgewähltem Zoo" mittels Aufruf der ShowAssociatedAnimals() Methode
                    ShowAssociatedAnimals();
                }
            }
        }

        private void btAnimalDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //quere zum löschen eines Tiers
                string quere = "delete from Animal where Id = @AnimalId";
                SqlCommand mySqlCommand = new SqlCommand(quere,mySqlConnection);
                //Verbindung zur Datenbank KaessDB öffnen
                mySqlConnection.Open();
                //setzen der Variable @AnimalId = lbxAnimalListe.SelectedValue (ausgewählter Zoo)
                mySqlCommand.Parameters.AddWithValue("@AnimalId", lbxAnimalListe.SelectedValue);
                //Befehl zum Ausführen
                mySqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Löschen: {0}", ex.ToString());
            }
            finally
            {
                //Verbindung zur Datenbank KaessDB schließen
                mySqlConnection.Close();
                //Aktualisierung der Tierliste mittels Aufruf der ShowAnimals() Methode
                ShowAnimals();
                ShowAssociatedAnimals();
            }
        }

        private void ShowSelectedZooInTextBox()
        {
            try
            {
                string quere = "select Location from Zoo where Id = @ZooId";
                SqlCommand mySqlCommand = new SqlCommand(quere, mySqlConnection);
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(mySqlCommand);

                using (mySqlDataAdapter)
                {
                    mySqlCommand.Parameters.AddWithValue("@ZooId", lbxZooListe.SelectedValue);

                    DataTable ZooDataTable = new DataTable();
                    //Fülle ZooDataTable mit Ergbnis aus mySqlDataAdapter (Ergbnis der quere)
                    mySqlDataAdapter.Fill(ZooDataTable);

                    tbAddZooOrAnimal.Text = ZooDataTable.Rows[0]["Location"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei ShowSelectedZooInTextBox: {0}", ex.ToString());
            }
        }

        private void ShowSelectedAnimalInTextBox()
        {
            try
            {
                string quere = "select AnimalName from Animal where Id = @AnimalId";
                SqlCommand mySqlCommand = new SqlCommand(quere, mySqlConnection);
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(mySqlCommand);

                using (mySqlDataAdapter)
                {
                    mySqlCommand.Parameters.AddWithValue("@AnimalId", lbxAnimalListe.SelectedValue);

                    DataTable AnimalDataTable = new DataTable();
                    //Fülle AnimalDataTable mit Ergbnis aus mySqlDataAdapter (Ergbnis der quere)
                    mySqlDataAdapter.Fill(AnimalDataTable);

                    tbAddZooOrAnimal.Text = AnimalDataTable.Rows[0]["AnimalName"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei ShowSelectedAnimalInTextBox: {0}", ex.ToString());
            }
        }

        private void lbxAnimalListe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedAnimalInTextBox();
        }
    }
}
