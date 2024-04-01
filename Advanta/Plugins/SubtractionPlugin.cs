using System.Drawing;
using ds.test.impl.ImagPathFactory;

namespace ds.test.impl;


/// <summary>
/// Класс плагина для получения разницы двух чисел
/// </summary>
public class SubtractionPlugin : BasePlugin
{
    public override string PluginName => "Subtraction";
    public override string Version => "1.0";
    public override Image? Image { get; } = new ImageSubtractionFactory().CreateImage();
    public override string Description => "Вычитание двух чисел";
    /// <summary>
    /// Метод запуска плагина, для вычитания числа <param name="input2"/> из числа <param name="input1"></param>
    /// </summary>
    /// <param name="input1">Первое число из которого производится вычитание</param>
    /// <param name="input2">Второе число которое необходимо вычесть</param>
    /// <returns>Возвращает результат вычитания</returns>
    public override int Run(int input1, int input2)
    {
        return input1 - input2;
    }
}