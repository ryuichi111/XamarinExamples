using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;

namespace UseSlider.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private double sliderMax = 100;
		public double SliderMax
		{
			get
			{
				return this.sliderMax;
			}
			set
			{
				this.SetProperty(ref this.sliderMax, value);
			}
		}

		private double sliderMin=-100.5;
		public double SliderMin
		{
			get
			{
				return this.sliderMin;
			}
			set
			{
				this.SetProperty(ref this.sliderMin, value);
			}
		}

		private double sliderValue;
		public double SliderValue
		{
			get
			{
				return this.sliderValue;
			}
			set
			{
				this.SetProperty(ref this.sliderValue, value);
			}
		}

		public ICommand AddCommand { get; }
		public ICommand SubtractCommand { get; }

		public MainPageViewModel()
		{
			this.AddCommand = new DelegateCommand(() => { this.SliderValue += 10; });
			this.SubtractCommand = new DelegateCommand(() => { this.SliderValue -= 10; });
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}

