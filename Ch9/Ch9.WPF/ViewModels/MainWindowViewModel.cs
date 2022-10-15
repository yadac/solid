using Ch9.WPF.Domain;
using Ch9.WPF.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ch9.WPF.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _resultValue;
        private ICommand _concatCommand;
        private readonly IMainWindowModelRepository _repository;

        public MainWindowViewModel()
            :this(Factories.CreateMainWindowModelRepository())
        {

        }
        public MainWindowViewModel(IMainWindowModelRepository repository)
        {
            _repository = repository;
            _concatCommand = new ConcatCommand(this);
        }

        public string Value1
        {
            get { return _repository.Value1; }
            set {
                _repository.Value1 = value;
                NotifyPropertyChanged();
            }
        }
        public string Value2
        {
            get { return _repository.Value2; }
            set
            {
                _repository.Value2 = value;
                NotifyPropertyChanged();
            }
        }
        public string ResultValue
        {
            get { return _resultValue; }
            set
            {
                _resultValue = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand ConcatCommand => _concatCommand;

        protected void NotifyPropertyChanged(string propertyName = "")
        {
            this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
