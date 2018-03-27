using System;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;
using Syncfusion.SfCalendar.XForms;
using System.Collections.ObjectModel;

namespace UseSfCalendarWithPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        /// <summary>
        /// ブラックアウト日付（無効日付）
        /// </summary>
        private ObservableCollection<DateTime> blackoutDates = null;

        /// <summary>
        /// イベントコレクション
        /// </summary>
        private CalendarEventCollection calendarEventCollection = new CalendarEventCollection();

        /// <summary>
        /// 選択モード
        /// </summary>
        private string selectionMode = "SingleSelection";
        
        /// <summary>
        /// 選択モードを取得または設定します。
        /// </summary>
        public string SelectionMode
        {
            get
            {
                return this.selectionMode;
            }
            set
            {
                this.selectionMode = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// 最小表示年月を取得します。
        /// </summary>
        public DateTime MinDate
        {
            get
            {
                return DateTime.Today.AddMonths(-6);
            }
        }

        /// <summary>
        /// 最大表示年月を取得します。
        /// </summary>
        public DateTime MaxDate
        {
            get
            {
                return DateTime.Today.AddMonths(6);
            }
        }

        /// <summary>
        /// ブラックアウト年月日コレクションを取得します。
        /// </summary>
        public ObservableCollection<DateTime> BlackoutDates
        {
            get
            {
                return this.blackoutDates;
            }
        }

        /// <summary>
        /// イベントコレクションを取得します。
        /// </summary>
        public CalendarEventCollection CalendarEventCollection
        {
            get
            {
                return this.calendarEventCollection;
            }
            private set
            {
                this.calendarEventCollection = value;
                this.RaisePropertyChanged();
            }
        }


        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="navigationService"></param>
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            // ブラックアウト日付（無効日付）を設定します。
            this.blackoutDates = new ObservableCollection<DateTime>();
            this.blackoutDates.Add(DateTime.Today.AddDays(-7));
            this.blackoutDates.Add(DateTime.Today.AddDays(-6));
            this.blackoutDates.Add(DateTime.Today.AddDays(-5));

            // イベントコレクションを初期化します。
            this.UpdateEvents(DateTime.Today);

            Title = "Main Page";
        }

        /// <summary>
        /// イベントを更新します。
        /// </summary>
        /// <remarks>
        /// 今月のイベントを表示するために、対象月＋前後一週間のイベントをコレクションに設定します。
        /// 1ヶ月のカレンダーの前後に 前月・次月 の日付が表示されるため、前後1週間のイベントを設定します。
        /// </remarks>
        /// <param name="calendarDate"></param>
        private void UpdateEvents(DateTime calendarDate)
        {
            // バインド対象のthis.CalendarEventCollectionを直接、繰り返しAdd()するとパフォーマンスが著しく落ちるのでテンポラリにデータコレクションを用意して差し替える
            CalendarEventCollection newCalendarEventCollection = new CalendarEventCollection();

            DateTime dt = new DateTime(calendarDate.Year, calendarDate.Month, 1);
            int thisMonthLastDay = dt.AddMonths(1).AddDays(-1).Day;
            for (int i = -7; i < thisMonthLastDay+7; i++)
            { // イベントはサンプルなので適当に2日に1回散歩と仕事、毎日のランチを設定
                DateTime eventDt = dt.AddDays(i);

                if (eventDt.Day % 2 == 1)
                {
                    //this.calendarEventCollection.Add(
                    newCalendarEventCollection.Add(
                    new CalendarInlineEvent()
                    {
                        Subject = $"{eventDt.Day}日 散歩",
                        StartTime = eventDt.AddHours(10),
                        EndTime = eventDt.AddHours(11),
                        Color = Color.Green
                    });
                }
                //this.calendarEventCollection.Add(
                newCalendarEventCollection.Add(
                    new CalendarInlineEvent()
                    {
                        Subject = $"{eventDt.Day}日 ランチ",
                        StartTime = eventDt.AddHours(12),
                        EndTime = eventDt.AddHours(13),
                        Color = Color.Orange
                    });
                if(eventDt.Day % 2 == 0)
                {
                    //this.calendarEventCollection.Add(
                    newCalendarEventCollection.Add(
                        new CalendarInlineEvent()
                        {
                            Subject = $"{eventDt.Day}日 仕事",
                            StartTime = eventDt.AddHours(10),
                            EndTime = eventDt.AddHours(19),
                            Color = Color.Blue
                        });
                }
            }
            this.CalendarEventCollection.Clear();
            this.CalendarEventCollection = newCalendarEventCollection;
        }


        /// <summary>
        /// 表示付きが変更された場合に呼び出されます。
        /// </summary>
        /// <remarks>
        /// SfCalendar.MonthChangedイベントをコマンドビヘイビアとしてViewModelに伝播されます
        /// </remarks>
        public ICommand MonthChangedCommand => new Command<DateTime>((currentDate) =>
        {
            this.UpdateEvents(currentDate);
        });

        /// <summary>
        /// 次の月を表示します。
        /// </summary>
        /// <remarks>
        /// ViewからMessagingCenter.Subscribeにより伝播されます。
        /// </remarks>
        public ICommand ForwardCommand => new Command(() => {
            MessagingCenter.Send<object>(this, "Forward");
        });

        /// <summary>
        /// 前の月を表示します。
        /// </summary>
        /// <remarks>
        /// ViewからMessagingCenter.Subscribeにより伝播されます。
        /// </remarks>
        public ICommand BackwardCommand => new Command(() => {
            MessagingCenter.Send<object>(this, "Backward");
        });
    }
}
