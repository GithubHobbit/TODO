using Xamarin.Forms;

namespace TODO.Model
{
    class Data : BindableObject
    {
        private string _text;

        public Data(string text)
        {
            Text = text;
        }

        public string Text
        {
            get => _text;
            set
            {
                if (_text == value) return;

                _text = value;
                OnPropertyChanged();
            }
        }
    }
}
