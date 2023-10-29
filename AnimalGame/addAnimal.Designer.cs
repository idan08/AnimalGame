namespace AnimalGame
{
    partial class addAnimal
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
            System.Windows.Forms.Timer timerChoose;
            this.boxAnimalSize = new System.Windows.Forms.ComboBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.boxPetType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textAge = new System.Windows.Forms.TextBox();
            this.boxColor = new System.Windows.Forms.ComboBox();
            this.upDownAge = new System.Windows.Forms.NumericUpDown();
            this.picAnimal = new System.Windows.Forms.PictureBox();
            timerChoose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.upDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // timerChoose
            // 
            timerChoose.Enabled = true;
            timerChoose.Tick += new System.EventHandler(this.Choosing_Tick);
            // 
            // boxAnimalSize
            // 
            this.boxAnimalSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAnimalSize.FormattingEnabled = true;
            this.boxAnimalSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.boxAnimalSize.Location = new System.Drawing.Point(9, 147);
            this.boxAnimalSize.Name = "boxAnimalSize";
            this.boxAnimalSize.Size = new System.Drawing.Size(139, 28);
            this.boxAnimalSize.TabIndex = 0;
            this.boxAnimalSize.Text = "Animal Size :";
            // 
            // txtPetName
            // 
            this.txtPetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetName.Location = new System.Drawing.Point(6, 75);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(154, 27);
            this.txtPetName.TabIndex = 1;
            this.txtPetName.Text = "Enter Pet name";
            this.txtPetName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPetName_MouseClick);
            this.txtPetName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPetName_KeyPress);
            // 
            // boxPetType
            // 
            this.boxPetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPetType.FormattingEnabled = true;
            this.boxPetType.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Horse",
            "Bird",
            "Fox"});
            this.boxPetType.Location = new System.Drawing.Point(6, 12);
            this.boxPetType.Name = "boxPetType";
            this.boxPetType.Size = new System.Drawing.Size(175, 28);
            this.boxPetType.TabIndex = 2;
            this.boxPetType.Text = "Choose Pet :";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.Location = new System.Drawing.Point(12, 399);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddClick);
            // 
            // textAge
            // 
            this.textAge.Enabled = false;
            this.textAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAge.Location = new System.Drawing.Point(6, 210);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(142, 27);
            this.textAge.TabIndex = 4;
            this.textAge.Text = "Enter Pet Age";
            this.textAge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.petAgeClicked);
            // 
            // boxColor
            // 
            this.boxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxColor.FormattingEnabled = true;
            this.boxColor.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Gold",
            "White"});
            this.boxColor.Location = new System.Drawing.Point(6, 274);
            this.boxColor.Name = "boxColor";
            this.boxColor.Size = new System.Drawing.Size(139, 28);
            this.boxColor.TabIndex = 5;
            this.boxColor.Text = "Choose Color:";
            // 
            // upDownAge
            // 
            this.upDownAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownAge.Location = new System.Drawing.Point(154, 210);
            this.upDownAge.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.upDownAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownAge.Name = "upDownAge";
            this.upDownAge.Size = new System.Drawing.Size(120, 27);
            this.upDownAge.TabIndex = 6;
            this.upDownAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // picAnimal
            // 
            this.picAnimal.Location = new System.Drawing.Point(383, 167);
            this.picAnimal.Name = "picAnimal";
            this.picAnimal.Size = new System.Drawing.Size(120, 100);
            this.picAnimal.TabIndex = 7;
            this.picAnimal.TabStop = false;
            // 
            // addAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AnimalGame.Properties.Resources.Pixel_art_grass_image;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.picAnimal);
            this.Controls.Add(this.upDownAge);
            this.Controls.Add(this.boxColor);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.boxPetType);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.boxAnimalSize);
            this.MaximizeBox = false;
            this.Name = "addAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.upDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxAnimalSize;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.ComboBox boxPetType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.ComboBox boxColor;
        private System.Windows.Forms.NumericUpDown upDownAge;
        private System.Windows.Forms.PictureBox picAnimal;
    }
}