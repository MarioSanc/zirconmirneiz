using Client.Controls;
using Client.Envir;
using Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Scenes.Views
{
    public sealed class ChatNoticeDialog : DXImageControl
    {
        public DXImageControl Layout;
        public DXLabel TextLabel;
        public DXLabel TextLabel2;
        public DateTime CurrentTime;
        public int ViewTime;
        public long Speed;
        public string message;

        public ChatNoticeDialog()
        {
            Index = 6911;
            LibraryFile = LibraryFile.GameInter;
            Movable = false;
            Sort = false;
            ImageOpacity = 0.3f;


            TextLabel = new DXLabel
            {
                Text = "",
                Font = new Font(Config.FontName, CEnvir.FontSize(10f), FontStyle.Bold),
                DrawFormat = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter,
                Parent = this,
                IsControl = true,
                Location = new Point(15, 3),
                AutoSize = true,
                ForeColour = Color.Yellow,
                BorderColour = Color.Black,
            };

            TextLabel2 = new DXLabel
            {
                Text = "",
                Font = new Font(Config.FontName, CEnvir.FontSize(15f), FontStyle.Bold),
                DrawFormat = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter,
                Parent = this,
                IsControl = true,
                Location = new Point(15, 3),
                AutoSize = true,
                ForeColour = Color.Yellow,
                BorderColour = Color.Black,
            };


            DXImageControl dxImageControl = new DXImageControl
            {
                Index = 6910,
                LibraryFile = LibraryFile.GameInter,
                Location = new Point(-2, -2),
                Parent = this,

            };
            Layout = dxImageControl;
            AfterDraw += new EventHandler<EventArgs>(ChatNotice_AfterDraw);
        }

        public void Show()
        {
            if (Visible)
                return;
            Visible = true;
        }

        public void Hide()
        {
            if (!Visible)
                return;
            Visible = false;
        }

        private void ChatNotice_AfterDraw(object sender, EventArgs e)
        {
            if (CurrentTime < CEnvir.Now)
                Hide();
            else if (CEnvir.Now.Ticks - Speed > 150000L)
            {
                Speed = CEnvir.Now.Ticks;
                if (TextLabel.Text.Length < 300)
                {
                    DXLabel textLabel1 = TextLabel;
                    textLabel1.Text = textLabel1.Text + " " + message;
                    DXLabel textLabel2 = TextLabel2;
                    textLabel2.Text = textLabel2.Text + " " + message;
                }
                DXLabel textLabel1_1 = TextLabel;
                DXLabel textLabel2_1 = TextLabel2;
                Point point1 = new Point(TextLabel2.Location.X - 1, 3);
                Point point2 = point1;
                textLabel2_1.Location = point2;
                Point point3 = point1;
                textLabel1_1.Location = point3;
            }
        }

        public void ShowNotice(string text, int type = 0)
        {
            Index = type == 0 ? 6911 : 6913;
            Layout.Index = type == 0 ? 6910 : 6912;
            message = TextLabel.Text = TextLabel2.Text = text;
            TextLabel.Visible = type == 0;
            TextLabel2.Visible = type == 1;
            DXLabel textLabel1 = TextLabel;
            DXLabel textLabel2 = TextLabel2;
            Point location = new Point(15, 3);
            Point location2 = location;
            textLabel2.Location = location2;
            Point location3 = location;
            textLabel1.Location = location3;
            CurrentTime = CEnvir.Now.AddMilliseconds(20000.0);
            Speed = CEnvir.Now.Ticks;
            Show();
        }
    }
}