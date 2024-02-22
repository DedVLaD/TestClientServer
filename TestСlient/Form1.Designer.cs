namespace TestKlient
{
    partial class Client
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addressServer_txt = new System.Windows.Forms.TextBox();
            this.fileName_txt = new System.Windows.Forms.TextBox();
            this.fileDate_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.CreateFileData_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addressServer_txt
            // 
            this.addressServer_txt.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.addressServer_txt.Location = new System.Drawing.Point(201, 20);
            this.addressServer_txt.Name = "addressServer_txt";
            this.addressServer_txt.Size = new System.Drawing.Size(277, 36);
            this.addressServer_txt.TabIndex = 0;
            this.addressServer_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressServer_txt_KeyPress);
            // 
            // fileName_txt
            // 
            this.fileName_txt.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.fileName_txt.Location = new System.Drawing.Point(373, 109);
            this.fileName_txt.Name = "fileName_txt";
            this.fileName_txt.Size = new System.Drawing.Size(484, 36);
            this.fileName_txt.TabIndex = 2;
            this.fileName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fileName_txt_KeyPress);
            // 
            // fileDate_txt
            // 
            this.fileDate_txt.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.fileDate_txt.Location = new System.Drawing.Point(373, 152);
            this.fileDate_txt.Name = "fileDate_txt";
            this.fileDate_txt.Size = new System.Drawing.Size(484, 36);
            this.fileDate_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Адрес сервера:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(118, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Укажите имя файл:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Укажите данные для записи:";
            // 
            // Connect_btn
            // 
            this.Connect_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.Connect_btn.Location = new System.Drawing.Point(484, 12);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(373, 44);
            this.Connect_btn.TabIndex = 1;
            this.Connect_btn.Text = "Подключиться к серверу";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // CreateFileData_btn
            // 
            this.CreateFileData_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.CreateFileData_btn.Location = new System.Drawing.Point(484, 203);
            this.CreateFileData_btn.Name = "CreateFileData_btn";
            this.CreateFileData_btn.Size = new System.Drawing.Size(373, 44);
            this.CreateFileData_btn.TabIndex = 4;
            this.CreateFileData_btn.Text = "Создать файл и внести данные";
            this.CreateFileData_btn.UseVisualStyleBackColor = true;
            this.CreateFileData_btn.Click += new System.EventHandler(this.CreateFileData_btn_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 262);
            this.Controls.Add(this.CreateFileData_btn);
            this.Controls.Add(this.Connect_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileDate_txt);
            this.Controls.Add(this.fileName_txt);
            this.Controls.Add(this.addressServer_txt);
            this.Name = "Client";
            this.Text = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressServer_txt;
        private System.Windows.Forms.TextBox fileName_txt;
        private System.Windows.Forms.TextBox fileDate_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.Button CreateFileData_btn;
    }
}

