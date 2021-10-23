using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace CourseProject.Pages
{
    /// <summary>
    ///     Логика взаимодействия для TestingPage.xaml
    /// </summary>
    public partial class TestingPage : UserControl
    {
        private readonly Random _r = new Random();
        private readonly DispatcherTimer _timer;
        private int intervalMin, intervalMax;
        private byte Mode;
        private string Number;
        private uint Score;
        private string sixTeenPeremens;
        private uint Time;
        private string TwoPeremens;
        private byte TypeGame;

        private byte typePerem;

        public TestingPage()
        {
            InitializeComponent();
            ModeBox.SelectedIndex = 0;
            DifBox.SelectedIndex = 0;
            TypePeremBox.SelectedIndex = 0;
            ParametersBox.SelectedIndex = 0;
            _timer = new DispatcherTimer();
            _timer.Tick += timer1_Tick;
            _timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void ModeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimePanel.Opacity = ModeBox.SelectedIndex == 1 ? 1 : 0;
        }

        //Режим 0 - обычный 1 - на время 2 - до первой ошибки ModeBox
        //Сложность 0 - легкая 1 - средняя 2 - сложно DifBox
        //численный тип 0 - sbyte 1 - byte 2 - short 3 - ushort 4 - int 5 - uint TypePeremBox
        //6 - long 7 - ulong 8 - float 9 - double 10 - decimal TypePeremBox
        //Тип игры 0 - из типа в число 1 - из числа в тип ParametersBox
        //Время игры 0 - 30 секунд 1 - 1 минута 2 - 2 минуты 3 - 3 минуты 4 - 5 минут 5 - 10 минут 6 - 30 минут 7 - 1 час TimeBox
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((string) BeginButton.Content == "Начать тестирование")
            {
                if (ModeBox.SelectedIndex == -1 ||
                    DifBox.SelectedIndex == -1 ||
                    TypePeremBox.SelectedIndex == -1 ||
                    ParametersBox.SelectedIndex == -1)
                {
                    DialogText.Text = "Выберите все настраиваемые пункты";
                    Dialog.IsOpen = true;
                    return;
                }

                switch (DifBox.SelectedIndex)
                {
                    case 0:
                        intervalMin = -100;
                        intervalMax = 100;
                        break;
                    case 1:
                        intervalMin = -1000000;
                        intervalMax = 1000000;
                        break;
                    case 2:
                        intervalMin = int.MinValue;
                        intervalMax = int.MaxValue;
                        break;
                }

                UserBox.Text = "";
                TwoBox.Text = "";
                typePerem = byte.Parse(TypePeremBox.SelectedIndex.ToString());
                Mode = (byte) ModeBox.SelectedIndex;
                if (Mode == 1)
                    switch (TimeBox.SelectedIndex)
                    {
                        case 0:
                            Time = 30;
                            break;
                        case 1:
                            Time = 60;
                            break;
                        case 2:
                            Time = 120;
                            break;
                        case 3:
                            Time = 180;
                            break;
                        case 4:
                            Time = 300;
                            break;
                        case 5:
                            Time = 600;
                            break;
                        case 6:
                            Time = 1800;
                            break;
                        case 7:
                            Time = 6000;
                            break;
                    }

                BeginButton.Content = "Закончить";
                UserDone.IsEnabled = true;
                Score = 0;
                TypeGame = (byte) ParametersBox.SelectedIndex;
                PlayGame();
            }
            else
            {
                BeginButton.Content = "Начать тестирование";
                UserDone.IsEnabled = false;
                _timer.Stop();
                TimeWindow.Opacity = 0;
                if (TypeGame == 1) TwoBox.Text = sixTeenPeremens;
                else TwoBox.Text = Number;
                ScoreBlock.Text = "0";
            }
        }

        private void PlayGame()
        {
            var answer = new string[2];
            ScoreBlock.Text = Score.ToString();
            string peremen = "";
            if(typePerem != 8 && typePerem != 9 && typePerem != 10) peremen = _r.Next(intervalMin, intervalMax).ToString();
            else
            {
                peremen = Math.Round((intervalMin + _r.NextDouble() * (intervalMax - intervalMin)),2).ToString();
            }

            Number = peremen;
            if (typePerem == 0)
            {
                sbyte z;
                z = sbyte.Parse(peremen);

                var p = new Pointer<sbyte>(true);
                answer = p.Сheck(z);
            }
            else if (typePerem == 1)
            {
                byte z;
                z = byte.Parse(peremen);

                var p = new Pointer<byte>(true);
                answer = p.Сheck(z);
            }
            else if (typePerem == 2)
            {
                short z;
                z = short.Parse(peremen);

                var p = new Pointer<short>(true);
                answer = p.Сheck(z);
            }
            else if (typePerem == 3)
            {
                ushort z;
                z = ushort.Parse(peremen);

                var p = new Pointer<ushort>(true);
                answer = p.Сheck(z);
            }
            else if (typePerem == 4)
            {
                int z;
                z = int.Parse(peremen);

                var p = new Pointer<int>(true);
                answer = p.Сheck(z);
            }
            else if (typePerem == 5)
            {
                uint z;
                z = uint.Parse(peremen);

                var p = new Pointer<uint>(true);
                answer = p.Сheck(z);
            }
            else if (typePerem == 6)
            {
                long z;
                z = long.Parse(peremen);

                var p = new Pointer<long>(true);
                answer = p.Сheck(z);
            }
            else if (typePerem == 7)
            {
                ulong z;
                z = ulong.Parse(peremen);

                var p = new Pointer<ulong>(true);
                answer = p.Сheck(z);
            }
            else if (typePerem == 8)
            {
                float z;
                z = float.Parse(peremen);

                var p = new Pointer<float>(true);
                answer = p.Сheck(z);
            }
            else if (typePerem == 9)
            {
                double z;
                z = double.Parse(peremen);
                var p = new Pointer<double>(true);
                answer = p.Сheck(z);
            }
            else if (typePerem == 10)
            {
                decimal z;
                z = decimal.Parse(peremen);

                var p = new Pointer<decimal>(true);
                answer = p.Сheck(z);
            }

            sixTeenPeremens = answer[0].Trim();
            TwoPeremens = answer[1].Trim();
            PeremenBox.Text = TypeGame == 0 ? sixTeenPeremens : peremen;
            if (Mode == 1)
            {
                _timer.Start();
                TimeWindow.Opacity = 1;
                var minutes = Time / 60;
                var seconds = Time - 60 * minutes;
                string sec = "", min = "";
                if (seconds < 10) sec = "0" + seconds;
                else sec = seconds.ToString();
                if (minutes < 10) min = "0" + minutes;
                else min = minutes.ToString();
                TimeBlock.Text = min + ":" + sec;
            }
            else
            {
                _timer.Stop();
                TimeWindow.Opacity = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time > 0)
            {
                Time -= 1;
                var minutes = Time / 60;
                var seconds = Time - 60 * minutes;
                string sec = "", min = "";
                if (seconds < 10) sec = "0" + seconds;
                else sec = seconds.ToString();
                if (minutes < 10) min = "0" + minutes;
                else min = minutes.ToString();
                TimeBlock.Text = min + ":" + sec;
            }
            else
            {
                DialogText.Text = "Время закончилось!";
                Dialog.IsOpen = true;
                _timer.Stop();
                TwoBox.Text = sixTeenPeremens;
                BeginButton.Content = "Начать тестирование";
                UserDone.IsEnabled = false;
            }
        }

        private void UserDone_Click(object sender, RoutedEventArgs e)
        {
            if (UserBox.Text == "")
            {
                DialogText.Text = "Вы не ввели результат!";
                Dialog.IsOpen = true;
                return;
            }

            var result = UserBox.Text.Replace(" ", string.Empty);
            if (result == sixTeenPeremens.Replace(" ", string.Empty) ||
                result == TwoPeremens.Replace(" ", string.Empty) && TypeGame == 1)
            {
                Score += 1;
                if (Mode != 0) PlayGame();
            }
            else if (result == Number.Replace(" ", string.Empty) && TypeGame == 0)
            {
                Score += 1;
                if (Mode != 0) PlayGame();
            }
            else
            {
                DialogText.Text = "Значение введено неверно!";
                Dialog.IsOpen = true;
                if (Mode == 0 || Mode == 2)
                {
                    if (TypeGame == 1) TwoBox.Text = sixTeenPeremens;
                    else TwoBox.Text = Number;
                    BeginButton.Content = "Начать тестирование";
                    UserDone.IsEnabled = false;
                }

                return;
            }

            if (Mode == 0)
            {
                DialogText.Text = "Значение введено верно!";
                Dialog.IsOpen = true;
                BeginButton.Content = "Начать тестирование";
                UserDone.IsEnabled = false;
                if (TypeGame == 1) TwoBox.Text = sixTeenPeremens;
                else TwoBox.Text = Number;
            }

            if (TypeGame == 1) TwoBox.Text = sixTeenPeremens;
            else TwoBox.Text = Number;
        }
    }
}