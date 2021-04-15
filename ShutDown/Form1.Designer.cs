namespace ShutDown
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SETTIME = new System.Windows.Forms.Panel();
            this.MIN_M = new System.Windows.Forms.Button();
            this.MIN_P = new System.Windows.Forms.Button();
            this.HOURS_M = new System.Windows.Forms.Button();
            this.MIN_R = new System.Windows.Forms.Label();
            this.HOUR_P = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.HOUR_R = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FMIN_M = new System.Windows.Forms.Button();
            this.FMIN_P = new System.Windows.Forms.Button();
            this.FHOUR_M = new System.Windows.Forms.Button();
            this.MIN_F = new System.Windows.Forms.Label();
            this.FHOUR_P = new System.Windows.Forms.Button();
            this.HOUR_F = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SDTime = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.doCancel = new System.Windows.Forms.Button();
            this.doShutDown = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SETTIME.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SETTIME
            // 
            this.SETTIME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SETTIME.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SETTIME.Controls.Add(this.MIN_M);
            this.SETTIME.Controls.Add(this.MIN_P);
            this.SETTIME.Controls.Add(this.HOURS_M);
            this.SETTIME.Controls.Add(this.MIN_R);
            this.SETTIME.Controls.Add(this.HOUR_P);
            this.SETTIME.Controls.Add(this.label4);
            this.SETTIME.Controls.Add(this.HOUR_R);
            this.SETTIME.Controls.Add(this.label3);
            this.SETTIME.Controls.Add(this.label1);
            this.SETTIME.Location = new System.Drawing.Point(12, 15);
            this.SETTIME.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.SETTIME.Name = "SETTIME";
            this.SETTIME.Size = new System.Drawing.Size(560, 136);
            this.SETTIME.TabIndex = 3;
            // 
            // MIN_M
            // 
            this.MIN_M.BackColor = System.Drawing.SystemColors.Control;
            this.MIN_M.FlatAppearance.BorderSize = 0;
            this.MIN_M.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MIN_M.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIN_M.ForeColor = System.Drawing.Color.Maroon;
            this.MIN_M.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MIN_M.Location = new System.Drawing.Point(336, 81);
            this.MIN_M.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MIN_M.Name = "MIN_M";
            this.MIN_M.Size = new System.Drawing.Size(40, 30);
            this.MIN_M.TabIndex = 10;
            this.MIN_M.Text = "-";
            this.MIN_M.UseVisualStyleBackColor = false;
            this.MIN_M.Click += new System.EventHandler(this.MIN_M_Click);
            // 
            // MIN_P
            // 
            this.MIN_P.BackColor = System.Drawing.SystemColors.Control;
            this.MIN_P.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MIN_P.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIN_P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MIN_P.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MIN_P.Location = new System.Drawing.Point(336, 20);
            this.MIN_P.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MIN_P.Name = "MIN_P";
            this.MIN_P.Size = new System.Drawing.Size(40, 30);
            this.MIN_P.TabIndex = 8;
            this.MIN_P.Text = "+";
            this.MIN_P.UseVisualStyleBackColor = false;
            this.MIN_P.Click += new System.EventHandler(this.MIN_P_Click);
            // 
            // HOURS_M
            // 
            this.HOURS_M.BackColor = System.Drawing.SystemColors.Control;
            this.HOURS_M.FlatAppearance.BorderSize = 0;
            this.HOURS_M.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HOURS_M.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOURS_M.ForeColor = System.Drawing.Color.Maroon;
            this.HOURS_M.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HOURS_M.Location = new System.Drawing.Point(224, 81);
            this.HOURS_M.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HOURS_M.Name = "HOURS_M";
            this.HOURS_M.Size = new System.Drawing.Size(40, 30);
            this.HOURS_M.TabIndex = 11;
            this.HOURS_M.Text = "-";
            this.HOURS_M.UseVisualStyleBackColor = false;
            this.HOURS_M.Click += new System.EventHandler(this.HOURS_M_Click);
            // 
            // MIN_R
            // 
            this.MIN_R.AutoSize = true;
            this.MIN_R.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIN_R.Location = new System.Drawing.Point(339, 54);
            this.MIN_R.Name = "MIN_R";
            this.MIN_R.Size = new System.Drawing.Size(36, 23);
            this.MIN_R.TabIndex = 3;
            this.MIN_R.Text = "00";
            this.MIN_R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HOUR_P
            // 
            this.HOUR_P.BackColor = System.Drawing.SystemColors.Control;
            this.HOUR_P.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HOUR_P.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOUR_P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HOUR_P.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HOUR_P.Location = new System.Drawing.Point(224, 20);
            this.HOUR_P.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HOUR_P.Name = "HOUR_P";
            this.HOUR_P.Size = new System.Drawing.Size(40, 30);
            this.HOUR_P.TabIndex = 9;
            this.HOUR_P.Text = "+";
            this.HOUR_P.UseVisualStyleBackColor = false;
            this.HOUR_P.Click += new System.EventHandler(this.HOUR_P_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "MINS   AFTER...";
            // 
            // HOUR_R
            // 
            this.HOUR_R.AutoSize = true;
            this.HOUR_R.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOUR_R.Location = new System.Drawing.Point(227, 54);
            this.HOUR_R.Name = "HOUR_R";
            this.HOUR_R.Size = new System.Drawing.Size(36, 23);
            this.HOUR_R.TabIndex = 5;
            this.HOUR_R.Text = "02";
            this.HOUR_R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "HOURS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "SHUT DOWN TIMER :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.FMIN_M);
            this.panel1.Controls.Add(this.FMIN_P);
            this.panel1.Controls.Add(this.FHOUR_M);
            this.panel1.Controls.Add(this.MIN_F);
            this.panel1.Controls.Add(this.FHOUR_P);
            this.panel1.Controls.Add(this.HOUR_F);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 136);
            this.panel1.TabIndex = 4;
            // 
            // FMIN_M
            // 
            this.FMIN_M.BackColor = System.Drawing.SystemColors.Control;
            this.FMIN_M.FlatAppearance.BorderSize = 0;
            this.FMIN_M.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FMIN_M.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FMIN_M.ForeColor = System.Drawing.Color.Maroon;
            this.FMIN_M.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FMIN_M.Location = new System.Drawing.Point(270, 81);
            this.FMIN_M.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FMIN_M.Name = "FMIN_M";
            this.FMIN_M.Size = new System.Drawing.Size(40, 30);
            this.FMIN_M.TabIndex = 10;
            this.FMIN_M.Text = "-";
            this.FMIN_M.UseVisualStyleBackColor = false;
            this.FMIN_M.Click += new System.EventHandler(this.FMIN_M_Click);
            // 
            // FMIN_P
            // 
            this.FMIN_P.BackColor = System.Drawing.SystemColors.Control;
            this.FMIN_P.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FMIN_P.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FMIN_P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FMIN_P.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FMIN_P.Location = new System.Drawing.Point(270, 20);
            this.FMIN_P.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FMIN_P.Name = "FMIN_P";
            this.FMIN_P.Size = new System.Drawing.Size(40, 30);
            this.FMIN_P.TabIndex = 8;
            this.FMIN_P.Text = "+";
            this.FMIN_P.UseVisualStyleBackColor = false;
            this.FMIN_P.Click += new System.EventHandler(this.FMIN_P_Click);
            // 
            // FHOUR_M
            // 
            this.FHOUR_M.BackColor = System.Drawing.SystemColors.Control;
            this.FHOUR_M.FlatAppearance.BorderSize = 0;
            this.FHOUR_M.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FHOUR_M.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FHOUR_M.ForeColor = System.Drawing.Color.Maroon;
            this.FHOUR_M.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FHOUR_M.Location = new System.Drawing.Point(224, 81);
            this.FHOUR_M.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FHOUR_M.Name = "FHOUR_M";
            this.FHOUR_M.Size = new System.Drawing.Size(40, 30);
            this.FHOUR_M.TabIndex = 11;
            this.FHOUR_M.Text = "-";
            this.FHOUR_M.UseVisualStyleBackColor = false;
            this.FHOUR_M.Click += new System.EventHandler(this.FHOUR_M_Click);
            // 
            // MIN_F
            // 
            this.MIN_F.AutoSize = true;
            this.MIN_F.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIN_F.Location = new System.Drawing.Point(273, 54);
            this.MIN_F.Name = "MIN_F";
            this.MIN_F.Size = new System.Drawing.Size(36, 23);
            this.MIN_F.TabIndex = 3;
            this.MIN_F.Text = "00";
            this.MIN_F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FHOUR_P
            // 
            this.FHOUR_P.BackColor = System.Drawing.SystemColors.Control;
            this.FHOUR_P.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FHOUR_P.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FHOUR_P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FHOUR_P.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FHOUR_P.Location = new System.Drawing.Point(224, 20);
            this.FHOUR_P.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FHOUR_P.Name = "FHOUR_P";
            this.FHOUR_P.Size = new System.Drawing.Size(40, 30);
            this.FHOUR_P.TabIndex = 9;
            this.FHOUR_P.Text = "+";
            this.FHOUR_P.UseVisualStyleBackColor = false;
            this.FHOUR_P.Click += new System.EventHandler(this.FHOUR_P_Click);
            // 
            // HOUR_F
            // 
            this.HOUR_F.AutoSize = true;
            this.HOUR_F.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOUR_F.Location = new System.Drawing.Point(227, 54);
            this.HOUR_F.Name = "HOUR_F";
            this.HOUR_F.Size = new System.Drawing.Size(36, 23);
            this.HOUR_F.TabIndex = 5;
            this.HOUR_F.Text = "02";
            this.HOUR_F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(260, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "SHUT DOWN AT :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.SDTime);
            this.panel2.Controls.Add(this.CurrentTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 304);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 24);
            this.panel2.TabIndex = 12;
            // 
            // SDTime
            // 
            this.SDTime.AutoSize = true;
            this.SDTime.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDTime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SDTime.Location = new System.Drawing.Point(310, 2);
            this.SDTime.Name = "SDTime";
            this.SDTime.Size = new System.Drawing.Size(19, 15);
            this.SDTime.TabIndex = 7;
            this.SDTime.Text = "...";
            this.SDTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CurrentTime.Location = new System.Drawing.Point(10, 2);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(19, 15);
            this.CurrentTime.TabIndex = 7;
            this.CurrentTime.Text = "...";
            this.CurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.doCancel);
            this.panel3.Controls.Add(this.doShutDown);
            this.panel3.Location = new System.Drawing.Point(402, 158);
            this.panel3.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 136);
            this.panel3.TabIndex = 12;
            // 
            // doCancel
            // 
            this.doCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.doCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.doCancel.FlatAppearance.BorderSize = 3;
            this.doCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doCancel.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doCancel.ForeColor = System.Drawing.Color.Maroon;
            this.doCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.doCancel.Location = new System.Drawing.Point(18, 74);
            this.doCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doCancel.Name = "doCancel";
            this.doCancel.Size = new System.Drawing.Size(132, 50);
            this.doCancel.TabIndex = 10;
            this.doCancel.Text = "CANCEL\r\nSHUT DOWN";
            this.doCancel.UseVisualStyleBackColor = false;
            this.doCancel.Click += new System.EventHandler(this.doCancel_Click);
            // 
            // doShutDown
            // 
            this.doShutDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doShutDown.FlatAppearance.BorderSize = 3;
            this.doShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doShutDown.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doShutDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.doShutDown.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.doShutDown.Location = new System.Drawing.Point(18, 15);
            this.doShutDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doShutDown.Name = "doShutDown";
            this.doShutDown.Size = new System.Drawing.Size(132, 50);
            this.doShutDown.TabIndex = 8;
            this.doShutDown.Text = "RESERVE\r\nSHUT DOWN";
            this.doShutDown.UseVisualStyleBackColor = false;
            this.doShutDown.Click += new System.EventHandler(this.doShutDown_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AcceptButton = this.doShutDown;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.doCancel;
            this.ClientSize = new System.Drawing.Size(583, 328);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SETTIME);
            this.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserve the Computer Shut Down for Victoria";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.SETTIME.ResumeLayout(false);
            this.SETTIME.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel SETTIME;
        private System.Windows.Forms.Button MIN_M;
        private System.Windows.Forms.Button MIN_P;
        private System.Windows.Forms.Button HOURS_M;
        private System.Windows.Forms.Label MIN_R;
        private System.Windows.Forms.Button HOUR_P;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HOUR_R;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FMIN_M;
        private System.Windows.Forms.Button FMIN_P;
        private System.Windows.Forms.Button FHOUR_M;
        private System.Windows.Forms.Label MIN_F;
        private System.Windows.Forms.Button FHOUR_P;
        private System.Windows.Forms.Label HOUR_F;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button doCancel;
        private System.Windows.Forms.Button doShutDown;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label SDTime;
    }
}

