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
         this.radioButton3 = new System.Windows.Forms.RadioButton();
         this.radioButton2 = new System.Windows.Forms.RadioButton();
         this.radioButton1 = new System.Windows.Forms.RadioButton();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // TXB_Moyenne
         // 
         this.TXB_Moyenne.Location = new System.Drawing.Point(76, 19);
         this.TXB_Moyenne.Name = "TXB_Moyenne";
         this.TXB_Moyenne.Size = new System.Drawing.Size(100, 20);
         this.TXB_Moyenne.TabIndex = 0;
         // 
         // TXB_Ecart
         // 
         this.TXB_Ecart.Location = new System.Drawing.Point(76, 46);
         this.TXB_Ecart.Name = "TXB_Ecart";
         this.TXB_Ecart.Size = new System.Drawing.Size(100, 20);
         this.TXB_Ecart.TabIndex = 1;
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
         this.CBX_Keep.TabIndex = 4;
         this.CBX_Keep.Text = "Garder les données";
         this.CBX_Keep.UseVisualStyleBackColor = true;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.radioButton3);
         this.groupBox1.Controls.Add(this.radioButton2);
         this.groupBox1.Controls.Add(this.radioButton1);
         this.groupBox1.Location = new System.Drawing.Point(8, 79);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(168, 100);
         this.groupBox1.TabIndex = 5;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Problème";
         // 
         // radioButton3
         // 
         this.radioButton3.AutoSize = true;
         this.radioButton3.Location = new System.Drawing.Point(8, 65);
         this.radioButton3.Name = "radioButton3";
         this.radioButton3.Size = new System.Drawing.Size(90, 17);
         this.radioButton3.TabIndex = 2;
         this.radioButton3.TabStop = true;
         this.radioButton3.Text = "P ( a < X < b )";
         this.radioButton3.UseVisualStyleBackColor = true;
         // 
         // radioButton2
         // 
         this.radioButton2.AutoSize = true;
         this.radioButton2.Location = new System.Drawing.Point(8, 42);
         this.radioButton2.Name = "radioButton2";
         this.radioButton2.Size = new System.Drawing.Size(72, 17);
         this.radioButton2.TabIndex = 1;
         this.radioButton2.TabStop = true;
         this.radioButton2.Text = "P ( X > a )";
         this.radioButton2.UseVisualStyleBackColor = true;
         // 
         // radioButton1
         // 
         this.radioButton1.AutoSize = true;
         this.radioButton1.Location = new System.Drawing.Point(8, 19);
         this.radioButton1.Name = "radioButton1";
         this.radioButton1.Size = new System.Drawing.Size(72, 17);
         this.radioButton1.TabIndex = 0;
         this.radioButton1.TabStop = true;
         this.radioButton1.Text = "P ( X < a )";
         this.radioButton1.UseVisualStyleBackColor = true;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(185, 43);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(118, 23);
         this.button1.TabIndex = 6;
         this.button1.Text = "Calcul";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(185, 73);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(118, 23);
         this.button2.TabIndex = 7;
         this.button2.Text = "Clear";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(185, 131);
         this.textBox1.Name = "textBox1";
         this.textBox1.ReadOnly = true;
         this.textBox1.Size = new System.Drawing.Size(118, 20);
         this.textBox1.TabIndex = 8;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(182, 115);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(56, 13);
         this.label3.TabIndex = 9;
         this.label3.Text = "Réponse :";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(315, 205);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
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
      private System.Windows.Forms.RadioButton radioButton3;
      private System.Windows.Forms.RadioButton radioButton2;
      private System.Windows.Forms.RadioButton radioButton1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label label3;
   }
}

