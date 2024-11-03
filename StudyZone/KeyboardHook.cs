using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StudyZone
{
    public class KeyboardHook : IDisposable
    {
        private IntPtr hookId = IntPtr.Zero;
        private LowLevelKeyboardProc proc;

        public KeyboardHook()
        {
            proc = HookCallback;
        }

        public void Install()
        {
            hookId = SetHook(proc);
        }

        public void Uninstall()
        {
            UnhookWindowsHookEx(hookId);
        }

        public void Dispose()
        {
            Uninstall();
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (ProcessModule module = Process.GetCurrentProcess().MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(module.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                // Suppress Alt+Tab, Alt+Esc, Ctrl+Esc, Windows Key
                if (wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN)
                {
                    if (IsKeyCombinationPressed(vkCode))
                    {
                        // Suppress the key event
                        return (IntPtr)1;
                    }
                }
            }

            return CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        private bool IsKeyCombinationPressed(int vkCode)
        {
            Keys key = (Keys)vkCode;

            // Check for Alt+Tab, Alt+Esc
            if ((key == Keys.Tab || key == Keys.Escape) && IsAltPressed())
            {
                return true;
            }

            // Check for Ctrl+Esc
            if (key == Keys.Escape && IsCtrlPressed())
            {
                return true;
            }

            // Check for Windows keys
            if (key == Keys.LWin || key == Keys.RWin)
            {
                return true;
            }

            // Check for Windows Key + Tab
            if (key == Keys.Tab && IsWinPressed())
            {
                return true;
            }

            return false;
        }

        private bool IsAltPressed()
        {
            return (GetKeyState(VK_MENU) & 0x8000) != 0;
        }

        private bool IsCtrlPressed()
        {
            return (GetKeyState(VK_CONTROL) & 0x8000) != 0;
        }

        private bool IsWinPressed()
        {
            return (GetKeyState(VK_LWIN) & 0x8000) != 0 || (GetKeyState(VK_RWIN) & 0x8000) != 0;
        }

        #region WinAPI Functions and Constants

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_SYSKEYDOWN = 0x0104;

        private const int VK_MENU = 0x12;
        private const int VK_CONTROL = 0x11;
        private const int VK_LWIN = 0x5B;
        private const int VK_RWIN = 0x5C;

        [DllImport("user32.dll")]
        private static extern short GetKeyState(int nVirtKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        #endregion
    }
}
