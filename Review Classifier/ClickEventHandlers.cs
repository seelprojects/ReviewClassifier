using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review_Classifier
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReviewClassifier
    {

        #region Emotion Positive Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EPositiveCheckBox_Click(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            var checkbox = sender as CheckBox;
            if (checkbox.CheckState == CheckState.Checked)
            {
                EPositivePanel.BackColor = Color.Aqua;
                CommitEPositive(true, a);
            }
            else if (checkbox.CheckState == CheckState.Unchecked)
            {
                EPositivePanel.BackColor = Color.White;
                CommitEPositive(false, a);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EPositivePanel_MouseClick(object sender, MouseEventArgs e)
        {
            var row = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(row.Cells["MainID"].Value);

            if (EPositiveCheckBox.CheckState == CheckState.Checked)
            {
                EPositiveCheckBox.CheckState = CheckState.Unchecked;
                EPositivePanel.BackColor = Color.White;
                CommitEPositive(false,a);
            }
            else if (EPositiveCheckBox.CheckState == CheckState.Unchecked)
            {
                EPositiveCheckBox.CheckState = CheckState.Checked;
                EPositivePanel.BackColor = Color.Aqua;
                CommitEPositive(true,a);
            }
        }

        #endregion Emotion Positive Click

        #region Emotion Negative Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ENegativeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            var checkbox = sender as CheckBox;
            if (checkbox.CheckState == CheckState.Checked)
            {
                ENegativePanel.BackColor = Color.Aqua;
                CommitENegative(true, a);
            }
            else if (checkbox.CheckState == CheckState.Unchecked)
            {
                ENegativePanel.BackColor = Color.White;
                CommitENegative(false, a);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ENegativePanel_Click(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            if (ENegativeCheckBox.CheckState == CheckState.Checked)
            {
                ENegativeCheckBox.CheckState = CheckState.Unchecked;
                ENegativePanel.BackColor = Color.White;
                CommitENegative(false, a);
            }
            else if (ENegativeCheckBox.CheckState == CheckState.Unchecked)
            {
                ENegativeCheckBox.CheckState = CheckState.Checked;
                ENegativePanel.BackColor = Color.Aqua;
                CommitENegative(true, a);
            }
        }

        #endregion Emotion Negative Click

        #region Emotion Neutral Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ENeutralCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            var checkbox = sender as CheckBox;
            if (checkbox.CheckState == CheckState.Checked)
            {
                ENeutralPanel.BackColor = Color.Aqua;
                CommitENeutral(true, a);
            }
            else if (checkbox.CheckState == CheckState.Unchecked)
            {
                ENeutralPanel.BackColor = Color.White;
                CommitENeutral(false, a);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ENeutralPanel_Click(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            if (ENeutralCheckBox.CheckState == CheckState.Checked)
            {
                ENeutralCheckBox.CheckState = CheckState.Unchecked;
                ENeutralPanel.BackColor = Color.White;
                CommitENeutral(false, a);
            }
            else if (ENeutralCheckBox.CheckState == CheckState.Unchecked)
            {
                ENeutralCheckBox.CheckState = CheckState.Checked;
                ENeutralPanel.BackColor = Color.Aqua;
                CommitENeutral(true, a);
            }
        }

        #endregion Emotion Neutral Click

        #region FR Bug Report Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BugReportCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            var checkbox = sender as CheckBox;
            if (checkbox.CheckState == CheckState.Checked)
            {
                BugReportPanel.BackColor = Color.Aqua;
                CommitFRBugReport(true, a);
            }
            else if (checkbox.CheckState == CheckState.Unchecked)
            {
                BugReportPanel.BackColor = Color.White;
                CommitFRBugReport(false, a);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BugReportPanel_Click(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            if (BugReportCheckBox.CheckState == CheckState.Checked)
            {
                BugReportCheckBox.CheckState = CheckState.Unchecked;
                BugReportPanel.BackColor = Color.White;
                CommitFRBugReport(false, a);
            }
            else if (BugReportCheckBox.CheckState == CheckState.Unchecked)
            {
                BugReportCheckBox.CheckState = CheckState.Checked;
                BugReportPanel.BackColor = Color.Aqua;
                CommitFRBugReport(true, a);
            }
        }

        #endregion FR Bug Report Click

        #region FR User Requirement Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserRequirementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            var checkbox = sender as CheckBox;
            if (checkbox.CheckState == CheckState.Checked)
            {
                UserRequirementPanel.BackColor = Color.Aqua;
                CommitFRUserRequest(true, a);
            }
            else if (checkbox.CheckState == CheckState.Unchecked)
            {
                UserRequirementPanel.BackColor = Color.White;
                CommitFRUserRequest(false, a);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserRequirementPanel_Click(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            if (UserRequirementCheckBox.CheckState == CheckState.Checked)
            {
                UserRequirementCheckBox.CheckState = CheckState.Unchecked;
                UserRequirementPanel.BackColor = Color.White;
                CommitFRUserRequest(false, a);
            }
            else if (UserRequirementCheckBox.CheckState == CheckState.Unchecked)
            {
                UserRequirementCheckBox.CheckState = CheckState.Checked;
                UserRequirementPanel.BackColor = Color.Aqua;
                CommitFRUserRequest(true, a);
            }
        }

        #endregion FR User Requirement Click

        #region FR Miscellaneous Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRMiscellaneousCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            var checkbox = sender as CheckBox;
            if (checkbox.CheckState == CheckState.Checked)
            {
                FRMiscellaneousPanel.BackColor = Color.Aqua;
                CommitFRMiscellaneous(true, a);
            }
            else if (checkbox.CheckState == CheckState.Unchecked)
            {
                FRMiscellaneousPanel.BackColor = Color.White;
                CommitFRMiscellaneous(false, a);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRMiscellaneousPanel_Click(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            if (FRMiscellaneousCheckBox.CheckState == CheckState.Checked)
            {
                FRMiscellaneousCheckBox.CheckState = CheckState.Unchecked;
                FRMiscellaneousPanel.BackColor = Color.White;
                CommitFRMiscellaneous(false, a);
            }
            else if (FRMiscellaneousCheckBox.CheckState == CheckState.Unchecked)
            {
                FRMiscellaneousCheckBox.CheckState = CheckState.Checked;
                FRMiscellaneousPanel.BackColor = Color.Aqua;
                CommitFRMiscellaneous(true, a);
            }
        }

        #endregion FR Miscellaneous Click

        #region NFR Dependability Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DependabilityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            var checkbox = sender as CheckBox;
            if (checkbox.CheckState == CheckState.Checked)
            {
                DependabilityPanel.BackColor = Color.Aqua;
                CommitNFRDependability(true, a);
            }
            else if (checkbox.CheckState == CheckState.Unchecked)
            {
                DependabilityPanel.BackColor = Color.White;
                CommitNFRDependability(false, a);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DependabilityPanel_Click(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            if (DependabilityCheckBox.CheckState == CheckState.Checked)
            {
                DependabilityCheckBox.CheckState = CheckState.Unchecked;
                DependabilityPanel.BackColor = Color.White;
                CommitNFRDependability(false, a);
            }
            else if (DependabilityCheckBox.CheckState == CheckState.Unchecked)
            {
                DependabilityCheckBox.CheckState = CheckState.Checked;
                DependabilityPanel.BackColor = Color.Aqua;
                CommitNFRDependability(true, a);
            }
        }

        #endregion NFR Dependability Click

        #region NFR Performance Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PerformanceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            var checkbox = sender as CheckBox;
            if (checkbox.CheckState == CheckState.Checked)
            {
                PerformancePanel.BackColor = Color.Aqua;
                CommitNFRPerformance(true, a);
            }
            else if (checkbox.CheckState == CheckState.Unchecked)
            {
                PerformancePanel.BackColor = Color.White;
                CommitNFRPerformance(false, a);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PerformancePanel_Click(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            if (PerformanceCheckBox.CheckState == CheckState.Checked)
            {
                PerformanceCheckBox.CheckState = CheckState.Unchecked;
                PerformancePanel.BackColor = Color.White;
                CommitNFRPerformance(false, a);
            }
            else if (PerformanceCheckBox.CheckState == CheckState.Unchecked)
            {
                PerformanceCheckBox.CheckState = CheckState.Checked;
                PerformancePanel.BackColor = Color.Aqua;
                CommitNFRPerformance(true, a);
            }
        }

        #endregion NFR Performance Click

        #region NFR Supportability Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SupportabilityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            var checkbox = sender as CheckBox;
            if (checkbox.CheckState == CheckState.Checked)
            {
                SupportabilityPanel.BackColor = Color.Aqua;
                CommitNFRPSupportability(true, a);
            }
            else if (checkbox.CheckState == CheckState.Unchecked)
            {
                SupportabilityPanel.BackColor = Color.White;
                CommitNFRPSupportability(false, a);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SupportabilityPanel_Click(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            if (SupportabilityCheckBox.CheckState == CheckState.Checked)
            {
                SupportabilityCheckBox.CheckState = CheckState.Unchecked;
                SupportabilityPanel.BackColor = Color.White;
                CommitNFRPSupportability(false, a);
            }
            else if (SupportabilityCheckBox.CheckState == CheckState.Unchecked)
            {
                SupportabilityCheckBox.CheckState = CheckState.Checked;
                SupportabilityPanel.BackColor = Color.Aqua;
                CommitNFRPSupportability(true, a);
            }
        }

        #endregion NFR Supportability Click

        #region NFR Usability Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsabilityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            var checkbox = sender as CheckBox;
            if (checkbox.CheckState == CheckState.Checked)
            {
                UsabilityPanel.BackColor = Color.Aqua;
                CommitNFRUsability(true, a);
            }
            else if (checkbox.CheckState == CheckState.Unchecked)
            {
                UsabilityPanel.BackColor = Color.White;
                CommitNFRUsability(false, a);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsabilityPanel_Click(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            if (UsabilityCheckBox.CheckState == CheckState.Checked)
            {
                UsabilityCheckBox.CheckState = CheckState.Unchecked;
                UsabilityPanel.BackColor = Color.White;
                CommitNFRUsability(false, a);
            }
            else if (UsabilityCheckBox.CheckState == CheckState.Unchecked)
            {
                UsabilityCheckBox.CheckState = CheckState.Checked;
                UsabilityPanel.BackColor = Color.Aqua;
                CommitNFRUsability(true, a);
            }
        }


        #endregion NFR Usability Click

        #region NFR Miscellaneous Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NFRMiscellaneousCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);

            var checkbox = sender as CheckBox;
            if (checkbox.CheckState == CheckState.Checked)
            {
                NFRMiscellaneousPanel.BackColor = Color.Aqua;
                CommitNFRMiscellaneous(true, a);
            }
            else if (checkbox.CheckState == CheckState.Unchecked)
            {
                NFRMiscellaneousPanel.BackColor = Color.White;
                CommitNFRMiscellaneous(false, a);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NFRMiscellaneousPanel_Click(object sender, EventArgs e)
        {
            var mainID = reviewsDataGridView.SelectedRows[0];
            string a = Convert.ToString(mainID.Cells["MainID"].Value);


            if (NFRMiscellaneousCheckBox.CheckState == CheckState.Checked)
            {
                NFRMiscellaneousCheckBox.CheckState = CheckState.Unchecked;
                FRMiscellaneousPanel.BackColor = Color.White;
                CommitNFRMiscellaneous(false, a);
            }
            else if (NFRMiscellaneousCheckBox.CheckState == CheckState.Unchecked)
            {
                NFRMiscellaneousCheckBox.CheckState = CheckState.Checked;
                NFRMiscellaneousPanel.BackColor = Color.Aqua;
                CommitNFRMiscellaneous(true, a);
            }
        }


        #endregion NFR Miscellaneous Click

        //Commit to Database and the Gridview

        #region Commit Emotion Positive

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="MainID"></param>
        private async void CommitEPositive(bool v, string MainID)
        {
            //Commit to Database
            SqlCommand command = new SqlCommand(SqlHelpers.SetEPositiveValue(MainID, v), connection.con);
            try
            {
                await connection.con.OpenAsync();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.con.Close();
            }

            //Commit to GridView
            var row = reviewsDataGridView.SelectedRows[0];
            row.Cells["E.Positive"].Value = v;

        }

        #endregion Commit Emotion Positive

        #region Commit Emotion Negative
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="MainID"></param>
        private async void CommitENegative(bool v, string MainID)
        {
            //Commit to Database
            SqlCommand command = new SqlCommand(SqlHelpers.SetENegativeValue(MainID, v), connection.con);
            try
            {
                await connection.con.OpenAsync();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.con.Close();
            }

            //Commit to GridView
            var row = reviewsDataGridView.SelectedRows[0];
            row.Cells["E.Negative"].Value = v;

        }


        #endregion Commit Emotion Negative

        #region Commit Emotion Neutral

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="MainID"></param>
        private async void CommitENeutral(bool v, string MainID)
        {
            //Commit to Database
            SqlCommand command = new SqlCommand(SqlHelpers.SetENeutralValue(MainID, v), connection.con);
            try
            {
                await connection.con.OpenAsync();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.con.Close();
            }

            //Commit to GridView
            var row = reviewsDataGridView.SelectedRows[0];
            row.Cells["E.Neutral"].Value = v;

        }

        #endregion Commit Emotion Neutral

        #region Commit BugReport

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="MainID"></param>
        private async void CommitFRBugReport(bool v, string MainID)
        {
            //Commit to Database
            SqlCommand command = new SqlCommand(SqlHelpers.SetFRBugReportValue(MainID, v), connection.con);
            try
            {
                await connection.con.OpenAsync();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.con.Close();
            }

            //Commit to GridView
            var row = reviewsDataGridView.SelectedRows[0];
            row.Cells["FR.BugRept"].Value = v;
        }


        #endregion Commit BugReport

        #region Commit UserRequirements

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="MainID"></param>
        private async void CommitFRUserRequest(bool v, string MainID)
        {
            //Commit to Database
            SqlCommand command = new SqlCommand(SqlHelpers.SetFRUserRequirementValue(MainID, v), connection.con);
            try
            {
                await connection.con.OpenAsync();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.con.Close();
            }

            //Commit to GridView
            var row = reviewsDataGridView.SelectedRows[0];
            row.Cells["FR.UserReq"].Value = v;
        }

        #endregion Commit UserRequirements

        #region Commit FR Miscellaneous
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="MainID"></param>
        private async void CommitFRMiscellaneous(bool v, string MainID)
        {
            //Commit to Database
            SqlCommand command = new SqlCommand(SqlHelpers.SetFRMiscellaneousValue(MainID, v), connection.con);
            try
            {
                await connection.con.OpenAsync();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.con.Close();
            }

            //Commit to GridView
            var row = reviewsDataGridView.SelectedRows[0];
            row.Cells["FR.Misc"].Value = v;
        }

        #endregion Commit FR Miscellaneous

        #region Commit NFR Usability

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="MainID"></param>
        private async void CommitNFRUsability(bool v, string MainID)
        {
            //Commit to Database
            SqlCommand command = new SqlCommand(SqlHelpers.SetNFRUsabilityValue(MainID, v), connection.con);
            try
            {
                await connection.con.OpenAsync();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.con.Close();
            }

            //Commit to GridView
            var row = reviewsDataGridView.SelectedRows[0];
            row.Cells["NFR.Usab"].Value = v;
        }

        #endregion Commit NFR Usability

        #region Commit NFR Supportability

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="MainID"></param>
        private async void CommitNFRPSupportability(bool v, string MainID)
        {
            //Commit to Database
            SqlCommand command = new SqlCommand(SqlHelpers.SetNFRSupportabilityValue(MainID, v), connection.con);
            try
            {
                await connection.con.OpenAsync();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.con.Close();
            }

            //Commit to GridView
            var row = reviewsDataGridView.SelectedRows[0];
            row.Cells["NFR.Supprt"].Value = v;
        }

        #endregion Commit NFR Supportability

        #region Commit NFR Performance

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="MainID"></param>
        private async void CommitNFRPerformance(bool v, string MainID)
        {
            //Commit to Database
            SqlCommand command = new SqlCommand(SqlHelpers.SetNFRPerformanceValue(MainID, v), connection.con);
            try
            {
                await connection.con.OpenAsync();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.con.Close();
            }

            //Commit to GridView
            var row = reviewsDataGridView.SelectedRows[0];
            row.Cells["NFR.Perf"].Value = v;
        }

        #endregion Commit NFR Performance

        #region Commit NFR Dependability

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="MainID"></param>
        private async void CommitNFRDependability(bool v, string MainID)
        {
            //Commit to Database
            SqlCommand command = new SqlCommand(SqlHelpers.SetNFRDependabilityValue(MainID, v), connection.con);
            try
            {
                await connection.con.OpenAsync();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.con.Close();
            }

            //Commit to GridView
            var row = reviewsDataGridView.SelectedRows[0];
            row.Cells["NFR.Depen"].Value = v;
        }

        #endregion Commit NFR Dependability

        #region Commit NFR Miscellaneous

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="MainID"></param>
        private async void CommitNFRMiscellaneous(bool v, string MainID)
        {
            //Commit to Database
            SqlCommand command = new SqlCommand(SqlHelpers.SetNFRMiscellaneousValue(MainID, v), connection.con);
            try
            {
                await connection.con.OpenAsync();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.con.Close();
            }

            //Commit to GridView
            var row = reviewsDataGridView.SelectedRows[0];
            row.Cells["NFR.Misc"].Value = v;
        }

        #endregion Commit NFR Miscellaneous
    }
}
