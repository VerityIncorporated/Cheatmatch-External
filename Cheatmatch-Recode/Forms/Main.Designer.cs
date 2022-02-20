
namespace Cheatmatch_Recode.Forms
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.logoPictureBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.logoDragControl = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.ToolTip = new Siticone.Desktop.UI.WinForms.SiticoneHtmlToolTip();
            this.godmodeLabel = new System.Windows.Forms.Label();
            this.unlimitedammoLabel = new System.Windows.Forms.Label();
            this.nospreadLabel = new System.Windows.Forms.Label();
            this.noslowdownLabel = new System.Windows.Forms.Label();
            this.freezeplayersLabel = new System.Windows.Forms.Label();
            this.freezeplayersandtpLabel = new System.Windows.Forms.Label();
            this.antishieldLabel = new System.Windows.Forms.Label();
            this.fastmeleeLabel = new System.Windows.Forms.Label();
            this.mainGroupBox = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.fastmeleeCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.antishieldCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.nospreadCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.unlimitedammoCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.godmodeCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.miscGroupBox = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.exitButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.freezeplayersandtpCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.freezeplayersCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.noslowdownCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.maingroupboxDragControl = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.miscDragControl = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.mainGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.BorderRadius = 8;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.HasFormShadow = false;
            this.BorderlessForm.ResizeForm = false;
            this.BorderlessForm.ShadowColor = System.Drawing.Color.Red;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.ImageRotate = 0F;
            this.logoPictureBox.Location = new System.Drawing.Point(7, 1);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.ShadowDecoration.Parent = this.logoPictureBox;
            this.logoPictureBox.Size = new System.Drawing.Size(278, 70);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // logoDragControl
            // 
            this.logoDragControl.TargetControl = this.logoPictureBox;
            // 
            // ToolTip
            // 
            this.ToolTip.AllowLinksHandling = true;
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ToolTip.BorderColor = System.Drawing.Color.Red;
            this.ToolTip.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ToolTip.InitialDelay = 200;
            this.ToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.ToolTipTitle = "Cheatmatch";
            // 
            // godmodeLabel
            // 
            this.godmodeLabel.AutoSize = true;
            this.godmodeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.godmodeLabel.Location = new System.Drawing.Point(8, 52);
            this.godmodeLabel.Name = "godmodeLabel";
            this.godmodeLabel.Size = new System.Drawing.Size(79, 21);
            this.godmodeLabel.TabIndex = 3;
            this.godmodeLabel.Text = "Godmode";
            this.ToolTip.SetToolTip(this.godmodeLabel, "You will no longer die when your HP hits 0");
            // 
            // unlimitedammoLabel
            // 
            this.unlimitedammoLabel.AutoSize = true;
            this.unlimitedammoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.unlimitedammoLabel.Location = new System.Drawing.Point(8, 83);
            this.unlimitedammoLabel.Name = "unlimitedammoLabel";
            this.unlimitedammoLabel.Size = new System.Drawing.Size(129, 21);
            this.unlimitedammoLabel.TabIndex = 4;
            this.unlimitedammoLabel.Text = "Unlimited Ammo";
            this.ToolTip.SetToolTip(this.unlimitedammoLabel, "Refills your ammo everytime you shoot");
            // 
            // nospreadLabel
            // 
            this.nospreadLabel.AutoSize = true;
            this.nospreadLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.nospreadLabel.Location = new System.Drawing.Point(8, 114);
            this.nospreadLabel.Name = "nospreadLabel";
            this.nospreadLabel.Size = new System.Drawing.Size(80, 21);
            this.nospreadLabel.TabIndex = 5;
            this.nospreadLabel.Text = "NoSpread";
            this.ToolTip.SetToolTip(this.nospreadLabel, "No bullet spread");
            // 
            // noslowdownLabel
            // 
            this.noslowdownLabel.AutoSize = true;
            this.noslowdownLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.noslowdownLabel.Location = new System.Drawing.Point(8, 52);
            this.noslowdownLabel.Name = "noslowdownLabel";
            this.noslowdownLabel.Size = new System.Drawing.Size(104, 21);
            this.noslowdownLabel.TabIndex = 6;
            this.noslowdownLabel.Text = "NoSlowdown";
            this.ToolTip.SetToolTip(this.noslowdownLabel, "Allows you to reload and sprint at the same time.");
            // 
            // freezeplayersLabel
            // 
            this.freezeplayersLabel.AutoSize = true;
            this.freezeplayersLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.freezeplayersLabel.Location = new System.Drawing.Point(8, 83);
            this.freezeplayersLabel.Name = "freezeplayersLabel";
            this.freezeplayersLabel.Size = new System.Drawing.Size(109, 21);
            this.freezeplayersLabel.TabIndex = 7;
            this.freezeplayersLabel.Text = "Freeze Players";
            this.ToolTip.SetToolTip(this.freezeplayersLabel, "Stops updating client sided positions.");
            // 
            // freezeplayersandtpLabel
            // 
            this.freezeplayersandtpLabel.AutoSize = true;
            this.freezeplayersandtpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.freezeplayersandtpLabel.Location = new System.Drawing.Point(8, 115);
            this.freezeplayersandtpLabel.Name = "freezeplayersandtpLabel";
            this.freezeplayersandtpLabel.Size = new System.Drawing.Size(137, 21);
            this.freezeplayersandtpLabel.TabIndex = 8;
            this.freezeplayersandtpLabel.Text = "Freeze Players+TP";
            this.ToolTip.SetToolTip(this.freezeplayersandtpLabel, "Stops updating client sided positions.\r\nTeleports everyone but you to the positio" +
        "n (0,0,0) XYZ\r\nWhich is different for each map but is usually the middle.");
            // 
            // antishieldLabel
            // 
            this.antishieldLabel.AutoSize = true;
            this.antishieldLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.antishieldLabel.Location = new System.Drawing.Point(8, 145);
            this.antishieldLabel.Name = "antishieldLabel";
            this.antishieldLabel.Size = new System.Drawing.Size(87, 21);
            this.antishieldLabel.TabIndex = 10;
            this.antishieldLabel.Text = "Anti-Shield";
            this.ToolTip.SetToolTip(this.antishieldLabel, "Allows you to kill people who have just spawned, and still have a shield");
            // 
            // fastmeleeLabel
            // 
            this.fastmeleeLabel.AutoSize = true;
            this.fastmeleeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.fastmeleeLabel.Location = new System.Drawing.Point(8, 176);
            this.fastmeleeLabel.Name = "fastmeleeLabel";
            this.fastmeleeLabel.Size = new System.Drawing.Size(83, 21);
            this.fastmeleeLabel.TabIndex = 12;
            this.fastmeleeLabel.Text = "Fast Melee";
            this.ToolTip.SetToolTip(this.fastmeleeLabel, "Allows you to kill people who have just spawned, and still have a shield");
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.BorderRadius = 4;
            this.mainGroupBox.BorderThickness = 0;
            this.mainGroupBox.Controls.Add(this.fastmeleeLabel);
            this.mainGroupBox.Controls.Add(this.fastmeleeCheckBox);
            this.mainGroupBox.Controls.Add(this.antishieldLabel);
            this.mainGroupBox.Controls.Add(this.antishieldCheckBox);
            this.mainGroupBox.Controls.Add(this.nospreadLabel);
            this.mainGroupBox.Controls.Add(this.unlimitedammoLabel);
            this.mainGroupBox.Controls.Add(this.godmodeLabel);
            this.mainGroupBox.Controls.Add(this.nospreadCheckBox);
            this.mainGroupBox.Controls.Add(this.unlimitedammoCheckBox);
            this.mainGroupBox.Controls.Add(this.godmodeCheckBox);
            this.mainGroupBox.CustomBorderColor = System.Drawing.Color.Firebrick;
            this.mainGroupBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mainGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainGroupBox.ForeColor = System.Drawing.Color.White;
            this.mainGroupBox.Location = new System.Drawing.Point(18, 75);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.ShadowDecoration.Parent = this.mainGroupBox;
            this.mainGroupBox.Size = new System.Drawing.Size(256, 210);
            this.mainGroupBox.TabIndex = 1;
            this.mainGroupBox.Text = "Main";
            // 
            // fastmeleeCheckBox
            // 
            this.fastmeleeCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fastmeleeCheckBox.CheckedState.BorderRadius = 2;
            this.fastmeleeCheckBox.CheckedState.BorderThickness = 0;
            this.fastmeleeCheckBox.CheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.fastmeleeCheckBox.CheckedState.Parent = this.fastmeleeCheckBox;
            this.fastmeleeCheckBox.Location = new System.Drawing.Point(144, 178);
            this.fastmeleeCheckBox.Name = "fastmeleeCheckBox";
            this.fastmeleeCheckBox.ShadowDecoration.Parent = this.fastmeleeCheckBox;
            this.fastmeleeCheckBox.Size = new System.Drawing.Size(20, 20);
            this.fastmeleeCheckBox.TabIndex = 11;
            this.fastmeleeCheckBox.Text = "Fast Melee";
            this.fastmeleeCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.fastmeleeCheckBox.UncheckedState.BorderRadius = 2;
            this.fastmeleeCheckBox.UncheckedState.BorderThickness = 0;
            this.fastmeleeCheckBox.UncheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.fastmeleeCheckBox.UncheckedState.Parent = this.fastmeleeCheckBox;
            // 
            // antishieldCheckBox
            // 
            this.antishieldCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.antishieldCheckBox.CheckedState.BorderRadius = 2;
            this.antishieldCheckBox.CheckedState.BorderThickness = 0;
            this.antishieldCheckBox.CheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.antishieldCheckBox.CheckedState.Parent = this.antishieldCheckBox;
            this.antishieldCheckBox.Location = new System.Drawing.Point(144, 147);
            this.antishieldCheckBox.Name = "antishieldCheckBox";
            this.antishieldCheckBox.ShadowDecoration.Parent = this.antishieldCheckBox;
            this.antishieldCheckBox.Size = new System.Drawing.Size(20, 20);
            this.antishieldCheckBox.TabIndex = 9;
            this.antishieldCheckBox.Text = "Anti-Shield";
            this.antishieldCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.antishieldCheckBox.UncheckedState.BorderRadius = 2;
            this.antishieldCheckBox.UncheckedState.BorderThickness = 0;
            this.antishieldCheckBox.UncheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.antishieldCheckBox.UncheckedState.Parent = this.antishieldCheckBox;
            // 
            // nospreadCheckBox
            // 
            this.nospreadCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nospreadCheckBox.CheckedState.BorderRadius = 2;
            this.nospreadCheckBox.CheckedState.BorderThickness = 0;
            this.nospreadCheckBox.CheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.nospreadCheckBox.CheckedState.Parent = this.nospreadCheckBox;
            this.nospreadCheckBox.Location = new System.Drawing.Point(144, 116);
            this.nospreadCheckBox.Name = "nospreadCheckBox";
            this.nospreadCheckBox.ShadowDecoration.Parent = this.nospreadCheckBox;
            this.nospreadCheckBox.Size = new System.Drawing.Size(20, 20);
            this.nospreadCheckBox.TabIndex = 2;
            this.nospreadCheckBox.Text = "NoSpread";
            this.nospreadCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nospreadCheckBox.UncheckedState.BorderRadius = 2;
            this.nospreadCheckBox.UncheckedState.BorderThickness = 0;
            this.nospreadCheckBox.UncheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.nospreadCheckBox.UncheckedState.Parent = this.nospreadCheckBox;
            // 
            // unlimitedammoCheckBox
            // 
            this.unlimitedammoCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unlimitedammoCheckBox.CheckedState.BorderRadius = 2;
            this.unlimitedammoCheckBox.CheckedState.BorderThickness = 0;
            this.unlimitedammoCheckBox.CheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.unlimitedammoCheckBox.CheckedState.Parent = this.unlimitedammoCheckBox;
            this.unlimitedammoCheckBox.Location = new System.Drawing.Point(144, 85);
            this.unlimitedammoCheckBox.Name = "unlimitedammoCheckBox";
            this.unlimitedammoCheckBox.ShadowDecoration.Parent = this.unlimitedammoCheckBox;
            this.unlimitedammoCheckBox.Size = new System.Drawing.Size(20, 20);
            this.unlimitedammoCheckBox.TabIndex = 1;
            this.unlimitedammoCheckBox.Text = "Unlimited Ammo";
            this.unlimitedammoCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.unlimitedammoCheckBox.UncheckedState.BorderRadius = 2;
            this.unlimitedammoCheckBox.UncheckedState.BorderThickness = 0;
            this.unlimitedammoCheckBox.UncheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.unlimitedammoCheckBox.UncheckedState.Parent = this.unlimitedammoCheckBox;
            // 
            // godmodeCheckBox
            // 
            this.godmodeCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.godmodeCheckBox.CheckedState.BorderRadius = 2;
            this.godmodeCheckBox.CheckedState.BorderThickness = 0;
            this.godmodeCheckBox.CheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.godmodeCheckBox.CheckedState.Parent = this.godmodeCheckBox;
            this.godmodeCheckBox.Location = new System.Drawing.Point(144, 54);
            this.godmodeCheckBox.Name = "godmodeCheckBox";
            this.godmodeCheckBox.ShadowDecoration.Parent = this.godmodeCheckBox;
            this.godmodeCheckBox.Size = new System.Drawing.Size(20, 20);
            this.godmodeCheckBox.TabIndex = 0;
            this.godmodeCheckBox.Text = "Godmode";
            this.godmodeCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.godmodeCheckBox.UncheckedState.BorderRadius = 2;
            this.godmodeCheckBox.UncheckedState.BorderThickness = 0;
            this.godmodeCheckBox.UncheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.godmodeCheckBox.UncheckedState.Parent = this.godmodeCheckBox;
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.BorderRadius = 4;
            this.miscGroupBox.BorderThickness = 0;
            this.miscGroupBox.Controls.Add(this.exitButton);
            this.miscGroupBox.Controls.Add(this.freezeplayersandtpLabel);
            this.miscGroupBox.Controls.Add(this.freezeplayersLabel);
            this.miscGroupBox.Controls.Add(this.noslowdownLabel);
            this.miscGroupBox.Controls.Add(this.freezeplayersandtpCheckBox);
            this.miscGroupBox.Controls.Add(this.freezeplayersCheckBox);
            this.miscGroupBox.Controls.Add(this.noslowdownCheckBox);
            this.miscGroupBox.CustomBorderColor = System.Drawing.Color.Firebrick;
            this.miscGroupBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.miscGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscGroupBox.ForeColor = System.Drawing.Color.White;
            this.miscGroupBox.Location = new System.Drawing.Point(18, 296);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.ShadowDecoration.Parent = this.miscGroupBox;
            this.miscGroupBox.Size = new System.Drawing.Size(256, 210);
            this.miscGroupBox.TabIndex = 2;
            this.miscGroupBox.Text = "Misc";
            // 
            // exitButton
            // 
            this.exitButton.Animated = true;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitButton.BorderRadius = 8;
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.DisabledState.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.Firebrick;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Location = new System.Drawing.Point(68, 164);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(121, 24);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit Cheatmatch";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // freezeplayersandtpCheckBox
            // 
            this.freezeplayersandtpCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.freezeplayersandtpCheckBox.CheckedState.BorderRadius = 2;
            this.freezeplayersandtpCheckBox.CheckedState.BorderThickness = 0;
            this.freezeplayersandtpCheckBox.CheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.freezeplayersandtpCheckBox.CheckedState.Parent = this.freezeplayersandtpCheckBox;
            this.freezeplayersandtpCheckBox.Location = new System.Drawing.Point(144, 116);
            this.freezeplayersandtpCheckBox.Name = "freezeplayersandtpCheckBox";
            this.freezeplayersandtpCheckBox.ShadowDecoration.Parent = this.freezeplayersandtpCheckBox;
            this.freezeplayersandtpCheckBox.Size = new System.Drawing.Size(20, 20);
            this.freezeplayersandtpCheckBox.TabIndex = 5;
            this.freezeplayersandtpCheckBox.Text = "Freeze Players + TP";
            this.freezeplayersandtpCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.freezeplayersandtpCheckBox.UncheckedState.BorderRadius = 2;
            this.freezeplayersandtpCheckBox.UncheckedState.BorderThickness = 0;
            this.freezeplayersandtpCheckBox.UncheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.freezeplayersandtpCheckBox.UncheckedState.Parent = this.freezeplayersandtpCheckBox;
            // 
            // freezeplayersCheckBox
            // 
            this.freezeplayersCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.freezeplayersCheckBox.CheckedState.BorderRadius = 2;
            this.freezeplayersCheckBox.CheckedState.BorderThickness = 0;
            this.freezeplayersCheckBox.CheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.freezeplayersCheckBox.CheckedState.Parent = this.freezeplayersCheckBox;
            this.freezeplayersCheckBox.Location = new System.Drawing.Point(144, 85);
            this.freezeplayersCheckBox.Name = "freezeplayersCheckBox";
            this.freezeplayersCheckBox.ShadowDecoration.Parent = this.freezeplayersCheckBox;
            this.freezeplayersCheckBox.Size = new System.Drawing.Size(20, 20);
            this.freezeplayersCheckBox.TabIndex = 4;
            this.freezeplayersCheckBox.Text = "Freeze Players";
            this.freezeplayersCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.freezeplayersCheckBox.UncheckedState.BorderRadius = 2;
            this.freezeplayersCheckBox.UncheckedState.BorderThickness = 0;
            this.freezeplayersCheckBox.UncheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.freezeplayersCheckBox.UncheckedState.Parent = this.freezeplayersCheckBox;
            // 
            // noslowdownCheckBox
            // 
            this.noslowdownCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noslowdownCheckBox.CheckedState.BorderRadius = 2;
            this.noslowdownCheckBox.CheckedState.BorderThickness = 0;
            this.noslowdownCheckBox.CheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.noslowdownCheckBox.CheckedState.Parent = this.noslowdownCheckBox;
            this.noslowdownCheckBox.Location = new System.Drawing.Point(144, 54);
            this.noslowdownCheckBox.Name = "noslowdownCheckBox";
            this.noslowdownCheckBox.ShadowDecoration.Parent = this.noslowdownCheckBox;
            this.noslowdownCheckBox.Size = new System.Drawing.Size(20, 20);
            this.noslowdownCheckBox.TabIndex = 3;
            this.noslowdownCheckBox.Text = "NoSlowdown";
            this.noslowdownCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.noslowdownCheckBox.UncheckedState.BorderRadius = 2;
            this.noslowdownCheckBox.UncheckedState.BorderThickness = 0;
            this.noslowdownCheckBox.UncheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.noslowdownCheckBox.UncheckedState.Parent = this.noslowdownCheckBox;
            // 
            // maingroupboxDragControl
            // 
            this.maingroupboxDragControl.TargetControl = this.mainGroupBox;
            // 
            // miscDragControl
            // 
            this.miscDragControl.TargetControl = this.miscGroupBox;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(84, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Developed by Verity";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(293, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.logoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm BorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox logoPictureBox;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl logoDragControl;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlToolTip ToolTip;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox miscGroupBox;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox mainGroupBox;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl maingroupboxDragControl;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl miscDragControl;
        private System.Windows.Forms.Label freezeplayersandtpLabel;
        private System.Windows.Forms.Label freezeplayersLabel;
        private System.Windows.Forms.Label noslowdownLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox freezeplayersandtpCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox freezeplayersCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox noslowdownCheckBox;
        private System.Windows.Forms.Label nospreadLabel;
        private System.Windows.Forms.Label unlimitedammoLabel;
        private System.Windows.Forms.Label godmodeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox nospreadCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox unlimitedammoCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox godmodeCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label antishieldLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox antishieldCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton exitButton;
        private System.Windows.Forms.Label fastmeleeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox fastmeleeCheckBox;
    }
}