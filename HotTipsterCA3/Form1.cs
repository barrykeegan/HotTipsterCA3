﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;

namespace HotTipsterCA3
{
    public partial class frmHotTipster : Form
    {
        //Create instance of FileAccess Class which will be used
        //for file IO.
        private FileAccess fa = new FileAccess();
        //The Results object will be used to store the working copy
        //of the TipResults collection being used during runtime.
        private TipResults Results = new TipResults();

        //This Method will only be used on Launch of the app, 
        //and only if the file being used does not already exist.
        //This Method creates the TipResults collection and then 
        //writes it to the file.
        private void WriteInitialTipResultsToFileOnLaunchIfFileNotExists()
        {
            TipResults tr = new TipResults();
            tr.Add(new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true });
            tr.Add(new TipResult { Course = "Punchestown", RaceDate = new DateTime(2016, 12, 22), ResultValue = 122.52m, Won = true });
            tr.Add(new TipResult { Course = "Sandown", RaceDate = new DateTime(2016, 11, 17), ResultValue = 20.00m, Won = false });
            tr.Add(new TipResult { Course = "Ayr", RaceDate = new DateTime(2016, 11, 03), ResultValue = 25.00m, Won = false });
            tr.Add(new TipResult { Course = "Fairyhouse", RaceDate = new DateTime(2016, 12, 02), ResultValue = 65.75m, Won = true });
            tr.Add(new TipResult { Course = "Ayr", RaceDate = new DateTime(2017, 03, 11), ResultValue = 12.05m, Won = true });
            tr.Add(new TipResult { Course = "Doncaster", RaceDate = new DateTime(2017, 12, 02), ResultValue = 10.00m, Won = false });
            tr.Add(new TipResult { Course = "Towcester", RaceDate = new DateTime(2016, 03, 12), ResultValue = 50.00m, Won = false });
            tr.Add(new TipResult { Course = "Goodwood", RaceDate = new DateTime(2017, 10, 07), ResultValue = 525.74m, Won = true });
            tr.Add(new TipResult { Course = "Kelso", RaceDate = new DateTime(2016, 09, 13), ResultValue = 43.21m, Won = true });
            tr.Add(new TipResult { Course = "Punchestown", RaceDate = new DateTime(2017, 07, 05), ResultValue = 35.00m, Won = false });
            tr.Add(new TipResult { Course = "Ascot", RaceDate = new DateTime(2016, 02, 04), ResultValue = 23.65m, Won = true });
            tr.Add(new TipResult { Course = "Kelso", RaceDate = new DateTime(2017, 08, 02), ResultValue = 30.00m, Won = false });
            tr.Add(new TipResult { Course = "Towcester", RaceDate = new DateTime(2017, 05, 01), ResultValue = 104.33m, Won = true });
            tr.Add(new TipResult { Course = "Ascot", RaceDate = new DateTime(2017, 06, 21), ResultValue = 25.00m, Won = false });
            tr.Add(new TipResult { Course = "Bangor", RaceDate = new DateTime(2016, 12, 22), ResultValue = 30.00m, Won = false });
            tr.Add(new TipResult { Course = "Ayr", RaceDate = new DateTime(2017, 05, 22), ResultValue = 11.50m, Won = true });
            tr.Add(new TipResult { Course = "Ascot", RaceDate = new DateTime(2017, 06, 23), ResultValue = 30.00m, Won = false });
            tr.Add(new TipResult { Course = "Ascot", RaceDate = new DateTime(2017, 06, 23), ResultValue = 374.27m, Won = true });
            tr.Add(new TipResult { Course = "Goodwood", RaceDate = new DateTime(2016, 10, 05), ResultValue = 34.12m, Won = true });
            tr.Add(new TipResult { Course = "Dundalk", RaceDate = new DateTime(2016, 11, 09), ResultValue = 20.00m, Won = false });
            tr.Add(new TipResult { Course = "Haydock", RaceDate = new DateTime(2016, 11, 12), ResultValue = 87.00m, Won = true });
            tr.Add(new TipResult { Course = "Perth", RaceDate = new DateTime(2017, 01, 20), ResultValue = 15.00m, Won = false });
            tr.Add(new TipResult { Course = "York", RaceDate = new DateTime(2017, 11, 11), ResultValue = 101.25m, Won = true });
            tr.Add(new TipResult { Course = "Punchestown", RaceDate = new DateTime(2016, 12, 22), ResultValue = 11.50m, Won = true });
            tr.Add(new TipResult { Course = "Chester", RaceDate = new DateTime(2016, 08, 14), ResultValue = 10.00m, Won = false });
            tr.Add(new TipResult { Course = "Kelso", RaceDate = new DateTime(2016, 09, 18), ResultValue = 10.00m, Won = false });
            tr.Add(new TipResult { Course = "Kilbeggan", RaceDate = new DateTime(2017, 03, 03), ResultValue = 20.00m, Won = false });
            tr.Add(new TipResult { Course = "Fairyhouse", RaceDate = new DateTime(2017, 03, 11), ResultValue = 55.50m, Won = true });
            tr.Add(new TipResult { Course = "Punchestown", RaceDate = new DateTime(2016, 11, 15), ResultValue = 10.00m, Won = false });
            tr.Add(new TipResult { Course = "Towcester", RaceDate = new DateTime(2016, 05, 08), ResultValue = 16.55m, Won = true });
            tr.Add(new TipResult { Course = "Punchestown", RaceDate = new DateTime(2016, 05, 23), ResultValue = 13.71m, Won = true });
            tr.Add(new TipResult { Course = "Cork", RaceDate = new DateTime(2016, 11, 30), ResultValue = 20.00m, Won = false });
            tr.Add(new TipResult { Course = "Punchestown", RaceDate = new DateTime(2016, 04, 25), ResultValue = 13.45m, Won = true });
            tr.Add(new TipResult { Course = "Bangor", RaceDate = new DateTime(2016, 01, 23), ResultValue = 10.00m, Won = false });
            tr.Add(new TipResult { Course = "Sandown", RaceDate = new DateTime(2017, 08, 07), ResultValue = 25.00m, Won = false });
            fa.WriteResultsCollectionToFile(System.Configuration.ConfigurationManager.AppSettings["fileName"], tr);
        }

        public frmHotTipster()
        {
            InitializeComponent();
            if(!File.Exists(System.Configuration.ConfigurationManager.AppSettings["fileName"]))
            {
                WriteInitialTipResultsToFileOnLaunchIfFileNotExists();
            }
        }

        private void mnuItemWriteFile_Click(object sender, EventArgs e)
        {
            if (Results.Count != 0)
            {
                DialogResult dr = MessageBox.Show(
                    this,
                    "Are you sure you want to write the current Tip Results to the file? This will overwrite the current contents of the file.", 
                    "Confirm File Write", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    fa.WriteResultsCollectionToFile(System.Configuration.ConfigurationManager.AppSettings["fileName"], Results);
                    MessageBox.Show(
                        this,
                        $"Write of {Results.Count} Tip Results successful.",
                        "Write Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void mnuItemReadFile_Click(object sender, EventArgs e)
        {
            if (Results.Count == 0)
            {
                Results = fa.ReadResultsCollectionFromFile(System.Configuration.ConfigurationManager.AppSettings["fileName"]);
                MessageBox.Show(
                    this,
                    $"Read of {Results.Count} Tip Results successful.",
                    "Read Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr = MessageBox.Show(
                    this,
                    "Are you sure you want to read in the contents of Tip Results file? This will overwrite the current set of Results you are working with.",
                    "Confirm File Read",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Results = fa.ReadResultsCollectionFromFile(System.Configuration.ConfigurationManager.AppSettings["fileName"]);
                    MessageBox.Show(
                        this,
                        $"Read of {Results.Count} Tip Results successful.",
                        "Read Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNewResult_Click(object sender, EventArgs e)
        {
            string validationMessage = "";
            bool validData = false;
            decimal ResultValue;
            if(txtCourse.Text == "")
            {
                validationMessage += "You must enter a race course name." + Environment.NewLine;
            }
            if (!Regex.IsMatch(txtCourse.Text, @"^[a-zA-Z ]+$"))
            {
                validationMessage += "Course Name can only be alphabetic." + Environment.NewLine;
            }
            if (dtpRaceDate.Value < new DateTime(2016,01,01))
            {
                validationMessage += "Date must not be before 2016." + Environment.NewLine;
            }
            if(dtpRaceDate.Value.Date > DateTime.Today)
            {
                validationMessage += "Date must not be in the future." + Environment.NewLine;
            }
            if(!decimal.TryParse(txtResultValue.Text, out ResultValue))
            {
                validationMessage += "You must enter a decimal value for the Result Value." + Environment.NewLine;
            }
            else if(ResultValue < 10)
            {
                validationMessage += "The Result Value cannot be less than €10.00" + Environment.NewLine;
            }

            if (validationMessage == "")
            {
                validData = true;
                //if results.count = 0, then file contents must not have been read in yet
                //if results is added to in this state then it will be overwritten on any 
                //future read, this may lead to unexpected results. check with user that
                //that's what they want
                if (Results.Count == 0)
                {
                    DialogResult dr = MessageBox.Show(
                        this,
                        "Are you sure you want to add to the Results Collection at this time?" + Environment.NewLine +
                        "The Results Collection is currently empty, this means you have not yet read the file contents in. If you continue with this action, any future write to the file will overwrite its contents, and any future read from the file will overwrite Results Collection contents.",
                        "Add New Record to Results Collection",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        TipResult newResult = new TipResult
                        {
                            Course = txtCourse.Text,
                            RaceDate = dtpRaceDate.Value.Date,
                            ResultValue = decimal.Parse(txtResultValue.Text),
                            Won = chkWon.Checked
                        };
                        Results.Add(newResult);
                        txtCourse.Text = "";
                        txtResultValue.Text = "";
                        dtpRaceDate.Value = DateTime.Today;
                        chkWon.Checked = false;
                    }
                }
                else
                {
                    TipResult newResult = new TipResult
                    {
                        Course = txtCourse.Text,
                        RaceDate = dtpRaceDate.Value.Date,
                        ResultValue = decimal.Parse(txtResultValue.Text),
                        Won = chkWon.Checked
                    };
                    Results.Add(newResult);
                    txtCourse.Text = "";
                    txtResultValue.Text = "";
                    dtpRaceDate.Value = DateTime.Today;
                    chkWon.Checked = false;
                }
            }
            else
            {
                MessageBox.Show(
                    this,
                    "Your input was invalid Details:" + Environment.NewLine + validationMessage +
                    Environment.NewLine + "Please fix the data and try again",
                    "Invalid Data Entered",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        
    }
}
