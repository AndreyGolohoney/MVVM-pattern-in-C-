using Lab6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Lab6.ViewModels
{
    class MyViewModel : INotifyPropertyChanged
    {
        private string alltext;
        private int result;

        public int Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
                RaisePropertyChanged("Result");
            }
        }
        public string AllText
        {
            get 
            { 
                return alltext;
            }

            set 
            { 
                alltext = value;
                RaisePropertyChanged("AllText");
            }
        }

        private RelayCommand clickCommand;
        public RelayCommand ClickCommand
        {
            get
            {
                return clickCommand ??
                  (clickCommand = new RelayCommand(obj =>
                  {  //при нажатии на кнопку производится расчет результата умножения
                      Words numbes = new Words();  //создадим объект класса модели
                      Result = numbes.returnResult(AllText); //вызовем функцию расчета результата и присвоим ее значение
                      //соответствующему полю Result
                  }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }


        public MyViewModel() //пустой конструктор
        {
        }
    }
}
