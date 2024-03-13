using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_bbr.src
{
    /// <summary>
    /// Глобальні змінні/константи, типу розмірів, швидкості і тд.
    /// Не використовувати рандомні числа, краще це число винести в іменовану змінну і юзати її.
    /// </summary>
    internal class Common
    {
        public static int WindowHeight { get; set; } = 800;
        public static int WindowWidth { get; set; } = 800;
        public static int TargetFPS { get; set; } = 60;
        public static int BaseSpeed { get; set; } = 200; // швидкість (пікселі/сек)


    }
}
