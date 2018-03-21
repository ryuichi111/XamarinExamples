using System;
namespace UseBindablePicker.Models
{
	public class Person
	{
		public string ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public override string ToString()
		{
			return $"{FirstName}, {LastName} ({ID})";
		}
	}
}
