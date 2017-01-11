using System;

namespace UseListView1.Models
{
	public class Person
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public DateTime Birth { get; set; }

		public string FullName { get { return $"{this.FirstName}, {this.LastName}"; } }

		/// <summary>
		/// Personリストをロードします。
		/// </summary>
		/// <returns>The persons.</returns>
		public static Person[] LoadPersons()
		{
			Person[] persons = new Person[]
			{
				new Person() { FirstName = "ryuichi", LastName = "daigo", Birth = new DateTime(2000, 1, 11) },
				new Person() { FirstName = "takako", LastName = "shimizu", Birth = new DateTime(1997, 3, 20) },
				new Person() { FirstName = "Hiroko", LastName = "Izumi", Birth = new DateTime(1970, 2, 1) },
				new Person() { FirstName = "Taro", LastName = "Wada", Birth = new DateTime(1996, 11, 30) },
				new Person() { FirstName = "maiko", LastName = "kitamura", Birth = new DateTime(1980, 4, 19) }
			};
			return persons;
		}
	}
}
