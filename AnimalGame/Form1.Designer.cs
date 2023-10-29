namespace AnimalGame
{
    partial class Form1
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
            this.lblHealth = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblMood = new System.Windows.Forms.Label();
            this.lblHunger = new System.Windows.Forms.Label();
            this.lblThirst = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.listPlay = new System.Windows.Forms.ListBox();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.lblControlled = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(4, 617);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(153, 25);
            this.lblHealth.TabIndex = 0;
            this.lblHealth.Text = "Health = x/100";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(945, 621);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1003, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(909, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // lblMood
            // 
            this.lblMood.AutoSize = true;
            this.lblMood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMood.Location = new System.Drawing.Point(173, 617);
            this.lblMood.Name = "lblMood";
            this.lblMood.Size = new System.Drawing.Size(145, 25);
            this.lblMood.TabIndex = 4;
            this.lblMood.Text = "Mood = x/100";
            // 
            // lblHunger
            // 
            this.lblHunger.AutoSize = true;
            this.lblHunger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHunger.Location = new System.Drawing.Point(339, 617);
            this.lblHunger.Name = "lblHunger";
            this.lblHunger.Size = new System.Drawing.Size(161, 25);
            this.lblHunger.TabIndex = 5;
            this.lblHunger.Text = "Hunger = x/100";
            // 
            // lblThirst
            // 
            this.lblThirst.AutoSize = true;
            this.lblThirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirst.Location = new System.Drawing.Point(534, 617);
            this.lblThirst.Name = "lblThirst";
            this.lblThirst.Size = new System.Drawing.Size(146, 25);
            this.lblThirst.TabIndex = 6;
            this.lblThirst.Text = "Thirst = x/100";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // btnFeed
            // 
            this.btnFeed.Enabled = false;
            this.btnFeed.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFeed.Location = new System.Drawing.Point(12, 51);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(75, 23);
            this.btnFeed.TabIndex = 7;
            this.btnFeed.Text = "Feed";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPlay.Location = new System.Drawing.Point(12, 257);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.Enabled = false;
            this.btnDrink.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnDrink.Location = new System.Drawing.Point(12, 144);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(75, 23);
            this.btnDrink.TabIndex = 10;
            this.btnDrink.Text = "Drink";
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // listPlay
            // 
            this.listPlay.Enabled = false;
            this.listPlay.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPlay.FormattingEnabled = true;
            this.listPlay.ItemHeight = 28;
            this.listPlay.Location = new System.Drawing.Point(448, 22);
            this.listPlay.Name = "listPlay";
            this.listPlay.Size = new System.Drawing.Size(209, 116);
            this.listPlay.TabIndex = 11;
            this.listPlay.Visible = false;
            this.listPlay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPlay_MouseDoubleClick);
            // 
            // btnSpecial
            // 
            this.btnSpecial.Location = new System.Drawing.Point(12, 349);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(75, 23);
            this.btnSpecial.TabIndex = 12;
            this.btnSpecial.UseVisualStyleBackColor = true;
            this.btnSpecial.Visible = false;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // lblControlled
            // 
            this.lblControlled.AutoSize = true;
            this.lblControlled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlled.Location = new System.Drawing.Point(5, 568);
            this.lblControlled.Name = "lblControlled";
            this.lblControlled.Size = new System.Drawing.Size(170, 20);
            this.lblControlled.TabIndex = 13;
            this.lblControlled.Text = "Controlled Animal :";
            this.lblControlled.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(945, 592);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(133, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove Animal";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AnimalGame.Properties.Resources.My_project;
            this.ClientSize = new System.Drawing.Size(1090, 651);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblControlled);
            this.Controls.Add(this.btnSpecial);
            this.Controls.Add(this.listPlay);
            this.Controls.Add(this.btnDrink);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.lblThirst);
            this.Controls.Add(this.lblHunger);
            this.Controls.Add(this.lblMood);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblHealth);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblMood;
        private System.Windows.Forms.Label lblHunger;
        private System.Windows.Forms.Label lblThirst;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.ListBox listPlay;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.Label lblControlled;
        private System.Windows.Forms.Button btnRemove;
    }
}

