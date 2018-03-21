using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.ObjectModel;

using UseListView1.Models;

namespace UseListView1.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private ObservableCollection<Person> persons;
		private Person selectedPerson;

		/// <summary>
		/// Personsリストを取得または設定します。
		/// </summary>
		/// <value>The persons.</value>
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

		/// <summary>
		/// 選択中Personを取得または設定します。
		/// </summary>
		/// <value>The selected person.</value>
		public Person SelectedPerson
		{
			get
			{
				return this.selectedPerson;
			}
			set
			{
				this.SetProperty(ref this.selectedPerson, value);
			}
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainPageViewModel()
		{
			this.Persons = new ObservableCollection<Person>(Person.LoadPersons());
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}

