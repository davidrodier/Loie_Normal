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
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(315, 205);
         this.Controls.Add(this.CBX_Keep);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.TXB_Ecart);
         this.Controls.Add(this.TXB_Moyenne);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox TXB_Moyenne;
      private System.Windows.Forms.TextBox TXB_Ecart;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.CheckBox CBX_Keep;
   }
}

