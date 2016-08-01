using System;
using System.ComponentModel;
using System.Windows;


namespace Strzelnica
{

    public partial class AddScore : Window
    {
        public AddScore(ref bool op)
        {
            op = true;
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AddScoreButton_Click(object sender, RoutedEventArgs e)
        {
            bool existed = false;
            int tmp;
            int tmpM;

            foreach (Player person in MainWindow.listOfPeople)
            {
                if (NickTextBox.Text == person.Nick)
                {
                    existed = true;
                    tmpM = person.Month[Month.SelectedIndex];
                    tmp = person.TotalScore;
                    person.Month[Month.SelectedIndex] = PointsPerGame();
                    person.TotalScore = TotalScore(person);

                    if (tmp == MainWindow.BestScore &&
                        tmpM > PointsPerGame())
                    {
                        MainWindow.BestScore = 0;
                        FindNewLeader();
                    }
                    else
                    {
                        CheckLeader(person);
                    }


                    if (person.MonthPercentage[Month.SelectedIndex] == 100 &&
                        tmpM > person.Month[Month.SelectedIndex])
                    {
                        FindNewLeaderOfMonth(Month.SelectedIndex);
                    }
                    else
                    {
                        CheckLeaderOfMonth(person, Month.SelectedIndex);
                    }
                    

                    RecountMonth(Month.SelectedIndex);
                    Dethronement();
                    HuntedAnimals();
                    ResetFields();
                    break;
                }
            }
            if (!existed)
            {
                MessageBox.Show("Najpierw zarejstruj osobę, a później przyznawaj jej punkty.");
            }
        }

        private void ResetFields()
        {
            NickTextBox.Text = "";
            ChickenPointsBox.SelectedIndex = 0;
            BoarPointsBox.SelectedIndex = 0;
            TurkeyPointsBox.SelectedIndex = 0;
            MouflonPointsBox.SelectedIndex = 0;
        }

        private void HuntedAnimals()
        {
            MainWindow.statistics[0].Hunt(this.ChickenPointsBox.SelectedIndex);
            MainWindow.statistics[1].Hunt(this.BoarPointsBox.SelectedIndex);
            MainWindow.statistics[2].Hunt(this.TurkeyPointsBox.SelectedIndex);
            MainWindow.statistics[3].Hunt(this.MouflonPointsBox.SelectedIndex);
        }

        private int PointsPerGame()
        {
            int points;
            points = ChickenPointsBox.SelectedIndex + BoarPointsBox.SelectedIndex +
                    TurkeyPointsBox.SelectedIndex + MouflonPointsBox.SelectedIndex;
            return points;
        }

        private int TotalScore(Player person)
        {
            int tmp = 0;
            foreach (int month in person.Month)
            {
                tmp = tmp + month;
            }
            return tmp;
        }

        private void Dethronement()
        {
            foreach (Player person in MainWindow.listOfPeople)
            {
                try
                {
                    person.TotalScorePercentage = person.TotalScore * 100 / MainWindow.BestScore;
                }
                catch (DivideByZeroException)
                {
                    person.TotalScorePercentage = person.TotalScore * 100 / 1;
                }
            }
        }

        private void RecountMonth(int month)
        {
            foreach( Player person in MainWindow.listOfPeople)
            {
                try
                {
                    person.MonthPercentage[month] = person.Month[month] * 100 / MainWindow.BestMonths[month];
                }
                catch (DivideByZeroException)
                {
                    person.MonthPercentage[month] = person.Month[month] * 100 / 1;
                }
            }
        }

        private void CheckLeaderOfMonth(Player person, int month)
        {
            if (person.Month[month] > MainWindow.BestMonths[month])
            {
                MainWindow.BestMonths[month] = person.Month[month];
                RecountMonth(month);
            }
        }

        private void FindNewLeaderOfMonth(int month)
        {
            MainWindow.BestMonths[month] = 0;
            foreach(Player person in MainWindow.listOfPeople)
            {
                if(person.Month[month] > MainWindow.BestMonths[month])
                {
                    MainWindow.BestMonths[month] = person.Month[month];
                }
            }
        }

        private void CheckLeader(Player leader)
        {
            if (TotalScore(leader) > MainWindow.BestScore)
            {
                MainWindow.BestScore = TotalScore(leader);
                Dethronement();
            }
        }

        private void FindNewLeader()
        {
            MainWindow.BestScore = 0;
            foreach (var score in MainWindow.listOfPeople)
            {
                if (score.TotalScore > MainWindow.BestScore)
                {
                    MainWindow.BestScore = score.TotalScore;
                }
            }
        }
    }
}
