using System.Runtime.InteropServices;

namespace KaneKirwanAutoClicker
{
    public partial class KaneKirwanAutoClicker : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        private const int LeftDown = 0x02;
        private const int LeftUp = 0x04;
        private const int MiddleDown = 0x20;
        private const int MiddleUp = 0x40;
        private const int RightDown = 0x08;
        private const int RightUp = 0x10;
        public bool click = false;

        public KaneKirwanAutoClicker()
        {
            InitializeComponent();
        }

        private void KaneKirwanAutoClicker_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new(Autoclick);
            AC.Start();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            click = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            click = false;
        }

        private void Autoclick()
        {
            while (true)
            {
                if (click == true)
                {
                    if (LeftClick.Checked)
                    {
                        mouse_event(dwFlags: LeftDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                        mouse_event(dwFlags: LeftUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                        Thread.Sleep(Int32.Parse(Interval.Text));
                    }
                    if (MiddleClick.Checked)
                    {
                        mouse_event(dwFlags: MiddleDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                        mouse_event(dwFlags: MiddleUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                        Thread.Sleep(Int32.Parse(Interval.Text));
                    }
                    if (RightClick.Checked)
                    {
                        mouse_event(dwFlags: RightDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                        mouse_event(dwFlags: RightUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                        Thread.Sleep(Int32.Parse(Interval.Text));
                    }
                }
            }
        }
    }
}