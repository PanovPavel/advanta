using System.Drawing;

namespace ds.test.impl
{
    /// <summary>
    /// Абстрактный класс создания плагина реализующий интерфейс <see cref="IPlugin"/>
    /// </summary>
    public abstract class BasePlugin : IPlugin
    {
        
        /// <summary>
        /// PluginName возвращает имя плагина
        /// </summary>
        public abstract string PluginName { get; }
        
        /// <summary>
        /// Version возвращает версию плагина
        /// </summary>
        public abstract string Version { get; }
        
        /// <summary>
        /// Image возвращает изображение плагина
        /// </summary>
        public abstract Image? Image { get; }
        
        /// <summary>
        /// Description возвращает описание плагина
        /// </summary>
        public abstract string Description { get; }
        
        /// <summary>
        /// Метод запуска плагина, принимает два параметра и возвразает пезультат взаимодействия этих параметров
        /// </summary>
        /// <param name="input1">Первый параметр используемый методом</param>
        /// <param name="input2">Второй параметр используемый методом</param>
        /// <returns>Результат взаимодействия параметров в плагине</returns>
        public abstract int Run(int input1, int input2);
        
        /// <summary>
        /// Equals сравнивает два экземпляра объекта реализующих <see cref="BasePlugin"/>  
        /// </summary>
        /// <param name="obj">Экземпляр объекта для сравнения</param>
        /// <returns>Возвращает true если значения свойств объектов равны, или false при неравенстве</returns>
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType() || obj is not BasePlugin)
            {
                return false;
            }
            var other = (BasePlugin)obj;
            return PluginName == other.PluginName &&
                   Version == other.Version &&
                   IsImageEquals(other) &&
                   Description == other.Description;
        }
        
        /// <summary>
        /// Возвразает HashCode экземпляра объекта <see cref="BasePlugin"/>
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = PluginName.GetHashCode();
                hashCode = (hashCode * 397) ^ Version.GetHashCode();
                hashCode = (hashCode * 397) ^ (Image != null ? Image.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Description.GetHashCode();
                return hashCode;
            }
        }
        
        /// <summary>
        /// Приватный метод сравнивает свойства объектов  <see cref="Image"/>
        /// </summary>
        /// <param name="other">Объект со свойством <see cref="Image"/> которое необходимо сравнить </param>
        /// <returns>True если <see cref="Image"/> одинаковые. False если <see cref="Image"/> отличаются </returns>
        private bool IsImageEquals(BasePlugin other)
        {
            if (Image == null && other.Image == null) return true;
            if ((Image == null && other.Image != null) || (Image != null && other.Image == null)) return false;
            if (Image == null || other.Image == null)
            {
                return false;
            }
            Bitmap bmp1 = new Bitmap(Image);
            Bitmap bmp2 = new Bitmap(other.Image);
            if (bmp1.Size != bmp2.Size)
            {
                return false;
            }

            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                    {
                        return false; 
                    }
                }
            }
            return true;
        }
    }
}