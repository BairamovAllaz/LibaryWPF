using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Libary.Model;
public class Book : INotifyPropertyChanged
{
    private int _id;

    public int Id
    {
        get => _id;
        set
        {
            if (value <= 0) return; 
            if(value == _id) return;
            _id = value;
            OnPropertyChanged(nameof(Id));
        } 

    }
    
    private string _title;
    public string Title
    {
        get => _title ;
        set
        {
            if (value == _title) return;
            _title = value;
            OnPropertyChanged(nameof(Title));
        }
    }
    private string _author;
    public string Author
    {
        get => _author ;
        set
        {
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