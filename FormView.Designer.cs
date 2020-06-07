namespace Laba2_LaborExchange
{
    partial class FormView
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewForVacancies = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewForApplicants = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxForCompareVacancy = new System.Windows.Forms.RichTextBox();
            this.richTextBoxForCompareApplicant = new System.Windows.Forms.RichTextBox();
            this.pictureBoxForComparison = new System.Windows.Forms.PictureBox();
            this.labelForVacancy = new System.Windows.Forms.Label();
            this.labelForApplicant = new System.Windows.Forms.Label();
            this.textBoxForPromptUser = new System.Windows.Forms.TextBox();
            this.buttonStartProcess = new System.Windows.Forms.Button();
            this.richTextBoxForEnterVacancy = new System.Windows.Forms.RichTextBox();
            this.richTextBoxForEnterApplicant = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForComparison)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Биржа труда";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(496, 89);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewForVacancies);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewForApplicants);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(423, 412);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 1;
            // 
            // listViewForVacancies
            // 
            this.listViewForVacancies.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewForVacancies.HideSelection = false;
            this.listViewForVacancies.Location = new System.Drawing.Point(3, 129);
            this.listViewForVacancies.MultiSelect = false;
            this.listViewForVacancies.Name = "listViewForVacancies";
            this.listViewForVacancies.Size = new System.Drawing.Size(214, 279);
            this.listViewForVacancies.TabIndex = 3;
            this.listViewForVacancies.UseCompatibleStateImageBehavior = false;
            this.listViewForVacancies.View = System.Windows.Forms.View.List;
            this.listViewForVacancies.SelectedIndexChanged += new System.EventHandler(this.listViewForVacancies_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вакансии";
            // 
            // listViewForApplicants
            // 
            this.listViewForApplicants.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewForApplicants.HideSelection = false;
            this.listViewForApplicants.Location = new System.Drawing.Point(3, 129);
            this.listViewForApplicants.MultiSelect = false;
            this.listViewForApplicants.Name = "listViewForApplicants";
            this.listViewForApplicants.Size = new System.Drawing.Size(193, 279);
            this.listViewForApplicants.TabIndex = 4;
            this.listViewForApplicants.UseCompatibleStateImageBehavior = false;
            this.listViewForApplicants.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Соискатели";
            // 
            // richTextBoxForCompareVacancy
            // 
            this.richTextBoxForCompareVacancy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBoxForCompareVacancy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxForCompareVacancy.Location = new System.Drawing.Point(12, 136);
            this.richTextBoxForCompareVacancy.Name = "richTextBoxForCompareVacancy";
            this.richTextBoxForCompareVacancy.ReadOnly = true;
            this.richTextBoxForCompareVacancy.Size = new System.Drawing.Size(219, 309);
            this.richTextBoxForCompareVacancy.TabIndex = 4;
            this.richTextBoxForCompareVacancy.Text = "";
            this.richTextBoxForCompareVacancy.Visible = false;
            // 
            // richTextBoxForCompareApplicant
            // 
            this.richTextBoxForCompareApplicant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBoxForCompareApplicant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxForCompareApplicant.Location = new System.Drawing.Point(248, 136);
            this.richTextBoxForCompareApplicant.Name = "richTextBoxForCompareApplicant";
            this.richTextBoxForCompareApplicant.ReadOnly = true;
            this.richTextBoxForCompareApplicant.Size = new System.Drawing.Size(231, 309);
            this.richTextBoxForCompareApplicant.TabIndex = 5;
            this.richTextBoxForCompareApplicant.Text = "";
            this.richTextBoxForCompareApplicant.Visible = false;
            // 
            // pictureBoxForComparison
            // 
            this.pictureBoxForComparison.Location = new System.Drawing.Point(208, 453);
            this.pictureBoxForComparison.Name = "pictureBoxForComparison";
            this.pictureBoxForComparison.Size = new System.Drawing.Size(64, 48);
            this.pictureBoxForComparison.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxForComparison.TabIndex = 6;
            this.pictureBoxForComparison.TabStop = false;
            this.pictureBoxForComparison.Visible = false;
            // 
            // labelForVacancy
            // 
            this.labelForVacancy.AutoSize = true;
            this.labelForVacancy.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForVacancy.Location = new System.Drawing.Point(23, 95);
            this.labelForVacancy.Name = "labelForVacancy";
            this.labelForVacancy.Size = new System.Drawing.Size(198, 30);
            this.labelForVacancy.TabIndex = 7;
            this.labelForVacancy.Text = "Текущая вакансия:";
            this.labelForVacancy.Visible = false;
            // 
            // labelForApplicant
            // 
            this.labelForApplicant.AutoSize = true;
            this.labelForApplicant.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForApplicant.Location = new System.Drawing.Point(250, 95);
            this.labelForApplicant.Name = "labelForApplicant";
            this.labelForApplicant.Size = new System.Drawing.Size(222, 30);
            this.labelForApplicant.TabIndex = 8;
            this.labelForApplicant.Text = "Текущий соискатель:";
            this.labelForApplicant.Visible = false;
            // 
            // textBoxForPromptUser
            // 
            this.textBoxForPromptUser.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxForPromptUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxForPromptUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForPromptUser.Location = new System.Drawing.Point(12, 64);
            this.textBoxForPromptUser.Name = "textBoxForPromptUser";
            this.textBoxForPromptUser.ReadOnly = true;
            this.textBoxForPromptUser.Size = new System.Drawing.Size(467, 28);
            this.textBoxForPromptUser.TabIndex = 9;
            this.textBoxForPromptUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonStartProcess
            // 
            this.buttonStartProcess.BackColor = System.Drawing.Color.Gold;
            this.buttonStartProcess.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartProcess.Location = new System.Drawing.Point(12, 12);
            this.buttonStartProcess.Name = "buttonStartProcess";
            this.buttonStartProcess.Size = new System.Drawing.Size(169, 46);
            this.buttonStartProcess.TabIndex = 10;
            this.buttonStartProcess.Text = "Запуск";
            this.buttonStartProcess.UseVisualStyleBackColor = false;
            this.buttonStartProcess.Click += new System.EventHandler(this.buttonStartProcess_Click);
            // 
            // richTextBoxForEnterVacancy
            // 
            this.richTextBoxForEnterVacancy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBoxForEnterVacancy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxForEnterVacancy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxForEnterVacancy.Location = new System.Drawing.Point(116, 136);
            this.richTextBoxForEnterVacancy.Name = "richTextBoxForEnterVacancy";
            this.richTextBoxForEnterVacancy.ReadOnly = true;
            this.richTextBoxForEnterVacancy.Size = new System.Drawing.Size(219, 309);
            this.richTextBoxForEnterVacancy.TabIndex = 11;
            this.richTextBoxForEnterVacancy.Text = "";
            this.richTextBoxForEnterVacancy.Visible = false;
            // 
            // richTextBoxForEnterApplicant
            // 
            this.richTextBoxForEnterApplicant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBoxForEnterApplicant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxForEnterApplicant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxForEnterApplicant.Location = new System.Drawing.Point(137, 136);
            this.richTextBoxForEnterApplicant.Name = "richTextBoxForEnterApplicant";
            this.richTextBoxForEnterApplicant.ReadOnly = true;
            this.richTextBoxForEnterApplicant.Size = new System.Drawing.Size(219, 309);
            this.richTextBoxForEnterApplicant.TabIndex = 12;
            this.richTextBoxForEnterApplicant.Text = "";
            this.richTextBoxForEnterApplicant.Visible = false;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 513);
            this.Controls.Add(this.richTextBoxForEnterApplicant);
            this.Controls.Add(this.richTextBoxForEnterVacancy);
            this.Controls.Add(this.buttonStartProcess);
            this.Controls.Add(this.textBoxForPromptUser);
            this.Controls.Add(this.labelForApplicant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelForVacancy);
            this.Controls.Add(this.pictureBoxForComparison);
            this.Controls.Add(this.richTextBoxForCompareApplicant);
            this.Controls.Add(this.richTextBoxForCompareVacancy);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormView";
            this.Text = "Биржа труда";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForComparison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxForCompareVacancy;
        private System.Windows.Forms.RichTextBox richTextBoxForCompareApplicant;
        private System.Windows.Forms.PictureBox pictureBoxForComparison;
        private System.Windows.Forms.Label labelForVacancy;
        private System.Windows.Forms.Label labelForApplicant;
        private System.Windows.Forms.TextBox textBoxForPromptUser;
        private System.Windows.Forms.ListView listViewForVacancies;
        private System.Windows.Forms.ListView listViewForApplicants;
        private System.Windows.Forms.Button buttonStartProcess;
        private System.Windows.Forms.RichTextBox richTextBoxForEnterVacancy;
        private System.Windows.Forms.RichTextBox richTextBoxForEnterApplicant;
    }
}

