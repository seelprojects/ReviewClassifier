using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review_Classifier
{
    public partial class ReviewClassifier : Form
    {
        List<string> applicationNames = new List<string>();
        Connection connection = new Connection();
        DataTable dataTable = new DataTable();

        /// <summary>
        /// 
        /// </summary>
        public ReviewClassifier()
        {
            InitializeComponent();

            //Open Database Connection
            connection.con.Close();

            //Set ApplicationDataGridViewProperties
            SetDataGridViewProperties(applicationsDataGridView);

            //Query Database for Application Names
            GetApplications();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicationsDataGridView"></param>
        private void SetDataGridViewProperties(DataGridView applicationsDataGridView)
        {
            applicationsDataGridView.RowHeadersVisible = false;
            applicationsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            applicationsDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(226, 237, 255);
            applicationsDataGridView.BackgroundColor = Color.White;
            applicationsDataGridView.ReadOnly = true;
            applicationsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            applicationsDataGridView.MultiSelect = false;
            applicationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            applicationsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            applicationsDataGridView.AllowUserToResizeRows = false;
            applicationsDataGridView.AllowUserToOrderColumns = false;
            applicationsDataGridView.AllowUserToResizeColumns = false;
            applicationsDataGridView.AllowUserToAddRows = false;
            applicationsDataGridView.CellClick += ApplicationsDataGridView_CellClick;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reviewsDataGridView"></param>
        private void SetReviewsGridViewProperties(DataGridView reviewsDataGridView)
        {
            reviewsDataGridView.RowHeadersVisible = false;
            reviewsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            reviewsDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(226, 237, 255);
            reviewsDataGridView.BackgroundColor = Color.White;
            reviewsDataGridView.ReadOnly = true;
            reviewsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reviewsDataGridView.MultiSelect = false;
            reviewsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            reviewsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            reviewsDataGridView.AllowUserToResizeRows = false;
            reviewsDataGridView.AllowUserToOrderColumns = false;
            reviewsDataGridView.AllowUserToResizeColumns = false;
            reviewsDataGridView.AllowUserToAddRows = false;
            reviewsDataGridView.ScrollBars = ScrollBars.Both;
            reviewsDataGridView.CellClick += (sender, e) => reviewsDataGridView_CellClick(sender, e);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplicationsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            if (null != sender && e.RowIndex != -1)
            {
                index = e.RowIndex;
            }

            if (applicationsDataGridView.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = applicationsDataGridView.Rows[index];
                string a = Convert.ToString(selectedRow.Cells["ApplicationID"].Value);
                int i = 0;
                int? id = (Int32.TryParse(a, out i) ? i : (int?)null);

                GetReviewsForSelectedID(id);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        private async void GetReviewsForSelectedID(int? id)
        {
            SqlCommand command = new SqlCommand(SqlHelpers.GetReviewsTable(id), connection.con);
            await connection.con.OpenAsync();
            DataTable dataTable = new DataTable();
            using (var reader = await command.ExecuteReaderAsync())
            {
                dataTable.Load(reader);
                reader.Close();
            }
            connection.con.Close();
            reviewsDataGridView.DataSource = dataTable;
            reviewsDataGridView.Columns["MainID"].Visible = false;
            reviewsDataGridView.Columns["ApplicationID"].Visible = false;
            SetReviewsGridViewProperties(reviewsDataGridView);

            if (reviewsDataGridView.Rows.Count > 0)
            {
                reviewsDataGridView.Rows[0].Selected = true;
                reviewsDataGridView_CellClick(null, null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        private async void GetApplications()
        {
            SqlCommand command = new SqlCommand(SqlHelpers.GetDetailedApplicationsTable(), connection.con);

            await connection.con.OpenAsync();

            using (var reader = await command.ExecuteReaderAsync())
            {
                dataTable.Load(reader);
                reader.Close();
            }
            connection.con.Close();
            applicationsDataGridView.DataSource = dataTable;
            applicationsDataGridView.Rows[0].Selected = true;
            applicationsDataGridView.Columns["ApplicationID"].Visible = false;
            applicationsDataGridView.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);

            var count = applicationsDataGridView.Rows.Count;
            ApplicationsDataGridView_CellClick(null, null);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reviewsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e, int newIndex = -1)
        {
            int index = 0;
            if (null != sender && e.RowIndex != -1)
            {
                index = e.RowIndex;
            }

            if (newIndex != -1)
            {
                index = newIndex;
            }

            if (reviewsDataGridView.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = reviewsDataGridView.Rows[index];

                SyncReviewsDataGridToControls(selectedRow);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedRow"></param>
        private void SyncReviewsDataGridToControls(DataGridViewRow selectedRow)
        {
            string a = Convert.ToString(selectedRow.Cells["MainID"].Value);
            int i = 0;
            int? id = (Int32.TryParse(a, out i) ? i : (int?)null);

            //Get Values from Reviews Grid
            var CommentValue = Convert.ToString(selectedRow.Cells["Comment"].Value);

            var EPositiveValue = (bool)(selectedRow.Cells["E.Positive"].Value);
            var ENegativeValue = (bool)(selectedRow.Cells["E.Negative"].Value);
            var ENeutralValue = (bool)(selectedRow.Cells["E.Neutral"].Value);

            var FRBugReportValue = (bool)(selectedRow.Cells["FR.BugRept"].Value);
            var FRUserRequirementValue = (bool)(selectedRow.Cells["FR.UserReq"].Value);
            var FRMiscellaneousValue = (bool)(selectedRow.Cells["FR.Misc"].Value);

            var NFRUsabilityValue = (bool)(selectedRow.Cells["NFR.Usab"].Value);
            var NFRDependabilityValue = (bool)(selectedRow.Cells["NFR.Depen"].Value);
            var NFRSupportabilityValue = (bool)(selectedRow.Cells["NFR.Supprt"].Value);
            var NFRPerformanceValue = (bool)(selectedRow.Cells["NFR.Perf"].Value);
            var NFRMiscelaneousValue = (bool)(selectedRow.Cells["NFR.Misc"].Value);



            //Apply Values to Controls
            CommentTextBox.Text = CommentValue;

            EPositiveCheckBox.Checked = EPositiveValue;
            ENegativeCheckBox.Checked = ENegativeValue;
            ENeutralCheckBox.Checked = ENeutralValue;

            EPositivePanel.BackColor = EPositiveValue == true ? Color.Aqua : Color.White;
            ENegativePanel.BackColor = ENegativeValue == true ? Color.Aqua : Color.White;
            ENeutralPanel.BackColor = ENeutralValue == true ? Color.Aqua : Color.White;

            BugReportCheckBox.Checked = FRBugReportValue;
            UserRequirementCheckBox.Checked = FRUserRequirementValue;
            FRMiscellaneousCheckBox.Checked = FRMiscellaneousValue;

            BugReportPanel.BackColor = FRBugReportValue == true ? Color.Aqua : Color.White;
            UserRequirementPanel.BackColor = FRUserRequirementValue == true ? Color.Aqua : Color.White;
            FRMiscellaneousPanel.BackColor = FRMiscellaneousValue == true ? Color.Aqua : Color.White;

            UsabilityCheckBox.Checked = NFRUsabilityValue;
            DependabilityCheckBox.Checked = NFRDependabilityValue;
            SupportabilityCheckBox.Checked = NFRSupportabilityValue;
            PerformanceCheckBox.Checked = NFRPerformanceValue;
            NFRMiscellaneousCheckBox.Checked = NFRMiscelaneousValue;

            UsabilityPanel.BackColor = NFRUsabilityValue == true ? Color.Aqua : Color.White;
            DependabilityPanel.BackColor = NFRDependabilityValue == true ? Color.Aqua : Color.White;
            SupportabilityPanel.BackColor = NFRSupportabilityValue == true ? Color.Aqua : Color.White;
            PerformancePanel.BackColor = NFRPerformanceValue == true ? Color.Aqua : Color.White;
            NFRMiscellaneousPanel.BackColor = NFRMiscelaneousValue == true ? Color.Aqua : Color.White;
        }


        private void PreviousButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = 0;
            var numberOfRows = reviewsDataGridView.Rows.Count;
            foreach (var row in reviewsDataGridView.Rows)
            {
                var datagridview = row as DataGridViewRow;
                if (datagridview.Selected)
                {
                    selectedIndex = datagridview.Index -1;
                    break;
                }
            }

            if (selectedIndex > -1 && selectedIndex < numberOfRows)
            {
                reviewsDataGridView.Rows[selectedIndex].Selected = true;
                reviewsDataGridView_CellClick(null, null, selectedIndex);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = 0;
            var numberOfRows = reviewsDataGridView.Rows.Count;
            foreach (var row in reviewsDataGridView.Rows)
            {
                var datagridview = row as DataGridViewRow;
                if (datagridview.Selected)
                {
                    selectedIndex = datagridview.Index + 1;
                    break;
                }
            }

            if (selectedIndex > -1 && selectedIndex < numberOfRows)
            {
                reviewsDataGridView.Rows[selectedIndex].Selected = true;
                reviewsDataGridView_CellClick(null, null, selectedIndex);
            }
        }
    }
}
