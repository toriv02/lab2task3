using lab2task3;
namespace lab2task3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            inputtextBox.Text = Properties.Settings.Default.vvod.ToString();
        }
        private void startbutton_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string ans = Logic.findsum(this.inputtextBox.Text, ref flag).ToString();
            if (flag) { Anserlabel.Text=ans; }
            //очистка
            //this.inputtextBox.Clear();
            //удаление последнего символа если он равен знаку
            if (this.inputtextBox.Text[this.inputtextBox.Text.Length-1] == '+' || this.inputtextBox.Text[this.inputtextBox.Text.Length-1] == '-')
            {
                var rt = "";
                for (int i =0; i < this.inputtextBox.Text.Length-1; i++)
                {
                    rt += this.inputtextBox.Text[i];
                }
                this.inputtextBox.Text = rt;
            }
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            Properties.Settings.Default.vvod = this.inputtextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void inputtextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AcceptButton = startbutton;
            }
        }

    }
}
public class Logic
{
    //логика программы в которой происходит поиск ответа на поставленную задачу с текущими данными
    public static double findsum(string vvod,ref bool flag)//передаю по ссылке флаг для обработки ошибок
    {
        double sum = 0; //счётчик суммы
        double save = 0; //вспомогательная переменная для хранения числа, при его переводе из текста
        int j = 0;//счётчик разрядности, предназначенный для корректного перевода числа
        int countlet = 0; //счётчик цифр
        try //обработка ошибки, при неверно введённом формате данных
        {
            for (int i = vvod.Length; i > 0; i--)//прохолдим строку в обратном порядке
            {
                if (vvod[i - 1] == '+') { sum += save; save = 0; j = 0; } //при виде символа "+" добавляем к значениу переменной sum значение из переменной save
                else if (vvod[i - 1] == '-') { sum -= save; save = 0; j = 0; }//при виде символа "-" добавляем к значениу переменной sum значение из переменной save
                else if (vvod[i - 1] == '.' || vvod[i - 1] == ',') { save /= Math.Pow(10, j); j = 0; }//при виде символа "." или "," делим значение переменной save на разрядность для перехода к вещественному числу
                else
                {
                    save += Math.Pow(10, j) * double.Parse(vvod[i - 1].ToString()); //переводимтекущий символ в число домнажая его на разрядность и сохраняем в переменной save
                    j++;
                    countlet++;
                }
            }
        }
        //обрабатываю ошибку выводя сообщение в отдельном окне и меняя значения flag 
        catch (FormatException) { MessageBox.Show("формат введённых данных некоректен, попробуйте ещё раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); flag = false; return -1; }
        sum += save;
        //обрабатываю ошибку,при отсутствии букв выводя сообщение в отдельном окне 
        if (countlet == 0)
        { MessageBox.Show("формат введённых данных некоректен, попробуйте ещё раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); flag = false; return -1;}
        return sum;
    }
}


