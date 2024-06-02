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
        public string message;
        public DXControl Panel;

        public DateTime SpawnTime;

        public int TotalRepetitions = 2;
        public int CurrentRepetitions = 0;

        public ChatNoticeDialog()
        {
            Index = 6911;
            LibraryFile = LibraryFile.GameInter;
            Movable = false;
            Sort = false;
            ImageOpacity = 0.3f;

            Panel = new DXControl
            {
                Parent = this,
            };
            Panel.Size = new Size(Size.Width - 10, Size.Height);
            Panel.Location = new Point(5, 0);

            TextLabel = new DXLabel
            {
                Text = "",
                Font = new Font(Config.FontName, CEnvir.FontSize(10f), FontStyle.Bold),
                DrawFormat = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter,
                Parent = Panel,
                IsControl = true,
                AutoSize = true,
                ForeColour = Color.Yellow,
                BorderColour = Color.Black,
            };
            TextLabel.Location = new Point(Size.Width, 2);

            Layout = new DXImageControl
            {
                Index = 6910,
                LibraryFile = LibraryFile.GameInter,
                Parent = this,

            };
            Layout.Size = new Size(Size.Width, Size.Height);
            Layout.Location = new Point(0, 0);
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
            var spawnElapsed = (int)Math.Floor((CEnvir.Now - SpawnTime).TotalMilliseconds);

            if (spawnElapsed > 10)
            {
                TextLabel.Location = new Point(TextLabel.Location.X - 1, TextLabel.Location.Y);
                SpawnTime = CEnvir.Now;
            }

            // Check if label reached the end of the parent container
            if (TextLabel.Location.X + TextLabel.Size.Width < 0)
            {
                CurrentRepetitions += 1;

                // If already repeated the desired number of times = dispose
                // else move the label to the end of the parent container
                if (CurrentRepetitions >= TotalRepetitions)
                {
                    SpawnTime = CEnvir.Now;
                    CurrentRepetitions = 0;
                    Hide();
                    //Dispose();
                }
                else
                    TextLabel.Location = new Point(Size.Width, TextLabel.Location.Y);
            }
        }

        public void ShowNotice(string text, int type = 0)
        {
            SpawnTime = CEnvir.Now;
            CurrentRepetitions = 0;

            Index = type == 0 ? 6911 : 6913;
            Layout.Index = type == 0 ? 6910 : 6912;
            message = TextLabel.Text = text;
            TextLabel.Visible = type == 0;
            TextLabel.Location = new Point(Size.Width, TextLabel.Location.Y);
            Show();
        }
    }
}