
using ds.test.impl.ImagPathFactory;

namespace ds.test.impl;
/// <summary>
/// Фабричный класс для создания <see cref="Image"/> со знаком сложения.
/// </summary>
public class ImageAdditionFactory : ImageFactory
{
    /// <summary>
    /// Инициализирует новый экземпляр <see cref="ImageAdditionFactory"/>
    /// </summary>
    /// <param name="keyNameAdditionImg"> Имя конфигурационного ключа в файле App.config. Со значением ссылки на файл изображения знака деления </param>
    public ImageAdditionFactory(string keyNameAdditionImg = "AdditionImgPath") : base(keyNameAdditionImg)
    {
    }
}