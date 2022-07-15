using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Libary.Model;
public class Book : INotifyPropertyChanged
{
    private string _title;
    public string Title
    {
        get => _title ;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) return;
            if (value is null) return;
            if (value == _title) return;
            _title = value;
            OnPropertyChanged(nameof(Title));
        }
    }
    private string _author;
    public string Author
    {
        get => _title ;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) return;
            if (value is null) return;
            if (value == _author) return;
            _author = value;
            OnPropertyChanged(nameof(Author));
        }
    }
    private string _genre;
    public string Genre
    {
        get => _genre;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) return;
            if (value is null) return;
            if (value == _genre) return;
            _genre = value;
            OnPropertyChanged(nameof(Genre));
        }
    }
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}