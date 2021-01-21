using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Galifrei.Core
{
    public class Progress : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _percent;

        public int Percent
        {
            get { return _percent; }
            set { _percent = value; Raise(); }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; Raise(); }
        }

        private void Raise([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public void Step(int percent)
        {
            Percent = percent;
        }
    }
}