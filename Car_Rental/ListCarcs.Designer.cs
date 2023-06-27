namespace Car_Rental
{
    partial class ListCarcs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            img = new PictureBox();
            txt_name = new Label();
            label1 = new Label();
            txt_owner = new Label();
            label2 = new Label();
            txt_price = new Label();
            label3 = new Label();
            btn_hire = new Button();
            btn_view = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            SuspendLayout();
            // 
            // img
            // 
            img.Location = new Point(3, 3);
            img.Name = "img";
            img.Size = new Size(216, 135);
            img.TabIndex = 0;
            img.TabStop = false;
            // 
            // txt_name
            // 
            txt_name.AutoSize = true;
            txt_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(11, 141);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(56, 23);
            txt_name.TabIndex = 1;
            txt_name.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 172);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Owner : ";
            // 
            // txt_owner
            // 
            txt_owner.AutoSize = true;
            txt_owner.Location = new Point(84, 171);
            txt_owner.Name = "txt_owner";
            txt_owner.Size = new Size(50, 20);
            txt_owner.TabIndex = 3;
            txt_owner.Text = "owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 204);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 4;
            label2.Text = "Price : ";
            // 
            // txt_price
            // 
            txt_price.AutoSize = true;
            txt_price.Location = new Point(87, 202);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(25, 20);
            txt_price.TabIndex = 5;
            txt_price.Text = "20";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 202);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 6;
            label3.Text = "$/1 day";
            // 
            // btn_hire
            // 
            btn_hire.BackColor = SystemColors.Highlight;
            btn_hire.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_hire.Location = new Point(3, 239);
            btn_hire.Name = "btn_hire";
            btn_hire.Size = new Size(77, 36);
            btn_hire.TabIndex = 7;
            btn_hire.Text = "HIRE";
            btn_hire.UseVisualStyleBackColor = false;
            btn_hire.Click += btn_hire_Click;
            // 
            // btn_view
            // 
            btn_view.BackColor = SystemColors.Highlight;
            btn_view.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_view.Location = new Point(112, 239);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(107, 36);
            btn_view.TabIndex = 8;
            btn_view.Text = "MORE VIEW";
            btn_view.UseVisualStyleBackColor = false;
            btn_view.Click += btn_view_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(59, 27);
            textBox1.TabIndex = 9;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(59, 27);
            textBox2.TabIndex = 10;
            textBox2.Visible = false;
            // 
            // ListCarcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_view);
            Controls.Add(btn_hire);
            Controls.Add(label3);
            Controls.Add(txt_price);
            Controls.Add(label2);
            Controls.Add(txt_owner);
            Controls.Add(label1);
            Controls.Add(txt_name);
            Controls.Add(img);
            Margin = new Padding(8, 10, 8, 10);
            Name = "ListCarcs";
            Size = new Size(222, 278);
            ((System.ComponentModel.ISupportInitialize)img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox img;
        private Label txt_name;
        private Label label1;
        private Label txt_owner;
        private Label label2;
        private Label txt_price;
        private Label label3;
        private Button btn_hire;
        private Button btn_view;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
