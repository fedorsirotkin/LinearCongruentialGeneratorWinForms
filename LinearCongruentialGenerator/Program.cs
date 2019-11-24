using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearCongruentialGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

    /**
     * Линейный конгруэнтный генератор
     */
    class RandomNumberGenerator
    {
        private long a; // Множитель, где 0 <= a < m
        private long c; // Приращение, где 0 <= с < m
        private long m; // Модуль, где 0 < m (2^32)
        private double ni; // Случайная величина

        // Конструктор
        public RandomNumberGenerator(long _a, long _c, long _m)
        {
            a = _a; c = _c; m = _m;
            ni = DateTime.Now.Ticks % m;  // Число тактов от текущей даты
        }

        /**
         * Получение случайной величины
         */
        public double Next()
        {
            ni = ((a * ni) + c) % m;
            return ni;
        }

        /**
         *  Получение случайной величины с учетом максимального значения
         */
        public double Next(long maxValue)
        {
            return Next() % maxValue;
        }
    }

    static class Debug
    {
        public static void debugMsg(string message)
        {
            const string caption = "Debug";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }
    }
}
