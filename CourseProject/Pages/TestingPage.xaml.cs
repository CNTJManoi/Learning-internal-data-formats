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
        private int _intervalMin, _intervalMax;
        private byte _mode;
        private string _number;
        private uint _score;
        private string _sixTeenPeremens;
        private uint _time;
        private string _twoPeremens;
        private byte _typeGame;

        private byte _typePerem;

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
                        _intervalMin = -100;
                        _intervalMax = 100;
                        break;
                    case 1:
                        _intervalMin = -1000000;
                        _intervalMax = 1000000;
                        break;
                    case 2:
                        _intervalMin = int.MinValue;
                        _intervalMax = int.MaxValue;
                        break;
                }

                UserBox.Text = "";
                TwoBox.Text = "";
                _typePerem = byte.Parse(TypePeremBox.SelectedIndex.ToString());
                _mode = (byte) ModeBox.SelectedIndex;
                if (_mode == 1)
                    switch (TimeBox.SelectedIndex)
                    {
                        case 0:
                            _time = 30;
                            break;
                        case 1:
                            _time = 60;
                            break;
                        case 2:
                            _time = 120;
                            break;
                        case 3:
                            _time = 180;
                            break;
                        case 4:
                            _time = 300;
                            break;
                        case 5:
                            _time = 600;
                            break;
                        case 6:
                            _time = 1800;
                            break;
                        case 7:
                            _time = 6000;
                            break;
                    }

                BeginButton.Content = "Закончить";
                UserDone.IsEnabled = true;
                _score = 0;
                _typeGame = (byte) ParametersBox.SelectedIndex;
                PlayGame();
            }
            else
            {
                BeginButton.Content = "Начать тестирование";
                UserDone.IsEnabled = false;
                _timer.Stop();
                TimeWindow.Opacity = 0;
                TwoBox.Text = _typeGame == 1 ? _sixTeenPeremens : _number;
                ScoreBlock.Text = "0";
            }
        }

        private void PlayGame()
        {
            var answer = new string[2];
            ScoreBlock.Text = _score.ToString();
            var peremen = "";
            if (_typePerem != 8 && _typePerem != 9 && _typePerem != 10)
                peremen = _r.Next(_intervalMin, _intervalMax).ToString();
            else
                peremen = Math.Round(_intervalMin + _r.NextDouble() * (_intervalMax - _intervalMin), 2).ToString();

            _number = peremen;
            if (_typePerem == 0)
            {
                sbyte z;
                z = sbyte.Parse(peremen);

                var p = new Pointer<sbyte>(true);
                answer = p.Сheck(z);
            }
            else if (_typePerem == 1)
            {
                byte z;
                z = byte.Parse(peremen);

                var p = new Pointer<byte>(true);
                answer = p.Сheck(z);
            }
            else if (_typePerem == 2)
            {
                short z;
                z = short.Parse(peremen);

                var p = new Pointer<short>(true);
                answer = p.Сheck(z);
            }
            else if (_typePerem == 3)
            {
                ushort z;
                z = ushort.Parse(peremen);

                var p = new Pointer<ushort>(true);
                answer = p.Сheck(z);
            }
            else if (_typePerem == 4)
            {
                int z;
                z = int.Parse(peremen);

                var p = new Pointer<int>(true);
                answer = p.Сheck(z);
            }
            else if (_typePerem == 5)
            {
                uint z;
                z = uint.Parse(peremen);

                var p = new Pointer<uint>(true);
                answer = p.Сheck(z);
            }
            else if (_typePerem == 6)
            {
                long z;
                z = long.Parse(peremen);

                var p = new Pointer<long>(true);
                answer = p.Сheck(z);
            }
            else if (_typePerem == 7)
            {
                ulong z;
                z = ulong.Parse(peremen);

                var p = new Pointer<ulong>(true);
                answer = p.Сheck(z);
            }
            else if (_typePerem == 8)
            {
                float z;
                z = float.Parse(peremen);

                var p = new Pointer<float>(true);
                answer = p.Сheck(z);
            }
            else if (_typePerem == 9)
            {
                double z;
                z = double.Parse(peremen);
                var p = new Pointer<double>(true);
                answer = p.Сheck(z);
            }
            else if (_typePerem == 10)
            {
                decimal z;
                z = decimal.Parse(peremen);

                var p = new Pointer<decimal>(true);
                answer = p.Сheck(z);
            }

            _sixTeenPeremens = answer[0].Trim();
            _twoPeremens = answer[1].Trim();
            PeremenBox.Text = _typeGame == 0 ? _sixTeenPeremens : peremen;
            if (_mode == 1)
            {
                _timer.Start();
                TimeWindow.Opacity = 1;
                var minutes = _time / 60;
                var seconds = _time - 60 * minutes;
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
            if (_time > 0)
            {
                _time -= 1;
                var minutes = _time / 60;
                var seconds = _time - 60 * minutes;
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
                TwoBox.Text = _sixTeenPeremens;
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
            if (result == _sixTeenPeremens.Replace(" ", string.Empty) ||
                result == _twoPeremens.Replace(" ", string.Empty) && _typeGame == 1)
            {
                _score += 1;
                if (_mode != 0) PlayGame();
            }
            else if (result == _number.Replace(" ", string.Empty) && _typeGame == 0)
            {
                _score += 1;
                if (_mode != 0) PlayGame();
            }
            else
            {
                DialogText.Text = "Значение введено неверно!";
                Dialog.IsOpen = true;
                if (_mode == 0 || _mode == 2)
                {
                    if (_typeGame == 1) TwoBox.Text = _sixTeenPeremens;
                    else TwoBox.Text = _number;
                    BeginButton.Content = "Начать тестирование";
                    UserDone.IsEnabled = false;
                }

                return;
            }

            if (_mode == 0)
            {
                DialogText.Text = "Значение введено верно!";
                Dialog.IsOpen = true;
                BeginButton.Content = "Начать тестирование";
                UserDone.IsEnabled = false;
                if (_typeGame == 1) TwoBox.Text = _sixTeenPeremens;
                else TwoBox.Text = _number;
            }

            if (_typeGame == 1) TwoBox.Text = _sixTeenPeremens;
            else TwoBox.Text = _number;
        }
    }
}