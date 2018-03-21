using System.Collections;
using Xamarin.Forms;

namespace UsePicker.Control
{
	/// <summary>
	/// データバインディング対応Pickerコントロール
	/// </summary>
	/// <remarks>
	/// Pickerコントロールはアイテムをデータバインディング出来ないのでカスタムコントロールを実装。
	/// </remarks>
	public class PickerEx : Picker
	{
		/// <summary>
		/// ItemsSourceのBindableProperty
		/// </summary>
		public static readonly BindableProperty ItemsSourceProperty =
			BindableProperty.Create(
				"ItemsSource", 
				typeof(IEnumerable), 
				typeof(PickerEx), 
				default(IEnumerable),
				propertyChanged: OnItemsSourceChanged);

		/// <summary>
		/// ItemsSourceのCLRプロパティ
		/// </summary>
		public IEnumerable ItemsSource
		{
			get { 
				return (IEnumerable)this.GetValue(ItemsSourceProperty); 
			}
			set {
				this.SetValue(ItemsSourceProperty, value); 
			}
		}

		/// <summary>
		/// ItemsSourceがに呼び出されます。
		/// </summary>
		/// <param name="bindable">イベント発行オブジェクト</param>
		/// <param name="oldValue">古い値</param>
		/// <param name="newValue">新しい値</param>
		private static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var picker = bindable as PickerEx;
			picker.Items.Clear();

			if (newValue == null)
				return;
			
			foreach (var item in newValue as IEnumerable)
			{
				picker.Items.Add(item.ToString());
			}
		}
	}
}
