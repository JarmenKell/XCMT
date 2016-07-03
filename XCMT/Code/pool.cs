using System;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using XCMT.helper;

namespace XCMT.Code
{
    class tickmain
    {
        public static Timer intervall;

        public static void uhr() //timer erzeugen und ausführen
        {
            AutoResetEvent autoEvent = new AutoResetEvent(false);
            tickpool zeiger = new tickpool();
            TimerCallback payback = new TimerCallback(zeiger.main);
            intervall = new Timer(payback, autoEvent, 100, Properties.Settings.Default.intervall);
        }

        public static anwendung[] apps;
    }

    class tickpool
    {
        GamePadState oldcontroller = GamePad.GetState(PlayerIndex.One);
        MouseState oldmouse = Mouse.GetState();
        KeyboardState oldkeyboard = Keyboard.GetState();
        String oldFenster = wrapper.GetActiveWindowTitle();
        const float deadzone = 0.02f;

        public void main(Object stateInfo)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)stateInfo; //sollte wichtig sein

            GamePadState controller = GamePad.GetState(PlayerIndex.One);
            MouseState mouse = Mouse.GetState();
            KeyboardState keyboard = Keyboard.GetState();
            String Fenster = wrapper.GetActiveWindowTitle();

            byte j = 0;
            byte i = 0;
            if (Fenster != oldFenster)
            {
                for (i = 0; i < tickmain.apps.Length; i++) if (Fenster.Contains(tickmain.apps[i].name)) j++;
                trayform.aktiv.Text = j + " Profil(e) für\r\n" + Fenster + "\r\ngefunden";
            }

            i = 0;
            for (j = 0; j < tickmain.apps[i].mt.Length; j++)
            {
                switch (tickmain.apps[i].mt[j].button)
                {
                    #region Buttons
                    case Buttons.A:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Buttons.A == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.Buttons.A, oldcontroller.Buttons.A, i, j);
                        break;

                    case Buttons.B:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Buttons.B == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.Buttons.B, oldcontroller.Buttons.B, i, j);
                        break;

                    case Buttons.X:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Buttons.X == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.Buttons.X, oldcontroller.Buttons.X, i, j);
                        break;

                    case Buttons.Y:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Buttons.Y == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.Buttons.Y, oldcontroller.Buttons.Y, i, j);
                        break;

                    case Buttons.Back:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Buttons.Y == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.Buttons.Back, oldcontroller.Buttons.Back, i, j);
                        break;

                    case Buttons.BigButton:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Buttons.BigButton == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.Buttons.BigButton, oldcontroller.Buttons.BigButton, i, j);
                        break;

                    case Buttons.Start:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Buttons.Start == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.Buttons.Start, oldcontroller.Buttons.Start, i, j);
                        break;

                    case Buttons.LeftShoulder:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Buttons.LeftShoulder == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.Buttons.LeftShoulder, oldcontroller.Buttons.LeftShoulder, i, j);
                        break;

                    case Buttons.RightShoulder:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Buttons.RightShoulder == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.Buttons.RightShoulder, oldcontroller.Buttons.RightShoulder, i, j);
                        break;

                    case Buttons.LeftStick:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Buttons.LeftStick == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.Buttons.LeftStick, oldcontroller.Buttons.LeftStick, i, j);
                        break;

                    case Buttons.RightStick:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Buttons.RightStick == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.Buttons.RightStick, oldcontroller.Buttons.RightStick, i, j);
                        break;
                    #endregion

                    #region DPad
                    case Buttons.DPadDown:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.DPad.Down == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.DPad.Down, oldcontroller.DPad.Down, i, j);
                        break;

                    case Buttons.DPadLeft:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.DPad.Left == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.DPad.Left, oldcontroller.DPad.Left, i, j);
                        break;

                    case Buttons.DPadRight:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.DPad.Right == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.DPad.Right, oldcontroller.DPad.Right, i, j);
                        break;

                    case Buttons.DPadUp:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.DPad.Up == ButtonState.Pressed) repeat_ad(i, j, 1);
                        }
                        else once_digital(controller.DPad.Up, oldcontroller.DPad.Up, i, j);
                        break;
                    #endregion

                    #region Thumbstick
                    case Buttons.LeftThumbstickDown:
                        if (controller.ThumbSticks.Left.Y < deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Left.Y < -deadzone) repeat_ad(i, j, -controller.ThumbSticks.Left.Y);
                            }
                            else once_analog(-controller.ThumbSticks.Left.Y, -oldcontroller.ThumbSticks.Left.Y, i, j);
                        }
                        break;

                    case Buttons.LeftThumbstickLeft:
                        if (controller.ThumbSticks.Left.X < deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Left.X < -deadzone) repeat_ad(i, j, -controller.ThumbSticks.Left.X);
                            }
                            else once_analog(-controller.ThumbSticks.Left.X, -oldcontroller.ThumbSticks.Left.X, i, j);
                        }
                        break;

                    case Buttons.LeftThumbstickRight:
                        if (controller.ThumbSticks.Left.X > -deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Left.X > deadzone) repeat_ad(i, j, controller.ThumbSticks.Left.X);
                            }
                            else once_analog(controller.ThumbSticks.Left.X, oldcontroller.ThumbSticks.Left.X, i, j);
                        }
                        break;

                    case Buttons.LeftThumbstickUp:
                        if (controller.ThumbSticks.Left.Y > -deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Left.Y > deadzone) repeat_ad(i, j, controller.ThumbSticks.Left.Y);
                            }
                            else once_analog(controller.ThumbSticks.Left.Y, oldcontroller.ThumbSticks.Left.Y, i, j);
                        }
                        break;

                    case Buttons.RightThumbstickDown:
                        if (controller.ThumbSticks.Right.Y < deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Right.Y < -deadzone) repeat_ad(i, j, -controller.ThumbSticks.Right.Y);
                            }
                            else once_analog(-controller.ThumbSticks.Right.Y, -oldcontroller.ThumbSticks.Right.Y, i, j);
                        }
                        break;

                    case Buttons.RightThumbstickLeft:
                        if (controller.ThumbSticks.Right.X < deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Right.X < -deadzone) repeat_ad(i, j, -controller.ThumbSticks.Right.X);
                            }
                            else once_analog(-controller.ThumbSticks.Right.X, -oldcontroller.ThumbSticks.Right.X, i, j);
                        }
                        break;

                    case Buttons.RightThumbstickRight:
                        if (controller.ThumbSticks.Right.X > -deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Right.X > deadzone) repeat_ad(i, j, controller.ThumbSticks.Right.X);
                            }
                            else once_analog(controller.ThumbSticks.Right.X, oldcontroller.ThumbSticks.Right.X, i, j);
                        }
                        break;

                    case Buttons.RightThumbstickUp:
                        if (controller.ThumbSticks.Right.Y > -deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Right.Y > deadzone) repeat_ad(i, j, controller.ThumbSticks.Right.Y);
                            }
                            else once_analog(controller.ThumbSticks.Right.Y, oldcontroller.ThumbSticks.Right.Y, i, j);
                        }
                        break;
                    #endregion

                    #region Tigger
                    case Buttons.LeftTrigger:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Triggers.Left > deadzone) repeat_ad(i, j, controller.Triggers.Left);
                        }
                        else once_analog(controller.Triggers.Left, oldcontroller.Triggers.Left, i, j);
                        break;

                    case Buttons.RightTrigger:
                        if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                        {
                            if (controller.Triggers.Right > deadzone) repeat_ad(i, j, controller.Triggers.Right);
                        }
                        else once_analog(controller.Triggers.Right, oldcontroller.Triggers.Right, i, j);
                        break;
                    #endregion
                }
            }

            for (i = 1; i < tickmain.apps.Length; i++)
            {
                if (Fenster.Contains(tickmain.apps[i].name))
                {
                    for (j = 0; j < tickmain.apps[i].mt.Length; j++)
                    {
                        switch (tickmain.apps[i].mt[j].button)
                        {
                            #region Buttons
                            case Buttons.A:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Buttons.A == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.Buttons.A, oldcontroller.Buttons.A, i, j);
                                break;

                            case Buttons.B:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Buttons.B == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.Buttons.B, oldcontroller.Buttons.B, i, j);
                                break;

                            case Buttons.X:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Buttons.X == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.Buttons.X, oldcontroller.Buttons.X, i, j);
                                break;

                            case Buttons.Y:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Buttons.Y == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.Buttons.Y, oldcontroller.Buttons.Y, i, j);
                                break;

                            case Buttons.Back:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Buttons.Y == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.Buttons.Back, oldcontroller.Buttons.Back, i, j);
                                break;

                            case Buttons.BigButton:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Buttons.BigButton == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.Buttons.BigButton, oldcontroller.Buttons.BigButton, i, j);
                                break;

                            case Buttons.Start:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Buttons.Start == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.Buttons.Start, oldcontroller.Buttons.Start, i, j);
                                break;

                            case Buttons.LeftShoulder:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Buttons.LeftShoulder == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.Buttons.LeftShoulder, oldcontroller.Buttons.LeftShoulder, i, j);
                                break;

                            case Buttons.RightShoulder:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Buttons.RightShoulder == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.Buttons.RightShoulder, oldcontroller.Buttons.RightShoulder, i, j);
                                break;

                            case Buttons.LeftStick:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Buttons.LeftStick == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.Buttons.LeftStick, oldcontroller.Buttons.LeftStick, i, j);
                                break;

                            case Buttons.RightStick:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Buttons.RightStick == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.Buttons.RightStick, oldcontroller.Buttons.RightStick, i, j);
                                break;
                            #endregion

                            #region DPad
                            case Buttons.DPadDown:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.DPad.Down == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.DPad.Down, oldcontroller.DPad.Down, i, j);
                                break;

                            case Buttons.DPadLeft:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.DPad.Left == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.DPad.Left, oldcontroller.DPad.Left, i, j);
                                break;

                            case Buttons.DPadRight:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.DPad.Right == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.DPad.Right, oldcontroller.DPad.Right, i, j);
                                break;

                            case Buttons.DPadUp:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.DPad.Up == ButtonState.Pressed) repeat_ad(i, j, 1);
                                }
                                else once_digital(controller.DPad.Up, oldcontroller.DPad.Up, i, j);
                                break;
                            #endregion

                            #region Thumbstick
                    case Buttons.LeftThumbstickDown:
                        if (controller.ThumbSticks.Left.Y < deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Left.Y < -deadzone) repeat_ad(i, j, -controller.ThumbSticks.Left.Y);
                            }
                            else once_analog(-controller.ThumbSticks.Left.Y, -oldcontroller.ThumbSticks.Left.Y, i, j);
                        }
                        break;

                    case Buttons.LeftThumbstickLeft:
                        if (controller.ThumbSticks.Left.X < deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Left.X < -deadzone) repeat_ad(i, j, -controller.ThumbSticks.Left.X);
                            }
                            else once_analog(-controller.ThumbSticks.Left.X, -oldcontroller.ThumbSticks.Left.X, i, j);
                        }
                        break;

                    case Buttons.LeftThumbstickRight:
                        if (controller.ThumbSticks.Left.X > -deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Left.X > deadzone) repeat_ad(i, j, controller.ThumbSticks.Left.X);
                            }
                            else once_analog(controller.ThumbSticks.Left.X, oldcontroller.ThumbSticks.Left.X, i, j);
                        }
                        break;

                    case Buttons.LeftThumbstickUp:
                        if (controller.ThumbSticks.Left.Y > -deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Left.Y > deadzone) repeat_ad(i, j, controller.ThumbSticks.Left.Y);
                            }
                            else once_analog(controller.ThumbSticks.Left.Y, oldcontroller.ThumbSticks.Left.Y, i, j);
                        }
                        break;

                    case Buttons.RightThumbstickDown:
                        if (controller.ThumbSticks.Right.Y < deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Right.Y < -deadzone) repeat_ad(i, j, -controller.ThumbSticks.Right.Y);
                            }
                            else once_analog(-controller.ThumbSticks.Right.Y, -oldcontroller.ThumbSticks.Right.Y, i, j);
                        }
                        break;

                    case Buttons.RightThumbstickLeft:
                        if (controller.ThumbSticks.Right.X < deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Right.X < -deadzone) repeat_ad(i, j, -controller.ThumbSticks.Right.X);
                            }
                            else once_analog(-controller.ThumbSticks.Right.X, -oldcontroller.ThumbSticks.Right.X, i, j);
                        }
                        break;

                    case Buttons.RightThumbstickRight:
                        if (controller.ThumbSticks.Right.X > -deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Right.X > deadzone) repeat_ad(i, j, controller.ThumbSticks.Right.X);
                            }
                            else once_analog(controller.ThumbSticks.Right.X, oldcontroller.ThumbSticks.Right.X, i, j);
                        }
                        break;

                    case Buttons.RightThumbstickUp:
                        if (controller.ThumbSticks.Right.Y > -deadzone)
                        {
                            if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                            {
                                if (controller.ThumbSticks.Right.Y > deadzone) repeat_ad(i, j, controller.ThumbSticks.Right.Y);
                            }
                            else once_analog(controller.ThumbSticks.Right.Y, oldcontroller.ThumbSticks.Right.Y, i, j);
                        }
                        break;
                    #endregion

                            #region Tigger
                            case Buttons.LeftTrigger:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Triggers.Left > deadzone) repeat_ad(i, j, controller.Triggers.Left);
                                }
                                else once_analog(controller.Triggers.Left, oldcontroller.Triggers.Left, i, j);
                                break;

                            case Buttons.RightTrigger:
                                if (tickmain.apps[i].mt[j].repeat & tickmain.apps[i].mt[j].press)
                                {
                                    if (controller.Triggers.Right > deadzone) repeat_ad(i, j, controller.Triggers.Right);
                                }
                                else once_analog(controller.Triggers.Right, oldcontroller.Triggers.Right, i, j);
                                break;
                            #endregion
                        }
                    }
                }
            }

            oldcontroller = controller;
            oldFenster = Fenster;
            autoEvent.Set(); //sollte auch wichtig sein
        }

        public static void once_digital(ButtonState state, ButtonState oldstate, byte i, byte j)
        {
            int speed = Properties.Settings.Default.speed;

            if (state == ButtonState.Pressed & oldstate == ButtonState.Released & tickmain.apps[i].mt[j].press)
            {
                switch (tickmain.apps[i].mt[j].mouse)
                {
                    case "MOVE_DOWN":
                        mousesend.SendInput(0, speed, (uint)MOUSEEVENTF.MOVE);
                        break;

                    case "MOVE_LEFT":
                        mousesend.SendInput(-speed, 0, (uint)MOUSEEVENTF.MOVE);
                        break;

                    case "MOVE_RIGHT":
                        mousesend.SendInput(speed, 0, (uint)MOUSEEVENTF.MOVE);
                        break;

                    case "MOVE_UP":
                        mousesend.SendInput(0, -speed, (uint)MOUSEEVENTF.MOVE);
                        break;

                    case "LEFT":
                        mousesend.SendInput((uint)MOUSEEVENTF.LEFTDOWN);
                        break;

                    case "RIGHT":
                        mousesend.SendInput((uint)MOUSEEVENTF.RIGHTDOWN);
                        break;

                    case "MIDDLE":
                        mousesend.SendInput((uint)MOUSEEVENTF.MIDDLEDOWN);
                        break;

                    case "X":
                        mousesend.SendInput((uint)MOUSEEVENTF.XDOWN);
                        break;

                    /*case "WHEEL":
                        break;

                    case "HWHEEL":
                        break;*/

                    case "":
                        keysend.SendInput(tickmain.apps[i].mt[j].key, (uint)KEYEVENTF.KEYDOWN);
                        break;
                }
            }

            if (state == ButtonState.Released & oldstate == ButtonState.Pressed & tickmain.apps[i].mt[j].release)
            {
                switch (tickmain.apps[i].mt[j].mouse)
                {
                    case "LEFT":
                        mousesend.SendInput((uint)MOUSEEVENTF.LEFTUP);
                        break;

                    case "RIGHT":
                        mousesend.SendInput((uint)MOUSEEVENTF.RIGHTUP);
                        break;

                    case "MIDDLE":
                        mousesend.SendInput((uint)MOUSEEVENTF.MIDDLEUP);
                        break;

                    case "X":
                        mousesend.SendInput((uint)MOUSEEVENTF.XUP);
                        break;

                    /*case "WHEEL":
                        break;

                    case "HWHEEL":
                        break;*/

                    case "":
                        keysend.SendInput(tickmain.apps[i].mt[j].key, (uint)KEYEVENTF.KEYUP);
                        break;
                }
            }
        }

        public static void once_analog(float range, float oldrange, byte i, byte j)
        {
            int speed = Properties.Settings.Default.speed;

            if (((range > deadzone & oldrange < deadzone) | (range < -deadzone & oldrange > -deadzone)) & tickmain.apps[i].mt[j].press)
            {
                switch (tickmain.apps[i].mt[j].mouse)
                {
                    case "MOVE_DOWN":
                        mousesend.SendInput(0, (int)(speed * range), (uint)MOUSEEVENTF.MOVE);
                        break;

                    case "MOVE_LEFT":
                        mousesend.SendInput((int)(-speed * range), 0, (uint)MOUSEEVENTF.MOVE);
                        break;

                    case "MOVE_RIGHT":
                        mousesend.SendInput((int)(speed * range), 0, (uint)MOUSEEVENTF.MOVE);
                        break;

                    case "MOVE_UP":
                        mousesend.SendInput(0, (int)(-speed * range), (uint)MOUSEEVENTF.MOVE);
                        break;

                    case "LEFT":
                        mousesend.SendInput((uint)MOUSEEVENTF.LEFTDOWN);
                        break;

                    case "RIGHT":
                        mousesend.SendInput((uint)MOUSEEVENTF.RIGHTDOWN);
                        break;

                    case "MIDDLE":
                        mousesend.SendInput((uint)MOUSEEVENTF.MIDDLEDOWN);
                        break;

                    case "X":
                        mousesend.SendInput((uint)MOUSEEVENTF.XDOWN);
                        break;

                    /*case "WHEEL":
                        break;

                    case "HWHEEL":
                        break;*/

                    case "":
                        keysend.SendInput(tickmain.apps[i].mt[j].key, (uint)KEYEVENTF.KEYDOWN);
                        break;
                }
            }

            if (((range < deadzone & oldrange > deadzone) | (range > -deadzone & oldrange < -deadzone)) & tickmain.apps[i].mt[j].release)
            {
                switch (tickmain.apps[i].mt[j].mouse)
                {
                    case "LEFT":
                        mousesend.SendInput((uint)MOUSEEVENTF.LEFTUP);
                        break;

                    case "RIGHT":
                        mousesend.SendInput((uint)MOUSEEVENTF.RIGHTUP);
                        break;

                    case "MIDDLE":
                        mousesend.SendInput((uint)MOUSEEVENTF.MIDDLEUP);
                        break;

                    case "X":
                        mousesend.SendInput((uint)MOUSEEVENTF.XUP);
                        break;

                    /*case "WHEEL":
                        break;

                    case "HWHEEL":
                        break;*/

                    case "":
                        keysend.SendInput(tickmain.apps[i].mt[j].key, (uint)KEYEVENTF.KEYUP);
                        break;
                }
            }
        }

        public static void repeat_ad(byte i, byte j, float range)
        {
            int speed = Properties.Settings.Default.speed;

            switch (tickmain.apps[i].mt[j].mouse)
            {
                case "MOVE_DOWN":
                    mousesend.SendInput(0, (int)(speed * range), (uint)MOUSEEVENTF.MOVE);
                    break;

                case "MOVE_LEFT":
                    mousesend.SendInput((int)(-speed * range), 0, (uint)MOUSEEVENTF.MOVE);
                    break;

                case "MOVE_RIGHT":
                    mousesend.SendInput((int)(speed * range), 0, (uint)MOUSEEVENTF.MOVE);
                    break;

                case "MOVE_UP":
                    mousesend.SendInput(0, (int)(-speed * range), (uint)MOUSEEVENTF.MOVE);
                    break;

                case "LEFT":
                    if (!tickmain.apps[i].mt[j].release)
                    {
                        mousesend.SendInput((uint)MOUSEEVENTF.LEFTDOWN);
                    }
                    else
                    {
                        mousesend.SendInput((uint)MOUSEEVENTF.LEFTDOWN);
                        mousesend.SendInput((uint)MOUSEEVENTF.LEFTUP);
                    }
                    break;

                case "RIGHT":
                    if (!tickmain.apps[i].mt[j].release)
                    {
                        mousesend.SendInput((uint)MOUSEEVENTF.RIGHTDOWN);
                    }
                    else
                    {
                        mousesend.SendInput((uint)MOUSEEVENTF.RIGHTDOWN);
                        mousesend.SendInput((uint)MOUSEEVENTF.RIGHTUP);
                    }
                    break;

                case "MIDDLE":
                    if (!tickmain.apps[i].mt[j].release)
                    {
                        mousesend.SendInput((uint)MOUSEEVENTF.MIDDLEDOWN);
                    }
                    else
                    {
                        mousesend.SendInput((uint)MOUSEEVENTF.MIDDLEDOWN);
                        mousesend.SendInput((uint)MOUSEEVENTF.MIDDLEUP);
                    }
                    break;

                case "X":
                    if (!tickmain.apps[i].mt[j].release)
                    {
                        mousesend.SendInput((uint)MOUSEEVENTF.XDOWN);
                    }
                    else
                    {
                        mousesend.SendInput((uint)MOUSEEVENTF.XDOWN);
                        mousesend.SendInput((uint)MOUSEEVENTF.XUP);
                    }
                    break;

                /*case "WHEEL":
                    break;

                case "HWHEEL":
                    break;*/

                case "":
                    if (!tickmain.apps[i].mt[j].release)
                    {
                        keysend.SendInput(tickmain.apps[i].mt[j].key, (uint)KEYEVENTF.KEYDOWN);
                    }
                    else
                    {
                        keysend.SendInput(tickmain.apps[i].mt[j].key, (uint)KEYEVENTF.KEYDOWN);
                        keysend.SendInput(tickmain.apps[i].mt[j].key, (uint)KEYEVENTF.KEYUP);
                    }
                    break;
            }
        }
    }
}