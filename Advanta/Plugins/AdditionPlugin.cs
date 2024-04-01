using System.Drawing;
using System.Net.Mime;

namespace ds.test.impl
{
    /// <summary>
    /// Класс плагина для сложения двух чисел между собой
    /// </summary>
    public class AdditionPlugin : BasePlugin
    {
        public override string PluginName => "Addition";
        public override string Version => "1.0.0";

        public override Image? Image { get; } = new ImageAdditionFactory().CreateImage();

        public override string Description => "сложение двух чисел";
        
        /// <summary>
        /// Метод запуска плагина, для сложения двух чисел между собой
        /// </summary>
        /// <param name="input1">Первое число для сложения</param>
        /// <param name="input2">Второе число для сложения</param>
        /// <returns>Возвращает результат сложения</returns>
        public override int Run(int input1, int input2)
        {
            return input1 + input2;
        }

    }
}