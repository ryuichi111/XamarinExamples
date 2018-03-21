using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.ObjectModel;
using UseBindablePicker.Models;

namespace UseBindablePicker.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		public ObservableCollection<Person> persons = null;
		public ObservableCollection<Person> Persons
		{
			get
			{
				return this.persons;
			}
			set
			{
				this.SetProperty(ref this.persons, value);
			}
		}

		public Person selectedPersons = null;
		public Person SelectedPerson
		{
			get
			{
				return this.selectedPersons;
			}
			set
			{
				this.SetProperty(ref this.selectedPersons, value);
			}
		}

		public MainPageViewModel()
		{
			this.Persons = new ObservableCollection<Person>();
			this.Persons.Add(new Person() { ID = "001", FirstName = "Ryuichi", LastName = "Daigo" });
			this.Persons.Add(new Person() { ID = "002", FirstName = "Sora", LastName = "Kitagawa" });
			this.Persons.Add(new Person() { ID = "003", FirstName = "Koji", LastName = "Sakashita" });

			this.SelectedPerson = this.Persons[0];
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}

