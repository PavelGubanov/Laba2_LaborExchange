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
using System.Windows.Threading;

namespace Laba2_LaborExchange
{
    public partial class FormView : Form, IView
    {
        public FormView()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void AddInfoToRichTextBox(RichTextBox textBox, string tmp)
        {
            textBox.Text += tmp;
            textBox.Refresh();
            Thread.Sleep(1000);
        }

        public void AddApplicant(Applicant applicant)
        {
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
            AddInfoToRichTextBox(richTextBoxForEnterApplicant, applicant.WorkExperience.GetInfo());
            Thread.Sleep(2000);

            ListViewItem item = new ListViewItem(applicant.GetInitials());
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
            Thread.Sleep(1000);
        }

        public void AddVacancy(Vacancy vacancy)
        {
            richTextBoxForEnterVacancy.Visible = true;
            richTextBoxForEnterVacancy.Refresh();
            Thread.Sleep(1000);

            textBoxForPromptUser.Text = "*** Работодатель заполняет вакансию ***";
            textBoxForPromptUser.Refresh();

            AddInfoToRichTextBox(richTextBoxForEnterVacancy, vacancy.Name + "\n\n");
            AddInfoToRichTextBox(richTextBoxForEnterVacancy, vacancy.Company.GetFullName() + "\n\n");
            AddInfoToRichTextBox(richTextBoxForEnterVacancy, vacancy.Education.GetEducationInfo() + "\n\n");
            AddInfoToRichTextBox(richTextBoxForEnterVacancy, vacancy.WorkExperience.GetInfo());
            Thread.Sleep(2000);

            ListViewItem item = new ListViewItem(vacancy.Name);
            item.Tag = vacancy;
            listViewForVacancies.Items.Add(item);
            listViewForVacancies.Refresh();

            textBoxForPromptUser.Text = "*** Работодатель заполнил вакансию! ***";
            textBoxForPromptUser.Refresh();
            richTextBoxForEnterVacancy.Visible = false;
            richTextBoxForEnterVacancy.Text = "";
            richTextBoxForEnterVacancy.Refresh();
            Thread.Sleep(1000);

            textBoxForPromptUser.Text = "";
            textBoxForPromptUser.Refresh();
            Thread.Sleep(1000);
        }

        private void FormView_Load(object sender, EventArgs e)
        {

        }

        public void SearchVacancyForApplicant(Vacancy vacancy, Applicant applicant)
        {
            int numberVacancy = -1, numberApplicant = -1;
            int i = 0;
            while (i < listViewForVacancies.Items.Count && numberVacancy == -1)
            {
                if (vacancy == (Vacancy)listViewForVacancies.Items[i].Tag)
                {
                    numberVacancy = i;
                }
                i++;
            }
            i = 0;
            while (i < listViewForApplicants.Items.Count && numberApplicant == -1)
            {
                if (applicant == (Applicant)listViewForApplicants.Items[i].Tag)
                {
                    numberApplicant = i;
                }
                i++;
            }
            listViewForApplicants.Items[numberApplicant].Selected = true;
            listViewForApplicants.Refresh();
            Thread.Sleep(1000);
            listViewForVacancies.Items[numberVacancy].Selected = true;
            listViewForVacancies.Refresh();

            labelForVacancy.Visible = true;
            labelForVacancy.Refresh();
            richTextBoxForCompareVacancy.Visible = true;
            richTextBoxForCompareVacancy.Refresh();

            labelForApplicant.Visible = true;
            labelForApplicant.Refresh();
            richTextBoxForCompareApplicant.Visible = true;
            richTextBoxForCompareApplicant.Refresh();

            AddInfoToRichTextBox(richTextBoxForCompareApplicant, applicant.ToString());
            AddInfoToRichTextBox(richTextBoxForCompareVacancy, vacancy.ToString());
            Thread.Sleep(2000);

            pictureBoxForComparison.Visible = true;
            if (applicant.CheckVacancy(vacancy))
            {
                pictureBoxForComparison.Image = Image.FromFile("GreenCheckMark.png");
            }
            else
            {
                pictureBoxForComparison.Image = Image.FromFile("RedDagger.png");
            }
            pictureBoxForComparison.Refresh();
            Thread.Sleep(3000);

            pictureBoxForComparison.Visible = false;
            labelForVacancy.Visible = false;
            labelForVacancy.Refresh();
            richTextBoxForCompareVacancy.Visible = false;
            richTextBoxForCompareVacancy.Text = "";
            richTextBoxForCompareVacancy.Refresh();
            labelForApplicant.Visible = false;
            labelForApplicant.Refresh();
            richTextBoxForCompareApplicant.Visible = false;
            richTextBoxForCompareApplicant.Text = "";
            richTextBoxForCompareApplicant.Refresh();

            if (applicant.CheckVacancy(vacancy))
            {
                listViewForApplicants.Items[numberApplicant].Remove();
                listViewForVacancies.Items[numberVacancy].Remove();
            }
            else
            {
                listViewForVacancies.Items[numberVacancy].Selected = false;
            }
            listViewForVacancies.Refresh();
            listViewForApplicants.Refresh();
            Thread.Sleep(1000);
            if (!applicant.CheckVacancy(vacancy))
            {
                listViewForApplicants.Items[numberApplicant].Selected = false;
            }
        }

        private void buttonStartProcess_Click(object sender, EventArgs e)
        {
            buttonStartProcess.Visible = false;
            Presenter presenter = new Presenter(this);
        }

        private void listViewForVacancies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
