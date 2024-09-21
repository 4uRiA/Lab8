using System.Drawing;

namespace Lab8var5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            double[] array;
            string[] numbers = textBox1.Text.Split(' ').ToArray();
            array = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = double.Parse(numbers[i]);
                    if (array[i] == 21.25) MessageBox.Show("Это наша группа!"); 
            }
            double min = Min1(array, array.Length);
            double max = Max1(array, array.Length);
            MessageBox.Show($"Минимальный элемент: {min} \n Максимальный элемент: {max}");
            }
            catch (Exception ex) { MessageBox.Show("Ой! Что-то пошло не так, попробуйте снова!"); }
        }
        static double Min1(double[] A, int N)
        {
            double min = A[0];
            for (int i = 1; i < N; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                }
            }
            return min;
        }

        static double Max1(double[] A, int N)
        {
            double max = A[0];
            for (int i = 1; i < N; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }
            return max;
        }
    }
}
