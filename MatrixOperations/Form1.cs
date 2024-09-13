namespace MatrixApp
{
    public partial class Form1 : Form
    {
        private double[,] matrix;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            matrix = new double[4, 6];
            GenerateTask1Matrix();
            DisplayMatrix(matrix);

            CalculateTask1Results();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            matrix = new double[4, 8];
            GenerateTask2Matrix();
            DisplayMatrix(matrix);

            CalculateTask2Results();
        }

        private void GenerateTask1Matrix()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = random.Next(-100, 100) / 10.0;
                }
            }
        }

        private void GenerateTask2Matrix()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = random.Next(-100, 100) / 10.0;
                }
            }
        }

        private void DisplayMatrix(double[,] matrix)
        {
            matrixTextBox.Clear();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixTextBox.AppendText($"{matrix[i, j]:0.00}\t");
                }
                matrixTextBox.AppendText(Environment.NewLine);
            }
        }

        private void CalculateTask1Results()
        {
            double sumPositive = 0;
            double productNegative = 1;
            bool hasNegative = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sumPositive += matrix[i, j];
                    }
                    else if (matrix[i, j] < 0)
                    {
                        productNegative *= matrix[i, j];
                        hasNegative = true;
                    }
                }
            }

            resultsTextBox.Text = $"Sum of positive elements: {sumPositive:0.00}" + Environment.NewLine;
            resultsTextBox.Text += hasNegative ? $"Product of negative elements: {productNegative:0.00}" : "No negative elements";
        }

        private void CalculateTask2Results()
        {
            int positiveCount = 0;
            int negativeCount = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        positiveCount++;
                    }
                    else if (matrix[i, j] < 0)
                    {
                        negativeCount++;
                    }
                }
            }

            resultsTextBox.Text = $"Number of positive elements: {positiveCount}" + Environment.NewLine;
            resultsTextBox.Text += $"Number of negative elements: {negativeCount}";
        }
    }
}
