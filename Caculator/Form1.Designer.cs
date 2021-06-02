
namespace Caculator
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
            this.tbbirinchiSon = new System.Windows.Forms.TextBox();
            this.tbikkinchiSon = new System.Windows.Forms.TextBox();
            this.tbNatija = new System.Windows.Forms.TextBox();
            this.qosh = new System.Windows.Forms.Button();
            this.ayir = new System.Windows.Forms.Button();
            this.kopay = new System.Windows.Forms.Button();
            this.bol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbamal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnKub = new System.Windows.Forms.Button();
            this.btnIldiz = new System.Windows.Forms.Button();
            this.tbKvadrat = new System.Windows.Forms.Button();
            this.btnctg = new System.Windows.Forms.Button();
            this.btntg = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbbirinchiSon
            // 
            this.tbbirinchiSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbbirinchiSon.Location = new System.Drawing.Point(47, 36);
            this.tbbirinchiSon.Name = "tbbirinchiSon";
            this.tbbirinchiSon.Size = new System.Drawing.Size(121, 26);
            this.tbbirinchiSon.TabIndex = 0;
            // 
            // tbikkinchiSon
            // 
            this.tbikkinchiSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbikkinchiSon.Location = new System.Drawing.Point(230, 36);
            this.tbikkinchiSon.Name = "tbikkinchiSon";
            this.tbikkinchiSon.Size = new System.Drawing.Size(107, 26);
            this.tbikkinchiSon.TabIndex = 1;
            // 
            // tbNatija
            // 
            this.tbNatija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNatija.Location = new System.Drawing.Point(47, 92);
            this.tbNatija.Name = "tbNatija";
            this.tbNatija.ReadOnly = true;
            this.tbNatija.Size = new System.Drawing.Size(290, 26);
            this.tbNatija.TabIndex = 2;
            // 
            // qosh
            // 
            this.qosh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.qosh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qosh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.qosh.Location = new System.Drawing.Point(47, 155);
            this.qosh.Name = "qosh";
            this.qosh.Size = new System.Drawing.Size(67, 34);
            this.qosh.TabIndex = 4;
            this.qosh.Text = "+";
            this.qosh.UseVisualStyleBackColor = false;
            this.qosh.Click += new System.EventHandler(this.qosh_Click);
            // 
            // ayir
            // 
            this.ayir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ayir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ayir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ayir.Location = new System.Drawing.Point(120, 155);
            this.ayir.Name = "ayir";
            this.ayir.Size = new System.Drawing.Size(67, 34);
            this.ayir.TabIndex = 5;
            this.ayir.Text = "-";
            this.ayir.UseVisualStyleBackColor = false;
            this.ayir.Click += new System.EventHandler(this.ayir_Click);
            // 
            // kopay
            // 
            this.kopay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.kopay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kopay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kopay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kopay.Location = new System.Drawing.Point(195, 155);
            this.kopay.Name = "kopay";
            this.kopay.Size = new System.Drawing.Size(67, 34);
            this.kopay.TabIndex = 6;
            this.kopay.Text = "*";
            this.kopay.UseVisualStyleBackColor = false;
            this.kopay.Click += new System.EventHandler(this.kopay_Click);
            // 
            // bol
            // 
            this.bol.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bol.Location = new System.Drawing.Point(270, 155);
            this.bol.Name = "bol";
            this.bol.Size = new System.Drawing.Size(67, 34);
            this.bol.TabIndex = 7;
            this.bol.Text = "/";
            this.bol.UseVisualStyleBackColor = false;
            this.bol.Click += new System.EventHandler(this.bol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Birinchi son";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ikkinchi son";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Natija";
            // 
            // tbamal
            // 
            this.tbamal.AutoSize = true;
            this.tbamal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbamal.Location = new System.Drawing.Point(175, 73);
            this.tbamal.Name = "tbamal";
            this.tbamal.Size = new System.Drawing.Size(34, 13);
            this.tbamal.TabIndex = 11;
            this.tbamal.Text = "Amal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(129, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Qo\'shimcha amallar";
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLog.Location = new System.Drawing.Point(269, 231);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(67, 34);
            this.btnLog.TabIndex = 16;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnKub
            // 
            this.btnKub.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnKub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKub.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKub.Location = new System.Drawing.Point(195, 231);
            this.btnKub.Name = "btnKub";
            this.btnKub.Size = new System.Drawing.Size(67, 34);
            this.btnKub.TabIndex = 15;
            this.btnKub.Text = "Kub";
            this.btnKub.UseVisualStyleBackColor = false;
            this.btnKub.Click += new System.EventHandler(this.btnKub_Click);
            // 
            // btnIldiz
            // 
            this.btnIldiz.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIldiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIldiz.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIldiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIldiz.Location = new System.Drawing.Point(121, 231);
            this.btnIldiz.Name = "btnIldiz";
            this.btnIldiz.Size = new System.Drawing.Size(67, 34);
            this.btnIldiz.TabIndex = 14;
            this.btnIldiz.Text = "Ildiz";
            this.btnIldiz.UseVisualStyleBackColor = false;
            this.btnIldiz.Click += new System.EventHandler(this.btnIldiz_Click);
            // 
            // tbKvadrat
            // 
            this.tbKvadrat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbKvadrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbKvadrat.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKvadrat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbKvadrat.Location = new System.Drawing.Point(47, 231);
            this.tbKvadrat.Name = "tbKvadrat";
            this.tbKvadrat.Size = new System.Drawing.Size(67, 34);
            this.tbKvadrat.TabIndex = 13;
            this.tbKvadrat.Text = "Kvadrat";
            this.tbKvadrat.UseVisualStyleBackColor = false;
            this.tbKvadrat.Click += new System.EventHandler(this.tbKvadrat_Click);
            // 
            // btnctg
            // 
            this.btnctg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnctg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnctg.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnctg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnctg.Location = new System.Drawing.Point(269, 272);
            this.btnctg.Name = "btnctg";
            this.btnctg.Size = new System.Drawing.Size(67, 34);
            this.btnctg.TabIndex = 20;
            this.btnctg.Text = "ctg";
            this.btnctg.UseVisualStyleBackColor = false;
            this.btnctg.Click += new System.EventHandler(this.btnctg_Click);
            // 
            // btntg
            // 
            this.btntg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btntg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntg.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntg.Location = new System.Drawing.Point(195, 272);
            this.btntg.Name = "btntg";
            this.btntg.Size = new System.Drawing.Size(67, 34);
            this.btntg.TabIndex = 19;
            this.btntg.Text = "tg";
            this.btntg.UseVisualStyleBackColor = false;
            this.btntg.Click += new System.EventHandler(this.btntg_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCos.Location = new System.Drawing.Point(121, 272);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(67, 34);
            this.btnCos.TabIndex = 18;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSin.Location = new System.Drawing.Point(47, 272);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(67, 34);
            this.btnSin.TabIndex = 17;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(141, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Asosiy amallar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 335);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnctg);
            this.Controls.Add(this.btntg);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnKub);
            this.Controls.Add(this.btnIldiz);
            this.Controls.Add(this.tbKvadrat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbamal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bol);
            this.Controls.Add(this.kopay);
            this.Controls.Add(this.ayir);
            this.Controls.Add(this.qosh);
            this.Controls.Add(this.tbNatija);
            this.Controls.Add(this.tbikkinchiSon);
            this.Controls.Add(this.tbbirinchiSon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbbirinchiSon;
        private System.Windows.Forms.TextBox tbikkinchiSon;
        private System.Windows.Forms.TextBox tbNatija;
        private System.Windows.Forms.Button qosh;
        private System.Windows.Forms.Button ayir;
        private System.Windows.Forms.Button kopay;
        private System.Windows.Forms.Button bol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tbamal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnKub;
        private System.Windows.Forms.Button btnIldiz;
        private System.Windows.Forms.Button tbKvadrat;
        private System.Windows.Forms.Button btnctg;
        private System.Windows.Forms.Button btntg;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Label label5;
    }
}

