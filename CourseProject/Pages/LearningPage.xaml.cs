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
                dialogText.Text = "Укажите число!";
                dialog.IsOpen = true;
                return;
            }

            peremen = Peremen.Text;
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
                    dialogText.Text = "Число должно быть в диапазоне от " + sbyte.MinValue + " до " + sbyte.MaxValue;
                    dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    dialogText.Text = "Число введено с ошибками!";
                    dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<sbyte>();
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
                    dialogText.Text = "Число должно быть в диапазоне от " + byte.MinValue + " до " + byte.MaxValue;
                    dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    dialogText.Text = "Число введено с ошибками!";
                    dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<byte>();
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
                    dialogText.Text = "Число должно быть в диапазоне от " + short.MinValue + " до " + short.MaxValue;
                    dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    dialogText.Text = "Число введено с ошибками!";
                    dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<short>();
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
                    dialogText.Text = "Число должно быть в диапазоне от " + ushort.MinValue + " до " + ushort.MaxValue;
                    dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    dialogText.Text = "Число введено с ошибками!";
                    dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<ushort>();
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
                    dialogText.Text = "Число должно быть в диапазоне от " + int.MinValue + " до " + int.MaxValue;
                    dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    dialogText.Text = "Число введено с ошибками!";
                    dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<int>();
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
                    dialogText.Text = "Число должно быть в диапазоне от " + uint.MinValue + " до " + uint.MaxValue;
                    dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    dialogText.Text = "Число введено с ошибками!";
                    dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<uint>();
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
                    dialogText.Text = "Число должно быть в диапазоне от " + long.MinValue + " до " + long.MaxValue;
                    dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    dialogText.Text = "Число введено с ошибками!";
                    dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<long>();
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
                    dialogText.Text = "Число должно быть в диапазоне от " + ulong.MinValue + " до " + ulong.MaxValue;
                    dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    dialogText.Text = "Число введено с ошибками!";
                    dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<ulong>();
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
                    dialogText.Text = "Число должно быть в диапазоне от " + float.MinValue + " до " + float.MaxValue;
                    dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    dialogText.Text = "Число введено с ошибками!";
                    dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<float>();
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
                    dialogText.Text = "Число должно быть в диапазоне от " + double.MinValue + " до " + double.MaxValue;
                    dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    dialogText.Text = "Число введено с ошибками!";
                    dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<double>();
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
                    dialogText.Text = "Число должно быть в диапазоне от " + decimal.MinValue + " до " +
                                      decimal.MaxValue;
                    dialog.IsOpen = true;
                    return;
                }
                catch
                {
                    dialogText.Text = "Число введено с ошибками!";
                    dialog.IsOpen = true;
                    return;
                }

                var p = new Pointer<decimal>();
                answer = p.Сheck(z);
            }

            if (answer == null)
            {
                dialogText.Text = "Произошла неизвестная ошибка!";
                dialog.IsOpen = true;
                return;
            }

            SixTeenBox.Text = answer[0].Remove(0, 1);
            TwoBox.Text = answer[1].Remove(0, 1);
        }
    }
}