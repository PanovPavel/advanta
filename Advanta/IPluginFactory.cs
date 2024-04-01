namespace ds.test.impl
{
    /// <summary>
    /// Набор методов для взаимодействия с набором плагинов
    /// </summary>
    public interface IPluginFactory
    {
        /// <summary>
        /// Возвразает количество плагинов
        /// </summary>
        int PluginsCount { get; }
        
        /// <summary>
        /// Возвращает массив string[] с наименованиями плагинов
        /// </summary>
        string[] GetPluginNames { get; }
        
        /// <summary>
        /// Фабричный метод получения экземпляра плагина по его имени
        /// </summary>
        /// <param name="pluginName">Наименование плагина</param>
        /// <returns>Возвращает плагин реализующий интерфейс <see cref="IPluginFactory"/></returns>
        IPlugin GetPlugin (string pluginName);
    }
}