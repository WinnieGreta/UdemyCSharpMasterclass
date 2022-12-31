using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace UdemyAssignment52
{
    public class Result : INotifyPropertyChanged
    {
        private string? num1;
        private string? num2;
        private string sumResult;
        private string multiResult;

        public string Num1
        {
            get { return num1; }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num1 = value;
                OnPropertyChanged("Num1");
                OnPropertyChanged("SumResult");
                OnPropertyChanged("MultiResult");
            }
        }

        public string Num2
        {
            get { return num2; }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num2 = value;
                OnPropertyChanged("Num2");
                OnPropertyChanged("SumResult");
                OnPropertyChanged("MultiResult");
            }
        }

        public string SumResult
        {
            get
            {
                int res = int.Parse(Num1) + int.Parse(Num2);
                return res.ToString();
            }
            set
            {
                int res = int.Parse(Num1) + int.Parse(Num2);
                sumResult = res.ToString();
                OnPropertyChanged("SumResult");
            }
        }

        public string MultiResult
        {
            get
            {
                int res = int.Parse(Num1) * int.Parse(Num2);
                return res.ToString();
            }
            set
            {
                int res = int.Parse(Num1) * int.Parse(Num2);
                multiResult = res.ToString();
                OnPropertyChanged("MultiResult");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged (string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged (this, new PropertyChangedEventArgs (property));
            }
        }
    }
}
