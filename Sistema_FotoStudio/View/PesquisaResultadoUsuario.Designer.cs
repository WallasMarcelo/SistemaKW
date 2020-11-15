namespace Sistema_FotoStudio.View
{
    partial class frmPesquisaResultadoUsuario
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
            this.DataGridUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridUsuario
            // 
            this.DataGridUsuario.AllowUserToAddRows = false;
            this.DataGridUsuario.AllowUserToDeleteRows = false;
            this.DataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridUsuario.Location = new System.Drawing.Point(0, 0);
            this.DataGridUsuario.Name = "DataGridUsuario";
            this.DataGridUsuario.ReadOnly = true;
            this.DataGridUsuario.Size = new System.Drawing.Size(564, 196);
            this.DataGridUsuario.TabIndex = 7;
            this.DataGridUsuario.DoubleClick += new System.EventHandler(this.DataGridUsuario_DoubleClick);
            // 
            // frmPesquisaResultadoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 196);
            this.Controls.Add(this.DataGridUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPesquisaResultadoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridUsuario;
    }
}