using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;

namespace NijiCC2
{
    public partial class Form1 : Form
    {
        string gradientPathPrimary, gradientPathSecondary, gradientPathOutline, gradientPathShadow;
        Bitmap bitmapGradientPrimary, bitmapGradientSecondary, bitmapGradientOutline, bitmapGradientShadow;
        int segmentDistancePrimary, segmentDistanceSecondary, segmentDistanceOutline, segmentDistanceShadow;
        int segmentCount;
        Regex regexC = new Regex(@"({\\c)(.*?)(})");
        Regex regex2C = new Regex(@"({\\2c)(.*?)(})");
        Regex regex3C = new Regex(@"({\\3c)(.*?)(})");
        Regex regex4C = new Regex(@"({\\4c)(.*?)(})");
        Regex regexRaw = new Regex(@"((})(.*?)({))|((})(.*?)($))");

        public Form1()
        {
            InitializeComponent();
            checkBoxPrimary.Enabled = false;
            checkBoxSecondary.Enabled = false;
            checkBoxOutline.Enabled = false;
            checkBoxShadow.Enabled = false;
        }

        private void boxInputLine_TextChanged(object sender, EventArgs e)
        {
            text_LineCharCount.Text = boxInputLine.Text.Length.ToString();
            int.TryParse(text_LineCharCount.Text, out segmentCount);
        }

        public void buttonLoadPrimary_Click(object sender, EventArgs e)
        {
            openGradientDialog.Filter = "PNG|*.png";
            if (openGradientDialog.ShowDialog() == DialogResult.OK)
            {
                gradientPathPrimary = openGradientDialog.FileName;
                bitmapGradientPrimary = new Bitmap(gradientPathPrimary, true);
                gradientPreviewPrimary.Image = bitmapGradientPrimary;
                checkBoxPrimary.Enabled = true;
                checkBoxPrimary.Checked = true;
            }
        }
        private void buttonLoadSecondary_Click(object sender, EventArgs e)
        {
            openGradientDialog.Filter = "PNG|*.png";
            if (openGradientDialog.ShowDialog() == DialogResult.OK)
            {
                gradientPathSecondary = openGradientDialog.FileName;
                bitmapGradientSecondary = new Bitmap(gradientPathSecondary, true);
                gradientPreviewSecondary.Image = bitmapGradientSecondary;
                checkBoxSecondary.Enabled = true;
                checkBoxSecondary.Checked = true;
            }
        }
        private void buttonLoadOutline_Click(object sender, EventArgs e)
        {
            openGradientDialog.Filter = "PNG|*.png";
            if (openGradientDialog.ShowDialog() == DialogResult.OK)
            {
                gradientPathOutline = openGradientDialog.FileName;
                bitmapGradientOutline = new Bitmap(gradientPathOutline, true);
                gradientPreviewOutline.Image = bitmapGradientOutline;
                checkBoxOutline.Enabled = true;
                checkBoxOutline.Checked = true;
            }
        }
        private void buttonLoadShadow_Click(object sender, EventArgs e)
        {
            openGradientDialog.Filter = "PNG|*.png";
            if (openGradientDialog.ShowDialog() == DialogResult.OK)
            {
                gradientPathShadow = openGradientDialog.FileName;
                bitmapGradientShadow = new Bitmap(gradientPathShadow, true);
                gradientPreviewShadow.Image = bitmapGradientShadow;
                checkBoxShadow.Enabled = true;
                checkBoxShadow.Checked = true;
            }
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (boxInputLine.Text.Contains("{\\c"))
            {
                int banyakKarakter = regexC.Matches(boxInputLine.Text).Count;
                String[] warnaBaruC = new String[banyakKarakter];
                String[] warnaBaru2C = new String[banyakKarakter];
                String[] warnaBaru3C = new String[banyakKarakter];
                String[] warnaBaru4C = new String[banyakKarakter];
                for (int i = 0; i < banyakKarakter; i++)
                {
                    if(checkBoxPrimary.Checked)
                        warnaBaruC[i] = ColorToASS(bitmapGradientPrimary.GetPixel(segmentDistancePrimary * i, bitmapGradientPrimary.Height / 2));
                    if(checkBoxSecondary.Checked)
                        warnaBaru2C[i] = ColorToASS(bitmapGradientSecondary.GetPixel(segmentDistanceSecondary * i, bitmapGradientSecondary.Height / 2));
                    if (checkBoxOutline.Checked)
                        warnaBaru3C[i] = ColorToASS(bitmapGradientOutline.GetPixel(segmentDistanceOutline * i, bitmapGradientOutline.Height / 2));
                    if (checkBoxShadow.Checked)
                        warnaBaru4C[i] = ColorToASS(bitmapGradientShadow.GetPixel(segmentDistanceShadow * i, bitmapGradientShadow.Height / 2));
                }
                boxOutputLine.Text = boxInputLine.Text;
                for(int i = 0; i < banyakKarakter; i++)
                {
                    if (checkBoxPrimary.Checked) 
                        boxOutputLine.Text = regexC.Replace(boxOutputLine.Text, "$1" + warnaBaruC[i] + "$3", 1);
                    if (checkBoxSecondary.Checked) 
                        boxOutputLine.Text = regex2C.Replace(boxOutputLine.Text, "$1" + warnaBaru2C[i] + "$3", 1);
                    if (checkBoxOutline.Checked) 
                        boxOutputLine.Text = regex3C.Replace(boxOutputLine.Text, "$1" + warnaBaru3C[i] + "$3", 1);
                    if (checkBoxShadow.Checked) 
                        boxOutputLine.Text = regex4C.Replace(boxOutputLine.Text, "$1" + warnaBaru4C[i] + "$3", 1);
                }
            }
          /*  else if(boxInputLine.Text.Contains("{"))
            {
                String lyricRaw = "";
                String lyricClean = "";
                String charColors = "";
                String[] coloredLyric = new string[] { };
                String lyricPart = "";
                String[] readyLyric = new string[] { };
                int[] panjangChar = new int[] { };
                int c = 0;
                int bawah = 0;
                MatchCollection matches = regexRaw.Matches(boxInputLine.Text);
                foreach(Match match in matches) //https://www.dotnetperls.com/regex-matches
                {
                    foreach(Capture capture in match.Captures)
                    {
                        lyricRaw = capture.Value;
                        lyricRaw.Replace("{", "");
                        lyricRaw.Replace("}", "");
                        lyricClean += lyricRaw;
                        panjangChar[c] = lyricClean.Length;
                        c++;
                    }
                }
                for (int i = 0; i < lyricClean.Length; i++)
                {
                    charColors = "";
                    if (checkBoxPrimary.Checked)
                    {
                        charColors = charColors + String.Format(@"{{\c{0}}}", ColorToASS(bitmapGradientPrimary.GetPixel(segmentDistancePrimary * i, bitmapGradientPrimary.Height / 2)));
                    }
                    if (checkBoxSecondary.Checked)
                    {
                        charColors = charColors + String.Format(@"{{\2c{0}}}", ColorToASS(bitmapGradientSecondary.GetPixel(segmentDistanceSecondary * i, bitmapGradientSecondary.Height / 2)));
                    }
                    if (checkBoxOutline.Checked)
                    {
                        charColors = charColors + String.Format(@"{{\3c{0}}}", ColorToASS(bitmapGradientOutline.GetPixel(segmentDistanceOutline * i, bitmapGradientOutline.Height / 2)));
                    }
                    if (checkBoxShadow.Checked)
                    {
                        charColors = charColors + String.Format(@"{{\4c{0}}}", ColorToASS(bitmapGradientShadow.GetPixel(segmentDistanceShadow * i, bitmapGradientShadow.Height / 2)));
                    }
                    coloredLyric[i] = String.Format(@"{0}{1}", charColors, lyricClean[i]);
                }
                for(int i = 0; i < panjangChar.Length; i++)
                {
                    for(int j = bawah; j < panjangChar[i]; j++)
                    {
                        lyricPart += coloredLyric[j]; 
                        bawah++;
                    }
                    readyLyric[i] = lyricPart;
                }
                boxOutputLine.Text = boxInputLine.Text;
                for(int i = 0; i < panjangChar.Length; i++)
                {
                    regexRaw.Replace(boxOutputLine.Text, "$1" + readyLyric[i] + "$3", 1);
                }
            }*/
            else
            {
                try
                {
                    boxOutputLine.Text = "";
                    string charColors = "";
                    if (checkBoxPrimary.Checked)
                        segmentDistancePrimary = bitmapGradientPrimary.Width / segmentCount;
                    if (checkBoxSecondary.Checked)
                        segmentDistanceSecondary = bitmapGradientSecondary.Width / segmentCount;
                    if (checkBoxOutline.Checked)
                        segmentDistanceOutline = bitmapGradientOutline.Width / segmentCount;
                    if (checkBoxShadow.Checked)
                        segmentDistanceShadow = bitmapGradientShadow.Width / segmentCount;

                    for (int i = 0; i < segmentCount; i++)
                    {
                        charColors = "";
                        if (checkBoxPrimary.Checked)
                        {
                            charColors = charColors + String.Format(@"{{\c{0}}}", ColorToASS(bitmapGradientPrimary.GetPixel(segmentDistancePrimary * i, bitmapGradientPrimary.Height / 2)));
                        }
                        if (checkBoxSecondary.Checked)
                        {
                            charColors = charColors + String.Format(@"{{\2c{0}}}", ColorToASS(bitmapGradientSecondary.GetPixel(segmentDistanceSecondary * i, bitmapGradientSecondary.Height / 2)));
                        }
                        if (checkBoxOutline.Checked)
                        {
                            charColors = charColors + String.Format(@"{{\3c{0}}}", ColorToASS(bitmapGradientOutline.GetPixel(segmentDistanceOutline * i, bitmapGradientOutline.Height / 2)));
                        }
                        if (checkBoxShadow.Checked)
                        {
                            charColors = charColors + String.Format(@"{{\4c{0}}}", ColorToASS(bitmapGradientShadow.GetPixel(segmentDistanceShadow * i, bitmapGradientShadow.Height / 2)));
                        }
                        boxOutputLine.Text = boxOutputLine.Text + String.Format(@"{0}{1}", charColors, boxInputLine.Text[i]);// + String.Format(@"{0}{1}", charColors, '\u200b');
                    }
                }
                catch (Exception z)
                {
                    MessageBox.Show("Error: \n" + z);
                }
            }
        }

        private void buttonCopyOutputLine_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(boxOutputLine.Text);
            }
            catch (Exception z)
            {
                MessageBox.Show("Error: \n" + z);
            }
        }

        public static string ColorToASS(Color color)
        {
            string R, G, B;

            if (color.R < 16)
            {
                R = String.Format("0{0}", color.R.ToString("X"));
            }
            else
            {
                R = color.R.ToString("X");
            }

            if (color.G < 16)
            {
                G = String.Format("0{0}", color.G.ToString("X"));
            }
            else
            {
                G = color.G.ToString("X");
            }

            if (color.B < 16)
            {
                B = String.Format("0{0}", color.B.ToString("X"));
            }
            else
            {
                B = color.B.ToString("X");
            }
            return String.Format("&H{0}{1}{2}&", B, G, R);
        }
    }
}