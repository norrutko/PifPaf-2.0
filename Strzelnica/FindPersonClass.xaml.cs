using System.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace Strzelnica
{
    public partial class FindPersonClass : Window
    {
        private  ObservableCollection<Player> selectedPerson;


        public FindPersonClass(ref bool op)
        {
            op = true;
            selectedPerson = new ObservableCollection<Player>();
            InitializeComponent();
            this.ListViewPerson.ItemsSource = selectedPerson;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void FindPersonButton_Click(object sender, RoutedEventArgs e)
        {
                bool existed = false;
                foreach (Player person in MainWindow.listOfPeople)
                {
                    if (NickTextBox.Text == person.Nick)
                    {
                        selectedPerson.Clear();
                        existed = true;
                        selectedPerson.Add(person);
                        break;
                    }
                if (!existed)
                {
                    MessageBox.Show("Nie znaleziono osoby o podanym nicku.");
                }
            }
        }
    }
}
