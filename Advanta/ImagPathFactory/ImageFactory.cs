using System.Configuration;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace ds.test.impl.ImagPathFactory;

/// <summary>
/// Абстрактный класс, который предоставляет способ создания <seealso cref="Image"/> на основе конфигурационного ключа.
/// Используя значения ссылки на файл изображения из файла конфигурации App.config.
/// </summary>
public abstract class ImageFactory
{
    /// <summary>
    /// Путь к файлу изображения
    /// </summary>
    private string _imagePath;
    
    /// <summary>
    /// Конструктор класса <seealso cref="ImageFactory"/> для иницииализации пути к файлу изображения
    /// Инициализирует путь к файлу изображения из полученного значения файла App.config
    /// </summary>
    /// <param name="keyName">Имя ключа конфигурации используемого в файле App.config</param>
    protected ImageFactory(string keyName)
    {
        _imagePath = ConfigurationManager.AppSettings[keyName];
    }
    
    /// <summary>
    /// Возвращает объект класса <seealso cref="Image"/>
    /// или null если файл изображения не существует по указонному в конструкрторе <see cref="ImageFactory(string)"/> пути,
    /// или если путь равен null или пустой строке/>
    /// </summary>
    /// <returns>Возвращает объект <see cref="Image"/> из указанного файла</returns>
    public Image? CreateImage()
    {
        if (string.IsNullOrEmpty(_imagePath))
        {
            return null;
        }
        if (!File.Exists(_imagePath))
        {
            return null;
        }

        return Image.FromFile(_imagePath);   
    }
}