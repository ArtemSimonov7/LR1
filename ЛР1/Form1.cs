using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            //рандомно задается число типа мебели на складе и считается их количество 
   
        {
            //объявление переменной для вычисления суммы 
            int summa = 0; //объявление целочисленной переменной типа int и присвоение ей нулевого значения
            int[] arr = new int[10]; //объявление одномерного целочисленного массива, размером 10 элементов 
            Random rand = new Random(); ///вызов класса рандом для генерации чисел массива

            for (int i = 0; i < 10; i++) //перебор поэлементно значений массива, начиная с 0 элемента
            {
                arr[i] = rand.Next(1, 10); //генерация чисел массива в диапазоне с 1 до 10 
            }
   
            textBox1.Text = string.Join(" ", arr); //вывод массива в виде строки
        //join - сцепляет строки в массив и размещает между заданный разделитель (пробел)
            string str = textBox1.Text;//присвоение  переменной str значения из текстбокс1

            //получение строки из текстового поля и деление посимвольно для записи каждого символа в массив 
            int[] mas = str.Split(' ').Select(int.Parse).ToArray();
            
            for(int i=0;i<mas.Length;i++) //перебор элементов массива от 0 до до конца Length - определяет размерность массива 
            {
                summa += arr[i];//суммирование элементов массива
                textBox2.Text = summa.ToString();//вывод элементов массива в строку в текстбокс2
            }
            
            }
        }
}
