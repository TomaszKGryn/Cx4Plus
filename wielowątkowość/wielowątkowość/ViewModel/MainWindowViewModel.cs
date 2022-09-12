using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using wielowątkowość.UtilsWPF;

namespace wielowątkowość.ViewModel

{
    class MainWindowViewModel:UtilsWPF.ObserverVM
    {
        private int sumResult;
        private int firstValue;
        private int secondValue;

        public int SumResult
        {
            get { return sumResult; }
            set {
                sumResult = value;
                OnPropertyChanged();           
            }
        }
     

        public int FirstValue
        {
            get { return firstValue; }
            set { firstValue = value; }
        }
        

        public int SecondValue
        {
            get { return secondValue; }
            set { secondValue = value; }
        }
        private string operationMessage;

        public string OperationMessage
        {
            get { return operationMessage; }
            set 
            { 
                operationMessage = value;
                OnPropertyChanged();       
            }
        }


        private ICommand synchronousSumCommand;

        public ICommand SynchronousSumCommand
        {
            get {
                if (synchronousSumCommand == null)
                    synchronousSumCommand = new RelayCommand<object>(o =>
                    {
                        int result = firstValue + secondValue;
                        Thread.Sleep(10000);
                        SumResult = result;
                        OperationMessage = "Operacja zakończona";
                    });

                return synchronousSumCommand; }
       
        }
        
        private ICommand taskSumCommand;

        public ICommand TaskSumCommand
        {
            get
            {
                if (taskSumCommand == null)
                    taskSumCommand = new RelayCommand<object>(o =>
                    {
                        /* 
                        Task newTask = new Task(() =>
                        {
                        int result = firstValue + secondValue;
                        Thread.Sleep(10000);
                        SumResult = result;
                        });
                        newTask.Start();
                        */

                        Task.Run(() =>
                       {
                           int result = firstValue + secondValue;
                           Thread.Sleep(10000);
                           SumResult = result;
                       });
                        OperationMessage = "Operacja zakończona (z wątku)";
                    });

                return taskSumCommand;
            }
        }
        private ICommand taskSumTaskMessageCommand;

        public ICommand TaskSumTaskMessageCommand
        {
            get
            {
                if (taskSumTaskMessageCommand == null)
                    taskSumTaskMessageCommand = new RelayCommand<object>(o =>
                    {

                        Task newTask = new Task(() =>
                        {
                            int result = firstValue + secondValue;
                            Thread.Sleep(10000);
                            SumResult = result;
                        });
                        newTask.Start();

                        Task.Run(() =>
                        {
                            newTask.Wait();
                            OperationMessage = "Operacja zakończona (z wątku)";

                        });
                    });
              
                return taskSumTaskMessageCommand;
            }
                set
                    { taskSumTaskMessageCommand = value; }
        }


    }
    }
    

  


