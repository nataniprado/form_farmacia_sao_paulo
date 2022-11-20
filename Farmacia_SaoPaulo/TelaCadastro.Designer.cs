using System.ComponentModel;

namespace Farmacia_SaoPaulo
{
    partial class TelaCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeUsuariotextbox = new System.Windows.Forms.TextBox();
            this.sobrenomeTextbox = new System.Windows.Forms.TextBox();
            this.cpfTextbox = new System.Windows.Forms.TextBox();
            this.telefoneTextbox = new System.Windows.Forms.TextBox();
            this.confirmarSenhaTextbox = new System.Windows.Forms.TextBox();
            this.cadastroSenhaTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.receberEmailCheckBox1 = new System.Windows.Forms.CheckBox();
            this.ParticiparProgramacheckBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // emailTextbox
            // 
            this.emailTextbox.AccessibleName = "";
            this.emailTextbox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.emailTextbox.BackColor = System.Drawing.Color.White;
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.emailTextbox.Location = new System.Drawing.Point(15, 129);
            this.emailTextbox.Multiline = true;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(523, 34);
            this.emailTextbox.TabIndex = 15;
            this.emailTextbox.Text = "E-mail";
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(489, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 60);
            this.button2.TabIndex = 14;
            this.button2.Text = "CONFIRMAR ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(367, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Crie sua conta na Drogarias São Paulo agora e acesse promoções exclusivas, fique " + "por dentro das novidades e acompanhe suas compras!";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 68);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quero criar uma conta na Drogarias São Paulo";
            // 
            // nomeUsuariotextbox
            // 
            this.nomeUsuariotextbox.BackColor = System.Drawing.Color.White;
            this.nomeUsuariotextbox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeUsuariotextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeUsuariotextbox.Location = new System.Drawing.Point(15, 169);
            this.nomeUsuariotextbox.Multiline = true;
            this.nomeUsuariotextbox.Name = "nomeUsuariotextbox";
            this.nomeUsuariotextbox.Size = new System.Drawing.Size(257, 34);
            this.nomeUsuariotextbox.TabIndex = 16;
            this.nomeUsuariotextbox.Text = "Nome ";
            // 
            // sobrenomeTextbox
            // 
            this.sobrenomeTextbox.BackColor = System.Drawing.Color.White;
            this.sobrenomeTextbox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobrenomeTextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.sobrenomeTextbox.Location = new System.Drawing.Point(281, 169);
            this.sobrenomeTextbox.Multiline = true;
            this.sobrenomeTextbox.Name = "sobrenomeTextbox";
            this.sobrenomeTextbox.Size = new System.Drawing.Size(257, 34);
            this.sobrenomeTextbox.TabIndex = 17;
            this.sobrenomeTextbox.Text = "Sobrenome ";
            this.sobrenomeTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cpfTextbox
            // 
            this.cpfTextbox.BackColor = System.Drawing.Color.White;
            this.cpfTextbox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfTextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cpfTextbox.Location = new System.Drawing.Point(15, 209);
            this.cpfTextbox.Multiline = true;
            this.cpfTextbox.Name = "cpfTextbox";
            this.cpfTextbox.Size = new System.Drawing.Size(257, 34);
            this.cpfTextbox.TabIndex = 18;
            this.cpfTextbox.Text = "CPF";
            // 
            // telefoneTextbox
            // 
            this.telefoneTextbox.BackColor = System.Drawing.Color.White;
            this.telefoneTextbox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.telefoneTextbox.Location = new System.Drawing.Point(281, 209);
            this.telefoneTextbox.Multiline = true;
            this.telefoneTextbox.Name = "telefoneTextbox";
            this.telefoneTextbox.Size = new System.Drawing.Size(257, 34);
            this.telefoneTextbox.TabIndex = 19;
            this.telefoneTextbox.Text = "Telefone";
            // 
            // confirmarSenhaTextbox
            // 
            this.confirmarSenhaTextbox.BackColor = System.Drawing.Color.White;
            this.confirmarSenhaTextbox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarSenhaTextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmarSenhaTextbox.Location = new System.Drawing.Point(281, 249);
            this.confirmarSenhaTextbox.Multiline = true;
            this.confirmarSenhaTextbox.Name = "confirmarSenhaTextbox";
            this.confirmarSenhaTextbox.Size = new System.Drawing.Size(257, 34);
            this.confirmarSenhaTextbox.TabIndex = 21;
            this.confirmarSenhaTextbox.Text = "Confirmar sua senha";
            // 
            // cadastroSenhaTextbox
            // 
            this.cadastroSenhaTextbox.BackColor = System.Drawing.Color.White;
            this.cadastroSenhaTextbox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroSenhaTextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cadastroSenhaTextbox.Location = new System.Drawing.Point(15, 249);
            this.cadastroSenhaTextbox.Multiline = true;
            this.cadastroSenhaTextbox.Name = "cadastroSenhaTextbox";
            this.cadastroSenhaTextbox.Size = new System.Drawing.Size(257, 34);
            this.cadastroSenhaTextbox.TabIndex = 20;
            this.cadastroSenhaTextbox.Text = "Cadastrar sua senha";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(15, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sua senha deve ter ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(15, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 75);
            this.label3.TabIndex = 22;
            this.label3.Text = "- 1 letra maiúscula\r\n- 1 letra minúscula\r\n- 1 número\r\n- Mínimo de 8 caracteres";
            // 
            // receberEmailCheckBox1
            // 
            this.receberEmailCheckBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.receberEmailCheckBox1.Location = new System.Drawing.Point(12, 393);
            this.receberEmailCheckBox1.Name = "receberEmailCheckBox1";
            this.receberEmailCheckBox1.Size = new System.Drawing.Size(257, 23);
            this.receberEmailCheckBox1.TabIndex = 24;
            this.receberEmailCheckBox1.Text = "Desejo receber e-mails da Drogarias São Paulo";
            this.receberEmailCheckBox1.UseVisualStyleBackColor = true;
            this.receberEmailCheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ParticiparProgramacheckBox2
            // 
            this.ParticiparProgramacheckBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ParticiparProgramacheckBox2.Location = new System.Drawing.Point(12, 413);
            this.ParticiparProgramacheckBox2.Name = "ParticiparProgramacheckBox2";
            this.ParticiparProgramacheckBox2.Size = new System.Drawing.Size(443, 35);
            this.ParticiparProgramacheckBox2.TabIndex = 25;
            this.ParticiparProgramacheckBox2.Text = "Gostaria de participar do Programa Viva Saúde para ter benefícios exclusivos na D" + "rogarias São Paulo.\r\n";
            this.ParticiparProgramacheckBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(30, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "Aceito os Termos de Uso e a Política de Privacidade da Drogarias São Paulo.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(76, 451);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 28);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Termos de Uso";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(170, 451);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(117, 28);
            this.linkLabel2.TabIndex = 28;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Política de Privacidade";
            // 
            // TelaCadastro
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ParticiparProgramacheckBox2);
            this.Controls.Add(this.receberEmailCheckBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmarSenhaTextbox);
            this.Controls.Add(this.cadastroSenhaTextbox);
            this.Controls.Add(this.telefoneTextbox);
            this.Controls.Add(this.cpfTextbox);
            this.Controls.Add(this.sobrenomeTextbox);
            this.Controls.Add(this.nomeUsuariotextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaCadastro";
            this.Text = "TelaCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.LinkLabel linkLabel2;

        private System.Windows.Forms.LinkLabel linkLabel1;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.CheckBox ParticiparProgramacheckBox2;

        private System.Windows.Forms.CheckBox receberEmailCheckBox1;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox telefoneTextbox;
        private System.Windows.Forms.TextBox cpfTextbox;
        private System.Windows.Forms.TextBox confirmarSenhaTextbox;
        private System.Windows.Forms.TextBox cadastroSenhaTextbox;

        private System.Windows.Forms.TextBox nomeUsuariotextbox;
        private System.Windows.Forms.TextBox sobrenomeTextbox;

        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}