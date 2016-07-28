using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows;


namespace Strzelnica
{
    public partial class MainWindow : Window
    {
        public static ObservableCollection<Player> listOfPeople { get; set; }
        private ScoresTableClass scoresTable;
        private AddPersonClass addPerson;
        private AddScore addScore;
        private FindPersonClass findPerson;
        public static Animal[] statistics = new Animal[4];
        private string animalsStatistics = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\StatystykiPolowan.txt";
        private string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PistoletZawody.txt";
        bool[] _opened = { false, false, false, false };
        public static int BestScore { get; set; } = 0;
        public static int[] BestMonths { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        enum WindowNames { Scores = 0, AddScore = 1, AddPerson = 2, FindPerson = 3 };


        public MainWindow()
        {
            listOfPeople = new ObservableCollection<Player>();
            ReadFile(mydocpath);
            loadAnimals(animalsStatistics, ref statistics);
            InitializeComponent();
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            SaveFile(mydocpath);
            saveAnimals(animalsStatistics);
            base.OnClosed(e);
            Application.Current.Shutdown();
        }


        private void Mode_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SaveFile(mydocpath);
            if (Mode.Value == 1)
            {
                StringMode.Text = "Liga";
                if (Weapon.Value == 0)
                {
                    mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PistoletLiga.txt";
                }
                else
                {
                    mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\KarabinLiga.txt";
                }
            }
            else
            {
                StringMode.Text = "Zawody";
                if (Weapon.Value == 0)
                {
                    mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PistoletZawody.txt";
                }
                else
                {
                    mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\KarabinZawody.txt";
                }
            }
            ReadFile(mydocpath);
        }


        private void Weapon_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SaveFile(mydocpath);
            if (Weapon.Value == 1)
            {
                StringWeapon.Text = "Karabin";
                if (Mode.Value == 0)
                {
                    mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\KarabinZawody.txt";
                }
                else
                {
                    mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\KarabinLiga.txt";
                }
            }
            else
            {
                StringWeapon.Text = "Pistolet";
                if (Mode.Value == 0)
                {
                    mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PistoletZawody.txt";
                }
                else
                {
                    mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PistoletLiga.txt";
                }
            }
            ReadFile(mydocpath);
        }


        private void Scores_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(WindowNames.Scores);
            if (!_opened[x])
            {
                scoresTable = new ScoresTableClass(ref _opened[x]);
            }
            scoresTable.Refresh();
            scoresTable.Show();
        }


        private void AddScores_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(WindowNames.AddScore);
            if (!_opened[x])
            {
                addScore = new AddScore(ref _opened[x]);
                addScore.Month.SelectedIndex = 0;
            }
            addScore.ChickenPointsBox.SelectedIndex = 0;
            addScore.BoarPointsBox.SelectedIndex = 0;
            addScore.TurkeyPointsBox.SelectedIndex = 0;
            addScore.MouflonPointsBox.SelectedIndex = 0;
            addScore.Show();
        }


        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(WindowNames.AddPerson);
            if (!_opened[x])
            {
                addPerson = new AddPersonClass(ref _opened[x]);
            }
            addPerson.Show();
        }


        private void FindPerson_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(WindowNames.FindPerson);
            if (!_opened[x])
            {
                findPerson = new FindPersonClass(ref _opened[x]);
            }
            findPerson.Show();
        }


        private string RecordConversion(Player person)
        {
            string chain = person.Nick + "\t" +
                            person.Name + "\t" +
                            person.Surname + "\t" +
                            person.Month[0] + "\t" +
                            person.MonthPercentage[0] + "\t" +
                            person.Month[1] + "\t" +
                            person.MonthPercentage[1] + "\t" +
                            person.Month[2] + "\t" +
                            person.MonthPercentage[2] + "\t" +
                            person.Month[3] + "\t" +
                            person.MonthPercentage[3] + "\t" +
                            person.Month[4] + "\t" +
                            person.MonthPercentage[4] + "\t" +
                            person.Month[5] + "\t" +
                            person.MonthPercentage[5] + "\t" +
                            person.Month[6] + "\t" +
                            person.MonthPercentage[6] + "\t" +
                            person.Month[7] + "\t" +
                            person.MonthPercentage[7] + "\t" +
                            person.Month[8] + "\t" +
                            person.MonthPercentage[8] + "\t" +
                            person.Month[9] + "\t" +
                            person.MonthPercentage[9] + "\t" +
                            person.Month[10] + "\t" +
                            person.MonthPercentage[10] + "\t" +
                            person.Month[11] + "\t" +
                            person.MonthPercentage[11] + "\t" +
                            person.TotalScore + "\t" +
                            person.TotalScorePercentage;
            return chain;
        }


        private void SaveFile(string path)
        {
            using (StreamWriter outputFile = new StreamWriter(path))
            {
                outputFile.WriteLine(Header());
                foreach (Player person in listOfPeople)
                {
                    outputFile.WriteLine(RecordConversion(person));
                }
            }
        }


        private void ReadFile(string path)
        {
            listOfPeople.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    BestScore = 0;
                    for (int i=0; i<BestMonths.Length;i++)
                    {
                        BestMonths[i] = 0;
                    }
                    String line = sr.ReadLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        var data = line.Split('\t');
                        Player person = new Player();
                        person.Nick = data[0];
                        person.Name = data[1];
                        person.Surname = data[2]; 
                        for (int j = 0; j < 24; j++ )
                        {
                            if (j % 2 == 0)
                            {
                                person.Month[j / 2] = Int32.Parse(data[j + 3]);
                            }
                            else
                            {
                                person.MonthPercentage[j / 2] = Int32.Parse(data[j + 3]);
                                if (person.MonthPercentage[j / 2] == 100)
                                {
                                    BestMonths[j / 2] = person.Month[j / 2];
                                }
                            }
                        }
                        
                        person.TotalScore = Int32.Parse(data[27]);
                        if (person.TotalScore > BestScore)
                        {
                            BestScore = person.TotalScore;
                        }
                        person.TotalScorePercentage = Int32.Parse(data[28]);
                        listOfPeople.Add(person);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie znaleziono pliku. \nUtworzono nowy plik.");
            }
        }


        private void loadAnimals(string path, ref Animal[] statistics)
        {
            for (int i = 0; i < statistics.Length; i++)
            {
                statistics[i] = new Animal();
            }
            statistics[0].Type = "Chicken";
            statistics[1].Type = "Boar";
            statistics[2].Type = "Turkey";
            statistics[3].Type = "Muflon";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line = sr.ReadLine();
                    line = sr.ReadLine();
                    var data = line.Split('\t');
                    for (int i = 0; i < statistics.Length; i++)
                    {
                        statistics[i].Hunted = Int32.Parse(data[i]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie znaleziono pliku ze statystykami. \nUtworzono nowy plik.");
                foreach(var animal in statistics)
                {
                    animal.Hunted = 0;
                }
            }
        }


        private void saveAnimals(string path)
        {
            using (StreamWriter outputFile = new StreamWriter(path))
            {
                string types = "";
                string amount = "";
                tabMakerForAnimals(statistics, ref types, ref amount);
                outputFile.WriteLine(types);
                outputFile.WriteLine(amount);
            }
        }


        private void tabMakerForAnimals(Animal[] pet, ref string type, ref string amount)
        {
            foreach (var animal in statistics)
            {
                type = type + animal.Type + "\t";
                amount = amount + animal.Hunted + "\t";
            }
        }

        private string Header()
        {
            string chain = "Nick\tImię\tNazwisko\tStyczeń\t%\tLuty\t%\tMarzec\t%\t+Kwiecień\t%\tMaj\t%\tCzerwiec\t%\tLipiec\t%\tSierpień\t%\tWrzesień\t%\tPaździernik\t%\tListopad\t%\tGrudzień\t%\tSuma\t%";
            return chain;
        }
       
    }
}

