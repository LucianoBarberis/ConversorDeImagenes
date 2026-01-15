namespace Conversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            cbOrigen = new ComboBox();
            cbFinal = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnConvertir = new Button();
            pictureBox1 = new PictureBox();
            btnLoadImg = new Button();
            lblImgName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(11, 9);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Conversor de Imagenes";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbOrigen
            // 
            cbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrigen.FormattingEnabled = true;
            cbOrigen.Items.AddRange(new object[] { "PNG", "JPG", "JPEG", "GIF", "ICO" });
            cbOrigen.Location = new Point(9, 139);
            cbOrigen.Margin = new Padding(2);
            cbOrigen.Name = "cbOrigen";
            cbOrigen.Size = new Size(134, 28);
            cbOrigen.TabIndex = 1;
            // 
            // cbFinal
            // 
            cbFinal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFinal.FormattingEnabled = true;
            cbFinal.Items.AddRange(new object[] { "PNG", "JPG", "JPEG", "WebP", "GIF", "ICO" });
            cbFinal.Location = new Point(175, 139);
            cbFinal.Margin = new Padding(2);
            cbFinal.Name = "cbFinal";
            cbFinal.Size = new Size(134, 28);
            cbFinal.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 117);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(175, 117);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 4;
            label2.Text = "Final";
            // 
            // btnConvertir
            // 
            btnConvertir.Enabled = false;
            btnConvertir.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConvertir.Location = new Point(8, 406);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(302, 48);
            btnConvertir.TabIndex = 5;
            btnConvertir.Text = "Transformar";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnLoadImg
            // 
            btnLoadImg.Location = new Point(8, 65);
            btnLoadImg.Name = "btnLoadImg";
            btnLoadImg.Size = new Size(135, 36);
            btnLoadImg.TabIndex = 7;
            btnLoadImg.Text = "Cargar Imagen";
            btnLoadImg.UseVisualStyleBackColor = true;
            btnLoadImg.Click += btnLoadImg_Click;
            // 
            // lblImgName
            // 
            lblImgName.AutoSize = true;
            lblImgName.Location = new Point(149, 73);
            lblImgName.Name = "lblImgName";
            lblImgName.Size = new Size(0, 20);
            lblImgName.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 471);
            Controls.Add(lblImgName);
            Controls.Add(btnLoadImg);
            Controls.Add(pictureBox1);
            Controls.Add(btnConvertir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbFinal);
            Controls.Add(cbOrigen);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor de Imagenes | Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ComboBox cbOrigen;
        private ComboBox cbFinal;
        private Label label1;
        private Label label2;
        private Button btnConvertir;
        private PictureBox pictureBox1;
        private Button btnLoadImg;
        private Label lblImgName;
    }
}
