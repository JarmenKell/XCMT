using System.Windows;
using System.Windows.Forms.Integration;

namespace XCMT.Code
{
    public partial class test : Window
    {
        public test()
        {
            ElementHost.EnableModelessKeyboardInterop(this);
            InitializeComponent();
        }
    }
}
