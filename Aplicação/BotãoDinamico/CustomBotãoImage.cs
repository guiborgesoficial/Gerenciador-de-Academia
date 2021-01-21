using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotãoDinamico
{
    public partial class CustomBotãoImage: PictureBox
    { 
        public CustomBotãoImage()
        {
            InitializeComponent();
        }
        private Image NormalImage;
        private Image HoverImage;

        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }
        public Image ImageHover
        {
            get { return HoverImage; }
            set { HoverImage = value; }
        }

        private void CustomBotãoImage_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void CustomBotãoImage_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}
