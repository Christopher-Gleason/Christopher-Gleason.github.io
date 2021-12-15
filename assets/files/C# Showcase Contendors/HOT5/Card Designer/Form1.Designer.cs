
namespace Card_Designer
{
    partial class FormCardDesigner
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
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.comboBoxOccasion = new System.Windows.Forms.ComboBox();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.labelOccasionSelect = new System.Windows.Forms.Label();
            this.labelStyleSelect = new System.Windows.Forms.Label();
            this.checkBoxEnvelope = new System.Windows.Forms.CheckBox();
            this.checkBoxStamp = new System.Windows.Forms.CheckBox();
            this.checkBoxMessage = new System.Windows.Forms.CheckBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelCustomMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxPreview.Location = new System.Drawing.Point(238, 15);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(421, 286);
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            // 
            // comboBoxOccasion
            // 
            this.comboBoxOccasion.FormattingEnabled = true;
            this.comboBoxOccasion.Location = new System.Drawing.Point(92, 12);
            this.comboBoxOccasion.Name = "comboBoxOccasion";
            this.comboBoxOccasion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOccasion.TabIndex = 0;
            this.comboBoxOccasion.SelectedIndexChanged += new System.EventHandler(this.comboBoxOccasion_SelectedIndexChanged);
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(92, 53);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStyle.TabIndex = 1;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyle_SelectedIndexChanged);
            // 
            // labelOccasionSelect
            // 
            this.labelOccasionSelect.AutoSize = true;
            this.labelOccasionSelect.Location = new System.Drawing.Point(22, 15);
            this.labelOccasionSelect.Name = "labelOccasionSelect";
            this.labelOccasionSelect.Size = new System.Drawing.Size(52, 13);
            this.labelOccasionSelect.TabIndex = 7;
            this.labelOccasionSelect.Text = "Occasion";
            // 
            // labelStyleSelect
            // 
            this.labelStyleSelect.AutoSize = true;
            this.labelStyleSelect.Location = new System.Drawing.Point(22, 56);
            this.labelStyleSelect.Name = "labelStyleSelect";
            this.labelStyleSelect.Size = new System.Drawing.Size(30, 13);
            this.labelStyleSelect.TabIndex = 8;
            this.labelStyleSelect.Text = "Style";
            // 
            // checkBoxEnvelope
            // 
            this.checkBoxEnvelope.AutoSize = true;
            this.checkBoxEnvelope.Location = new System.Drawing.Point(25, 80);
            this.checkBoxEnvelope.Name = "checkBoxEnvelope";
            this.checkBoxEnvelope.Size = new System.Drawing.Size(107, 17);
            this.checkBoxEnvelope.TabIndex = 2;
            this.checkBoxEnvelope.Text = "Envelope ($0.25)";
            this.checkBoxEnvelope.UseVisualStyleBackColor = true;
            this.checkBoxEnvelope.CheckedChanged += new System.EventHandler(this.checkBoxEnvelope_CheckedChanged);
            // 
            // checkBoxStamp
            // 
            this.checkBoxStamp.AutoSize = true;
            this.checkBoxStamp.Location = new System.Drawing.Point(25, 103);
            this.checkBoxStamp.Name = "checkBoxStamp";
            this.checkBoxStamp.Size = new System.Drawing.Size(92, 17);
            this.checkBoxStamp.TabIndex = 3;
            this.checkBoxStamp.Text = "Stamp ($0.50)";
            this.checkBoxStamp.UseVisualStyleBackColor = true;
            this.checkBoxStamp.CheckedChanged += new System.EventHandler(this.checkBoxStamp_CheckedChanged);
            // 
            // checkBoxMessage
            // 
            this.checkBoxMessage.AutoSize = true;
            this.checkBoxMessage.Location = new System.Drawing.Point(25, 126);
            this.checkBoxMessage.Name = "checkBoxMessage";
            this.checkBoxMessage.Size = new System.Drawing.Size(143, 17);
            this.checkBoxMessage.TabIndex = 4;
            this.checkBoxMessage.Text = "Custom Message ($0.30)";
            this.checkBoxMessage.UseVisualStyleBackColor = true;
            this.checkBoxMessage.CheckedChanged += new System.EventHandler(this.checkBoxMessage_CheckedChanged);
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(25, 149);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.Size = new System.Drawing.Size(207, 114);
            this.richTextBoxMessage.TabIndex = 5;
            this.richTextBoxMessage.Text = "";
            this.richTextBoxMessage.TextChanged += new System.EventHandler(this.richTextBoxMessage_TextChanged);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.Location = new System.Drawing.Point(23, 281);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(51, 20);
            this.labelCost.TabIndex = 9;
            this.labelCost.Text = "Cost:";
            // 
            // labelCustomMessage
            // 
            this.labelCustomMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelCustomMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCustomMessage.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCustomMessage.Location = new System.Drawing.Point(238, 229);
            this.labelCustomMessage.Name = "labelCustomMessage";
            this.labelCustomMessage.Size = new System.Drawing.Size(421, 72);
            this.labelCustomMessage.TabIndex = 6;
            // 
            // FormCardDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(683, 313);
            this.Controls.Add(this.labelCustomMessage);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.checkBoxMessage);
            this.Controls.Add(this.checkBoxStamp);
            this.Controls.Add(this.checkBoxEnvelope);
            this.Controls.Add(this.labelStyleSelect);
            this.Controls.Add(this.labelOccasionSelect);
            this.Controls.Add(this.comboBoxStyle);
            this.Controls.Add(this.comboBoxOccasion);
            this.Controls.Add(this.pictureBoxPreview);
            this.Name = "FormCardDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Designer";
            this.Load += new System.EventHandler(this.FormCardDesigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.ComboBox comboBoxOccasion;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.Label labelOccasionSelect;
        private System.Windows.Forms.Label labelStyleSelect;
        private System.Windows.Forms.CheckBox checkBoxEnvelope;
        private System.Windows.Forms.CheckBox checkBoxStamp;
        private System.Windows.Forms.CheckBox checkBoxMessage;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelCustomMessage;
    }
}

