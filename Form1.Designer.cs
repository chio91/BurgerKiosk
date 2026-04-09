namespace BurgerKiosk
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
            lblAppname = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpMenu = new GroupBox();
            grpOpction = new GroupBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btninit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpMenu.SuspendLayout();
            grpOpction.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppname
            // 
            lblAppname.AutoSize = true;
            lblAppname.Font = new Font("맑은 고딕", 27.8571434F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppname.ForeColor = Color.DarkBlue;
            lblAppname.Location = new Point(27, 24);
            lblAppname.Name = "lblAppname";
            lblAppname.Size = new Size(603, 87);
            lblAppname.TabIndex = 0;
            lblAppname.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 9F);
            rdoHamBurger.ForeColor = SystemColors.ControlText;
            rdoHamBurger.Location = new Point(17, 80);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(101, 34);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 9F);
            rdoBulgogiBurger.ForeColor = SystemColors.ControlText;
            rdoBulgogiBurger.Location = new Point(17, 190);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(143, 34);
            rdoBulgogiBurger.TabIndex = 2;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 9F);
            rdoChickenBurger.ForeColor = SystemColors.ControlText;
            rdoChickenBurger.Location = new Point(17, 300);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(122, 34);
            rdoChickenBurger.TabIndex = 3;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(176, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(176, 278);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(175, 104);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 9F);
            chkPotato.ForeColor = SystemColors.ControlText;
            chkPotato.Location = new Point(17, 52);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(123, 34);
            chkPotato.TabIndex = 7;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 9F);
            chkCola.ForeColor = SystemColors.ControlText;
            chkCola.Location = new Point(17, 106);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(81, 34);
            chkCola.TabIndex = 8;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 9F);
            chkCheese.ForeColor = SystemColors.ControlText;
            chkCheese.Location = new Point(17, 162);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(130, 34);
            chkCheese.TabIndex = 9;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 9F);
            chkSauce.ForeColor = SystemColors.ControlText;
            chkSauce.Location = new Point(17, 222);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(130, 34);
            chkSauce.TabIndex = 10;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(pictureBox1);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(pictureBox3);
            grpMenu.Controls.Add(pictureBox2);
            grpMenu.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.Chocolate;
            grpMenu.Location = new Point(27, 128);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(367, 411);
            grpMenu.TabIndex = 11;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // grpOpction
            // 
            grpOpction.Controls.Add(chkPotato);
            grpOpction.Controls.Add(chkSauce);
            grpOpction.Controls.Add(chkCola);
            grpOpction.Controls.Add(chkCheese);
            grpOpction.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOpction.ForeColor = Color.Chocolate;
            grpOpction.Location = new Point(417, 128);
            grpOpction.Name = "grpOpction";
            grpOpction.Size = new Size(245, 299);
            grpOpction.TabIndex = 7;
            grpOpction.TabStop = false;
            grpOpction.Text = "추가 옵션";
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.Chocolate;
            grpOrder.Location = new Point(683, 128);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(333, 351);
            grpOrder.TabIndex = 12;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = Color.CornflowerBlue;
            lblTotalCost.Location = new Point(6, 296);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(182, 38);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(6, 44);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(321, 232);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.LimeGreen;
            btnOrder.Font = new Font("맑은 고딕", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = SystemColors.ControlLight;
            btnOrder.Location = new Point(689, 509);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(144, 52);
            btnOrder.TabIndex = 13;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btninit
            // 
            btninit.BackColor = Color.Red;
            btninit.Font = new Font("맑은 고딕", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btninit.ForeColor = SystemColors.ControlLight;
            btninit.Location = new Point(885, 509);
            btninit.Name = "btninit";
            btninit.Size = new Size(131, 52);
            btninit.TabIndex = 14;
            btninit.Text = "초기화";
            btninit.UseVisualStyleBackColor = false;
            btninit.Click += btninit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 603);
            Controls.Add(btninit);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(grpOpction);
            Controls.Add(lblAppname);
            Controls.Add(grpMenu);
            Name = "Form1";
            Text = "Burger Kiosk 1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpOpction.ResumeLayout(false);
            grpOpction.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppname;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpMenu;
        private GroupBox grpOpction;
        private GroupBox grpOrder;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btninit;
    }
}
