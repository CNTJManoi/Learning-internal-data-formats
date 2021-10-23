using System.Windows;
using System.Windows.Controls;

namespace CourseProject.Pages
{
    /// <summary>
    ///     Логика взаимодействия для HelpPage.xaml
    /// </summary>
    public partial class HelpPage : UserControl
    {
        private readonly string[] _oneBlockOne =
        {
            "Алгоритм из внутреннего представления во внешнее: ",
            "1) определяется значение знакового разряда;",
            "2.1) если знаковый разряд содержит 1, то  его модуль необходимо перевести из дополнительного кода в прямой, а затем из прямого кода в десятичную систему счисления;",
            "2.2) если знаковый разряд содержит 0, то надо сразу переводить в десятичное представление."
        };

        private readonly string[] _oneBlockTwo =
        {
            "Алгоритм из внешнего во внутренее представление: ",
            "1) Перевести число в двоичное представление. Если число положительное, то добавить нули слева пока не будет необходимое количество битов, иначе перейти к пункту 2.",
            "2) Если число отрицательное, то знаковый разряд равен 1, а число необходимо представить в дополнительном коде. Добавить слева такое количество единиц чтобы размер соответствовал численному типу. ",
            "2.1.) Обратный код получается из прямого путем инвертирования каждого разряда двоичного представления модуля числа;" +
            "\nДополнительный код получается из обратного кода путем прибавления единицы."
        };

        private readonly TextBlock[] _onePanel;

        private readonly string[] _threeBlockOne =
        {
            "Алгоритм из внешнего представления во внутренее:",
            "1) преобразовать число к экспоненциальному виду с приведенной к масимальной разрядности мантиссой;",
            "2) найти двоичные представления мантиссы и порядка; ",
            "3) найти шестнадцатеричное представление числа;",
            "4) расположить числа по схеме выше."
        };

        private readonly string[] _threeBlockTwo =
        {
            "Алгоритм из внутреннего представления во внешнее:",
            "1) Найти значение мантиссы и порядка;",
            "2) Преобразовать число к экспоненциальному виду с приведенной к максимальной разрядности мантиссой; ",
            "3) Перевести в обычный десятичный вид;",
            ""
        };

        private readonly TextBlock[] _threePanel;

        private readonly string[] _twoBlockOne =
        {
            "Алгоритм из внешнего представления во внутренее: ",
            "1) число представляется в двоичном коде и нормализуется. При этом для чисел, больших единицы, плавающая точка переносится влево, определяя положительный порядок. Для чисел, меньших единицы, точка переносится вправо, определяя отрицательный порядок;",
            "2) определяется экспонента e = k + const;",
            "3) определяется значение знакового разряда;",
            "4) в отведенное в памяти поле в соответствии с типом числа записываются знак мантиссы, экспонента и дробная часть мантиссы."
        };

        private readonly string[] _twoBlockTwo =
        {
            "Алгоритм из внутреннего представления во внешнее: ",
            "1) Внутреннее представление разбивается на поля (знаковое, экспонента, дробная часть мантиссы. Указаны выше);",
            "2) Определяется значение знакового разряда s и порядка (k = e - const);",
            "3) Записывается значение числа в двоичном коде;",
            "4) запятая в полученном двоичном числе передвигается на k разрядов вправо (при k >0) или влево (при k <0);\n5) Полученное число переводится в десятичную систему счисления."
        };

        private readonly TextBlock[] _twoPanel;

        public HelpPage()
        {
            InitializeComponent();
            _onePanel = new[]
            {
                Block1Main,
                Block11,
                Block12,
                Block13
            };
            _twoPanel = new[]
            {
                Block2Main,
                Block21,
                Block22,
                Block23,
                Block24
            };
            _threePanel = new[]
            {
                Block3Main,
                Block31,
                Block32,
                Block33,
                Block34
            };
        }

        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            if (Block1Main.Text == _oneBlockOne[0])
                for (var i = 0; i < _oneBlockTwo.Length; i++)
                    _onePanel[i].Text = _oneBlockTwo[i];
            else
                for (var i = 0; i < _oneBlockOne.Length; i++)
                    _onePanel[i].Text = _oneBlockOne[i];
            if (Block2Main.Text == _twoBlockOne[0])
                for (var i = 0; i < _twoBlockTwo.Length; i++)
                    _twoPanel[i].Text = _twoBlockTwo[i];
            else
                for (var i = 0; i < _twoBlockOne.Length; i++)
                    _twoPanel[i].Text = _twoBlockOne[i];
            if (Block3Main.Text == _threeBlockOne[0])
                for (var i = 0; i < _threeBlockTwo.Length; i++)
                    _threePanel[i].Text = _threeBlockTwo[i];
            else
                for (var i = 0; i < _threeBlockOne.Length; i++)
                    _threePanel[i].Text = _threeBlockOne[i];
        }
    }
}