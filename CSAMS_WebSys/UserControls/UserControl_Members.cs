using CSAMS_WebSys.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services;
using System.Diagnostics.Eventing.Reader;
using Google.Cloud.Firestore;
using Firebase.Auth;
using System.Diagnostics.Metrics;
using System.Reflection;
using Sprache;
using System.Web.UI.WebControls;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using CSAMS_WebSys.Services.Dashboard;

namespace CSAMS_WebSys.UserControls
{
    public partial class UserControl_Members : UserControl
    {
        private static DocumentSnapshot _lastDocumentSnapshot;
        private static DocumentSnapshot _firstDocumentSnapshot;
        private bool disposing = false;
        private string BiometricsAdded;
        private int pageSize = 10;
        private bool buttonClicked = false;
        private MemberService memberservice;
        private HashSet<string> DisplayedMember = new HashSet<string>();
        private List<MemberModel> originalList = new List<MemberModel>();
        private List<MemberModel> searchedmembers;
        private DataTable table = new DataTable();
        DataView view;
        public UserControl_Members()
        {
            InitializeComponent();
            searchedmembers = new List<MemberModel>();
            memberservice = new MemberService();
            SearchMembers_gunaTextBox.Enter += EnterText;
            SearchMembers_gunaTextBox.Leave += LeaveText;
            InitializeTable();
        }

        private void InitializeTable()
        {
            table.Columns.Add("Student ID", typeof(string));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Year Level", typeof(string));
            table.Columns.Add("Biometrics", typeof(string));
            table.Columns.Add("Status", typeof(string));
            table.Columns.Add("Date Added", typeof(string));
            MembersData_gunaDataGridView.DataSource = table;

            DataGridViewButtonColumn dataGridViewButtonColumn_edit = new DataGridViewButtonColumn
            {
                Name = "Edit_button",
                HeaderText = "edit",
                Text = " Edit",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Popup
            };

            DataGridViewButtonColumn dataGridViewButtonColumn_delete = new DataGridViewButtonColumn
            {
                Name = "Delete_button",
                HeaderText = "delete",
                Text = " Delete",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Popup
            };

            DataGridViewButtonColumn dataGridViewButtonColumn_detials = new DataGridViewButtonColumn
            {
                Name = "Detail_button",
                HeaderText = "detail",
                Text = " Details",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Popup
            };

            MembersData_gunaDataGridView.RowTemplate.Height = 50;

            MembersData_gunaDataGridView.Columns.Add(dataGridViewButtonColumn_edit);
            MembersData_gunaDataGridView.Columns.Add(dataGridViewButtonColumn_delete);
            MembersData_gunaDataGridView.Columns.Add(dataGridViewButtonColumn_detials);

            MembersData_gunaDataGridView.Columns[6].Width = 160;
            MembersData_gunaDataGridView.Columns[7].Width = 80;
            MembersData_gunaDataGridView.Columns[8].Width = 80;
            MembersData_gunaDataGridView.Columns[9].Width = 80;

            MembersData_gunaDataGridView.AllowUserToResizeRows = false;
            MembersData_gunaDataGridView.AllowUserToResizeColumns = false;
            MembersData_gunaDataGridView.AllowUserToAddRows = false;

            MembersData_gunaDataGridView.ReadOnly = true;
            view = table.DefaultView;
        }

        private void AddMember_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            AddMember_gunaAdvenceButton.Enabled = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AddMemberForm")
                {
                    isOpen = true;
                    f.BringToFront();
                    f.FormClosing += (s, ev) => AddMember_gunaAdvenceButton.Enabled = true;
                    break;
                }
            }
            if (isOpen == false)
            {
                AddMemberForm addbookn = new AddMemberForm();
                addbookn.MemberChanged += CheckUpdates;
                addbookn.FormClosing += (s, ev) => AddMember_gunaAdvenceButton.Enabled = true;
                addbookn.Show();
            }
        }

        public void HasBiometrics(MemberModel member)
        {
            if (member.BiometricsAdded)
            {
                BiometricsAdded = "Added";
            }
            else
            {
                BiometricsAdded = "Not Added";
            }
            Console.WriteLine(member.BiometricsAdded);
        }

        private void CheckUpdates(MemberModel member)
        {
            if (member != null && DisplayedMember.Add(member.StudentID))
            {
                HasBiometrics(member);
                table.Rows.Add(member.StudentID, member.FirstName, member.LastName, member.YearLevel, BiometricsAdded, member.Status, member.DateAdded?.ToString("MMMM dd, yyyy"));
            }
        }
        private void AddMembers(List<MemberModel> members)
        {
            foreach(var member in members)
            {
                if (member != null && DisplayedMember.Add(member.StudentID))
                {
                    HasBiometrics(member);
                    table.Rows.Add(member.StudentID, member.FirstName, member.LastName, member.YearLevel, BiometricsAdded, member.Status, member.DateAdded?.ToString("MMMM dd, yyyy"));
                }
            }
        }

        //TEST
        private void dummy()
        {
            MemberModel member = new MemberModel
            {
                StudentID = "22-1-00182",
                FirstName = "Benjie",
                LastName = "Saquin",
                YearLevel = "4",
                Status = "Irregular",
                DateAdded = DateTime.Now
            };

            for(int i = 0; i < 21; i++)
            {
                table.Rows.Add(member.StudentID, member.FirstName, member.LastName, member.YearLevel, member.Status, member.DateAdded?.ToString("MMMM dd, yyyy"));
            }
        }

        public async void AppendCurrentData()
        {
            try
            {
                List<MemberModel> members = new List<MemberModel>();
                (members, _firstDocumentSnapshot) = await memberservice.RetrieveActiveMembersAsync(pageSize, _lastDocumentSnapshot);

                if (members.Count > 0)
                {
                    AddMembers(members);
                    _lastDocumentSnapshot = _firstDocumentSnapshot;
                }
                else
                {
                    Console.WriteLine("No more data to fetch");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AppendCurrentData(): {ex.Message}");
            }
        }

        private string FormatTextToTitleCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var words = input.Split(' ');

            var formattedWords = words.Select(word =>
                char.ToUpper(word[0]) + word.Substring(1).ToLower());

            return string.Join(" ", formattedWords);
        }

        private void helper(MemberModel member, DataGridViewRow selectedRow)
        {
            if (selectedRow.Cells["Biometrics"].Value.ToString() == "Added")
            {
                member.BiometricsAdded = true;
            }
            else
            {
                member.BiometricsAdded = false;
            }
        }
        private async void MembersData_gunaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == MembersData_gunaDataGridView.Columns["Detail_button"].Index)
                {
                    try
                    {
                        int rowIndex = e.RowIndex;
                        if (rowIndex >= 0)
                        {
                            DataGridViewRow selectedRow = MembersData_gunaDataGridView.Rows[rowIndex];
                            var member = new MemberModel
                            {
                                StudentID = selectedRow.Cells["Student ID"].Value.ToString(),
                                FirstName = selectedRow.Cells["First Name"].Value.ToString(),
                                LastName = selectedRow.Cells["Last Name"].Value.ToString(),
                                YearLevel = selectedRow.Cells["Year Level"].Value.ToString(),
                                Status = selectedRow.Cells["Status"].Value.ToString(),
                                DateAdded = string.IsNullOrEmpty(selectedRow.Cells["Date Added"].Value.ToString()) ? DateTime.UtcNow : DateTime.SpecifyKind(DateTime.Parse(selectedRow.Cells["date added"].Value.ToString()), DateTimeKind.Utc)
                            };
                            helper(member, selectedRow);
                            MemberDetailsForm member_details = new MemberDetailsForm(member);
                            member_details.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }

                }
                else if (e.ColumnIndex == MembersData_gunaDataGridView.Columns["Edit_button"].Index)
                {
                    try
                    {
                        int rowIndex = e.RowIndex;
                        if (rowIndex >= 0)
                        {
                            DataGridViewRow selectedRow = MembersData_gunaDataGridView.Rows[rowIndex];
                            var member = new MemberModel
                            {
                                StudentID = selectedRow.Cells["Student ID"].Value.ToString(),
                                FirstName = selectedRow.Cells["First Name"].Value.ToString(),
                                LastName = selectedRow.Cells["Last Name"].Value.ToString(),
                                YearLevel = selectedRow.Cells["Year Level"].Value.ToString(),
                                Status = selectedRow.Cells["Status"].Value.ToString(),
                                DateAdded = string.IsNullOrEmpty(selectedRow.Cells["Date Added"].Value.ToString()) ? DateTime.UtcNow : DateTime.SpecifyKind(DateTime.Parse(selectedRow.Cells["date added"].Value.ToString()), DateTimeKind.Utc),
                                BiometricsAdded =  selectedRow.Cells["Biometrics"].Value.ToString() == "Added" ? true : false
                            };

                            EditMemberForm edit_member = new EditMemberForm(member);
                            edit_member.Show();

                            edit_member.MemberEdited += MemberChanged;
                            edit_member.CloseForm += ReActivate;
           
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }

                }
                else if (e.ColumnIndex == MembersData_gunaDataGridView.Columns["Delete_button"].Index)
                {
                    MembersData_gunaDataGridView.Enabled = false;
                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = MembersData_gunaDataGridView.Rows[rowIndex];
                    string studentID = selectedRow.Cells["Student ID"].Value.ToString();

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Delete Member", MessageBoxButtons.YesNo);
                    var member = new MemberModel
                    {
                        StudentID = selectedRow.Cells["Student ID"].Value.ToString()
                    };
                   
                    if (result == DialogResult.Yes)
                    {
                        if (DisplayedMember.Contains(studentID))
                        {
                            DisplayedMember.Remove(studentID);
                        }

                        await memberservice.DeleteMember(member);
                        MemberDeleted(member);
                    }
                }
            }
            catch
            {
                Console.Write("Error");
            }
            finally
            {
                MembersData_gunaDataGridView.Enabled = true;
            }
        }

        private void ReActivate()
        {
            MembersData_gunaDataGridView.Enabled = true;
        }

        private void MemberDeleted(MemberModel member)
        {
            int rowIndex = -1;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["Student ID"].ToString() == member.StudentID)
                {
                    rowIndex = i;
                    break;
                }
            }

            if (rowIndex >= 0)
            {
                DataRow rowToDelete = table.Rows[rowIndex];
                table.Rows.Remove(rowToDelete);
                table.AcceptChanges();
                MembersData_gunaDataGridView.Refresh();
            }
        }
        private void MemberChanged(MemberModel member)
        {
            int rowIndex = -1;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["Student ID"].ToString() == member.StudentID)
                {
                    rowIndex = i;
                    break;
                }
            }

            if (rowIndex >= 0)
            {
                DataRow rowToUpdate = table.Rows[rowIndex];
                rowToUpdate["First Name"] = member.FirstName;
                rowToUpdate["Last Name"] = member.LastName;
                rowToUpdate["Year Level"] = member.YearLevel;
                rowToUpdate["Status"] = member.Status;
                rowToUpdate["Biometrics"] = member.BiometricsAdded ? "Added" : "Not Added";
                MembersData_gunaDataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Member not found in the table.");
            }
            MembersData_gunaDataGridView.Enabled = true;
        }

        private void HandlePagination(object sender, ScrollEventArgs e)
        {
          
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                LoadScrollPagination(this, e);
            }
        }

        private void LoadScrollPagination(object sender, ScrollEventArgs e)
        {
            try
            {
                PropertyInfo property = typeof(DataGridView).GetProperty("VerticalScrollBar", BindingFlags.NonPublic | BindingFlags.Instance);
                ScrollBar verticalScrollBar = (ScrollBar)property.GetValue(MembersData_gunaDataGridView);

                if (verticalScrollBar.Value + verticalScrollBar.LargeChange >= verticalScrollBar.Maximum)
                {
                    Console.WriteLine("Scrolled to the bottom. Loading more data...");
                    AppendCurrentData();
                }
                else
                {
                    Console.WriteLine("Scrolling");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error accessing VerticalScrollBar: " + ex.Message);
            }
        }

        private void Typing(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();

        }
        private void LeaveText(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Tick -= SearchedValues;
            disposing = true;
        }

        private void EnterText(object sender, EventArgs e)
        {
            timer1.Interval = 300;
            timer1.Tick += SearchedValues;
        }

        protected void DisposeTimer(bool disposing)
        {
            if (disposing)
            {
                if (timer1 != null)
                {
                    timer1.Dispose();
                }
            }
            disposing = false;
        }

       
        private void PageLoadMembers(object sender, EventArgs e)
        {
            MembersData_gunaDataGridView.Scroll -= HandlePagination;
            AppendCurrentData(); 
            MembersData_gunaDataGridView.Scroll += HandlePagination;
        }

        private void SearchedValues(object sender, EventArgs e)
        {
            string text = FormatTextToTitleCase(SearchMembers_gunaTextBox.Text);
            try
            {
                view = table.DefaultView;
                view.RowFilter = $"[First Name] LIKE '%{text}%' OR [Last Name] LIKE '%{text}%' OR [Year Level] LIKE '%{text}%' OR [Status] LIKE '%{text}%'";

                MembersData_gunaDataGridView.DataSource = view;

                if(view.Count == 0)
                {
                    AppendCurrentData();
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error searching for data: {ex.Message}", "Searching Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterYear(object sender, EventArgs e)
        {
            string yearLevelFilter = FilterMembers_gunaComboBox.Text;
            try
            {
                view = table.DefaultView;

                switch (yearLevelFilter)
                {
                    case " ":
                        view.RowFilter = string.Empty;
                        break;
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        view.RowFilter = $"[Year Level] = '{yearLevelFilter}'";
                        break;
                    case "5th above":
                        view.RowFilter = "[Year Level] LIKE '5%' OR [Year Level] LIKE '6%' OR [Year Level] LIKE '7%' OR [Year Level] LIKE '8%' OR [Year Level] LIKE '9%'";
                        break;
                    default:
                        view.RowFilter = string.Empty;
                        break;
                }

                MembersData_gunaDataGridView.DataSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering data: {ex.Message}", "Filter Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void bulkAdd_gunaAdvenceButton_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Excel Files|*.xlsx;*.xls",
                    Title = "Select Student List Excel File"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    var workbook = new XLWorkbook(filePath);
                    var worksheet = workbook.Worksheet(1);

                    var headerRow = worksheet.FirstRowUsed();

                    List<MemberModel> members = new List<MemberModel>();

                    if (headerRow.Cell(1).GetValue<string>() != "Student ID" ||
                        headerRow.Cell(2).GetValue<string>() != "First Name" ||
                        headerRow.Cell(3).GetValue<string>() != "Last Name" ||
                        headerRow.Cell(4).GetValue<string>() != "Year Level" ||
                        headerRow.Cell(5).GetValue<string>() != "Status")
                    {
                        foreach (var row in worksheet.RowsUsed().Skip(1))
                        {

                            members.Add(new MemberModel
                            {
                                StudentID = row.Cell(1).GetValue<string>(),
                                FirstName = row.Cell(2).GetValue<string>(),
                                LastName = row.Cell(3).GetValue<string>(),
                                YearLevel = row.Cell(4).GetValue<string>(),
                                Status = row.Cell(5).GetValue<string>(),
                                DateAdded = DateTime.UtcNow
                            });
                        }

                        DialogResult result = MessageBox.Show(
                                           "Do you want to proceed adding students?", 
                                           "Confirm Action",                          
                                           MessageBoxButtons.OKCancel,              
                                           MessageBoxIcon.Question                  
                                         );

                        switch (result)
                        {
                            case DialogResult.OK:
                                AddMembers(members);

                                var filteredMembers = members
                                                    .Where(member => !string.IsNullOrEmpty(member.StudentID))
                                                    .GroupBy(member => member.StudentID)
                                                    .Select(group => group.First())
                                                    .ToList();

                                await memberservice.StoreMemberInBulk(filteredMembers);
                                MessageBox.Show("Students have been saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case DialogResult.Cancel:
                                break;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PopulateSchoolYearsComboBox()
        {
            UpdatesService updatesService = new UpdatesService();
            List<SchoolYearModel> SchoolYears = await updatesService.GetAllSchoolYearID();

            try
            {
                guna2ComboBox1.DataSource = SchoolYears;

                guna2ComboBox1.DisplayMember = "SchoolYearID";
                guna2ComboBox1.ValueMember = "SchoolYearID";
                var activeYear = SchoolYears.FirstOrDefault(x => x.isActive);

                if (activeYear != null)
                {
                    guna2ComboBox1.SelectedItem = activeYear;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating school year combobox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
