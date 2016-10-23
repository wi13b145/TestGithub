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
        private string newTaskDescription;

        public string NewTaskDescription
        {
            get { return newTaskDescription; }
            set { newTaskDescription = value; }
        }

        private ObservableCollection<String> toDoList = new ObservableCollection<string>();

        public ObservableCollection<String> ToDoList
        {
            get { return toDoList; }
            set { toDoList = value; }
        }

        public MainViewModel()
        {
            ToDoList.Add("sdfsdf");
            ToDoList.Add("sdfsdf");
        }

    }
}
