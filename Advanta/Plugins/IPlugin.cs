using System.Drawing;

namespace ds.test.impl
{
    /// <summary>
    /// Определяет набор методов реализуемые плагином
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Возвращает имя плагина
        /// </summary>
        string PluginName { get; }
        
        /// <summary>
        /// Возвращает версию плагина
        /// </summary>
        string Version { get; }
        
        /// <summary>
        /// Image возвращает изображение плагина
        /// </summary>
        Image? Image { get; }
        
        /// <summary>
        /// Возвращает описание плагина
        /// </summary>
        string Description { get; }
        
        /// <summary>
        /// Метод запуска плагина, принимает два параметра и возвразает пезультат взаимодействия этих параметров
        /// </summary>
        /// <param name="input1">Первый параметр используемый методом</param>
        /// <param name="input2">Второй параметр используемый методом</param>
        /// <returns>Результат взаимодействия параметров в плагине</returns>
        int Run (int input1, int input2);
    }
}