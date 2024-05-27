using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProxyChanger.Services
{
    public class ProxyManager
    {
        [DllImport("wininet.dll", SetLastError = true)]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

        private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        private const int INTERNET_OPTION_REFRESH = 37;
        private const int INTERNET_OPTION_PROXY = 38;
        private const int INTERNET_OPEN_TYPE_PROXY = 3;

        public static bool ThietLapProxy(string diaChiProxy)
        {
            IntPtr hInternet = InternetOpen("ProxySetup", INTERNET_OPEN_TYPE_PROXY, diaChiProxy, null, 0);
            if (hInternet == IntPtr.Zero)
            {
                return false;
            }
            InternetCloseHandle(hInternet);
            return true;
        }

        public static void LamMoiCaiDatMang()
        {
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        public static bool XoaTatCaProxy()
        {
            return ThietLapProxy(" ");
        }

        [DllImport("wininet.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr InternetOpen(string lpszAgent, int dwAccessType, string lpszProxyName, string lpszProxyBypass, int dwFlags);

        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetCloseHandle(IntPtr hInternet);
    }
}
