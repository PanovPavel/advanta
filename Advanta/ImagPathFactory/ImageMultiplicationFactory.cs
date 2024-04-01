namespace ds.test.impl.ImagPathFactory;


/// <summary>
/// Фабричный класс для создания <see cref="Image"/> со знаком умножения.
/// </summary>
public class ImageMultiplicationFactory : ImageFactory
{
    /// <summary>
    /// Инициализирует новый экземпляр <see cref="ImageMultiplicationFactory"/>
    /// </summary>
    /// <param name="keyNameMultiplication"> Имя конфигурационного ключа в файле App.config. Со значением ссылки на файл изображения знака деления </param>
    public ImageMultiplicationFactory(string keyNameMultiplication = "MultiplicationImgPath") : base(keyNameMultiplication)
    {
    }
}