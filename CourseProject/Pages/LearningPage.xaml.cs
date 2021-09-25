using System;
using System.Windows;
using System.Windows.Controls;

namespace CourseProject.Pages
{
    /// <summary>
    ///     Логика взаимодействия для LearningPage.xaml
    /// </summary>
    public partial class LearningPage : UserControl
    {
        public LearningPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string peremen;
            if (Peremen.Text == "")
            {
                DialogText.Text = "Укажите число!";
                Dialog.IsOpen = true;
                return;
            }

            peremen = Peremen.Text.Replace('.', ',');
            try
            {
                decimal.Parse(peremen);
            }
            catch
            {
                DialogText.Text = "Допущены ошибки при вводе числа!";
                Dialog.IsOpen = true;
                return;
            }

            if (TypePeremen.SelectedIndex == -1)
            {
                DialogText.Text = "Выберите численный тип!";
                Dialog.IsOpen = true;
                return;
            }

            var answer = new string[2];
            if (TypePeremen.SelectedIndex == 0)
            {
                sbyte z;
                try
                {
                    z = sbyte.Parse(peremen);
                }
                catch (OverflowException)
                {
                    DialogText.Text = "Число должно быть в диапазоне от " + sbyte.MinValue + " до " + sbyte.MaxValue;
                    Dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    DialogText.Text = "Число введено с ошибками!";
                    Dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<sbyte>((bool) ModeLearn.IsChecked);
                answer = p.Сheck(z);
            }
            else if (TypePeremen.SelectedIndex == 1)
            {
                byte z;
                try
                {
                    z = byte.Parse(peremen);
                }
                catch (OverflowException)
                {
                    DialogText.Text = "Число должно быть в диапазоне от " + byte.MinValue + " до " + byte.MaxValue;
                    Dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    DialogText.Text = "Число введено с ошибками!";
                    Dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<byte>((bool) ModeLearn.IsChecked);
                answer = p.Сheck(z);
            }
            else if (TypePeremen.SelectedIndex == 2)
            {
                short z;
                try
                {
                    z = short.Parse(peremen);
                }
                catch (OverflowException)
                {
                    DialogText.Text = "Число должно быть в диапазоне от " + short.MinValue + " до " + short.MaxValue;
                    Dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    DialogText.Text = "Число введено с ошибками!";
                    Dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<short>((bool) ModeLearn.IsChecked);
                answer = p.Сheck(z);
            }
            else if (TypePeremen.SelectedIndex == 3)
            {
                ushort z;
                try
                {
                    z = ushort.Parse(peremen);
                }
                catch (OverflowException)
                {
                    DialogText.Text = "Число должно быть в диапазоне от " + ushort.MinValue + " до " + ushort.MaxValue;
                    Dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    DialogText.Text = "Число введено с ошибками!";
                    Dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<ushort>((bool) ModeLearn.IsChecked);
                answer = p.Сheck(z);
            }
            else if (TypePeremen.SelectedIndex == 4)
            {
                int z;
                try
                {
                    z = int.Parse(peremen);
                }
                catch (OverflowException)
                {
                    DialogText.Text = "Число должно быть в диапазоне от " + int.MinValue + " до " + int.MaxValue;
                    Dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    DialogText.Text = "Число введено с ошибками!";
                    Dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<int>((bool) ModeLearn.IsChecked);
                answer = p.Сheck(z);
            }
            else if (TypePeremen.SelectedIndex == 5)
            {
                uint z;
                try
                {
                    z = uint.Parse(peremen);
                }
                catch (OverflowException)
                {
                    DialogText.Text = "Число должно быть в диапазоне от " + uint.MinValue + " до " + uint.MaxValue;
                    Dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    DialogText.Text = "Число введено с ошибками!";
                    Dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<uint>((bool) ModeLearn.IsChecked);
                answer = p.Сheck(z);
            }
            else if (TypePeremen.SelectedIndex == 6)
            {
                long z;
                try
                {
                    z = long.Parse(peremen);
                }
                catch (OverflowException)
                {
                    DialogText.Text = "Число должно быть в диапазоне от " + long.MinValue + " до " + long.MaxValue;
                    Dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    DialogText.Text = "Число введено с ошибками!";
                    Dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<long>((bool) ModeLearn.IsChecked);
                answer = p.Сheck(z);
            }
            else if (TypePeremen.SelectedIndex == 7)
            {
                ulong z;
                try
                {
                    z = ulong.Parse(peremen);
                }
                catch (OverflowException)
                {
                    DialogText.Text = "Число должно быть в диапазоне от " + ulong.MinValue + " до " + ulong.MaxValue;
                    Dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    DialogText.Text = "Число введено с ошибками!";
                    Dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<ulong>((bool) ModeLearn.IsChecked);
                answer = p.Сheck(z);
            }
            else if (TypePeremen.SelectedIndex == 8)
            {
                float z;
                try
                {
                    z = float.Parse(peremen);
                }
                catch (OverflowException)
                {
                    DialogText.Text = "Число должно быть в диапазоне от " + float.MinValue + " до " + float.MaxValue;
                    Dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    DialogText.Text = "Число введено с ошибками!";
                    Dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<float>((bool) ModeLearn.IsChecked);
                answer = p.Сheck(z);
            }
            else if (TypePeremen.SelectedIndex == 9)
            {
                double z;
                try
                {
                    z = double.Parse(peremen);
                }
                catch (OverflowException)
                {
                    DialogText.Text = "Число должно быть в диапазоне от " + double.MinValue + " до " + double.MaxValue;
                    Dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    DialogText.Text = "Число введено с ошибками!";
                    Dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<double>((bool) ModeLearn.IsChecked);
                answer = p.Сheck(z);
            }
            else if (TypePeremen.SelectedIndex == 10)
            {
                decimal z;
                try
                {
                    z = decimal.Parse(peremen);
                }
                catch (OverflowException)
                {
                    DialogText.Text = "Число должно быть в диапазоне от " + decimal.MinValue + " до " +
                                      decimal.MaxValue;
                    Dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    DialogText.Text = "Число введено с ошибками!";
                    Dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<decimal>((bool) ModeLearn.IsChecked);
                answer = p.Сheck(z);
            }

            if (answer == null)
            {
                DialogText.Text = "Произошла неизвестная ошибка!";
                Dialog.IsOpen = true;
                return;
            }

            SixTeenBox.Text = answer[0].Trim();
            TwoBox.Text = answer[1].Trim();
        }
    }
}