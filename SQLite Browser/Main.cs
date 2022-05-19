using Microsoft.Data.Sqlite;

namespace SQLite_Browser
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Rows To Display Per Page (On data grid)
        /// </summary>
        int RowsPerPage = 10;
        /// <summary>
        /// Total number of pages calculated from total rows in database
        /// and the number of rows per page
        /// </summary>
        int TotalPages = 0;
        /// <summary>
        /// Index of page currently being viewed / displayed in grid
        /// </summary>
        int PageIndex = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // get total number of pages
            GetTotal();
            // load data into datagrid
            LoadData();
        }

        /// <summary>
        /// Gets the total number of pages based from rows in database
        /// uses RowsPerPage to calculate number of pages
        /// </summary>
        private void GetTotal()
        {
            // Set connection string
            using (var connection = new SqliteConnection("Data Source=hashes.sqlite"))
            {
                // Open connection
                connection.Open();

                // sql command to query db
                var command = connection.CreateCommand();
                command.CommandText = $"SELECT count(hash_id) from safe_hashes";

                // read results from sql query
                using (var reader = command.ExecuteReader())
                {
                    // loop over rows returned 
                    while (reader.Read())
                    {
                        // set total pages to the number of total pages there should be
                        TotalPages = int.Parse(reader[0].ToString()) / RowsPerPage;
                    }
                }

                // close sql connection
                connection.Close();
            }
            // set the maximum number of pages in the numeric up down counter to the total number of pages
            nbPageNumber.Maximum = TotalPages;
        }

        /// <summary>
        /// Method to load the hash data into the datagrid 
        /// </summary>
        private void LoadData()
        {
            // set all button elements to enabled
            btnPreviousPage.Enabled = true;
            btnNextPage.Enabled = true;
            btnLastPage.Enabled = true;
            btnFirstPage.Enabled = true;
            // set buttons on form to be disabled if this is the first / last page or there is no previous / next page
            if (PageIndex == 1)
            {
                btnPreviousPage.Enabled = false;
                btnFirstPage.Enabled = false;
            }
            else if(PageIndex == TotalPages)
            {
                btnNextPage.Enabled = false;
                btnLastPage.Enabled= false;
            }

            // clear rows in grid
            dgv.Rows.Clear();
            // set the page number in the textbox so the current page can be displayed to user
            tbPageNumber.Text = $"Page {PageIndex}/{TotalPages}";
            // calculate the offset for the number of rows to skip to get the desired page for the user
            int offset = (PageIndex * RowsPerPage) - RowsPerPage;

            // set db connection string
            using (var connection = new SqliteConnection("Data Source=hashes.sqlite"))
            {
                // open connection to db
                connection.Open();

                // sql query
                var command = connection.CreateCommand();
                command.CommandText = $"SELECT hash_id, sha1 FROM safe_hashes LIMIT {RowsPerPage} OFFSET {offset}";

                // read results from query
                using (var reader = command.ExecuteReader())
                {
                    // loop over rows returned
                    while (reader.Read())
                    {
                        // because data returned is relative to the class use class to store values
                        safe_hash hash = new safe_hash()
                        {
                            hash_id = int.Parse(reader[0].ToString()),
                            sha1 = reader[1].ToString()
                        };

                        // create new row and get index
                        int index = dgv.Rows.Add();
                        // set the appropriate results to the newly created row by the index
                        dgv.Rows[index].Cells["column1"].Value = hash.hash_id;
                        dgv.Rows[index].Cells["column2"].Value = hash.sha1;
                    }
                }

                // close connection
                connection.Close();
            }
        }

        /// <summary>
        /// Class to hold safe_hashes table data as well
        /// Has extra exists in database boolean value for checked hashes
        /// </summary>
        public class safe_hash
        {
            public int hash_id;
            public string sha1;
            public bool ExistsInDatabase;
        }
        private void btnViewPage_Click(object sender, EventArgs e)
        {
            PageIndex = (int)nbPageNumber.Value;
            LoadData();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            PageIndex = 1;
            LoadData();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            PageIndex = TotalPages;
            LoadData();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            PageIndex++;
            LoadData();
        }
        
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            PageIndex--;
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // create new hash list
            List<safe_hash> hashesToFind = new List<safe_hash>();
            // add hashes from textbox to list of hashes to find
            foreach(string hash in tbHashes.Lines)
            {
                hashesToFind.Add(new safe_hash
                {
                    sha1=hash
                });
            }
            // call the find hash method
            FindHashes(hashesToFind);
        }
        /// <summary>
        /// Method which will find hashes that exist or dont exist in the database
        /// </summary>
        /// <param name="hashesToFind">list of safe_hash hashes</param>
        private void FindHashes(List<safe_hash> hashesToFind)
        {
            // loop over each hash in list
            foreach(safe_hash hash in hashesToFind)
            {
                // set connection string
                using (var connection = new SqliteConnection("Data Source=hashes.sqlite"))
                {
                    // connect to db
                    connection.Open();

                    // sql query to check if it exists in db
                    var command = connection.CreateCommand();
                    command.CommandText = $"SELECT count(hash_id) from safe_hashes where sha1='{hash.sha1}'";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // check the query result
                            if(int.Parse(reader[0].ToString()) == 0)
                            {
                                // hash does not exist
                                hash.ExistsInDatabase = false;
                            }
                            else 
                            {
                                // hash exists in database
                                hash.ExistsInDatabase = true;
                            }
                        }
                    }

                    // close connection
                    connection.Close();
                }
            }

            // empty string to store msgbox output from checking the hashes
            string msgboxOutput = string.Empty;
            // looping over the list of hashes
            foreach(safe_hash hash in hashesToFind)
            {
                string extText = string.Empty;
                // setting appriopriate text to display to the user regarding whether the hashes exist or not
                if (hash.ExistsInDatabase)
                {
                    extText = " exists in the database";
                }
                else
                    extText = " does not exist in the database";

                // append text to msgboxoutput string
                msgboxOutput += hash.sha1 + extText + Environment.NewLine;
            }

            // display message box to user
            MessageBox.Show("Hash check result is below" + Environment.NewLine + msgboxOutput);
        }
    }
}