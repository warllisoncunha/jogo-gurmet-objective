using static System.Net.Mime.MediaTypeNames;

namespace JogoGourmet_Warllison
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label _principalLabel;
        private Button _okPrincipalButton;
        private Button _simButton;
        private Button _naoButton;
        private Button _cancelarButton;
        private Button _setPratoButton;
        private TextBox _informaPratoPensado;



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
            _principalLabel = new Label();
            SuspendLayout();

            LabelInicialize("Pense em um prato que gosta");
            FormInicialize();
            OkPrincipalButtonInitialize();
        }

        private void TextBoxInicialize()
        {
            _informaPratoPensado = new TextBox();

            _informaPratoPensado.Location = new Point(55, 53);
            _informaPratoPensado.Name = "textBox1";
            _informaPratoPensado.Size = new Size(216, 27);
            _informaPratoPensado.TabIndex = 0;

            this.Controls.Add(_informaPratoPensado);

        }

        private void LabelInicialize(string textLabel)
        {
            _principalLabel.AutoSize = true;
            _principalLabel.Location = new Point(69, 24);
            _principalLabel.Name = "principalLabel";
            _principalLabel.Size = new Size(206, 20);
            _principalLabel.TabIndex = 0;
            _principalLabel.Text = textLabel;
        }

        private void OkPrincipalButtonInitialize()
        {
            _okPrincipalButton = new Button();

            _okPrincipalButton.BackColor = SystemColors.ActiveCaption;
            _okPrincipalButton.ForeColor = Color.Black;
            _okPrincipalButton.Location = new Point(119, 62);
            _okPrincipalButton.Name = "principalButton";
            _okPrincipalButton.Size = new Size(94, 29);
            _okPrincipalButton.TabIndex = 1;
            _okPrincipalButton.Text = "OK";
            _okPrincipalButton.UseVisualStyleBackColor = false;
            _okPrincipalButton.Click += BtnOk;

            this.Controls.Add(_okPrincipalButton);
        }

        private void SetPratoButtonInitialize()
        {
            _setPratoButton = new Button();

            _setPratoButton.BackColor = SystemColors.ActiveCaption;
            _setPratoButton.ForeColor = Color.Black;
            _setPratoButton.Location = new Point(30, 85);
            _setPratoButton.Name = "setPratoButton";
            _setPratoButton.Size = new Size(94, 29);
            _setPratoButton.TabIndex = 1;
            _setPratoButton.Text = "OK";
            _setPratoButton.UseVisualStyleBackColor = false;

            _setPratoButton.Click += BtnSetPratoPensado;
            this.Controls.Add(_setPratoButton);
        }

        private void CancelarButtonInitialize()
        {
            _cancelarButton = new Button();

            _cancelarButton.ForeColor = Color.Black;
            _cancelarButton.BackColor = SystemColors.ActiveCaption;
            _cancelarButton.Location = new Point(180, 85);
            _cancelarButton.Name = "cancelarButton";
            _cancelarButton.Size = new Size(94, 29);
            _cancelarButton.TabIndex = 1;
            _cancelarButton.Text = "Cncelar";
            _cancelarButton.UseVisualStyleBackColor = false;

            _cancelarButton.Click += BtnCancelar;
            this.Controls.Add(_cancelarButton);
        }

        private void SimButtonInitialize()
        {
            _simButton = new Button();

            _simButton.BackColor = SystemColors.ActiveCaption;
            _simButton.ForeColor = Color.Black;
            _simButton.Location = new Point(19, 62);
            _simButton.Name = "simButton";
            _simButton.Size = new Size(94, 29);
            _simButton.TabIndex = 1;
            _simButton.Text = "Sim";
            _simButton.UseVisualStyleBackColor = false;

            _simButton.Click += BtnSim;
            this.Controls.Add(_simButton);
        }

        private void NaoButtonInitialize()
        {
            _naoButton = new Button();

            _naoButton.ForeColor = Color.Black;
            _naoButton.BackColor = SystemColors.ActiveCaption;
            _naoButton.Location = new Point(239, 62);
            _naoButton.Name = "naoButton";
            _naoButton.Size = new Size(94, 29);
            _naoButton.TabIndex = 1;
            _naoButton.Text = "Não";
            _naoButton.UseVisualStyleBackColor = false;

            _naoButton.Click += BtnNao;
            this.Controls.Add(_naoButton);
        }

        private void FormInicialize()
        {
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CenterToScreen();
            ClientSize = new Size(356, 93);
            Controls.Add(_okPrincipalButton);
            Controls.Add(_principalLabel);
            Name = "PrincipalForm";
            Text = "Jogo Gourmet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}