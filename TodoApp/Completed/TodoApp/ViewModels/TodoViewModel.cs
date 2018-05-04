using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TodoApp.Models;
using TodoApp.Utilities;
using Xamarin.Forms;

namespace TodoApp.ViewModels
{
    public class TodoViewModel : NotifyPropertyChanged
    {
        private readonly ObservableCollection<TodoItem> _todos = new ObservableCollection<TodoItem>();
        private string _newTodoItemTitle;

        public TodoViewModel()
        {
            NewTodoItemCommand = new Command<string>(HandleNewTodoItemCommand);
        }

        public ICommand NewTodoItemCommand { get; }
        public ObservableCollection<TodoItem> Todos => _todos;
        public string NewTodoItemTitle
        {
            get => _newTodoItemTitle;
            set => SetProperty(ref _newTodoItemTitle, value);
        }

        private void HandleNewTodoItemCommand(string title)
        {
            var newTodoItem = new TodoItem { Title = NewTodoItemTitle };
            _todos.Add(newTodoItem);

            NewTodoItemTitle = null;
        }
    }
}

