using TodoApp.ViewModels;
using Xamarin.Forms;

namespace TodoApp
{
    public partial class TodoAppPage : ContentPage
    {
        private TodoViewModel _todoViewModel;

        public TodoAppPage()
        {
            InitializeComponent();

        _todoViewModel = new TodoViewModel();
        BindingContext = _todoViewModel; }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            if (_todoViewModel.NewTodoItemCommand.CanExecute(null))
                _todoViewModel.NewTodoItemCommand.Execute(null);
        }
    }
}
