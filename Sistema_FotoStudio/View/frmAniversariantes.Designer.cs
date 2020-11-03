namespace Sistema_FotoStudio.View
{
    partial class frmAniversariantes
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
            this.dataGridAniversario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAniversario)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAniversario
            // 
            this.dataGridAniversario.AllowUserToAddRows = false;
            this.dataGridAniversario.AllowUserToDeleteRows = false;
            this.dataGridAniversario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAniversario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAniversario.Location = new System.Drawing.Point(0, 0);
            this.dataGridAniversario.Name = "dataGridAniversario";
            this.dataGridAniversario.ReadOnly = true;
            this.dataGridAniversario.Size = new System.Drawing.Size(564, 256);
            this.dataGridAniversario.TabIndex = 0;
            // 
            // frmAniversariantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 256);
            this.Controls.Add(this.dataGridAniversario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAniversariantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aniversáriantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAniversario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAniversario;
    }
}