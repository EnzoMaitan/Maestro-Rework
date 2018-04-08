namespace Maestro_Rework.Forms
{
    partial class fmrAdicionarAtividadeCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrAdicionarAtividadeCodigo));
            this.btnConcluir = new System.Windows.Forms.Button();
            this.lblAtividadeAdicionada = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnConcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConcluir.FlatAppearance.BorderSize = 0;
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnConcluir.Image")));
            this.btnConcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConcluir.Location = new System.Drawing.Point(671, 534);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(176, 39);
            this.btnConcluir.TabIndex = 9;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // lblAtividadeAdicionada
            // 
            this.lblAtividadeAdicionada.AutoSize = true;
            this.lblAtividadeAdicionada.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadeAdicionada.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblAtividadeAdicionada.Location = new System.Drawing.Point(213, 244);
            this.lblAtividadeAdicionada.Name = "lblAtividadeAdicionada";
            this.lblAtividadeAdicionada.Size = new System.Drawing.Size(428, 44);
            this.lblAtividadeAdicionada.TabIndex = 10;
            this.lblAtividadeAdicionada.Text = "Conteúdo adicionado!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(253, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(447, 300);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(135, 44);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "G0392";
            // 
            // fmrAdicionarConteudo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAtividadeAdicionada);
            this.Controls.Add(this.btnConcluir);
            this.Name = "fmrAdicionarConteudo3";
            this.Text = "frmAdicionarConteudo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label lblAtividadeAdicionada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
    }
}