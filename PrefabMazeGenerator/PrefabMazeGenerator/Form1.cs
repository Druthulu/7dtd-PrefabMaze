using System.Linq.Expressions;

namespace PrefabMazeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            debugFunc();
        }

        void debugFunc()
        {
            string filePath = @"";
            RadioButton radioBtn = this.Controls.OfType<RadioButton>()
                                       .Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "basic3":
                    filePath = @textBox1.Text;
                    break;

                    case "rotate1":
                    filePath = @textBox2.Text;
                    break;

                    case "rotate2":
                    filePath = @textBox3.Text;
                    break;

                    case "textures":
                    filePath = @textBox4.Text;
                    break;

                    case "textures2":
                    filePath = @textBox5.Text;
                    break;

                    case "traderRekt":
                    filePath = @textBox6.Text;
                    break;

                    default: 
                        break;
                }
            }
            byte[] byteArray = File.ReadAllBytes(filePath);
            output.Text =  BitConverter.ToString(byteArray).Replace("-", "");


            // end debug func
        }

    }
}