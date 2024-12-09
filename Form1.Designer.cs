namespace Lumus
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
            lbl_teste = new Label();
            myDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)myDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbl_teste
            // 
            lbl_teste.AutoSize = true;
            lbl_teste.Location = new Point(477, 268);
            lbl_teste.Name = "lbl_teste";
            lbl_teste.Size = new Size(0, 20);
            lbl_teste.TabIndex = 1;
            // 
            // myDataGridView
            // 
            myDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myDataGridView.Location = new Point(113, 77);
            myDataGridView.Name = "myDataGridView";
            myDataGridView.RowHeadersWidth = 51;
            myDataGridView.Size = new Size(762, 188);
            myDataGridView.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 502);
            Controls.Add(myDataGridView);
            Controls.Add(lbl_teste);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)myDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_teste;
        private DataGridView myDataGridView;
    }
}
