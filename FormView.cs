using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2_LaborExchange
{
    public partial class FormView : Form, IView
    {
        public FormView()
        {
            InitializeComponent();
        }

        private void AddInfoToRichTextBox(RichTextBox textBox, string tmp)
        {
            textBox.Text += tmp;
            textBox.Refresh();
            Thread.Sleep(1000);
        }

        public void AddApplicant(Applicant applicant)
        {        
            labelForApplicant.Visible = true;
            labelForApplicant.Refresh();
            richTextBoxForEnterApplicant.Visible = true;
            richTextBoxForEnterApplicant.Refresh();
            Thread.Sleep(1000);

            textBoxForPromptUser.Text = "*** Соискатель заполняет анкету ***";
            textBoxForPromptUser.Refresh();

            AddInfoToRichTextBox(richTextBoxForEnterApplicant, "ФИО: ");
            AddInfoToRichTextBox(richTextBoxForEnterApplicant, applicant.FIO + "\n\n");
            AddInfoToRichTextBox(richTextBoxForEnterApplicant, "Образование:\n");
            AddInfoToRichTextBox(richTextBoxForEnterApplicant, applicant.Education.GetEducationInfo() + "\n\n");
            AddInfoToRichTextBox(richTextBoxForEnterApplicant, "Опыт работы:\n");
            AddInfoToRichTextBox(richTextBoxForEnterApplicant, applicant.WorkExperience.GetInfo() + "\n");
            Thread.Sleep(3000);

            ListViewItem item = new ListViewItem(applicant.FIO);
            item.Tag = applicant;
            listViewForApplicants.Items.Add(item);
            listViewForApplicants.Refresh();

            textBoxForPromptUser.Text = "*** Соискатель заполнил анкету! ***";
            textBoxForPromptUser.Refresh();
            labelForApplicant.Visible = false;
            labelForApplicant.Refresh();
            richTextBoxForEnterApplicant.Visible = false;
            richTextBoxForEnterApplicant.Text = "";
            richTextBoxForEnterApplicant.Refresh();
            Thread.Sleep(1000);

            textBoxForPromptUser.Text = "";
            textBoxForPromptUser.Refresh();
            Thread.Sleep(3000);
        }

        public void AddVacancy(Vacancy vacancy)
        {
            labelForVacancy.Visible = true;
            labelForVacancy.Refresh();
            richTextBoxForEnterVacancy.Visible = true;
            richTextBoxForEnterVacancy.Refresh();
            Thread.Sleep(1000);

            textBoxForPromptUser.Text = "*** Работодатель заполняет вакансию ***";
            textBoxForPromptUser.Refresh();


        }

        public void SearchVacancyForApplicant()
        {
            throw new NotImplementedException();
        }

        private void FormView_Load(object sender, EventArgs e)
        {

        }
    }
}
