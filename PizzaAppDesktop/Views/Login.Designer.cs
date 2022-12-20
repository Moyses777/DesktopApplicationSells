
namespace PizzaAppDesktop
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_TC = new System.Windows.Forms.CheckBox();
            this.btn_validate = new System.Windows.Forms.Button();
            this.user_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.password_error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.user_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIAR SESION";
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(23, 211);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(183, 23);
            this.password_input.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // user_input
            // 
            this.user_input.Location = new System.Drawing.Point(23, 135);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(183, 23);
            this.user_input.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario:";
            // 
            // cbx_TC
            // 
            this.cbx_TC.AutoSize = true;
            this.cbx_TC.Location = new System.Drawing.Point(30, 337);
            this.cbx_TC.Name = "cbx_TC";
            this.cbx_TC.Size = new System.Drawing.Size(193, 19);
            this.cbx_TC.TabIndex = 3;
            this.cbx_TC.Text = "Acepto Terminos y Condiciones";
            this.cbx_TC.UseVisualStyleBackColor = true;
            // 
            // btn_validate
            // 
            this.btn_validate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_validate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_validate.Location = new System.Drawing.Point(85, 269);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(77, 26);
            this.btn_validate.TabIndex = 4;
            this.btn_validate.Text = "Ingresar";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // user_error
            // 
            this.user_error.ContainerControl = this;
            // 
            // password_error
            // 
            this.password_error.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 352);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.cbx_TC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_input);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Login";
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.user_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbx_TC;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.ErrorProvider user_error;
        private System.Windows.Forms.ErrorProvider password_error;
    }
}

