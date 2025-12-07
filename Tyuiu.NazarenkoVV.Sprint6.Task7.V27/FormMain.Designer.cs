using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.MokslaevEA.Sprint6.Task7.V27
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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button_Save = new Button();
            button_Spr = new Button();
            button_Go = new Button();
            button_Imput = new Button();
            panel3 = new Panel();
            dataGridView_Res = new DataGridView();
            panel4 = new Panel();
            dataGridView_Imput = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            saveFileDialog1 = new SaveFileDialog();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Res).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Imput).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button_Save);
            panel2.Controls.Add(button_Spr);
            panel2.Controls.Add(button_Go);
            panel2.Controls.Add(button_Imput);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1696, 257);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(979, 207);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 30;
            label2.Text = "Вывод";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(81, 207);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 29;
            label1.Text = "Ввод";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1584, 139);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 85);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button_Save
            // 
            button_Save.BackColor = SystemColors.ButtonFace;
            button_Save.Enabled = false;
            button_Save.FlatStyle = FlatStyle.Flat;
            button_Save.Location = new Point(231, 16);
            button_Save.Margin = new Padding(3, 4, 3, 4);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(77, 84);
            button_Save.TabIndex = 27;
            toolTip1.SetToolTip(button_Save, "Нажмите, чтобы сохранить в новый файл\r\n");
            button_Save.UseVisualStyleBackColor = false;
            button_Save.Click += button_Save_Click;
            // 
            // button_Spr
            // 
            button_Spr.BackColor = Color.FromArgb(192, 192, 0);
            button_Spr.Location = new Point(1629, 32);
            button_Spr.Margin = new Padding(3, 4, 3, 4);
            button_Spr.Name = "button_Spr";
            button_Spr.Size = new Size(48, 52);
            button_Spr.TabIndex = 26;
            button_Spr.Text = "?";
            button_Spr.UseVisualStyleBackColor = false;
            button_Spr.Click += button_Spr_Click;
            // 
            // button_Go
            // 
            button_Go.BackColor = SystemColors.ControlDark;
            button_Go.Enabled = false;
            button_Go.FlatStyle = FlatStyle.Flat;
            button_Go.Location = new Point(136, 16);
            button_Go.Margin = new Padding(3, 4, 3, 4);
            button_Go.Name = "button_Go";
            button_Go.Size = new Size(77, 84);
            button_Go.TabIndex = 25;
            toolTip1.SetToolTip(button_Go, "Нажмите, чтобы выполнить действие");
            button_Go.UseVisualStyleBackColor = false;
            button_Go.Click += button_Go_Click;
            // 
            // button_Imput
            // 
            button_Imput.BackColor = SystemColors.HotTrack;
            button_Imput.Location = new Point(42, 16);
            button_Imput.Margin = new Padding(3, 4, 3, 4);
            button_Imput.Name = "button_Imput";
            button_Imput.Size = new Size(77, 84);
            button_Imput.TabIndex = 24;
            button_Imput.UseVisualStyleBackColor = false;
            button_Imput.Click += button_Imput_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView_Res);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(819, 257);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(877, 798);
            panel3.TabIndex = 2;
            // 
            // dataGridView_Res
            // 
            dataGridView_Res.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Res.ColumnHeadersVisible = false;
            dataGridView_Res.Location = new Point(50, 28);
            dataGridView_Res.Margin = new Padding(3, 4, 3, 4);
            dataGridView_Res.Name = "dataGridView_Res";
            dataGridView_Res.RowHeadersVisible = false;
            dataGridView_Res.RowHeadersWidth = 51;
            dataGridView_Res.Size = new Size(766, 673);
            dataGridView_Res.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView_Imput);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 257);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(817, 798);
            panel4.TabIndex = 3;
            // 
            // dataGridView_Imput
            // 
            dataGridView_Imput.AllowUserToAddRows = false;
            dataGridView_Imput.AllowUserToDeleteRows = false;
            dataGridView_Imput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Imput.ColumnHeadersVisible = false;
            dataGridView_Imput.EnableHeadersVisualStyles = false;
            dataGridView_Imput.GridColor = SystemColors.Desktop;
            dataGridView_Imput.Location = new Point(25, 28);
            dataGridView_Imput.Margin = new Padding(3, 4, 3, 4);
            dataGridView_Imput.Name = "dataGridView_Imput";
            dataGridView_Imput.RowHeadersVisible = false;
            dataGridView_Imput.RowHeadersWidth = 51;
            dataGridView_Imput.Size = new Size(766, 673);
            dataGridView_Imput.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1696, 1055);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1712, 1018);
            Name = "Form1";
            Text = "Спринт 6 | Таск 7 | Вариант 27 | Москалев Е.А.";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Res).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Imput).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button_Save;
        private Button button_Spr;
        private Button button_Go;
        private Button button_Imput;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView_Res;
        private DataGridView dataGridView_Imput;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private SaveFileDialog saveFileDialog1;
    }
}