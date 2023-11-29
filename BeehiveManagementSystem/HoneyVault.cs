using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    static class HoneyVault
    {
        const float NECTAR_CONVERSION_RATIO = 0.19f;
        const float LOW_LEVEL_WARNING = 10f;

        private static float honey = 25;
        private static float nectar = 100f;

        public static void ConvertNectartoHoney(float amount)
        {
            if (amount > nectar)
            {
                honey += nectar * NECTAR_CONVERSION_RATIO;
                nectar = 0;
            }
            nectar -= amount;
            honey += amount * NECTAR_CONVERSION_RATIO;
        }

        public static bool ConsumeHoney(float amount)
        {
            if (amount < honey)
            {
                honey -= amount;
                return true;
            }
            return false;
        }

        public static void CollectNectar(float amount)
        {
            if(amount > 0f)
                nectar += amount;
        }

        public static string StatusReport
        {
            get
            {
                if (honey < LOW_LEVEL_WARNING) Console.WriteLine("LOW HONEY - ADD AHONEY");
                if (nectar < LOW_LEVEL_WARNING) Console.WriteLine("LOW NECTAR - ADD NECTAR");
                return $"Honey - {honey}; Nectar - {nectar}";
            }
            
        }
    }   

}
