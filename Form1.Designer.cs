namespace TestDataLayer
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
            btnConectarVar = new Button();
            btnConectarJson = new Button();
            btnConectarApp = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            btnConectarAppMySQL = new Button();
            btnConectarJsonMySQL = new Button();
            btnConectarVarMySQL = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnConectarVar
            // 
            btnConectarVar.Location = new Point(16, 62);
            btnConectarVar.Name = "btnConectarVar";
            btnConectarVar.Size = new Size(168, 23);
            btnConectarVar.TabIndex = 0;
            btnConectarVar.Text = "&Connect witdh var Environ";
            btnConectarVar.UseVisualStyleBackColor = true;
            btnConectarVar.Click += btnConectar_Click;
            // 
            // btnConectarJson
            // 
            btnConectarJson.Location = new Point(190, 62);
            btnConectarJson.Name = "btnConectarJson";
            btnConectarJson.Size = new Size(168, 23);
            btnConectarJson.TabIndex = 1;
            btnConectarJson.Text = "&Connect witdh files";
            btnConectarJson.UseVisualStyleBackColor = true;
            btnConectarJson.Click += btnConectarJson_Click;
            // 
            // btnConectarApp
            // 
            btnConectarApp.Location = new Point(364, 62);
            btnConectarApp.Name = "btnConectarApp";
            btnConectarApp.Size = new Size(168, 23);
            btnConectarApp.TabIndex = 1;
            btnConectarApp.Text = "&Connect witdh hard data";
            btnConectarApp.UseVisualStyleBackColor = true;
            btnConectarApp.Click += btnConectarApp_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 47);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "Conection to SQLServer ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(546, 47);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(17, 17);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 1;
            label2.Text = "Conection to MySQL";
            // 
            // btnConectarAppMySQL
            // 
            btnConectarAppMySQL.Location = new Point(364, 170);
            btnConectarAppMySQL.Name = "btnConectarAppMySQL";
            btnConectarAppMySQL.Size = new Size(168, 23);
            btnConectarAppMySQL.TabIndex = 6;
            btnConectarAppMySQL.Text = "&Connect witdh hard data";
            btnConectarAppMySQL.UseVisualStyleBackColor = true;
            btnConectarAppMySQL.Click += btnConectarAppMySQL_Click;
            // 
            // btnConectarJsonMySQL
            // 
            btnConectarJsonMySQL.Location = new Point(190, 170);
            btnConectarJsonMySQL.Name = "btnConectarJsonMySQL";
            btnConectarJsonMySQL.Size = new Size(168, 23);
            btnConectarJsonMySQL.TabIndex = 5;
            btnConectarJsonMySQL.Text = "&Conectar con archivos";
            btnConectarJsonMySQL.UseVisualStyleBackColor = true;
            btnConectarJsonMySQL.Visible = false;
            btnConectarJsonMySQL.Click += btnConectarJsonMySQL_Click;
            // 
            // btnConectarVarMySQL
            // 
            btnConectarVarMySQL.Location = new Point(16, 170);
            btnConectarVarMySQL.Name = "btnConectarVarMySQL";
            btnConectarVarMySQL.Size = new Size(168, 23);
            btnConectarVarMySQL.TabIndex = 4;
            btnConectarVarMySQL.Text = "&Connect witdh var Environ";
            btnConectarVarMySQL.UseVisualStyleBackColor = true;
            btnConectarVarMySQL.Click += btnConectarVarMySQL_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 215);
            Controls.Add(btnConectarAppMySQL);
            Controls.Add(btnConectarJsonMySQL);
            Controls.Add(btnConectarVarMySQL);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnConectarApp);
            Controls.Add(btnConectarJson);
            Controls.Add(btnConectarVar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Test XauDataLayer";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConectarVar;
        private Button btnConectarJson;
        private Button btnConectarApp;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button btnConectarAppMySQL;
        private Button btnConectarJsonMySQL;
        private Button btnConectarVarMySQL;
    }
}
