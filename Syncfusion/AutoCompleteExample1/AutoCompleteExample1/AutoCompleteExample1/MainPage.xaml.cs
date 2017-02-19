using System.Collections.Generic;
using Xamarin.Forms;

namespace AutoCompleteExample1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // 候補文字列リストを作成
            List<string> Stations = new List<string>();
            Stations.Add("Tokyo");
            Stations.Add("Osaka");
            Stations.Add("Nagoya");
            Stations.Add("Nagatachou");
            Stations.Add("Ebisu");
            Stations.Add("Sinagawa");

            // SfAutoCompleteに候補文字列リストをソースとして設定
            this.AutoComplete1.AutoCompleteSource = Stations;
        }

        // ボタンクリックイベントハンドラ
        private void CheckClicked(object sender, System.EventArgs e)
        {
            // ラベルにSfAutoCompleteに入力された値を設定
            this.Label1.Text = this.AutoComplete1.Text;
        }
    }
}
