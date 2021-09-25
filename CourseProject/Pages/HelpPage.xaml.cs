using System.Windows;
using System.Windows.Controls;

namespace CourseProject.Pages
{
    /// <summary>
    ///     Логика взаимодействия для HelpPage.xaml
    /// </summary>
    public partial class HelpPage : UserControl
    {
        private readonly string[] OneBlockOne =
        {
            "Алгоритм из внутреннего представления во внешнее: ",
            "1) определяется значение знакового разряда;",
            "2.1) если знаковый разряд содержит 1, то  его модуль необходимо перевести из дополнительного кода в прямой, а затем из прямого кода в десятичную систему счисления;",
            "2.2) если знаковый разряд содержит 0, то надо сразу переводить в десятичное представление."
        };

        private readonly string[] OneBlockTwo =
        {
            "Алгоритм из внешнего во внутренее представление: ",
            "1) Перевести число в двоичное представление. Если число положительное, то добавить нули слева пока не будет необходимое количество битов, иначе перейти к пункту 2.",
            "2) Если число отрицательное, то знаковый разряд равен 1, а число необходимо представить в дополнительном коде. Добавить слева такое количество единиц чтобы размер соответствовал численному типу. ",
            "2.1.) Обратный код получается из прямого путем инвертирования каждого разряда двоичного представления модуля числа;" +
            "\nДополнительный код получается из обратного кода путем прибавления единицы."
        };

        private readonly TextBlock[] OnePanel;

        private readonly string[] ThreeBlockOne =
        {
            "Алгоритм из внешнего представления во внутренее:",
            "1) преобразовать число к экспоненциальному виду с приведенной к масимальной разрядности мантиссой;",
            "2) найти двоичные представления мантиссы и порядка; ",
            "3) найти шестнадцатеричное представление числа;",
            "4) расположить числа по схеме выше."
        };

        private readonly string[] ThreeBlockTwo =
        {
            "Алгоритм из внутреннего представления во внешнее:",
            "1) Найти значение мантиссы и порядка;",
            "2) Преобразовать число к экспоненциальному виду с приведенной к максимальной разрядности мантиссой; ",
            "3) Перевести в обычный десятичный вид;",
            ""
        };

        private readonly TextBlock[] ThreePanel;

        private readonly string[] TwoBlockOne =
        {
            "Алгоритм из внешнего представления во внутренее: ",
            "1) число представляется в двоичном коде и нормализуется. При этом для чисел, больших единицы, плавающая точка переносится влево, определяя положительный порядок. Для чисел, меньших единицы, точка переносится вправо, определяя отрицательный порядок;",
            "2) определяется экспонента e = k + const;",
            "3) определяется значение знакового разряда;",
            "4) в отведенное в памяти поле в соответствии с типом числа записываются знак мантиссы, экспонента и дробная часть мантиссы."
        };

        private readonly string[] TwoBlockTwo =
        {
            "Алгоритм из внутреннего представления во внешнее: ",
            "1) Внутреннее представление разбивается на поля (знаковое, экспонента, дробная часть мантиссы. Указаны выше);",
            "2) Определяется значение знакового разряда s и порядка (k = e - const);",
            "3) Записывается значение числа в двоичном коде;",
            "4) запятая в полученном двоичном числе передвигается на k разрядов вправо (при k >0) или влево (при k <0);\n5) Полученное число переводится в десятичную систему счисления."
        };

        private readonly TextBlock[] TwoPanel;

        public HelpPage()
        {
            InitializeComponent();
            OnePanel = new[]
            {
                Block1Main,
                Block11,
                Block12,
                Block13
            };
            TwoPanel = new[]
            {
                Block2Main,
                Block21,
                Block22,
                Block23,
                Block24
            };
            ThreePanel = new[]
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
            if (Block1Main.Text == OneBlockOne[0])
                for (var i = 0; i < OneBlockTwo.Length; i++)
                    OnePanel[i].Text = OneBlockTwo[i];
            else
                for (var i = 0; i < OneBlockOne.Length; i++)
                    OnePanel[i].Text = OneBlockOne[i];
            if (Block2Main.Text == TwoBlockOne[0])
                for (var i = 0; i < TwoBlockTwo.Length; i++)
                    TwoPanel[i].Text = TwoBlockTwo[i];
            else
                for (var i = 0; i < TwoBlockOne.Length; i++)
                    TwoPanel[i].Text = TwoBlockOne[i];
            if (Block3Main.Text == ThreeBlockOne[0])
                for (var i = 0; i < ThreeBlockTwo.Length; i++)
                    ThreePanel[i].Text = ThreeBlockTwo[i];
            else
                for (var i = 0; i < ThreeBlockOne.Length; i++)
                    ThreePanel[i].Text = ThreeBlockOne[i];
        }
    }
}