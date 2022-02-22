namespace SerializationAndDeserialization
{
    partial class mainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.deserializeButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.personInstanceLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstnameText = new System.Windows.Forms.TextBox();
            this.lastnameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.agePicker = new System.Windows.Forms.NumericUpDown();
            this.serializeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.exampleArea = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.agePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // textArea
            // 
            this.textArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArea.Location = new System.Drawing.Point(12, 12);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(479, 289);
            this.textArea.TabIndex = 0;
            this.textArea.Text = "";
            // 
            // deserializeButton
            // 
            this.deserializeButton.BackColor = System.Drawing.Color.GreenYellow;
            this.deserializeButton.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deserializeButton.Location = new System.Drawing.Point(12, 326);
            this.deserializeButton.Name = "deserializeButton";
            this.deserializeButton.Size = new System.Drawing.Size(479, 84);
            this.deserializeButton.TabIndex = 1;
            this.deserializeButton.Text = "Deserializuj";
            this.deserializeButton.UseVisualStyleBackColor = false;
            this.deserializeButton.Click += new System.EventHandler(this.deserializeButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.Color.Yellow;
            this.clearAllButton.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearAllButton.Location = new System.Drawing.Point(12, 430);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(479, 84);
            this.clearAllButton.TabIndex = 2;
            this.clearAllButton.Text = "Czyść Wszystko";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // personInstanceLabel
            // 
            this.personInstanceLabel.AutoSize = true;
            this.personInstanceLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personInstanceLabel.Location = new System.Drawing.Point(507, 15);
            this.personInstanceLabel.Name = "personInstanceLabel";
            this.personInstanceLabel.Size = new System.Drawing.Size(320, 25);
            this.personInstanceLabel.TabIndex = 3;
            this.personInstanceLabel.Text = "Uworzony obiekt klasy Person";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstnameLabel.Location = new System.Drawing.Point(550, 49);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(48, 19);
            this.firstnameLabel.TabIndex = 4;
            this.firstnameLabel.Text = "Imię:";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastnameLabel.Location = new System.Drawing.Point(508, 78);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(90, 19);
            this.lastnameLabel.TabIndex = 5;
            this.lastnameLabel.Text = "Nazwisko:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageLabel.Location = new System.Drawing.Point(545, 104);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(53, 19);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Wiek:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.Location = new System.Drawing.Point(540, 129);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(58, 19);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email:";
            // 
            // firstnameText
            // 
            this.firstnameText.Location = new System.Drawing.Point(604, 51);
            this.firstnameText.Name = "firstnameText";
            this.firstnameText.Size = new System.Drawing.Size(223, 20);
            this.firstnameText.TabIndex = 8;
            // 
            // lastnameText
            // 
            this.lastnameText.Location = new System.Drawing.Point(604, 77);
            this.lastnameText.Name = "lastnameText";
            this.lastnameText.Size = new System.Drawing.Size(223, 20);
            this.lastnameText.TabIndex = 9;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(604, 129);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(223, 20);
            this.emailText.TabIndex = 11;
            // 
            // agePicker
            // 
            this.agePicker.Location = new System.Drawing.Point(604, 103);
            this.agePicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.agePicker.Name = "agePicker";
            this.agePicker.Size = new System.Drawing.Size(223, 20);
            this.agePicker.TabIndex = 12;
            this.agePicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // serializeButton
            // 
            this.serializeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.serializeButton.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serializeButton.Location = new System.Drawing.Point(554, 280);
            this.serializeButton.Name = "serializeButton";
            this.serializeButton.Size = new System.Drawing.Size(283, 84);
            this.serializeButton.TabIndex = 13;
            this.serializeButton.Text = "Serializuj";
            this.serializeButton.UseVisualStyleBackColor = false;
            this.serializeButton.Click += new System.EventHandler(this.serializeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.SkyBlue;
            this.updateButton.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateButton.Location = new System.Drawing.Point(554, 179);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(283, 84);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Aktualizuj";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // exampleArea
            // 
            this.exampleArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exampleArea.Location = new System.Drawing.Point(554, 380);
            this.exampleArea.Name = "exampleArea";
            this.exampleArea.ReadOnly = true;
            this.exampleArea.Size = new System.Drawing.Size(283, 169);
            this.exampleArea.TabIndex = 15;
            this.exampleArea.Text = "{\n\t\"firstname\":\"Grzegorz\",\n\t\"lastname\":\"Konopka\",\n\t\"age\":30,\n\t\"email\":\"example@ex" +
    "ample.com\"\n}";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.exampleArea);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.serializeButton);
            this.Controls.Add(this.agePicker);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.lastnameText);
            this.Controls.Add(this.firstnameText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.personInstanceLabel);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.deserializeButton);
            this.Controls.Add(this.textArea);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "mainForm";
            this.Text = "Serialization And Deserialization";
            ((System.ComponentModel.ISupportInitialize)(this.agePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.Button deserializeButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Label personInstanceLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastnameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.NumericUpDown agePicker;
        private System.Windows.Forms.Button serializeButton;
        public System.Windows.Forms.TextBox firstnameText;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.RichTextBox exampleArea;
    }
}

