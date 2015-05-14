namespace WindowsFormsApplication1
{
   partial class Form1
   {
      /// <summary>
      /// Variable nécessaire au concepteur.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Nettoyage des ressources utilisées.
      /// </summary>
      /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Code généré par le Concepteur Windows Form

      /// <summary>
      /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
      /// le contenu de cette méthode avec l'éditeur de code.
      /// </summary>
      private void InitializeComponent()
      {
            this.TXB_Moyenne = new System.Windows.Forms.TextBox();
            this.TXB_Ecart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBX_Keep = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDB_APXGB = new System.Windows.Forms.RadioButton();
            this.RDB_XGA = new System.Windows.Forms.RadioButton();
            this.RDB_XPA = new System.Windows.Forms.RadioButton();
            this.BTN_Calcul = new System.Windows.Forms.Button();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.TXB_Reponse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXB_A = new System.Windows.Forms.TextBox();
            this.TXB_B = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXB_Moyenne
            // 
            this.TXB_Moyenne.BackColor = System.Drawing.Color.White;
            this.TXB_Moyenne.Location = new System.Drawing.Point(76, 19);
            this.TXB_Moyenne.Name = "TXB_Moyenne";
            this.TXB_Moyenne.Size = new System.Drawing.Size(100, 20);
            this.TXB_Moyenne.TabIndex = 0;
            this.TXB_Moyenne.TextChanged += new System.EventHandler(this.TXB_Moyenne_TextChanged);
            // 
            // TXB_Ecart
            // 
            this.TXB_Ecart.Location = new System.Drawing.Point(76, 46);
            this.TXB_Ecart.Name = "TXB_Ecart";
            this.TXB_Ecart.Size = new System.Drawing.Size(100, 20);
            this.TXB_Ecart.TabIndex = 1;
            this.TXB_Ecart.TextChanged += new System.EventHandler(this.TXB_Ecart_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Moyenne :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Écart Type :";
            // 
            // CBX_Keep
            // 
            this.CBX_Keep.AutoSize = true;
            this.CBX_Keep.Location = new System.Drawing.Point(185, 18);
            this.CBX_Keep.Name = "CBX_Keep";
            this.CBX_Keep.Size = new System.Drawing.Size(118, 17);
            this.CBX_Keep.TabIndex = 11;
            this.CBX_Keep.Text = "Garder les données";
            this.CBX_Keep.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RDB_APXGB);
            this.groupBox1.Controls.Add(this.RDB_XGA);
            this.groupBox1.Controls.Add(this.RDB_XPA);
            this.groupBox1.Location = new System.Drawing.Point(8, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Problème";
            // 
            // RDB_APXGB
            // 
            this.RDB_APXGB.AutoSize = true;
            this.RDB_APXGB.Location = new System.Drawing.Point(8, 65);
            this.RDB_APXGB.Name = "RDB_APXGB";
            this.RDB_APXGB.Size = new System.Drawing.Size(90, 17);
            this.RDB_APXGB.TabIndex = 2;
            this.RDB_APXGB.TabStop = true;
            this.RDB_APXGB.Text = "P ( a < X < b )";
            this.RDB_APXGB.UseVisualStyleBackColor = true;
            this.RDB_APXGB.CheckedChanged += new System.EventHandler(this.RDB_APXGB_CheckedChanged);
            // 
            // RDB_XGA
            // 
            this.RDB_XGA.AutoSize = true;
            this.RDB_XGA.Location = new System.Drawing.Point(8, 42);
            this.RDB_XGA.Name = "RDB_XGA";
            this.RDB_XGA.Size = new System.Drawing.Size(72, 17);
            this.RDB_XGA.TabIndex = 1;
            this.RDB_XGA.TabStop = true;
            this.RDB_XGA.Text = "P ( X > a )";
            this.RDB_XGA.UseVisualStyleBackColor = true;
            this.RDB_XGA.CheckedChanged += new System.EventHandler(this.RDB_XGA_CheckedChanged);
            // 
            // RDB_XPA
            // 
            this.RDB_XPA.AutoSize = true;
            this.RDB_XPA.Location = new System.Drawing.Point(8, 19);
            this.RDB_XPA.Name = "RDB_XPA";
            this.RDB_XPA.Size = new System.Drawing.Size(72, 17);
            this.RDB_XPA.TabIndex = 0;
            this.RDB_XPA.TabStop = true;
            this.RDB_XPA.Text = "P ( X < a )";
            this.RDB_XPA.UseVisualStyleBackColor = true;
            this.RDB_XPA.CheckedChanged += new System.EventHandler(this.RDB_XPA_CheckedChanged);
            // 
            // BTN_Calcul
            // 
            this.BTN_Calcul.Location = new System.Drawing.Point(185, 43);
            this.BTN_Calcul.Name = "BTN_Calcul";
            this.BTN_Calcul.Size = new System.Drawing.Size(118, 23);
            this.BTN_Calcul.TabIndex = 4;
            this.BTN_Calcul.Text = "Calcul";
            this.BTN_Calcul.UseVisualStyleBackColor = true;
            this.BTN_Calcul.Click += new System.EventHandler(this.BTN_Calcul_Click);
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(185, 73);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(118, 23);
            this.BTN_Clear.TabIndex = 5;
            this.BTN_Clear.Text = "Clear";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // TXB_Reponse
            // 
            this.TXB_Reponse.Location = new System.Drawing.Point(185, 173);
            this.TXB_Reponse.Name = "TXB_Reponse";
            this.TXB_Reponse.ReadOnly = true;
            this.TXB_Reponse.Size = new System.Drawing.Size(118, 20);
            this.TXB_Reponse.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Réponse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "a :";
            this.label4.Visible = false;
            // 
            // TXB_A
            // 
            this.TXB_A.Location = new System.Drawing.Point(205, 102);
            this.TXB_A.Name = "TXB_A";
            this.TXB_A.Size = new System.Drawing.Size(98, 20);
            this.TXB_A.TabIndex = 2;
            this.TXB_A.Visible = false;
            this.TXB_A.TextChanged += new System.EventHandler(this.TXB_A_TextChanged);
            // 
            // TXB_B
            // 
            this.TXB_B.Location = new System.Drawing.Point(205, 128);
            this.TXB_B.Name = "TXB_B";
            this.TXB_B.Size = new System.Drawing.Size(98, 20);
            this.TXB_B.TabIndex = 3;
            this.TXB_B.Visible = false;
            this.TXB_B.TextChanged += new System.EventHandler(this.TXB_B_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "b :";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 205);
            this.Controls.Add(this.TXB_B);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXB_A);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXB_Reponse);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.BTN_Calcul);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CBX_Keep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_Ecart);
            this.Controls.Add(this.TXB_Moyenne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox TXB_Moyenne;
      private System.Windows.Forms.TextBox TXB_Ecart;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.CheckBox CBX_Keep;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton RDB_APXGB;
      private System.Windows.Forms.RadioButton RDB_XGA;
      private System.Windows.Forms.RadioButton RDB_XPA;
      private System.Windows.Forms.Button BTN_Calcul;
      private System.Windows.Forms.Button BTN_Clear;
      private System.Windows.Forms.TextBox TXB_Reponse;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox TXB_A;
      private System.Windows.Forms.TextBox TXB_B;
      private System.Windows.Forms.Label label5;
   }
}

