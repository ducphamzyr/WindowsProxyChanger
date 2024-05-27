using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProxyChanger.Services;

namespace WindowsProxyChanger
{
    public partial class MainForm : Form
    {
        // Another
        public MainForm()
        {
            InitializeComponent();
        }
        // Helper Varable
        [DllImport("wininet.dll", SetLastError = true)]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

        private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        private const int INTERNET_OPTION_REFRESH = 37;
        private const int INTERNET_OPTION_PROXY = 38;
        private const int INTERNET_OPEN_TYPE_PROXY = 3;
        // Main Function
        //
        private void ImportProxy()
        {
            string ChainProxy = tbt_inputProxy.Text;
            if (ChainProxy != null)
            {
                string[] part = ChainProxy.Split(':');
                if (part.Length == 2)
                {
                    tbt_ipProxy.Text = part[0];
                    tbt_portProxy.Text = part[1];
                }
                else if (part.Length == 4)
                {
                    cb_AuthProxy.Checked = true;
                    tbt_ipProxy.Text = part[0];
                    tbt_portProxy.Text = part[1];
                    tbt_usernameProxy.Text = part[2];
                    tbt_passwordProxy.Text = part[3];
                }
                else
                {
                    MessageBox.Show("Định dạng không phù hợp ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Action Function
        private void ThayDoiProxy(string ip, string port)
        {
            string diaChiProxy = $"{ip}:{port}";

            if (string.IsNullOrEmpty(ip) || string.IsNullOrEmpty(port))
            {
                MessageBox.Show("Vui lòng nhập IP và port hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thay đổi proxy
            if (ProxyManager.ThietLapProxy(diaChiProxy))
            {
                ProxyManager.LamMoiCaiDatMang();
                MessageBox.Show($"Đã thay đổi proxy thành: {diaChiProxy}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể thay đổi proxy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThayDoiProxy(string ip, string port, string username, string password)
        {
            string diaChiProxy = $"{ip}:{port}";

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                diaChiProxy += $":{username}:{password}";
            }

            if (string.IsNullOrEmpty(ip) || string.IsNullOrEmpty(port))
            {
                MessageBox.Show("Vui lòng nhập IP và port hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thay đổi proxy
            if (ProxyManager.ThietLapProxy(diaChiProxy))
            {
                ProxyManager.LamMoiCaiDatMang();
                MessageBox.Show($"Đã thay đổi proxy thành: {diaChiProxy}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể thay đổi proxy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaTatCaProxy()
        {
            if (ProxyManager.XoaTatCaProxy())
            {
                MessageBox.Show("Đã xóa tất cả cài đặt proxy.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể xóa cài đặt proxy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Event Function
        private void tbt_inputProxy_Click(object sender, EventArgs e)
        {
            if (tbt_inputProxy.Text == "Nhập proxy tại đây...")
            {
                tbt_inputProxy.Clear();
            }

        }

        private void tbt_ipProxy_Click(object sender, EventArgs e)
        {
            if (tbt_ipProxy.Text == "Ip")
            {
                tbt_ipProxy.Clear();
            }
        }

        private void tbt_portProxy_Click(object sender, EventArgs e)
        {
            if (tbt_portProxy.Text == "Port")
            {
                tbt_portProxy.Clear();
            }
        }

        private void tbt_usernameProxy_Click(object sender, EventArgs e)
        {
            if (tbt_usernameProxy.Text == "Username")
            {
                tbt_usernameProxy.Clear();
            }
        }

        private void tbt_passwordProxy_Click(object sender, EventArgs e)
        {
            if (tbt_passwordProxy.Text == "Password")
            {
                tbt_passwordProxy.Clear();
            }
        }

        private void cb_AuthProxy_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_AuthProxy.Checked)
            {
                tbt_usernameProxy.Enabled = true;
                tbt_passwordProxy.Enabled = true;
            }
            else
            {
                tbt_usernameProxy.Enabled = false;
                tbt_passwordProxy.Enabled = false;
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            ImportProxy();
        }

        private void button1_Click(object sender, EventArgs e) // change proxy
        {
            string ip = tbt_ipProxy.Text.Trim();
            string port = tbt_portProxy.Text.Trim();
            string username = tbt_usernameProxy.Text.Trim();
            string password = tbt_passwordProxy.Text.Trim();
            if (cb_AuthProxy.Checked == true)
            {
                ThayDoiProxy(ip, port, username, password);
            }
            else
            {
                ThayDoiProxy(ip, port);
            }

        }

        private void btn_removeProxy_Click(object sender, EventArgs e)
        {
            XoaTatCaProxy();
        }
    }
}
