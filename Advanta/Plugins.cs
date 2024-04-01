#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ds.test.impl;


/// <summary>
/// Статический класс предоставляющий возможность управления плагинами
/// Неявно реализует интерфейс <see cref="IPluginFactory"/>
/// </summary>
public static class  Plugins
{
    /// <summary>
    /// Список загруженных плагинов
    /// </summary>
    private static List<IPlugin>? PluginsList { get; set; }

    /// <summary>
    /// Статический конструктор
    /// </summary>
    static Plugins()
    {
        LoudPlugin();
    } 
    /// <summary>
    /// Создаёт экземпляры плагинов с помощью рефлексии из текущей сборки, реализующих интерфейс <see cref="IPlugin"/>
    /// И добавляет их в коллекцию свойство <param name="PluginsList"></param>
    /// </summary>
    private static void LoudPlugin()
    {
        PluginsList = new List<IPlugin>();
        Assembly assembly = Assembly.GetExecutingAssembly();
        Type interfaceType = typeof(IPlugin);
        Type[] types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a => a.GetTypes())
            .Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass && !p.IsAbstract)
            .ToArray();
        foreach (Type type in types)
        {
            PluginsList.Add((IPlugin)Activator.CreateInstance(type));
        }
    }
    /// <summary>
    /// Получает количество загруженных плагинов.
    /// </summary>
    public static int PluginsCount => PluginsList?.Count??0;
    
    /// <summary>
    /// Получает имена всех загруженных плагинов
    /// </summary>
    public static IEnumerable<string> GetPluginNames
    {
        get
        {
            return PluginsList?.Select(p => p.PluginName).ToArray() ?? Array.Empty<string>();
        }
    }
    
    /// <summary>
    /// Возвращает загруженный плагин, который реализует <see cref="IPlugin"/>, по его имени.
    /// </summary>
    /// <param name="pluginName">Имя плагина.</param>
    /// <returns>Возвращает плагин с указанным именем, или null если плагин с указанным именем не найден</returns>
    public static IPlugin? GetPlugin(string pluginName)
    {
        if(string.IsNullOrWhiteSpace(pluginName)) return null;
        return PluginsList?.FirstOrDefault(p => p.PluginName == pluginName);    
    }
}