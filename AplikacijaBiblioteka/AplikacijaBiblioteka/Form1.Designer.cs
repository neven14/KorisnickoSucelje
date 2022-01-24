namespace AplikacijaBiblioteka
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpisKnjiga = new System.Windows.Forms.Button();
            this.btnPosudbaKnjige = new System.Windows.Forms.Button();
            this.btnStanjeKnjiga = new System.Windows.Forms.Button();
            this.btnStanjeKnjSkladistu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Upis Korisnika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpisKnjiga
            // 
            this.btnUpisKnjiga.Location = new System.Drawing.Point(303, 113);
            this.btnUpisKnjiga.Name = "btnUpisKnjiga";
            this.btnUpisKnjiga.Size = new System.Drawing.Size(166, 38);
            this.btnUpisKnjiga.TabIndex = 1;
            this.btnUpisKnjiga.Text = "Upis Knjiga";
            this.btnUpisKnjiga.UseVisualStyleBackColor = true;
            this.btnUpisKnjiga.Click += new System.EventHandler(this.btnUpisKnjiga_Click);
            // 
            // btnPosudbaKnjige
            // 
            this.btnPosudbaKnjige.Location = new System.Drawing.Point(303, 167);
            this.btnPosudbaKnjige.Name = "btnPosudbaKnjige";
            this.btnPosudbaKnjige.Size = new System.Drawing.Size(166, 38);
            this.btnPosudbaKnjige.TabIndex = 2;
            this.btnPosudbaKnjige.Text = "Posudba Knjige";
            this.btnPosudbaKnjige.UseVisualStyleBackColor = true;
            this.btnPosudbaKnjige.Click += new System.EventHandler(this.btnPosudbaKnjige_Click);
            // 
            // btnStanjeKnjiga
            // 
            this.btnStanjeKnjiga.Location = new System.Drawing.Point(303, 224);
            this.btnStanjeKnjiga.Name = "btnStanjeKnjiga";
            this.btnStanjeKnjiga.Size = new System.Drawing.Size(166, 38);
            this.btnStanjeKnjiga.TabIndex = 3;
            this.btnStanjeKnjiga.Text = "Stanje Knjiga";
            this.btnStanjeKnjiga.UseVisualStyleBackColor = true;
            this.btnStanjeKnjiga.Click += new System.EventHandler(this.btnStanjeKnjiga_Click);
            // 
            // btnStanjeKnjSkladistu
            // 
            this.btnStanjeKnjSkladistu.Location = new System.Drawing.Point(303, 283);
            this.btnStanjeKnjSkladistu.Name = "btnStanjeKnjSkladistu";
            this.btnStanjeKnjSkladistu.Size = new System.Drawing.Size(166, 38);
            this.btnStanjeKnjSkladistu.TabIndex = 4;
            this.btnStanjeKnjSkladistu.Text = "Stanje Knjiga u Skladistu";
            this.btnStanjeKnjSkladistu.UseVisualStyleBackColor = true;
            this.btnStanjeKnjSkladistu.Click += new System.EventHandler(this.btnStanjeKnjSkladistu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStanjeKnjSkladistu);
            this.Controls.Add(this.btnStanjeKnjiga);
            this.Controls.Add(this.btnPosudbaKnjige);
            this.Controls.Add(this.btnUpisKnjiga);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Pocetna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpisKnjiga;
        private System.Windows.Forms.Button btnPosudbaKnjige;
        private System.Windows.Forms.Button btnStanjeKnjiga;
        private System.Windows.Forms.Button btnStanjeKnjSkladistu;
    }
}

