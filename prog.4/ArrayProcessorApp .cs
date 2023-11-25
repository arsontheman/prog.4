using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static prog._4.ArrayProcessorApp;

namespace prog._4
{
    public partial class Form1 : Form
    {
        private ArrayProcessor arrayProcessor;

        public Form1()
        {
            InitializeComponent();
            arrayProcessor = new ArrayProcessor();
        }

        private void btnReadArray_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    arrayProcessor.ReadArrayFromFile(filePath);
                    lblMessage.Text = "Масив успішно зчитано!";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при зчитуванні масиву: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int result = arrayProcessor.CalculateUniqueNumbers();
                lblMessage.Text = $"Кількість унікальних цілих чисел: {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при обчисленні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteResult_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    arrayProcessor.WriteResultToFile(filePath);
                    lblMessage.Text = "Результат успішно записано у файл!";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при записі результату у файл: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}