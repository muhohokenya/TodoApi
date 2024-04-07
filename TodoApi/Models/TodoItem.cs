using System;
namespace TodoApi.Models
{
	public class TodoItem
	{
		public TodoItem(){
            // Constructor
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}

