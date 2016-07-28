using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Strzelnica
{
    public partial class ScoresTableClass : Window
    {
        public ScoresTableClass(ref bool op)
        {
            op = true;
            InitializeComponent();
            this.ListView1.ItemsSource = MainWindow.listOfPeople;
            ListView1.Items.Refresh();
        }
        
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        
        private void ListView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView1.Items.Refresh();
        }

        public void Refresh()
        {
            this.ListView1.Items.Refresh();
        }


        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            List<Player> sortingList = new List<Player>();
            foreach(Player person in MainWindow.listOfPeople)
            {
                sortingList.Add(person);
            }

            if(Month.SelectedIndex > 0 && Month.SelectedIndex <=12)
            {
                sortingList.Sort(delegate (Player x, Player y)
                {
                    return x.MonthPercentage[Month.SelectedIndex - 1].CompareTo(y.MonthPercentage[Month.SelectedIndex - 1]);
                });
            }
            else
            {
               sortingList.Sort(); 
            }
            
            sortingList.Reverse();
            MainWindow.listOfPeople.Clear();
            foreach (Player person in sortingList)
            {
                MainWindow.listOfPeople.Add(person);
            }
            MainWindow.listOfPeople.Reverse();
            sortingList.Clear();
            Refresh();

        }

    }
}
