namespace NeonQRGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "Text / URL:";
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.AutoSize = true;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(20, 45);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Size = new System.Drawing.Size(420, 60);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Text = "Generieren";
            this.buttonGenerate.Location = new System.Drawing.Point(460, 45);
            this.buttonGenerate.Size = new System.Drawing.Size(120, 30);
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Text = "Speichern";
            this.buttonSave.Location = new System.Drawing.Point(460, 85);
            this.buttonSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(20, 130);
            this.pictureBoxPreview.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBoxPreview);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
