using System.Drawing;

namespace ds.test.impl.ImagPathFactory;

/// <summary>
/// Фабричный класс для создания <see cref="Image"/> со знаком деления.
/// </summary>
public class ImageDivisionFactory : ImageFactory
{
    /// <summary>
    /// Инициализирует новый экземпляр <see cref="ImageDivisionFactory"/>
    /// </summary>
    /// <param name="keyNameDivision"> Имя конфигурационного ключа в файле App.config. Со значением ссылки на файл изображения знака деления </param>
    public ImageDivisionFactory(string keyNameDivision = "DivisionImagePath") : base(keyNameDivision)
    {
    }
}