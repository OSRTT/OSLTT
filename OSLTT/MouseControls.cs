using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OSLTT
{

    class MouseControls
    {
        [DllImport("User32.dll")]
        static extern Boolean SystemParametersInfo(UInt32 uiAction,UInt32 uiParam,IntPtr pvParam,UInt32 fWinIni);

        [DllImport("user32.dll")]
        public static extern int SystemParametersInfo(int uAction, int uParam, IntPtr lpvParam, int fuWinIni);

        public const int SPI_GETMOUSESPEED = 112;
        public const int SPI_SETMOUSESPEED = 113;


        private static int originalSpeed = 10;
        private static int intCurrentSpeed;
        private static int intNewSpeed;

        public static void GetDefaults()
        {
            intCurrentSpeed = GetMouseSpeed();
        }
        public static void ResetToOriginal()
        {
            SetMouseSpeed(originalSpeed);
        }

        public static int GetMouseSpeed()
        {
            int intSpeed = 0;
            IntPtr ptr;
            ptr = Marshal.AllocCoTaskMem(4);
            SystemParametersInfo(SPI_GETMOUSESPEED, 0, ptr, 0);
            intSpeed = Marshal.ReadInt32(ptr);
            Marshal.FreeCoTaskMem(ptr);

            return intSpeed;
        }

        public static void SetMaxSpeed()
        {
            SetMouseSpeed(20);
        }

        public static void SetMouseSpeed(int intSpeed)
        {
            IntPtr ptr = new IntPtr(intSpeed);

            int b = SystemParametersInfo(SPI_SETMOUSESPEED, 0, ptr, 0);

            if (b == 0)
            {
                Console.WriteLine("Not able to set speed"); // bring up dialog?
            }
            else if (b == 1)
            {
                Console.WriteLine("Successfully done");
            }

        }


    }
}
