using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace listeJeuxAmeliorer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<Game> ListGame = new ObservableCollection<Game>();
        public ObservableCollection<string> ListConsole { get; set; } = new ObservableCollection<string>();
        public Game currentGame;

        public event PropertyChangedEventHandler PropertyChanged;
        public Game CurrentGame
        {
            get => currentGame;
            set
            {
                currentGame = value;
                OnPropertyChanged();
            }
        }



        public MainWindow()
        {
            ListConsole.Add("PS4");
            ListConsole.Add("Xbox3");
            ListConsole.Add("PC");
            ListConsole.Add("NES");

            ListGame.Add(new Game()
            {
                Title = "Kill the goat",
                Description = "You need to kill as many goat as possible!!",
                Editor = "Ubisoft",
                Year = 2010,
                Console = "PS4",
                Rating = 5,
                PicturePath = "Image/chevre1.jpg"
            });

            ListGame.Add(new Game()
            {
                Title = "Slab the goat",
                Description = "You need to slab as many goat as possible!!",
                Editor = "Epic Game",
                Year = 2015,
                Console = "Xbox3",
                Rating = 9,
                PicturePath = "Image/chevre2.jpg"
            });

            ListGame.Add(new Game()
            {
                Title = "Run from the goat",
                Description = "You need to run away of the goat as possible!!",
                Editor = "Runtime",
                Year = 2005,
                Console = "PC",
                Rating = 7,
                PicturePath = "Image/chevre3.jpg"
            });

            ListGame.Add(new Game()
            {
                Title = "Capture the goat",
                Description = "You need to capture as many goat as possible!!",
                Editor = "Gamecon",
                Year = 2000,
                Console = "NES",
                Rating = 4,
                PicturePath = "Image/chevre4.jpg"
            });


            CurrentGame = ListGame[0];

            InitializeComponent();
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CurrentGame = ListGame[Convert.ToInt32(e.NewValue)];
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
