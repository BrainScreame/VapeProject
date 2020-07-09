namespace VapeApplication
{
    partial class ListItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListItem));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQantity = new System.Windows.Forms.Label();
            this.buttonAddBasket = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelNewPrice = new System.Windows.Forms.Label();
            this.labelCart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(220, 216);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(250, 4);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(126, 23);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Trix WORLD";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxDescription.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxDescription.Location = new System.Drawing.Point(254, 39);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(700, 115);
            this.textBoxDescription.TabIndex = 3;
            this.textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(250, 190);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(58, 19);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "ЦЕНА ";
            // 
            // labelQantity
            // 
            this.labelQantity.AutoSize = true;
            this.labelQantity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQantity.Location = new System.Drawing.Point(250, 157);
            this.labelQantity.Name = "labelQantity";
            this.labelQantity.Size = new System.Drawing.Size(85, 19);
            this.labelQantity.TabIndex = 5;
            this.labelQantity.Text = "В наличии:";
            // 
            // buttonAddBasket
            // 
            this.buttonAddBasket.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddBasket.Location = new System.Drawing.Point(820, 184);
            this.buttonAddBasket.Name = "buttonAddBasket";
            this.buttonAddBasket.Size = new System.Drawing.Size(125, 30);
            this.buttonAddBasket.TabIndex = 6;
            this.buttonAddBasket.Text = "В корзину";
            this.buttonAddBasket.UseVisualStyleBackColor = true;
            this.buttonAddBasket.Click += new System.EventHandler(this.buttonAddBasket_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(775, 189);
            this.textBoxCount.Multiline = true;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(39, 22);
            this.textBoxCount.TabIndex = 7;
            this.textBoxCount.Text = "1";
            this.textBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCount_KeyPress);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonEdit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(775, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(179, 37);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelNewPrice
            // 
            this.labelNewPrice.AutoSize = true;
            this.labelNewPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewPrice.Location = new System.Drawing.Point(425, 190);
            this.labelNewPrice.Name = "labelNewPrice";
            this.labelNewPrice.Size = new System.Drawing.Size(88, 19);
            this.labelNewPrice.TabIndex = 9;
            this.labelNewPrice.Text = "Новая цена";
            // 
            // labelCart
            // 
            this.labelCart.AutoSize = true;
            this.labelCart.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCart.Location = new System.Drawing.Point(771, 157);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(84, 19);
            this.labelCart.TabIndex = 10;
            this.labelCart.Text = "В корзине:";
            this.labelCart.Visible = false;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelCart);
            this.Controls.Add(this.labelNewPrice);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonAddBasket);
            this.Controls.Add(this.labelQantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(957, 223);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQantity;
        private System.Windows.Forms.Button buttonAddBasket;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelNewPrice;
        private System.Windows.Forms.Label labelCart;
    }
}
