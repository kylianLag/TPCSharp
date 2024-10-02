namespace GestionVente
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
            comboBox1 = new ComboBox();
            listClient = new ListBox();
            btnAjout = new Button();
            btnSuppression = new Button();
            btnModification = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(509, 23);
            comboBox1.TabIndex = 0;
            // 
            // listClient
            // 
            listClient.FormattingEnabled = true;
            listClient.ItemHeight = 15;
            listClient.Location = new Point(32, 92);
            listClient.Name = "listClient";
            listClient.Size = new Size(509, 334);
            listClient.TabIndex = 1;
            // 
            // btnAjout
            // 
            btnAjout.Location = new Point(651, 92);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(95, 23);
            btnAjout.TabIndex = 2;
            btnAjout.Text = "Ajout";
            btnAjout.UseVisualStyleBackColor = true;
            // 
            // btnSuppression
            // 
            btnSuppression.Location = new Point(651, 170);
            btnSuppression.Name = "btnSuppression";
            btnSuppression.Size = new Size(95, 23);
            btnSuppression.TabIndex = 3;
            btnSuppression.Text = "Suppression";
            btnSuppression.UseVisualStyleBackColor = true;
            // 
            // btnModification
            // 
            btnModification.Location = new Point(651, 234);
            btnModification.Name = "btnModification";
            btnModification.Size = new Size(95, 23);
            btnModification.TabIndex = 4;
            btnModification.Text = "Modification";
            btnModification.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModification);
            Controls.Add(btnSuppression);
            Controls.Add(btnAjout);
            Controls.Add(listClient);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ListBox listClient;
        private Button btnAjout;
        private Button btnSuppression;
        private Button btnModification;
    }
}
