namespace BanRX
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            addyTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            checkButton = new Guna.UI2.WinForms.Guna2GradientButton();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            onemin = new Label();
            tenmin = new Label();
            onehour = new Label();
            twelvehour = new Label();
            twentyfourhour = new Label();
            label9 = new Label();
            acceptedshares = new Label();
            label10 = new Label();
            label11 = new Label();
            totalhashes = new Label();
            label12 = new Label();
            lastsubmitted = new Label();
            label13 = new Label();
            paid = new Label();
            label14 = new Label();
            pending = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 28);
            label1.Name = "label1";
            label1.Size = new Size(336, 44);
            label1.TabIndex = 0;
            label1.Text = "BANRX Monitor";
            // 
            // addyTextBox
            // 
            addyTextBox.CustomizableEdges = customizableEdges9;
            addyTextBox.DefaultText = "";
            addyTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            addyTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            addyTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            addyTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            addyTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            addyTextBox.Font = new Font("Segoe UI", 9F);
            addyTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            addyTextBox.Location = new Point(148, 105);
            addyTextBox.Name = "addyTextBox";
            addyTextBox.PasswordChar = '\0';
            addyTextBox.PlaceholderText = "";
            addyTextBox.SelectedText = "";
            addyTextBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            addyTextBox.Size = new Size(439, 22);
            addyTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(323, 87);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Banano Address";
            // 
            // checkButton
            // 
            checkButton.CustomizableEdges = customizableEdges11;
            checkButton.DisabledState.BorderColor = Color.DarkGray;
            checkButton.DisabledState.CustomBorderColor = Color.DarkGray;
            checkButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            checkButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            checkButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            checkButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkButton.ForeColor = Color.White;
            checkButton.Location = new Point(282, 133);
            checkButton.Name = "checkButton";
            checkButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            checkButton.Size = new Size(180, 25);
            checkButton.TabIndex = 3;
            checkButton.Text = "Check My Address!";
            checkButton.Click += checkButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(82, 209);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 4;
            label3.Text = "Hashrate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(21, 245);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 5;
            label4.Text = "1m";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(64, 245);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 6;
            label5.Text = "10m";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(113, 245);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 7;
            label6.Text = "1h";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(159, 245);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 8;
            label7.Text = "12h";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(210, 245);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 9;
            label8.Text = "24h";
            // 
            // onemin
            // 
            onemin.AutoSize = true;
            onemin.Location = new Point(23, 264);
            onemin.Name = "onemin";
            onemin.Size = new Size(13, 15);
            onemin.TabIndex = 10;
            onemin.Text = "x";
            // 
            // tenmin
            // 
            tenmin.AutoSize = true;
            tenmin.Location = new Point(65, 264);
            tenmin.Name = "tenmin";
            tenmin.Size = new Size(13, 15);
            tenmin.TabIndex = 11;
            tenmin.Text = "x";
            // 
            // onehour
            // 
            onehour.AutoSize = true;
            onehour.Location = new Point(114, 264);
            onehour.Name = "onehour";
            onehour.Size = new Size(13, 15);
            onehour.TabIndex = 12;
            onehour.Text = "x";
            // 
            // twelvehour
            // 
            twelvehour.AutoSize = true;
            twelvehour.Location = new Point(161, 264);
            twelvehour.Name = "twelvehour";
            twelvehour.Size = new Size(13, 15);
            twelvehour.TabIndex = 13;
            twelvehour.Text = "x";
            // 
            // twentyfourhour
            // 
            twentyfourhour.AutoSize = true;
            twentyfourhour.Location = new Point(210, 264);
            twentyfourhour.Name = "twentyfourhour";
            twentyfourhour.Size = new Size(13, 15);
            twentyfourhour.TabIndex = 14;
            twentyfourhour.Text = "x";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.Location = new Point(330, 209);
            label9.Name = "label9";
            label9.Size = new Size(157, 25);
            label9.TabIndex = 15;
            label9.Text = "Accepted Shares";
            // 
            // acceptedshares
            // 
            acceptedshares.AutoSize = true;
            acceptedshares.Font = new Font("Segoe UI", 14F);
            acceptedshares.Location = new Point(323, 245);
            acceptedshares.Name = "acceptedshares";
            acceptedshares.Size = new Size(21, 25);
            acceptedshares.TabIndex = 16;
            acceptedshares.Text = "x";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label10.Location = new Point(322, 213);
            label10.Name = "label10";
            label10.Size = new Size(157, 25);
            label10.TabIndex = 17;
            label10.Text = "Accepted Shares";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(582, 213);
            label11.Name = "label11";
            label11.Size = new Size(122, 25);
            label11.TabIndex = 18;
            label11.Text = "Total Hashes";
            // 
            // totalhashes
            // 
            totalhashes.AutoSize = true;
            totalhashes.Font = new Font("Segoe UI", 14F);
            totalhashes.Location = new Point(583, 245);
            totalhashes.Name = "totalhashes";
            totalhashes.Size = new Size(21, 25);
            totalhashes.TabIndex = 19;
            totalhashes.Text = "x";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label12.Location = new Point(65, 330);
            label12.Name = "label12";
            label12.Size = new Size(145, 25);
            label12.TabIndex = 20;
            label12.Text = "Last Submitted";
            // 
            // lastsubmitted
            // 
            lastsubmitted.AutoSize = true;
            lastsubmitted.Font = new Font("Segoe UI", 14F);
            lastsubmitted.Location = new Point(65, 365);
            lastsubmitted.Name = "lastsubmitted";
            lastsubmitted.Size = new Size(21, 25);
            lastsubmitted.TabIndex = 21;
            lastsubmitted.Text = "x";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label13.ForeColor = Color.LawnGreen;
            label13.Location = new Point(321, 330);
            label13.Name = "label13";
            label13.Size = new Size(51, 25);
            label13.TabIndex = 22;
            label13.Text = "Paid";
            // 
            // paid
            // 
            paid.AutoSize = true;
            paid.Font = new Font("Segoe UI", 14F);
            paid.Location = new Point(323, 364);
            paid.Name = "paid";
            paid.Size = new Size(21, 25);
            paid.TabIndex = 23;
            paid.Text = "x";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label14.ForeColor = Color.DarkOrange;
            label14.Location = new Point(581, 330);
            label14.Name = "label14";
            label14.Size = new Size(86, 25);
            label14.TabIndex = 24;
            label14.Text = "Pending";
            // 
            // pending
            // 
            pending.AutoSize = true;
            pending.Font = new Font("Segoe UI", 14F);
            pending.Location = new Point(583, 364);
            pending.Name = "pending";
            pending.Size = new Size(21, 25);
            pending.TabIndex = 25;
            pending.Text = "x";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 406);
            Controls.Add(pending);
            Controls.Add(label14);
            Controls.Add(paid);
            Controls.Add(label13);
            Controls.Add(lastsubmitted);
            Controls.Add(label12);
            Controls.Add(totalhashes);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(acceptedshares);
            Controls.Add(label9);
            Controls.Add(twentyfourhour);
            Controls.Add(twelvehour);
            Controls.Add(onehour);
            Controls.Add(tenmin);
            Controls.Add(onemin);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkButton);
            Controls.Add(label2);
            Controls.Add(addyTextBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "BANRX Monitor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox addyTextBox;
        private Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton checkButton;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label onemin;
        private Label tenmin;
        private Label onehour;
        private Label twelvehour;
        private Label twentyfourhour;
        private Label label9;
        private Label acceptedshares;
        private Label label10;
        private Label label11;
        private Label totalhashes;
        private Label label12;
        private Label lastsubmitted;
        private Label label13;
        private Label paid;
        private Label label14;
        private Label pending;
    }
}
