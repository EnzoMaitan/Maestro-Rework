namespace Maestro_Rework.Forms
{
    partial class fmrConcluirQuestionario
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
            this.lblQuestionarioConcluido = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.lblTempoGasto = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestionarioConcluido
            // 
            this.lblQuestionarioConcluido.AutoSize = true;
            this.lblQuestionarioConcluido.Font = new System.Drawing.Font("Century Gothic", 25.25F);
            this.lblQuestionarioConcluido.Location = new System.Drawing.Point(208, 108);
            this.lblQuestionarioConcluido.Name = "lblQuestionarioConcluido";
            this.lblQuestionarioConcluido.Size = new System.Drawing.Size(418, 40);
            this.lblQuestionarioConcluido.TabIndex = 0;
            this.lblQuestionarioConcluido.Text = "Questionario Concluido!";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lblNota.Location = new System.Drawing.Point(305, 204);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(95, 33);
            this.lblNota.TabIndex = 1;
            this.lblNota.Text = "Nota: ";
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lblAcertos.Location = new System.Drawing.Point(305, 284);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(122, 33);
            this.lblAcertos.TabIndex = 2;
            this.lblAcertos.Text = "Acertos:";
            // 
            // lblTempoGasto
            // 
            this.lblTempoGasto.AutoSize = true;
            this.lblTempoGasto.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lblTempoGasto.Location = new System.Drawing.Point(305, 361);
            this.lblTempoGasto.Name = "lblTempoGasto";
            this.lblTempoGasto.Size = new System.Drawing.Size(200, 33);
            this.lblTempoGasto.TabIndex = 3;
            this.lblTempoGasto.Text = "Tempo Gasto:";
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.Lime;
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnConcluir.Location = new System.Drawing.Point(348, 480);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(114, 42);
            this.btnConcluir.TabIndex = 4;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // fmrConcluirQuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.lblTempoGasto);
            this.Controls.Add(this.lblAcertos);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblQuestionarioConcluido);
            this.Name = "fmrConcluirQuestionario";
            this.Text = "fmrConcluirQuestionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionarioConcluido;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.Label lblTempoGasto;
        private System.Windows.Forms.Button btnConcluir;
    }
}