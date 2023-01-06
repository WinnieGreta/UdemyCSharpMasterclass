using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace UdemyAssignment57_Zoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        object lastSelectedZoo;

        public MainWindow()
        {
            InitializeComponent();
            
            string connectionString = ConfigurationManager.ConnectionStrings["UdemyAssignment57_Zoo.Properties.Settings.GretaUdemyDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            ShowZoos();
            ShowAllAnimals();
        }

        private void ShowZoos()
        {
            try
            {
                string query = "SELECT * FROM Zoo";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using(sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);

                    listZoos.DisplayMemberPath = "Location";
                    listZoos.SelectedValuePath = "Id";
                    listZoos.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowAllAnimals()
        {
            try
            {
                string query = "SELECT * FROM Animal";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);

                    listAnimals.DisplayMemberPath = "Name";
                    listAnimals.SelectedValuePath = "Id";
                    listAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowAssociatedAnimal()
        {
            try
            {
                string query = "SELECT * FROM Animal a INNER JOIN ZooAnimal za ON a.Id = za.AnimalId WHERE za.ZooId = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using(sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", lastSelectedZoo);

                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);

                    listAssociatedAnimals.DisplayMemberPath = "Name";
                    listAssociatedAnimals.SelectedValuePath= "Id";
                    listAssociatedAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listZoos_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (listZoos.SelectedValue != null)
            {
                lastSelectedZoo = listZoos.SelectedValue;
            }
            //MessageBox.Show("You selected " + lastSelectedZoo);
            ShowAssociatedAnimal();
        }

        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            if (lastSelectedZoo != null)
            {
                try
                {
                    string query = "DELETE FROM Zoo WHERE Id = @ZooId";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    sqlCommand.Parameters.AddWithValue("@ZooId", lastSelectedZoo);
                    sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    ShowZoos();
                }
            }
            else
            {
                MessageBox.Show("No zoo selected!\nPlease select from list of available zoos!");
            }
        }

        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            if (myTextBox.Text != "")
            {
                try
                {
                    string query = "INSERT INTO Zoo VALUES (@Location)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.Parameters.AddWithValue("@Location", myTextBox.Text);
                    sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    ShowZoos();
                }
            }
            else
            {
                MessageBox.Show("Please enter location of the zoo you want to add in the textbox!");
            }
        }

        private void AddAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            if (lastSelectedZoo != null && listAnimals.SelectedValue != null)
            {
                try
                {
                    string query = "INSERT INTO ZooAnimal VALUES (@ZooId, @AnimalId)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.Parameters.AddWithValue("@ZooId", lastSelectedZoo);
                    sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                    sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    ShowZoos();
                    ShowAssociatedAnimal();
                }
            }
            else
            {
                MessageBox.Show("Please choose the zoo and the animal you want to add!");
            }
        }

        private void RemoveAnimal_Click(object sender, RoutedEventArgs e)
        {
            if (lastSelectedZoo != null && listAssociatedAnimals.SelectedValue != null)
            {
                try
                {
                    string query = "DELETE FROM ZooAnimal WHERE ZooId = @ZooId AND AnimalId = @AnimalId";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.Parameters.AddWithValue("@ZooId", lastSelectedZoo);
                    sqlCommand.Parameters.AddWithValue("@AnimalId", listAssociatedAnimals.SelectedValue);
                    sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    ShowZoos();
                    ShowAssociatedAnimal();
                }
            }
            else
            {
                MessageBox.Show("Please choose the zoo and the animal you want to remove!");
            }
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            if (myTextBox.Text != "")
            {
                try
                {
                    string query = "INSERT INTO Animal VALUES (@Name)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.Parameters.AddWithValue("@Name", myTextBox.Text);
                    sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    ShowAllAnimals();
                }
            }
            else
            {
                MessageBox.Show("Please enter name of the animal you want to add in the textbox!");
            }
        }

        private void DeleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            if (listAnimals.SelectedValue != null)
            {
                try
                {
                    string query = "DELETE FROM Animal WHERE Id = @AnimalId";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                    sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    ShowAllAnimals();
                    ShowAssociatedAnimal();
                }
            }
            else
            {
                MessageBox.Show("No animal selected!\nPlease select from list of all avaliable animals!");
            }
        }
    }
}
