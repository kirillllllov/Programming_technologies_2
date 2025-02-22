namespace Programming_technologies_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sentence.Text = Properties.Settings.Default.result.ToString();
            this.KeyPreview = true; // Позволяет форме перехватывать нажатия клавиш
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick(); // Имитируем клик по кнопке
                e.SuppressKeyPress = true; // Предотвращаем стандартный звуковой сигнал
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = this.sentence.Text.Trim(); // Убираем лишние пробелы

            if (string.IsNullOrEmpty(result)) // Проверяем, пуст ли текст
            {
                return; // Если да, просто выходим из метода
            }

            try
            {
                Properties.Settings.Default.result = Logic.CalculateLetterPercentage(result);
                Properties.Settings.Default.Save();

                MessageBox.Show("Вы ввели: " + result + "\n" + Logic.CalculateLetterPercentage(result));
            }
            catch (FormatException)
            {
                return;
            }
        }

        public class Logic
        {
            public double percentage;
            public static string CalculateLetterPercentage(string input)
            {
                // Подсчёт общего количества символов и количества букв
                int totalChars = input.Length;
                int letterCount = input.Count(char.IsLetter);

                // Вычисление процента букв
                double percentage = Math.Round(((double)letterCount / totalChars * 100), 2);
                string output = $"Доля букв в предложении:  {percentage}%";
                return output;

            }
        }

    }
}
