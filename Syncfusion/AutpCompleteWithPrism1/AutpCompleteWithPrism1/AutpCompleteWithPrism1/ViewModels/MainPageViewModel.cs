using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

using Xamarin.Forms;

using AutpCompleteWithPrism1.Models;

namespace AutpCompleteWithPrism1.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        /// <summary>
        /// SfAutoCompleteにデータバインドする駅情報データソース
        /// </summary>
        public List<Station> Stations { get; set; } = new List<Station>();

        /// <summary>
        /// 検索ボタンコマンド
        /// </summary>
        public ICommand SearchCommand { get; }

        /// <summary>
        /// SfAutoComplete選択項目変更コマンド
        /// </summary>
        public ICommand SelectionChangedCommand { get; }

        /// <summary>
        /// SfAutoComplete入力テキスト
        /// </summary>
        private string inputText = "";
        public string InputText
        {
            get
            {
                return this.inputText;
            }
            set
            {
                this.SetProperty(ref this.inputText, value);
            }
        }

        /// <summary>
        /// メッセージテキスト
        /// </summary>
        private string message = "";
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

        public MainPageViewModel()
        {
            // データソース作成
            this.Stations.Add(new Station() { Name = "東京", Kana = "とうきょう" });
            this.Stations.Add(new Station() { Name = "恵比寿", Kana = "えびす" });
            this.Stations.Add(new Station() { Name = "江戸橋", Kana = "えどばし" });
            this.Stations.Add(new Station() { Name = "品川", Kana = "しながわ" });
            this.Stations.Add(new Station() { Name = "新宿", Kana = "しんじゅく" });

            // SfAutoComplete.SelectionChangedイベントに対応したCommand
            SelectionChangedCommand = new Command((param) =>
            {
                this.InputText = this.Stations.First(s => s.Kana == ((Syncfusion.SfAutoComplete.XForms.SelectionChangedEventArgs)param).Value).Name;
            });

            // 検索ボタンクリック時のCommand
            SearchCommand = new Command(() => { this.Message = this.InputText; });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
