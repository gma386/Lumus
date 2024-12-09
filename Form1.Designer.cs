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
            btn_connection = new Button();
            lbl_teste = new Label();
            SuspendLayout();
            // 
            // btn_connection
            // 
            btn_connection.Location = new Point(461, 317);
            btn_connection.Name = "btn_connection";
            btn_connection.Size = new Size(94, 29);
            btn_connection.TabIndex = 0;
            btn_connection.Text = "Conectar";
            btn_connection.UseVisualStyleBackColor = true;
            btn_connection.Click += btn_connection_Click;
            // 
            // lbl_teste
            // 
            lbl_teste.AutoSize = true;
            lbl_teste.Location = new Point(477, 268);
            lbl_teste.Name = "lbl_teste";
            lbl_teste.Size = new Size(0, 20);
            lbl_teste.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 502);
            Controls.Add(lbl_teste);
            Controls.Add(btn_connection);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_connection;
        private Label lbl_teste;
    }
}
