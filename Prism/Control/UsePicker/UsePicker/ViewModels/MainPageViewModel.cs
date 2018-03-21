using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UsePicker.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private string message;
		public string Message
		{
			get
			{
				return this.message;
			}
			set
			{
				this.SetProperty(ref this.message, value);
			}
		}

		private List<string> pickerItems = new List<string>();
		public List<string> PickerItems
		{
			get
			{
				return this.pickerItems;
			}
		}

		private int selectedPickerItem = 0;
		public int SelectedPickerItem
		{
			get
			{
				return this.selectedPickerItem;
			}
			set
			{
				this.SetProperty(ref this.selectedPickerItem, value);
				this.Message = $"選択インデックス：{this.SelectedPickerItem}";
			}
		}

		public MainPageViewModel()
		{
			this.pickerItems.Add("item1");
			this.pickerItems.Add("item2");
			this.pickerItems.Add("item3");
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}

