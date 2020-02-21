using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using ListeJeuxAmeliorer.Models;
using ListeJeuxAmeliorer.Services;

namespace listeJeuxAmeliorer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private IGameRepository gameRepository = new GameRepository();
        private IConsoleRepository consoleRepository = new ConsoleRepository();

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
	        var consoles = consoleRepository.FindAll();
	        foreach (var console in consoles)
	        {
		        ListConsole.Add(console);
            }
            
            var games = gameRepository.FindAll();
            foreach (var game in games)
            {
	            ListGame.Add(game);
            }

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
