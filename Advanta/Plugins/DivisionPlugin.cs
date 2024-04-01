using System;
using System.Drawing;
using System.Drawing.Imaging;
using ds.test.impl.ImagPathFactory;

namespace ds.test.impl;

/// <summary>
/// Класс плагина для деления двух чисел между собой
/// </summary>
public class DivisionPlugin : BasePlugin
{
    public override string PluginName => "Division";
    public override string Version => "1.2";
    public override Image? Image { get; } = new ImageDivisionFactory().CreateImage();
    public override string Description => "Деление одного числа на другое";
    
    /// <summary>
    /// Метод запуска плагина, для деления первого числа <param name="input1"/> на <param name="input2"></param>
    /// </summary>
    /// <param name="input1">Первое число для деления</param>
    /// <param name="input2">Второе число для деления</param>
    /// <returns>Возвращает результат деления</returns>
    /// <exception cref="DivideByZeroException">Исключение возникающее при <param name="input2"/> равном нулю></exception>
    public override int Run(int input1, int input2)
    {
        if (input2 == 0) throw new DivideByZeroException($"argument {nameof(input2)} cannot be zero");
        return input1 / input2;
    }
}