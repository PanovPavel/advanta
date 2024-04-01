using System.Drawing;
using ds.test.impl.ImagPathFactory;

namespace ds.test.impl;

/// <summary>
/// Класс плагина для умножения двух чисел между собой
/// </summary>
public class MultiplicationPlugin : BasePlugin
{
    public override string PluginName => "Multiplication";
    public override string Version => "1.2";
    public override Image? Image { get; } = new ImageMultiplicationFactory().CreateImage();
    public override string Description => "умножает два числа";
    
    /// <summary>
    /// Метод запуска плагина, для умножения первого числа <param name="input1"/> на <param name="input2"></param>
    /// </summary>
    /// <param name="input1">Первое число для умножения</param>
    /// <param name="input2">Второе число для умножения</param>
    /// <returns>Возвращает результат умножения</returns>
    public override int Run(int input1, int input2)
    {
        return input1*input2;
    }
}