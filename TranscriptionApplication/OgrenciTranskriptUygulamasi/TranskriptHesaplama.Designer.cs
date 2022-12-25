namespace OgrenciTranskriptUygulamasi
{
    partial class TranskriptHesaplama
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
            this.datagridTranskript = new System.Windows.Forms.DataGridView();
            this.gano = new System.Windows.Forms.Button();
            this.txtToplamKredi = new System.Windows.Forms.TextBox();
            this.txtGano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTranskript)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridTranskript
            // 
            this.datagridTranskript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTranskript.Location = new System.Drawing.Point(3, 0);
            this.datagridTranskript.Name = "datagridTranskript";
            this.datagridTranskript.RowTemplate.Height = 25;
            this.datagridTranskript.Size = new System.Drawing.Size(761, 331);
            this.datagridTranskript.TabIndex = 0;
            // 
            // gano
            // 
            this.gano.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gano.Location = new System.Drawing.Point(586, 356);
            this.gano.Name = "gano";
            this.gano.Size = new System.Drawing.Size(131, 44);
            this.gano.TabIndex = 1;
            this.gano.Text = "Gano Hesapla";
            this.gano.UseVisualStyleBackColor = false;
            this.gano.Click += new System.EventHandler(this.gano_Click);
            // 
            // txtToplamKredi
            // 
            this.txtToplamKredi.Location = new System.Drawing.Point(111, 368);
            this.txtToplamKredi.Name = "txtToplamKredi";
            this.txtToplamKredi.Size = new System.Drawing.Size(100, 23);
            this.txtToplamKredi.TabIndex = 2;
            // 
            // txtGano
            // 
            this.txtGano.Location = new System.Drawing.Point(329, 368);
            this.txtGano.Name = "txtGano";
            this.txtGano.Size = new System.Drawing.Size(100, 23);
            this.txtGano.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplam Kredi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "GANO";
            // 
            // TranskriptHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGano);
            this.Controls.Add(this.txtToplamKredi);
            this.Controls.Add(this.gano);
            this.Controls.Add(this.datagridTranskript);
            this.Name = "TranskriptHesaplama";
            this.Text = "TranskriptHesaplama";
            this.Load += new System.EventHandler(this.TranskriptHesaplama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridTranskript)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagridTranskript;
        private Button gano;
        private TextBox txtToplamKredi;
        private TextBox txtGano;
        private Label label1;
        private Label label2;
    }
}