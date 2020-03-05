using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newFields
{
    public class Fields
    {
        /*Переменные, отвечающие за количество используемых строк и столбцов из массива Articles*/
        public int Rows, Columns = 32;
        /*Создаем двумерный массив, в котором будут храниться данные по каждой статье и дню. Задаем 50 строк, чтобы можно было создавать много статей (на перспективу) */
        public string[,] Articles = new string[50, 32];
        /*Конструктор класса, в котором мы сразу при создании объекта определяем количество используемых строк из массива Articles */
        public Fields(int rows)
        {
            Rows = rows;
        }

        /*Метод, который задает значения первого столбца массива Articles из передаваемого в него массива*/
        public void SetFirstColumn(string[] mas)
        {
            Articles[0, 0] = "Статья/День\t";
            for (int i = 1; i < Rows; i++)
            {
                Articles[i, 0] = mas[i - 1];
            }
        }

        /* Метод, который присваивает значениям первой строки массива Articles значения дней месяца */
        public void SetDayNumbers()
        {
            for (int i = 1; i <= Columns - 1; i++)
                Articles[0, i] = Convert.ToString(i);
        }

        // Метод, который построчно выводит все значения массива Articles 
        public string Output()
        {
            string str = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (Articles[i, j] != null)
                        str = str + Articles[i, j] + " \t";
                    else
                        str = str + "- \t";
                }
                str = str + "\r\n";
            }
            return str;
        }

        //Метод, который считает сумму всех элементов массива Articles
        public int SumOfElements()
        {
            int iSum = 0;
            for (int i = 1; i < Rows; i++)
                for (int j = 1; j < Columns; j++)
                    if (Articles[i, j] != "" && Articles[i, j] != "-")
                        iSum = iSum + Convert.ToInt32(Articles[i, j]);
            return iSum;
        }

        public void Clear()
        {
            for (int i = 1; i < Rows; i++)
            {
                for (int j = 1; j < Columns; j++)
                {
                    Articles[i, j] = "-";
                }
            }
        }
    }
}
