using System;

using Xamarin.Forms;

namespace TodoApp.Models
{
    public class TodoItem
    {
        public bool IsDone { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}

