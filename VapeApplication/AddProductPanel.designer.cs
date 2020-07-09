namespace VapeApplication
{
    partial class AddProductPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.discountTB = new System.Windows.Forms.TextBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.addQuantityTB = new System.Windows.Forms.TextBox();
            this.labelPlus = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.BackBnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фото";
            // 
            // nameTB
            // 
            this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTB.Location = new System.Drawing.Point(18, 38);
            this.nameTB.MaximumSize = new System.Drawing.Size(450, 30);
            this.nameTB.MinimumSize = new System.Drawing.Size(150, 30);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(448, 30);
            this.nameTB.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.ImageLocation = "";
            this.pictureBox.Location = new System.Drawing.Point(18, 398);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Описание";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Скидка (%)";
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(246, 473);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(222, 56);
            this.buttonAddImage.TabIndex = 12;
            this.buttonAddImage.Text = "Добавить фото";
            this.buttonAddImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddImage.UseVisualStyleBackColor = false;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // descriptionTB
            // 
            this.descriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTB.Location = new System.Drawing.Point(18, 579);
            this.descriptionTB.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.descriptionTB.MaximumSize = new System.Drawing.Size(450, 150);
            this.descriptionTB.MinimumSize = new System.Drawing.Size(150, 30);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(448, 150);
            this.descriptionTB.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Количество";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(18, 734);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(138, 53);
            this.buttonAddProduct.TabIndex = 19;
            this.buttonAddProduct.Text = "Добавить";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // quantityTB
            // 
            this.quantityTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityTB.Location = new System.Drawing.Point(18, 331);
            this.quantityTB.MaximumSize = new System.Drawing.Size(450, 30);
            this.quantityTB.MinimumSize = new System.Drawing.Size(150, 30);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(448, 30);
            this.quantityTB.TabIndex = 18;
            // 
            // discountTB
            // 
            this.discountTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discountTB.Location = new System.Drawing.Point(18, 258);
            this.discountTB.MaximumSize = new System.Drawing.Size(450, 30);
            this.discountTB.MinimumSize = new System.Drawing.Size(150, 30);
            this.discountTB.Name = "discountTB";
            this.discountTB.Size = new System.Drawing.Size(448, 30);
            this.discountTB.TabIndex = 15;
            // 
            // priceTB
            // 
            this.priceTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTB.Location = new System.Drawing.Point(18, 184);
            this.priceTB.MaximumSize = new System.Drawing.Size(450, 30);
            this.priceTB.MinimumSize = new System.Drawing.Size(150, 30);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(448, 30);
            this.priceTB.TabIndex = 14;
            // 
            // CategoryBox
            // 
            this.CategoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(18, 109);
            this.CategoryBox.MaximumSize = new System.Drawing.Size(450, 0);
            this.CategoryBox.MinimumSize = new System.Drawing.Size(150, 0);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(448, 33);
            this.CategoryBox.TabIndex = 20;
            // 
            // addQuantityTB
            // 
            this.addQuantityTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addQuantityTB.Location = new System.Drawing.Point(502, 331);
            this.addQuantityTB.Name = "addQuantityTB";
            this.addQuantityTB.Size = new System.Drawing.Size(89, 30);
            this.addQuantityTB.TabIndex = 21;
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Location = new System.Drawing.Point(472, 334);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(24, 25);
            this.labelPlus.TabIndex = 22;
            this.labelPlus.Text = "+";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(172, 734);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(140, 53);
            this.deleteBtn.TabIndex = 23;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // BackBnt
            // 
            this.BackBnt.Location = new System.Drawing.Point(318, 734);
            this.BackBnt.Name = "BackBnt";
            this.BackBnt.Size = new System.Drawing.Size(150, 53);
            this.BackBnt.TabIndex = 24;
            this.BackBnt.Text = "Назад";
            this.BackBnt.UseVisualStyleBackColor = true;
            this.BackBnt.Click += new System.EventHandler(this.BackBnt_Click);
            // 
            // AddProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.BackBnt);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.addQuantityTB);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.discountTB);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddProductPanel";
            this.Size = new System.Drawing.Size(805, 798);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TextBox quantityTB;
        private System.Windows.Forms.TextBox discountTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.TextBox addQuantityTB;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button BackBnt;
    }
}
