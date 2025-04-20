partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.metroTextbox1 = new MetroSuite.MetroTextbox();
            this.metroButton1 = new MetroSuite.MetroButton();
            this.siticoneRadioButton1 = new ns1.SiticoneRadioButton();
            this.siticoneRadioButton2 = new ns1.SiticoneRadioButton();
            this.siticoneRadioButton3 = new ns1.SiticoneRadioButton();
            this.siticoneRadioButton4 = new ns1.SiticoneRadioButton();
            this.siticoneCheckBox1 = new ns1.SiticoneCheckBox();
            this.siticoneCheckBox2 = new ns1.SiticoneCheckBox();
            this.siticoneCheckBox3 = new ns1.SiticoneCheckBox();
            this.siticoneRadioButton5 = new ns1.SiticoneRadioButton();
            this.siticoneRadioButton6 = new ns1.SiticoneRadioButton();
            this.SuspendLayout();
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(333, 7);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.Animated = true;
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(282, 7);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // metroTextbox1
            // 
            this.metroTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTextbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroTextbox1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroTextbox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.metroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroTextbox1.HideSelection = false;
            this.metroTextbox1.HoverColor = System.Drawing.Color.Red;
            this.metroTextbox1.Location = new System.Drawing.Point(22, 46);
            this.metroTextbox1.MaxLength = 88;
            this.metroTextbox1.Name = "metroTextbox1";
            this.metroTextbox1.PasswordChar = '\0';
            this.metroTextbox1.Size = new System.Drawing.Size(349, 23);
            this.metroTextbox1.Style = MetroSuite.Design.Style.Dark;
            this.metroTextbox1.TabIndex = 2;
            this.metroTextbox1.Text = "Insert the user token to lock here...";
            this.metroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroButton1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.metroButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.metroButton1.Location = new System.Drawing.Point(22, 146);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroButton1.RoundingArc = 23;
            this.metroButton1.Size = new System.Drawing.Size(349, 30);
            this.metroButton1.Style = MetroSuite.Design.Style.Dark;
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Lock token now";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // siticoneRadioButton1
            // 
            this.siticoneRadioButton1.AutoSize = true;
            this.siticoneRadioButton1.Checked = true;
            this.siticoneRadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRadioButton1.CheckedState.BorderThickness = 0;
            this.siticoneRadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneRadioButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRadioButton1.Location = new System.Drawing.Point(22, 75);
            this.siticoneRadioButton1.Name = "siticoneRadioButton1";
            this.siticoneRadioButton1.Size = new System.Drawing.Size(75, 17);
            this.siticoneRadioButton1.TabIndex = 4;
            this.siticoneRadioButton1.TabStop = true;
            this.siticoneRadioButton1.Text = "Method 1";
            this.siticoneRadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneRadioButton1.UncheckedState.BorderThickness = 2;
            this.siticoneRadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneRadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.siticoneRadioButton1.UseVisualStyleBackColor = true;
            // 
            // siticoneRadioButton2
            // 
            this.siticoneRadioButton2.AutoSize = true;
            this.siticoneRadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRadioButton2.CheckedState.BorderThickness = 0;
            this.siticoneRadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneRadioButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRadioButton2.Location = new System.Drawing.Point(103, 75);
            this.siticoneRadioButton2.Name = "siticoneRadioButton2";
            this.siticoneRadioButton2.Size = new System.Drawing.Size(75, 17);
            this.siticoneRadioButton2.TabIndex = 5;
            this.siticoneRadioButton2.Text = "Method 2";
            this.siticoneRadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneRadioButton2.UncheckedState.BorderThickness = 2;
            this.siticoneRadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneRadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.siticoneRadioButton2.UseVisualStyleBackColor = true;
            // 
            // siticoneRadioButton3
            // 
            this.siticoneRadioButton3.AutoSize = true;
            this.siticoneRadioButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRadioButton3.CheckedState.BorderThickness = 0;
            this.siticoneRadioButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRadioButton3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneRadioButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRadioButton3.Location = new System.Drawing.Point(184, 75);
            this.siticoneRadioButton3.Name = "siticoneRadioButton3";
            this.siticoneRadioButton3.Size = new System.Drawing.Size(75, 17);
            this.siticoneRadioButton3.TabIndex = 6;
            this.siticoneRadioButton3.Text = "Method 3";
            this.siticoneRadioButton3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneRadioButton3.UncheckedState.BorderThickness = 2;
            this.siticoneRadioButton3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneRadioButton3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.siticoneRadioButton3.UseVisualStyleBackColor = true;
            // 
            // siticoneRadioButton4
            // 
            this.siticoneRadioButton4.AutoSize = true;
            this.siticoneRadioButton4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRadioButton4.CheckedState.BorderThickness = 0;
            this.siticoneRadioButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRadioButton4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneRadioButton4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRadioButton4.Location = new System.Drawing.Point(265, 75);
            this.siticoneRadioButton4.Name = "siticoneRadioButton4";
            this.siticoneRadioButton4.Size = new System.Drawing.Size(75, 17);
            this.siticoneRadioButton4.TabIndex = 7;
            this.siticoneRadioButton4.Text = "Method 4";
            this.siticoneRadioButton4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneRadioButton4.UncheckedState.BorderThickness = 2;
            this.siticoneRadioButton4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneRadioButton4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.siticoneRadioButton4.UseVisualStyleBackColor = true;
            // 
            // siticoneCheckBox1
            // 
            this.siticoneCheckBox1.AutoSize = true;
            this.siticoneCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox1.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox1.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox1.Location = new System.Drawing.Point(22, 121);
            this.siticoneCheckBox1.Name = "siticoneCheckBox1";
            this.siticoneCheckBox1.Size = new System.Drawing.Size(163, 19);
            this.siticoneCheckBox1.TabIndex = 8;
            this.siticoneCheckBox1.Text = "Use clean request method";
            this.siticoneCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox1.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox1.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox1.UseVisualStyleBackColor = true;
            // 
            // siticoneCheckBox2
            // 
            this.siticoneCheckBox2.AutoSize = true;
            this.siticoneCheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox2.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.Location = new System.Drawing.Point(191, 121);
            this.siticoneCheckBox2.Name = "siticoneCheckBox2";
            this.siticoneCheckBox2.Size = new System.Drawing.Size(120, 19);
            this.siticoneCheckBox2.TabIndex = 9;
            this.siticoneCheckBox2.Text = "Loop All Methods";
            this.siticoneCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox2.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.UseVisualStyleBackColor = true;
            // 
            // siticoneCheckBox3
            // 
            this.siticoneCheckBox3.AutoSize = true;
            this.siticoneCheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox3.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox3.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox3.Location = new System.Drawing.Point(317, 121);
            this.siticoneCheckBox3.Name = "siticoneCheckBox3";
            this.siticoneCheckBox3.Size = new System.Drawing.Size(47, 19);
            this.siticoneCheckBox3.TabIndex = 10;
            this.siticoneCheckBox3.Text = "Fast";
            this.siticoneCheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox3.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox3.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox3.UseVisualStyleBackColor = true;
            // 
            // siticoneRadioButton5
            // 
            this.siticoneRadioButton5.AutoSize = true;
            this.siticoneRadioButton5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRadioButton5.CheckedState.BorderThickness = 0;
            this.siticoneRadioButton5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRadioButton5.CheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneRadioButton5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRadioButton5.Location = new System.Drawing.Point(22, 98);
            this.siticoneRadioButton5.Name = "siticoneRadioButton5";
            this.siticoneRadioButton5.Size = new System.Drawing.Size(75, 17);
            this.siticoneRadioButton5.TabIndex = 11;
            this.siticoneRadioButton5.Text = "Method 5";
            this.siticoneRadioButton5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneRadioButton5.UncheckedState.BorderThickness = 2;
            this.siticoneRadioButton5.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneRadioButton5.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.siticoneRadioButton5.UseVisualStyleBackColor = true;
            // 
            // siticoneRadioButton6
            // 
            this.siticoneRadioButton6.AutoSize = true;
            this.siticoneRadioButton6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRadioButton6.CheckedState.BorderThickness = 0;
            this.siticoneRadioButton6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRadioButton6.CheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneRadioButton6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRadioButton6.Location = new System.Drawing.Point(103, 98);
            this.siticoneRadioButton6.Name = "siticoneRadioButton6";
            this.siticoneRadioButton6.Size = new System.Drawing.Size(75, 17);
            this.siticoneRadioButton6.TabIndex = 12;
            this.siticoneRadioButton6.Text = "Method 6";
            this.siticoneRadioButton6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneRadioButton6.UncheckedState.BorderThickness = 2;
            this.siticoneRadioButton6.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneRadioButton6.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.siticoneRadioButton6.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AccentColor = System.Drawing.Color.Red;
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(385, 194);
            this.Controls.Add(this.siticoneRadioButton6);
            this.Controls.Add(this.siticoneRadioButton5);
            this.Controls.Add(this.siticoneCheckBox3);
            this.Controls.Add(this.siticoneCheckBox2);
            this.Controls.Add(this.siticoneCheckBox1);
            this.Controls.Add(this.siticoneRadioButton4);
            this.Controls.Add(this.siticoneRadioButton3);
            this.Controls.Add(this.siticoneRadioButton2);
            this.Controls.Add(this.siticoneRadioButton1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextbox1);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.State = MetroSuite.MetroForm.FormState.Custom;
            this.Style = MetroSuite.Design.Style.Dark;
            this.Text = "AstarothLocker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
    private MetroSuite.MetroTextbox metroTextbox1;
    private MetroSuite.MetroButton metroButton1;
    private ns1.SiticoneRadioButton siticoneRadioButton1;
    private ns1.SiticoneRadioButton siticoneRadioButton2;
    private ns1.SiticoneRadioButton siticoneRadioButton3;
    private ns1.SiticoneRadioButton siticoneRadioButton4;
    private ns1.SiticoneCheckBox siticoneCheckBox1;
    private ns1.SiticoneCheckBox siticoneCheckBox2;
    private ns1.SiticoneCheckBox siticoneCheckBox3;
    private ns1.SiticoneRadioButton siticoneRadioButton5;
    private ns1.SiticoneRadioButton siticoneRadioButton6;
}