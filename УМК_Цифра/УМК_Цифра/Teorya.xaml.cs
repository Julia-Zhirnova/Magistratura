using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace УМК_Цифра
{
    /// <summary>
    /// Логика взаимодействия для Teorya.xaml
    /// </summary>
    public partial class Teorya : Window
    {
        public Teorya()
        {
            InitializeComponent();
            MainFrame.Navigate(new Teoryas.tmainpage());
            Manager.MainFrame = MainFrame;
        }
        IntPtr hWnd = IntPtr.Zero;
        double xRatio = 1;
        double yRatio = 1;
        int sizingEdge = 0;


        [StructLayout(LayoutKind.Sequential)]
        internal struct WINDOWPOS
        {
            public IntPtr hwnd;
            public IntPtr hwndInsertAfter;
            public int x;
            public int y;
            public int cx;
            public int cy;
            public int flags;
        }

        IntPtr DragHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handeled)
        {
            const int WM_SIZE = 0x0005;
            const int WM_SIZING = 0x0214;
            const int WM_WINDOWPOSCHANGING = 0x0046;


            // https://docs.microsoft.com/en-us/windows/win32/winmsg/wm-sizing
            const int WMSZ_BOTTOM = 6;
            const int WMSZ_BOTTOMLEFT = 7;
            const int WMSZ_BOTTOMRIGHT = 8;
            const int WMSZ_LEFT = 1;
            const int WMSZ_RIGHT = 2;
            const int WMSZ_TOP = 3;
            const int WMSZ_TOPLEFT = 4;
            const int WMSZ_TOPRIGHT = 5;

            switch (msg)
            {
                case WM_SIZING:
                    sizingEdge = wParam.ToInt32();
                    break;

                case WM_WINDOWPOSCHANGING:


                    var position =
                        (WINDOWPOS)Marshal.PtrToStructure(lParam, typeof(WINDOWPOS));

                    if (position.cx == this.Width && position.cy == this.Height)
                        return IntPtr.Zero;

                    switch (sizingEdge)
                    {
                        case WMSZ_TOP: // Top edge
                        case WMSZ_BOTTOM: // Bottom edge
                        case WMSZ_TOPRIGHT: // Top-right corner
                            position.cx = (int)(position.cy * xRatio);
                            break;

                        case WMSZ_LEFT: // Left edge
                        case WMSZ_RIGHT: // Right edge
                        case WMSZ_BOTTOMRIGHT: // Bottom-right corner
                        case WMSZ_BOTTOMLEFT: // Bottom-left corner
                            position.cy = (int)(position.cx * yRatio);
                            break;


                        case WMSZ_TOPLEFT: // Top-left corner
                            position.cx = (int)(position.cy * xRatio);
                            position.x = (int)Left - (position.cx - (int)Width);
                            break;
                    }

                    Marshal.StructureToPtr(position, lParam, true);
                    break;
            }


            return IntPtr.Zero;
        }


        public void Show()
        {

            xRatio = Width / Height;
            yRatio = Height / Width;

            base.Show();

            if (hWnd == IntPtr.Zero)
            {
                var interopHelper = new WindowInteropHelper(this);

                hWnd = interopHelper.Handle;

                var source = HwndSource.FromHwnd(hWnd);
                source?.AddHook(DragHook);
            }
        }

    }
}
