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
            //�������
            //this.inputtextBox.Clear();
            //�������� ���������� ������� ���� �� ����� �����
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
    //������ ��������� � ������� ���������� ����� ������ �� ������������ ������ � �������� �������
    public static double findsum(string vvod,ref bool flag)//������� �� ������ ���� ��� ��������� ������
    {
        double sum = 0; //������� �����
        double save = 0; //��������������� ���������� ��� �������� �����, ��� ��� �������� �� ������
        int j = 0;//������� �����������, ��������������� ��� ����������� �������� �����
        int countlet = 0; //������� ����
        try //��������� ������, ��� ������� �������� ������� ������
        {
            for (int i = vvod.Length; i > 0; i--)//��������� ������ � �������� �������
            {
                if (vvod[i - 1] == '+') { sum += save; save = 0; j = 0; } //��� ���� ������� "+" ��������� � �������� ���������� sum �������� �� ���������� save
                else if (vvod[i - 1] == '-') { sum -= save; save = 0; j = 0; }//��� ���� ������� "-" ��������� � �������� ���������� sum �������� �� ���������� save
                else if (vvod[i - 1] == '.' || vvod[i - 1] == ',') { save /= Math.Pow(10, j); j = 0; }//��� ���� ������� "." ��� "," ����� �������� ���������� save �� ����������� ��� �������� � ������������� �����
                else
                {
                    save += Math.Pow(10, j) * double.Parse(vvod[i - 1].ToString()); //���������������� ������ � ����� �������� ��� �� ����������� � ��������� � ���������� save
                    j++;
                    countlet++;
                }
            }
        }
        //����������� ������ ������ ��������� � ��������� ���� � ����� �������� flag 
        catch (FormatException) { MessageBox.Show("������ �������� ������ ����������, ���������� ��� ���", "������", MessageBoxButtons.OK, MessageBoxIcon.Error); flag = false; return -1; }
        sum += save;
        //����������� ������,��� ���������� ���� ������ ��������� � ��������� ���� 
        if (countlet == 0)
        { MessageBox.Show("������ �������� ������ ����������, ���������� ��� ���", "������", MessageBoxButtons.OK, MessageBoxIcon.Error); flag = false; return -1;}
        return sum;
    }
}


