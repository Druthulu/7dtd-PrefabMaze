namespace PrefabMazeGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.basic3 = new System.Windows.Forms.RadioButton();
            this.rotate1 = new System.Windows.Forms.RadioButton();
            this.rotate2 = new System.Windows.Forms.RadioButton();
            this.textures = new System.Windows.Forms.RadioButton();
            this.traderRekt = new System.Windows.Forms.RadioButton();
            this.textures2 = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.byteArrayIndexPercent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "D:\\git\\MazePrefabs\\test prefabs\\3x3x3-X.tts";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(402, 41);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(386, 397);
            this.output.TabIndex = 2;
            this.output.Text = "";
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "input TTS";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "D:\\git\\MazePrefabs\\test prefabs\\3x3x3-X-Texture on three blocks-rotate1.tts";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 23);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "D:\\git\\MazePrefabs\\test prefabs\\3x3x3-X-Texture on three blocks-rotate2.tts";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 229);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 23);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "D:\\git\\MazePrefabs\\test prefabs\\3x3x3-X-Texture on one block, front middle1x0x1.t" +
    "ts";
            // 
            // basic3
            // 
            this.basic3.AutoSize = true;
            this.basic3.Checked = true;
            this.basic3.Location = new System.Drawing.Point(12, 41);
            this.basic3.Name = "basic3";
            this.basic3.Size = new System.Drawing.Size(85, 19);
            this.basic3.TabIndex = 7;
            this.basic3.TabStop = true;
            this.basic3.Text = "basic 3x3x3";
            this.basic3.UseVisualStyleBackColor = true;
            // 
            // rotate1
            // 
            this.rotate1.AutoSize = true;
            this.rotate1.Location = new System.Drawing.Point(12, 95);
            this.rotate1.Name = "rotate1";
            this.rotate1.Size = new System.Drawing.Size(71, 19);
            this.rotate1.TabIndex = 8;
            this.rotate1.Text = "3 rorate1";
            this.rotate1.UseVisualStyleBackColor = true;
            // 
            // rotate2
            // 
            this.rotate2.AutoSize = true;
            this.rotate2.Location = new System.Drawing.Point(12, 149);
            this.rotate2.Name = "rotate2";
            this.rotate2.Size = new System.Drawing.Size(74, 19);
            this.rotate2.TabIndex = 9;
            this.rotate2.Text = "3 rotate 2";
            this.rotate2.UseVisualStyleBackColor = true;
            // 
            // textures
            // 
            this.textures.AutoSize = true;
            this.textures.Location = new System.Drawing.Point(12, 204);
            this.textures.Name = "textures";
            this.textures.Size = new System.Drawing.Size(76, 19);
            this.textures.TabIndex = 10;
            this.textures.Text = "3 textures";
            this.textures.UseVisualStyleBackColor = true;
            // 
            // traderRekt
            // 
            this.traderRekt.AutoSize = true;
            this.traderRekt.Location = new System.Drawing.Point(12, 313);
            this.traderRekt.Name = "traderRekt";
            this.traderRekt.Size = new System.Drawing.Size(79, 19);
            this.traderRekt.TabIndex = 14;
            this.traderRekt.Text = "trader rekt";
            this.traderRekt.UseVisualStyleBackColor = true;
            // 
            // textures2
            // 
            this.textures2.AutoSize = true;
            this.textures2.Location = new System.Drawing.Point(12, 258);
            this.textures2.Name = "textures2";
            this.textures2.Size = new System.Drawing.Size(107, 19);
            this.textures2.TabIndex = 13;
            this.textures2.Text = "3 more textures";
            this.textures2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 283);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(239, 23);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "D:\\git\\MazePrefabs\\test prefabs\\3x3x3-X-Texture on one block, front middle1x0x1, " +
    "and 0,0,2.tts";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 338);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(239, 23);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "D:\\git\\MazePrefabs\\test prefabs\\trader_rekt.tts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Struct Data";
            // 
            // byteArrayIndexPercent
            // 
            this.byteArrayIndexPercent.Location = new System.Drawing.Point(269, 415);
            this.byteArrayIndexPercent.Name = "byteArrayIndexPercent";
            this.byteArrayIndexPercent.Size = new System.Drawing.Size(100, 23);
            this.byteArrayIndexPercent.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.byteArrayIndexPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.traderRekt);
            this.Controls.Add(this.textures2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textures);
            this.Controls.Add(this.rotate2);
            this.Controls.Add(this.rotate1);
            this.Controls.Add(this.basic3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Prefab Maze Generator 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private RichTextBox output;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private RadioButton basic3;
        private RadioButton rotate1;
        private RadioButton rotate2;
        private RadioButton textures;
        private RadioButton traderRekt;
        private RadioButton textures2;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label2;
        private TextBox byteArrayIndexPercent;
    }
}