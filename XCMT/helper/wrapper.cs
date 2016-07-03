using System;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Input;
using System.Windows.Forms;
using System.Collections;

namespace XCMT.helper
{
    class wrapper
    {
        #region GetActiveWindowTitle //ist für den Titel der aktiven anwendung zuständig
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        public static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            IntPtr handle = IntPtr.Zero;
            StringBuilder Buff = new StringBuilder(nChars);
            handle = GetForegroundWindow();
            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return "Desktop";
        }
        #endregion

        #region SendInput //für die Eingaben veranwortlich
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        [StructLayout(LayoutKind.Explicit)]
        public struct INPUT
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(4)]
            public MOUSEINPUT mi;
            [FieldOffset(4)]
            public KEYBDINPUT ki;
            [FieldOffset(4)]
            public HARDWAREINPUT hi;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HARDWAREINPUT
        {
            public uint uMsg;
            public ushort wParamL;
            public ushort wParamH;
        }

        public const byte INPUT_MOUSE = 0;
        public const byte INPUT_KEYBOARD = 1;
        public const byte INPUT_HARDWARE = 2;
        #endregion

        #region Hotkey //für die Hotkey(un)registrierung zuständig
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern int RegisterHotKey(IntPtr Hwnd, int ID, int Modifiers, int Key);
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern int UnregisterHotKey(IntPtr Hwnd, int ID);

        public const int WM_ALT = 1;
        public const int WM_CONTROL = 2;
        public const int WM_SHIFT = 4;
        public const int WM_WIN = 8;
        public const int WM_HOTKEY = 0x312;
        #endregion
    }

    class hash
    {
        public static string[] key_;
        public static byte[] code_;
        public static Hashtable code_key = new Hashtable();
        public static Hashtable key_code = new Hashtable();
        public static Hashtable mouse_code = new Hashtable();

        public static void fill()
        {
            #region key_ //string
            key_ = new string[]{
            "BACKSPACE",
            "TAB",
            "CLEAR",
            "ENTER",
            "SHIFT",
            "CTRL",
            "ALT",
            "PAUSE",
            "CAPS LOCK",
            "IME Kana mode",
            "IME Junja mode",
            "IME final mode",
            "IME Hanja mode",
            "ESC",
            "IME convert",
            "IME nonconvert",
            "IME accept",
            "IME mode change request",
            "SPACEBAR",
            "PAGE UP",
            "PAGE DOWN",
            "END",
            "HOME",
            "LEFT ARROW",
            "UP ARROW",
            "RIGHT ARROW",
            "DOWN ARROW",
            "SELECT",
            "PRINT",
            "EXECUTE",
            "PRINT SCREEN",
            "INS",
            "DEL",
            "HELP",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "Left Windows",
            "Right Windows",
            "Applications",
            "Computer Sleep",
            "Numericpad 0",
            "Numericpad 1",
            "Numericpad 2",
            "Numericpad 3",
            "Numericpad 4",
            "Numericpad 5",
            "Numericpad 6",
            "Numericpad 7",
            "Numericpad 8",
            "Numericpad 9",
            "Multiply",
            "Add",
            "Separator",
            "Subtract",
            "Decimal",
            "Divide",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "F13",
            "F14",
            "F15",
            "F16",
            "F17",
            "F18",
            "F19",
            "F20",
            "F21",
            "F22",
            "F23",
            "F24",
            "NUM LOCK",
            "SCROLL LOCK",
            "Left SHIFT",
            "Right SHIFT",
            "Left CONTROL",
            "Right CONTROL",
            "Left ALT",
            "Right ALT",
            "Browser Back",
            "Browser Forward",
            "Browser Refresh",
            "Browser Stop",
            "Browser Search",
            "Browser Favorites",
            "Browser Start and Home",
            "Volume Mute",
            "Volume Down",
            "Volume Up",
            "Next Track",
            "Previous Track",
            "Stop Media",
            "Play/Pause Media",
            "Start Mail",
            "Select Media",
            "Start Application 1",
            "Start Application 2",
            "For any country '+'",
            "For any country ','",
            "For any country '-'",
            "For any country'.'",
            "Reserved",
            "OEM specific1",
            "IME PROCESS",
            "OEM specific2",
            "Attn",
            "CrSel",
            "ExSel",
            "Erase EOF",
            "Play",
            "Zoom",
            "PA1",
            "Clear",
        };
            #endregion
            #region code_ //byte
            code_ = new byte[]{
                0x08,
                0x09,
                0x0C,
                0x0D,
                0x10,
                0x11,
                0x12,
                0x13,
                0x14,
                0x15,
                0x17,
                0x18,
                0x19,
                0x1B,
                0x1C,
                0x1D,
                0x1E,
                0x1F,
                0x20,
                0x21,
                0x22,
                0x23,
                0x24,
                0x25,
                0x26,
                0x27,
                0x28,
                0x29,
                0x2A,
                0x2B,
                0x2C,
                0x2D,
                0x2E,
                0x2F,
                0x30,
                0x31,
                0x32,
                0x33,
                0x34,
                0x35,
                0x36,
                0x37,
                0x38,
                0x39,
                0x41,
                0x42,
                0x43,
                0x44,
                0x45,
                0x46,
                0x47,
                0x48,
                0x49,
                0x4A,
                0x4B,
                0x4C,
                0x4D,
                0x4E,
                0x4F,
                0x50,
                0x51,
                0x52,
                0x53,
                0x54,
                0x55,
                0x56,
                0x57,
                0x58,
                0x59,
                0x5A,
                0x5B,
                0x5C,
                0x5D,
                0x5F,
                0x60,
                0x61,
                0x62,
                0x63,
                0x64,
                0x65,
                0x66,
                0x67,
                0x68,
                0x69,
                0x6A,
                0x6B,
                0x6C,
                0x6D,
                0x6E,
                0x6F,
                0x70,
                0x71,
                0x72,
                0x73,
                0x74,
                0x75,
                0x76,
                0x77,
                0x78,
                0x79,
                0x7A,
                0x7B,
                0x7C,
                0x7D,
                0x7E,
                0x7F,
                0x80,
                0x81,
                0x82,
                0x83,
                0x84,
                0x85,
                0x86,
                0x87,
                0x90,
                0x91,
                0xA0,
                0xA1,
                0xA2,
                0xA3,
                0xA4,
                0xA5,
                0xA6,
                0xA7,
                0xA8,
                0xA9,
                0xAA,
                0xAB,
                0xAC,
                0xAD,
                0xAE,
                0xAF,
                0xB0,
                0xB1,
                0xB2,
                0xB3,
                0xB4,
                0xB5,
                0xB6,
                0xB7,
                0xBB,
                0xBC,
                0xBD,
                0xBE,
                0xE0,
                0xE1,
                0xE5,
                0xE6,
                0xF6,
                0xF7,
                0xF8,
                0xF9,
                0xFA,
                0xFB,
                0xFD,
                0xFE,
            };
            #endregion

            byte i = 0;
            for (i = 0; i < key_.Length; i++) code_key.Add(code_[i], key_[i]);
            for (i = 0; i < key_.Length; i++) key_code.Add(key_[i], code_[i]);
            
            mouse_code.Add("MOVE", 0x0001);
            mouse_code.Add("LEFT", 0x0002);
            mouse_code.Add("RIGHT", 0x0008);
            mouse_code.Add("MIDDLE", 0x0020);
            mouse_code.Add("X", 0x0080);
            mouse_code.Add("WHEEL", 0x0800);
        }
    }

    enum MOUSEEVENTF : uint { MOVE = 0x0001, LEFTDOWN = 0x0002, LEFTUP = 0x0004, RIGHTDOWN = 0x0008, RIGHTUP = 0x0010, MIDDLEDOWN = 0x0020, MIDDLEUP = 0x0040,
                            XDOWN = 0x0080, XUP = 0x0100, WHEEL = 0x0800, HWHEEL = 0x1000, MOVE_NOCOALESCE = 0x2000, VIRTUALDESK = 0x4000, ABSOLUTE = 0x8000 };
    enum KEYEVENTF : byte { KEYDOWN = 0, EXTENDEDKEY = 1, KEYUP = 2, UNICODE = 4, SCANCODE = 8 };

    [Serializable()] public struct xc
    {
        public Buttons button;
        public byte key;
        public string mouse;
        public bool press;
        public bool release;
        public bool repeat;

        public xc(Buttons button, byte key, string mouse, bool press, bool release, bool repeat)
        {
            this.button = button;
            this.key = key;
            this.mouse = mouse;
            this.press = press;
            this.release = release;
            this.repeat = repeat;
        }

        public void change(Buttons xtype, Boolean kradio, byte key, String mouse, CheckState xdown, CheckState xup, Boolean repeat)
        {
            this.button = xtype;
            this.repeat = repeat;

            if (kradio)
            {
                this.key = key;
                this.mouse = "";
            }
            else
            {
                this.key = 0;
                this.mouse = mouse;
            }

            if (xdown == CheckState.Checked & xup == CheckState.Unchecked)
            {
                this.press = true;
                this.release = false;
            }
            else if (xdown == CheckState.Unchecked & xup == CheckState.Checked)
            {
                this.press = false;
                this.release = true;
            }
            else
            {
                this.press = true;
                this.release = true;
            }
        }

        public void change(Buttons xtype, byte key, bool press, bool release)
        {
            this.button = xtype;
            this.key = key;
            this.mouse = "";
            this.press = press;
            this.release = release;
        }
    }

    [Serializable()] public struct anwendung
    {
        public String name;
        public xc[] mt;

        public anwendung(String name, xc[] mt)
        {
            this.name = name;
            this.mt = mt;
        }

        public void add(String name)
        {
            this.name = name;
            this.mt = new xc[1];
            this.mt[0].button = Buttons.BigButton;
            this.mt[0].key = 0x1B;
            this.mt[0].mouse = "";
            this.mt[0].press = true;
            this.mt[0].release = true;
            this.mt[0].repeat = true;
        }

        public void mt_delete(int x2, int xindex)
        {
            int i;
            for (i = x2; i < xindex; i++)
            {
                this.mt[i] = this.mt[i + 1];
            }
            Array.Resize(ref this.mt, this.mt.Length - 1);
        }
    }
}