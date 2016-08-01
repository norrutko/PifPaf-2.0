using System.ComponentModel;
using System.Windows;


namespace Strzelnica
{
    public partial class AddPersonClass : Window
    {
        public AddPersonClass(ref bool op)
        {
            op = true;
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void AddPersonButton_Click(object sender, RoutedEventArgs e)
        {
            bool existed = false;
            foreach (Player person in MainWindow.listOfPeople)
            {
                if (NickTextBox.Text == person.Nick || NickTextBox.Text == "")
                {
                    existed = true;
                    break;
                }
            }
            if (!existed)
            {
                CreatePerson();
                ResetFields();
            }
            else
            {
                MessageBox.Show("Osoba o podanym nicku już istnieje. BĄDŹ KREATYWNY!!!");
            }
        }

        private void CreatePerson()
        {
            Player newPerson = new Player();
            newPerson.Nick = this.NickTextBox.Text;
            newPerson.Name = this.NameTextBox.Text;
            newPerson.Surname = this.SurnameTextBox.Text;
            MainWindow.listOfPeople.Add(newPerson);
        }

        private void DeletePersonButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Player person in MainWindow.listOfPeople)
            {
                if (this.NickTextBox.Text == person.Nick)
                {
                    MainWindow.listOfPeople.Remove(person);
                    ResetFields();
                    MessageBox.Show("Osoba o podanym nicku została usunięta.");
                    break;
                }
            }
        }

        private void ResetFields()
        {
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
        }
    }
}
