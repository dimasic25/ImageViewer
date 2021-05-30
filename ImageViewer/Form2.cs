using System.Drawing;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Image img)
        {
            InitializeComponent();
            this.pictureBox1.Image = img;
        }
    }
}
