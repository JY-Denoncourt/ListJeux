using System.ComponentModel;

namespace ListeJeuxAmeliorer.Models
{
    public class Game : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Editor { get; set; }
        public int Year { get; set; }
        public string Console { get; set; }
        public int Rating { get; set; }
        public string PicturePath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}


