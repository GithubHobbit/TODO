using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TODO.Model;
using Xamarin.Forms;


namespace TODO.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Data> TaskCollection { get; }

        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        
        public MainViewModel()
        {
            AddCommand = new Command(AddTask);
            DeleteCommand = new Command(DeleteTask);
            TaskCollection = new ObservableCollection<Data>();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void AddTask(object text)
        {
            TaskCollection.Add(new Data(text.ToString()));
            OnPropertyChanged();
        }

        private void DeleteTask(object obj)
        {
            if (obj is Data task)
            {
                TaskCollection.Remove(task);
            }
            OnPropertyChanged();
        }
    }
}


