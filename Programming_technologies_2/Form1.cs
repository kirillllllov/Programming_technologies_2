namespace Programming_technologies_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sentence.Text = Properties.Settings.Default.result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                result = this.sentence.Text;
                
            }
            catch (FormatException) // тип ошибки, которую перехватываем
            {
                return; // прерываем обработчик клика, если ввели какую-то ерунду
            }
            Properties.Settings.Default.result = Logic.CalculateLetterPercentage(result);
            Properties.Settings.Default.Save();

            MessageBox.Show("Вы ввели: " + result + "\n" + Logic.CalculateLetterPercentage(result));

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
