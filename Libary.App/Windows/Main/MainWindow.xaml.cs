using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using Libary.App.Annotations;
using Libary.Model;
namespace Libary.App.Windows.Main
{
    public partial class MainWindow : INotifyPropertyChanged
    {
        public ObservableCollection<Book> Books { get; set; }
        private Book _book;
        public Book Book
        {
            get => _book;
            set
            {
                if (value is null) return;
                if (value == _book) return;
                _book = value;
                OnPropertyChanged(nameof(Book));
            }
        }
        public MainWindow()
        {
            _book = new Book();
            Books = new ObservableCollection<Book>();
            InitializeComponent();
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void ButtonClear_OnClick(object sender, RoutedEventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            InputTitle.Clear();
            InputAuthor.Clear();
            InputGenre.Clear();
        }
        private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        {
            Books.Remove(Book);
            Clear();
        }
        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            if (!Books.Contains(Book))
            {
                Books.Add(Book);
                Clear();
            }
        }
    }
}