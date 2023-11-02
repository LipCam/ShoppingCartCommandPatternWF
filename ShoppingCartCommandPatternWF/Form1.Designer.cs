namespace ShoppingCartCommandPatternWF
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
            btnAddCart = new Button();
            btnAddReservList = new Button();
            btnUndo = new Button();
            label1 = new Label();
            label2 = new Label();
            lblQtdCart = new Label();
            lblQtdReservList = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            lblTotalCart = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddCart
            // 
            btnAddCart.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCart.Location = new Point(83, 143);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(206, 70);
            btnAddCart.TabIndex = 0;
            btnAddCart.Text = "Add Carrinho";
            btnAddCart.UseVisualStyleBackColor = true;
            btnAddCart.Click += btnAddCart_Click;
            // 
            // btnAddReservList
            // 
            btnAddReservList.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddReservList.Location = new Point(360, 143);
            btnAddReservList.Name = "btnAddReservList";
            btnAddReservList.Size = new Size(206, 70);
            btnAddReservList.TabIndex = 1;
            btnAddReservList.Text = "Add Reserva";
            btnAddReservList.UseVisualStyleBackColor = true;
            btnAddReservList.Click += btnAddReservList_Click;
            // 
            // btnUndo
            // 
            btnUndo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnUndo.Location = new Point(216, 231);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(206, 70);
            btnUndo.TabIndex = 2;
            btnUndo.Text = "Desfazer";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 3;
            label1.Text = "Carrinho:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 4;
            label2.Text = "Reservas:";
            // 
            // lblQtdCart
            // 
            lblQtdCart.AutoSize = true;
            lblQtdCart.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblQtdCart.Location = new Point(101, 12);
            lblQtdCart.Name = "lblQtdCart";
            lblQtdCart.Size = new Size(23, 28);
            lblQtdCart.TabIndex = 5;
            lblQtdCart.Text = "0";
            // 
            // lblQtdReservList
            // 
            lblQtdReservList.AutoSize = true;
            lblQtdReservList.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblQtdReservList.Location = new Point(101, 40);
            lblQtdReservList.Name = "lblQtdReservList";
            lblQtdReservList.Size = new Size(23, 28);
            lblQtdReservList.TabIndex = 6;
            lblQtdReservList.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 40);
            label3.Name = "label3";
            label3.Size = new Size(350, 37);
            label3.TabIndex = 7;
            label3.Text = "Barraca de Camping Grande";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblTotalCart);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblQtdReservList);
            panel1.Controls.Add(lblQtdCart);
            panel1.Location = new Point(387, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 109);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 68);
            label5.Name = "label5";
            label5.Size = new Size(58, 28);
            label5.TabIndex = 7;
            label5.Text = "Total:";
            // 
            // lblTotalCart
            // 
            lblTotalCart.AutoSize = true;
            lblTotalCart.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalCart.Location = new Point(101, 68);
            lblTotalCart.Name = "lblTotalCart";
            lblTotalCart.Size = new Size(23, 28);
            lblTotalCart.TabIndex = 8;
            lblTotalCart.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 21);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 9;
            label4.Text = "Produto:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 331);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(btnUndo);
            Controls.Add(btnAddReservList);
            Controls.Add(btnAddCart);
            Name = "Form1";
            Text = "Carrinho";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCart;
        private Button btnAddReservList;
        private Button btnUndo;
        private Label label1;
        private Label label2;
        private Label lblQtdCart;
        private Label lblQtdReservList;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label lblTotalCart;
    }
}