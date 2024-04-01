namespace ds.test.impl.ImagPathFactory;


/// <summary>
/// Фабричный класс для создания <see cref="Image"/> со знаком вычитания.
/// </summary>
public class ImageSubtractionFactory : ImageFactory
{
    /// <summary>
    /// Инициализирует новый экземпляр <see cref="ImageMultiplicationFactory"/>
    /// </summary>
    /// <param name="keyNameSubtraction"> Имя конфигурационного ключа в файле App.config. Со значением ссылки на файл изображения знака деления </param>
    public ImageSubtractionFactory(string keyNameSubtraction = "SubtractionImgPath") : base(keyNameSubtraction)
    {
    }
}