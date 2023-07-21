using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Spanzuratoarea
{
    public partial class Form1 : Form
    {
        Image img;
        Graphics g;
        String s;
        String S;
        int Incercari = 0;
        Image imgP = Properties.Resources.a0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(img);
            int a = File.ReadLines("C:\\Users\\Dan\\source\\repos\\Spanzuratoarea\\Spanzuratoarea\\TextFile1.txt").Count();
            Random rnd = new Random();
            int num = rnd.Next(1, a + 1);
            this.s = File.ReadLines("C:\\Users\\Dan\\source\\repos\\Spanzuratoarea\\Spanzuratoarea\\TextFile1.txt").Skip(num - 1).Take(1).First();
            S = null;
            for (int i = 0; i < s.Length; i++)
            {
                S += "*";
            }
            String v1 = null;
            String v2 = null;

            v1 += s[rnd.Next(1, s.Length)];
            v2 += s[rnd.Next(1, s.Length)];
            for (int i = 0; i < this.s.Length; i++)
            {
                if (v1[0] == this.s[i])
                {
                    string SS = S.Substring(0, i);
                    SS += v1;
                    String SSS = S.Substring(i + 1, this.s.Length - i - 1);
                    SS += SSS;
                    S = SS;

                }

            }

            for (int i = 0; i < this.s.Length; i++)
            {
                if (v2[0] == this.s[i])
                {
                    string SS = S.Substring(0, i);
                    SS += v2;
                    String SSS = S.Substring(i + 1, this.s.Length - i - 1);
                    SS += SSS;
                    S = SS;

                }

            }

            //using (Font myFont = new Font("Arial", 14))
            //{
            //    g.DrawString(this.S + "  " + this.s, myFont, Brushes.Green, new Point(2, 2));
            //    g.DrawImage(imgP, 4, 1);

            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool vv = false;
            String a = this.litera.Text;
            for (int i = 0; i < this.s.Length; i++)
            {

                if (a[0] == this.s[i])
                {
                    string SS = S.Substring(0, i);
                    SS += a;
                    String SSS = S.Substring(i + 1, this.s.Length - i - 1);
                    SS += SSS;
                    S = SS;
                    vv = true;
                }


            }
            if (vv == false) this.Incercari += 1;


            switch (this.Incercari)
            {
                case 0:
                    this.imgP = Properties.Resources.a0;
                    break;
                case 1:
                    this.imgP = Properties.Resources.a1;
                    break;
                case 2:
                    this.imgP = Properties.Resources.a2;
                    break;
                case 3:
                    this.imgP = Properties.Resources.a3;
                    break;
                case 4:
                    this.imgP = Properties.Resources.a4;
                    break;
                case 5:
                    this.imgP = Properties.Resources.a5;
                    break;
                case 6:
                    this.imgP = Properties.Resources.a6;
                    break;
                case 7:
                    this.imgP = Properties.Resources.a7;
                    break;
                case 8:
                    this.imgP = Properties.Resources.a8;
                    break;
                case 9:
                    this.imgP = Properties.Resources.a9;
                    break;
                case 10:
                    this.imgP = Properties.Resources.a10;
                    break;



            }

            p.Refresh();



            int k = 0;
            for (int i = 0; i < this.S.Length; i++)
            {
                String b = "*";
                if (S[i] == b[0])
                {
                    k += 1;
                }
            }
            if (k == 0)
            {
                MessageBox.Show("Felicitari ai ghicit cuvantul " + this.s);
                this.Close();
            }
            if (this.Incercari == 10)
            {
                MessageBox.Show("Ai pierdut. Cuvantul era " + this.s);
                this.Close();
            }
        }

        private void p_Paint(object sender, PaintEventArgs e)
        {


            using (Font myFont = new Font("Arial", 14))
            {
                e.Graphics.DrawString(this.S + "    " + this.Incercari.ToString(), myFont, Brushes.Green, new Point(400, 2));

            }

            e.Graphics.DrawImage(imgP, 0, 0);
        }
    }
}