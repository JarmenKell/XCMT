using System;
using System.Runtime.InteropServices;

namespace XCMT.helper
{
    class mousesend //1. universell - 2. mausbewegung - 3. mausrad - 4. mausklick
    {
        public static void SendInput(int mx, int my, int mouseData, uint dwFlags, uint time, IntPtr dwExtraInfo){
            wrapper.MOUSEINPUT m = new wrapper.MOUSEINPUT();
            m.dx = mx;
            m.dy = my;
            m.mouseData = mouseData; 
            m.dwFlags = dwFlags;
            m.time = time;
            m.dwExtraInfo = dwExtraInfo;

            wrapper.INPUT i = new wrapper.INPUT();
            i.type = wrapper.INPUT_MOUSE;
            i.mi = m;

            wrapper.INPUT[] inputs = new wrapper.INPUT[] { i };
            int isize = Marshal.SizeOf(i);
            wrapper.SendInput(1, inputs, isize);
        }

        public static void SendInput(int mx, int my, uint dwFlags)
        {
            wrapper.MOUSEINPUT m = new wrapper.MOUSEINPUT();
            m.dx = mx;
            m.dy = my;
            m.dwFlags = dwFlags;

            wrapper.INPUT i = new wrapper.INPUT();
            i.type = wrapper.INPUT_MOUSE;
            i.mi = m;

            wrapper.INPUT[] inputs = new wrapper.INPUT[] { i };
            int isize = Marshal.SizeOf(i);
            wrapper.SendInput(1, inputs, isize);
        }

        public static void SendInput(int mouseData, uint dwFlags)
        {
            wrapper.MOUSEINPUT m = new wrapper.MOUSEINPUT();
            m.mouseData = mouseData;
            m.dwFlags = dwFlags;

            wrapper.INPUT i = new wrapper.INPUT();
            i.type = wrapper.INPUT_MOUSE;
            i.mi = m;

            wrapper.INPUT[] inputs = new wrapper.INPUT[] { i };
            int isize = Marshal.SizeOf(i);
            wrapper.SendInput(1, inputs, isize);
        }

        public static void SendInput(uint dwFlags)
        {
            wrapper.MOUSEINPUT m = new wrapper.MOUSEINPUT();
            m.dwFlags = dwFlags;

            wrapper.INPUT i = new wrapper.INPUT();
            i.type = wrapper.INPUT_MOUSE;
            i.mi = m;

            wrapper.INPUT[] inputs = new wrapper.INPUT[] { i };
            int isize = Marshal.SizeOf(i);
            wrapper.SendInput(1, inputs, isize);
        }
    }

    class keysend //1. tastaturklick - 2. universell
    {
        public static void SendInput(ushort wVk, uint dwFlags)
        {
            wrapper.KEYBDINPUT k = new wrapper.KEYBDINPUT();
            k.wVk = wVk;
            k.dwFlags = dwFlags;

            wrapper.INPUT i = new wrapper.INPUT();
            i.type = wrapper.INPUT_KEYBOARD;
            i.ki = k;

            wrapper.INPUT[] inputs = new wrapper.INPUT[] { i };
            int isize = Marshal.SizeOf(i);
            wrapper.SendInput(1, inputs, isize);
        }

        public static void SendInput(ushort wVk, ushort wScan, uint dwFlags, uint time, IntPtr dwExtraInfo)
        {
            wrapper.KEYBDINPUT k = new wrapper.KEYBDINPUT();
            k.wVk = wVk;
            k.wScan = wScan;
            k.dwFlags = dwFlags;
            k.time = time;
            k.dwExtraInfo = dwExtraInfo;

            wrapper.INPUT i = new wrapper.INPUT();
            i.type = wrapper.INPUT_KEYBOARD;
            i.ki = k;

            wrapper.INPUT[] inputs = new wrapper.INPUT[] { i };
            int isize = Marshal.SizeOf(i);
            wrapper.SendInput(1, inputs, isize);
        }
    }

    class hardwaresnd //1. universell (ka was man mit macht)
    {
        public static void SendInput(uint uMsg, ushort wParamL, ushort wParamH)
        {
            wrapper.HARDWAREINPUT h = new wrapper.HARDWAREINPUT();
            h.uMsg = uMsg;
            h.wParamH = wParamH;
            h.wParamL = wParamL;

            wrapper.INPUT i = new wrapper.INPUT();
            i.type = wrapper.INPUT_MOUSE;
            i.hi = h;

            wrapper.INPUT[] inputs = new wrapper.INPUT[] { i };
            int isize = Marshal.SizeOf(i);
            wrapper.SendInput(1, inputs, isize);
        }
    }
}
