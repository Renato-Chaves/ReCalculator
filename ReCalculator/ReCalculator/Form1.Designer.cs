namespace ReCalculator
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
            Container = new GroupBox();
            Operation = new Label();
            SubDisplay = new Label();
            Equal = new Button();
            Decimal = new Button();
            Zero = new Button();
            DarkSwitch = new Button();
            Three = new Button();
            Two = new Button();
            One = new Button();
            Plus = new Button();
            Six = new Button();
            Five = new Button();
            Four = new Button();
            Minus = new Button();
            Nine = new Button();
            Eight = new Button();
            Seven = new Button();
            Clear = new Button();
            Multiply = new Button();
            Division = new Button();
            Backspace = new Button();
            Display = new TextBox();
            Container.SuspendLayout();
            SuspendLayout();
            // 
            // Container
            // 
            Container.BackgroundImageLayout = ImageLayout.None;
            Container.Controls.Add(Operation);
            Container.Controls.Add(SubDisplay);
            Container.Controls.Add(Equal);
            Container.Controls.Add(Decimal);
            Container.Controls.Add(Zero);
            Container.Controls.Add(DarkSwitch);
            Container.Controls.Add(Three);
            Container.Controls.Add(Two);
            Container.Controls.Add(One);
            Container.Controls.Add(Plus);
            Container.Controls.Add(Six);
            Container.Controls.Add(Five);
            Container.Controls.Add(Four);
            Container.Controls.Add(Minus);
            Container.Controls.Add(Nine);
            Container.Controls.Add(Eight);
            Container.Controls.Add(Seven);
            Container.Controls.Add(Clear);
            Container.Controls.Add(Multiply);
            Container.Controls.Add(Division);
            Container.Controls.Add(Backspace);
            Container.Controls.Add(Display);
            Container.FlatStyle = FlatStyle.Popup;
            Container.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            Container.Location = new Point(2, 0);
            Container.Name = "Container";
            Container.Size = new Size(320, 521);
            Container.TabIndex = 0;
            Container.TabStop = false;
            // 
            // Operation
            // 
            Operation.AutoSize = true;
            Operation.BackColor = Color.FromArgb(217, 217, 217);
            Operation.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Operation.Location = new Point(10, 32);
            Operation.Name = "Operation";
            Operation.Size = new Size(0, 25);
            Operation.TabIndex = 22;
            // 
            // SubDisplay
            // 
            SubDisplay.AutoSize = true;
            SubDisplay.BackColor = Color.Transparent;
            SubDisplay.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SubDisplay.ForeColor = SystemColors.InactiveCaption;
            SubDisplay.Location = new Point(8, 2);
            SubDisplay.Name = "SubDisplay";
            SubDisplay.Size = new Size(0, 30);
            SubDisplay.TabIndex = 21;
            // 
            // Equal
            // 
            Equal.BackColor = Color.FromArgb(250, 150, 56);
            Equal.FlatAppearance.BorderColor = Color.FromArgb(214, 121, 44);
            Equal.FlatAppearance.BorderSize = 4;
            Equal.FlatStyle = FlatStyle.Flat;
            Equal.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Equal.Image = Properties.Resources.Equal;
            Equal.Location = new Point(242, 358);
            Equal.Margin = new Padding(7);
            Equal.Name = "Equal";
            Equal.Size = new Size(64, 142);
            Equal.TabIndex = 20;
            Equal.UseVisualStyleBackColor = false;
            // 
            // Decimal
            // 
            Decimal.BackColor = Color.FromArgb(217, 217, 217);
            Decimal.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            Decimal.FlatAppearance.BorderSize = 4;
            Decimal.FlatStyle = FlatStyle.Flat;
            Decimal.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Decimal.Image = Properties.Resources.Decimal;
            Decimal.Location = new Point(166, 436);
            Decimal.Margin = new Padding(7);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(64, 64);
            Decimal.TabIndex = 19;
            Decimal.UseVisualStyleBackColor = false;
            // 
            // Zero
            // 
            Zero.BackColor = Color.FromArgb(217, 217, 217);
            Zero.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            Zero.FlatAppearance.BorderSize = 4;
            Zero.FlatStyle = FlatStyle.Flat;
            Zero.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Zero.Image = Properties.Resources._0;
            Zero.Location = new Point(90, 436);
            Zero.Margin = new Padding(7);
            Zero.Name = "Zero";
            Zero.Size = new Size(64, 64);
            Zero.TabIndex = 18;
            Zero.UseVisualStyleBackColor = false;
            Zero.Click += OnButtonPress;
            // 
            // DarkSwitch
            // 
            DarkSwitch.BackColor = Color.FromArgb(217, 217, 217);
            DarkSwitch.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            DarkSwitch.FlatAppearance.BorderSize = 4;
            DarkSwitch.FlatStyle = FlatStyle.Flat;
            DarkSwitch.Image = Properties.Resources.DarkSwitch;
            DarkSwitch.Location = new Point(14, 436);
            DarkSwitch.Margin = new Padding(7);
            DarkSwitch.Name = "DarkSwitch";
            DarkSwitch.Size = new Size(64, 64);
            DarkSwitch.TabIndex = 17;
            DarkSwitch.UseVisualStyleBackColor = false;
            // 
            // Three
            // 
            Three.BackColor = Color.FromArgb(217, 217, 217);
            Three.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            Three.FlatAppearance.BorderSize = 4;
            Three.FlatStyle = FlatStyle.Flat;
            Three.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Three.Image = Properties.Resources._3;
            Three.Location = new Point(166, 358);
            Three.Margin = new Padding(7);
            Three.Name = "Three";
            Three.Size = new Size(64, 64);
            Three.TabIndex = 15;
            Three.UseVisualStyleBackColor = false;
            Three.Click += OnButtonPress;
            // 
            // Two
            // 
            Two.BackColor = Color.FromArgb(217, 217, 217);
            Two.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            Two.FlatAppearance.BorderSize = 4;
            Two.FlatStyle = FlatStyle.Flat;
            Two.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Two.Image = Properties.Resources._2;
            Two.Location = new Point(90, 358);
            Two.Margin = new Padding(7);
            Two.Name = "Two";
            Two.Size = new Size(64, 64);
            Two.TabIndex = 14;
            Two.UseVisualStyleBackColor = false;
            Two.Click += OnButtonPress;
            // 
            // One
            // 
            One.BackColor = Color.FromArgb(217, 217, 217);
            One.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            One.FlatAppearance.BorderSize = 4;
            One.FlatStyle = FlatStyle.Flat;
            One.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            One.Image = Properties.Resources._1;
            One.Location = new Point(14, 358);
            One.Margin = new Padding(7);
            One.Name = "One";
            One.Size = new Size(64, 64);
            One.TabIndex = 13;
            One.UseVisualStyleBackColor = false;
            One.Click += OnButtonPress;
            // 
            // Plus
            // 
            Plus.BackColor = Color.FromArgb(250, 150, 56);
            Plus.FlatAppearance.BorderColor = Color.FromArgb(214, 121, 44);
            Plus.FlatAppearance.BorderSize = 4;
            Plus.FlatStyle = FlatStyle.Flat;
            Plus.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Plus.Image = Properties.Resources.Plus;
            Plus.Location = new Point(242, 280);
            Plus.Margin = new Padding(7);
            Plus.Name = "Plus";
            Plus.Size = new Size(64, 64);
            Plus.TabIndex = 12;
            Plus.UseVisualStyleBackColor = false;
            Plus.Click += OnButtonPress;
            // 
            // Six
            // 
            Six.BackColor = Color.FromArgb(217, 217, 217);
            Six.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            Six.FlatAppearance.BorderSize = 4;
            Six.FlatStyle = FlatStyle.Flat;
            Six.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Six.Image = Properties.Resources._6;
            Six.Location = new Point(166, 280);
            Six.Margin = new Padding(7);
            Six.Name = "Six";
            Six.Size = new Size(64, 64);
            Six.TabIndex = 11;
            Six.UseVisualStyleBackColor = false;
            Six.Click += OnButtonPress;
            // 
            // Five
            // 
            Five.BackColor = Color.FromArgb(217, 217, 217);
            Five.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            Five.FlatAppearance.BorderSize = 4;
            Five.FlatStyle = FlatStyle.Flat;
            Five.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Five.Image = Properties.Resources._5;
            Five.Location = new Point(90, 280);
            Five.Margin = new Padding(7);
            Five.Name = "Five";
            Five.Size = new Size(64, 64);
            Five.TabIndex = 10;
            Five.UseVisualStyleBackColor = false;
            Five.Click += OnButtonPress;
            // 
            // Four
            // 
            Four.BackColor = Color.FromArgb(217, 217, 217);
            Four.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            Four.FlatAppearance.BorderSize = 4;
            Four.FlatStyle = FlatStyle.Flat;
            Four.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Four.Image = Properties.Resources._4;
            Four.Location = new Point(14, 280);
            Four.Margin = new Padding(7);
            Four.Name = "Four";
            Four.Size = new Size(64, 64);
            Four.TabIndex = 9;
            Four.UseVisualStyleBackColor = false;
            Four.Click += OnButtonPress;
            // 
            // Minus
            // 
            Minus.BackColor = Color.FromArgb(250, 150, 56);
            Minus.FlatAppearance.BorderColor = Color.FromArgb(214, 121, 44);
            Minus.FlatAppearance.BorderSize = 4;
            Minus.FlatStyle = FlatStyle.Flat;
            Minus.Font = new Font("Impact", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Minus.Image = Properties.Resources.Minus;
            Minus.Location = new Point(242, 202);
            Minus.Margin = new Padding(7);
            Minus.Name = "Minus";
            Minus.Size = new Size(64, 64);
            Minus.TabIndex = 8;
            Minus.UseVisualStyleBackColor = false;
            Minus.Click += OnButtonPress;
            // 
            // Nine
            // 
            Nine.BackColor = Color.FromArgb(217, 217, 217);
            Nine.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            Nine.FlatAppearance.BorderSize = 4;
            Nine.FlatStyle = FlatStyle.Flat;
            Nine.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Nine.Image = Properties.Resources._9;
            Nine.Location = new Point(166, 202);
            Nine.Margin = new Padding(7);
            Nine.Name = "Nine";
            Nine.Size = new Size(64, 64);
            Nine.TabIndex = 7;
            Nine.UseVisualStyleBackColor = false;
            Nine.Click += OnButtonPress;
            // 
            // Eight
            // 
            Eight.BackColor = Color.FromArgb(217, 217, 217);
            Eight.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            Eight.FlatAppearance.BorderSize = 4;
            Eight.FlatStyle = FlatStyle.Flat;
            Eight.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Eight.Image = Properties.Resources._8;
            Eight.Location = new Point(90, 202);
            Eight.Margin = new Padding(7);
            Eight.Name = "Eight";
            Eight.Size = new Size(64, 64);
            Eight.TabIndex = 6;
            Eight.UseVisualStyleBackColor = false;
            Eight.Click += OnButtonPress;
            // 
            // Seven
            // 
            Seven.BackColor = Color.FromArgb(217, 217, 217);
            Seven.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            Seven.FlatAppearance.BorderSize = 4;
            Seven.FlatStyle = FlatStyle.Flat;
            Seven.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Seven.Image = Properties.Resources._7;
            Seven.Location = new Point(14, 202);
            Seven.Margin = new Padding(7);
            Seven.Name = "Seven";
            Seven.Size = new Size(64, 64);
            Seven.TabIndex = 5;
            Seven.UseVisualStyleBackColor = false;
            Seven.Click += OnButtonPress;
            // 
            // Clear
            // 
            Clear.BackColor = Color.FromArgb(250, 150, 56);
            Clear.FlatAppearance.BorderColor = Color.FromArgb(214, 121, 44);
            Clear.FlatAppearance.BorderSize = 4;
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.Image = Properties.Resources.C;
            Clear.Location = new Point(242, 124);
            Clear.Margin = new Padding(7);
            Clear.Name = "Clear";
            Clear.Size = new Size(64, 64);
            Clear.TabIndex = 4;
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += OnButtonPress;
            // 
            // Multiply
            // 
            Multiply.BackColor = Color.FromArgb(250, 150, 56);
            Multiply.FlatAppearance.BorderColor = Color.FromArgb(214, 121, 44);
            Multiply.FlatAppearance.BorderSize = 4;
            Multiply.FlatStyle = FlatStyle.Flat;
            Multiply.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Multiply.Image = Properties.Resources.Multiply;
            Multiply.Location = new Point(166, 124);
            Multiply.Margin = new Padding(7);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(64, 64);
            Multiply.TabIndex = 3;
            Multiply.TextAlign = ContentAlignment.MiddleRight;
            Multiply.UseVisualStyleBackColor = false;
            Multiply.Click += OnButtonPress;
            // 
            // Division
            // 
            Division.BackColor = Color.FromArgb(250, 150, 56);
            Division.FlatAppearance.BorderColor = Color.FromArgb(214, 121, 44);
            Division.FlatAppearance.BorderSize = 4;
            Division.FlatStyle = FlatStyle.Flat;
            Division.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Division.Image = Properties.Resources.Division;
            Division.Location = new Point(90, 124);
            Division.Margin = new Padding(7);
            Division.Name = "Division";
            Division.RightToLeft = RightToLeft.No;
            Division.Size = new Size(64, 64);
            Division.TabIndex = 2;
            Division.Text = " ";
            Division.TextAlign = ContentAlignment.MiddleLeft;
            Division.UseVisualStyleBackColor = false;
            Division.Click += OnButtonPress;
            // 
            // Backspace
            // 
            Backspace.BackColor = Color.FromArgb(250, 150, 56);
            Backspace.FlatAppearance.BorderColor = Color.FromArgb(214, 121, 44);
            Backspace.FlatAppearance.BorderSize = 4;
            Backspace.FlatStyle = FlatStyle.Flat;
            Backspace.Image = Properties.Resources.backspace;
            Backspace.Location = new Point(14, 124);
            Backspace.Margin = new Padding(7);
            Backspace.Name = "Backspace";
            Backspace.Size = new Size(64, 64);
            Backspace.TabIndex = 1;
            Backspace.UseVisualStyleBackColor = false;
            Backspace.Click += OnButtonPress;
            // 
            // Display
            // 
            Display.BackColor = Color.FromArgb(217, 217, 217);
            Display.Font = new Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point);
            Display.Location = new Point(10, 32);
            Display.Name = "Display";
            Display.Size = new Size(300, 82);
            Display.TabIndex = 0;
            Display.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 98, 103);
            ClientSize = new Size(324, 522);
            Controls.Add(Container);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ReCalculator";
            Container.ResumeLayout(false);
            Container.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Container;
        private Button Equal;
        private Button Decimal;
        private Button Zero;
        private Button DarkSwitch;
        private Button Three;
        private Button Two;
        private Button One;
        private Button Plus;
        private Button Six;
        private Button Five;
        private Button Four;
        private Button Minus;
        private Button Nine;
        private Button Eight;
        private Button Seven;
        private Button Clear;
        private Button Multiply;
        private Button Division;
        private Button Backspace;
        private TextBox Display;
        private Label Operation;
        private Label SubDisplay;
    }
}