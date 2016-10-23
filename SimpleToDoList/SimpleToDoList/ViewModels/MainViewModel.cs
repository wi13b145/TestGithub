using SimpleToDoList.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList.ViewModels
{
    class MainViewModel
    {
        private string newTaskDescription = "";

        public string NewTaskDescription
        {
            get { return newTaskDescription; }
            set { newTaskDescription = value; }
        }

        private RelayCommand addButtonClickedCommand;

        public RelayCommand AddButtonClickedCommand
        {
            get { return addButtonClickedCommand; }
            set { addButtonClickedCommand = value; }
        }



        private ObservableCollection<ToDoVM> toDoList = new ObservableCollection<ToDoVM>();

        public ObservableCollection<ToDoVM> ToDoList
        {
            get { return toDoList; }
            set { toDoList = value; }
        }

        public MainViewModel()
        {
            AddButtonClickedCommand = new RelayCommand(new Action(AddButtonClicked), new Func<bool>(CanExecute));
            LoadData();
        }

        private bool CanExecute()
        {
            //return true;
            return NewTaskDescription.Length > 0;
        }

        private void AddButtonClicked()
        {
            ToDoList.Add(new ToDoVM(NewTaskDescription, false));
        }

        private void LoadData()
        {
            ToDoList.Add(new ToDoVM("ddd", false));
            ToDoList.Add(new ToDoVM("dddsd", true));

        }

    }
}
