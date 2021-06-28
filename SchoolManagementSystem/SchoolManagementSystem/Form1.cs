using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SchoolManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            SetupData();
        }
        BackgroundWorker bw;
        private void SetupData()
        {
            labelProcessing.Text = "Setting up data please wait...";
            bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
        }


        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var initializer = new MigrateDatabaseToLatestVersion<SchoolContext, Data.Migrations.Configuration>();
                Database.SetInitializer(initializer);
                using (var ctx = new SchoolContext())
                {
                    if (!ctx.Parents.Any())
                    {
                        var parents = new List<Parent>()
                        {
                            new Parent()
                            {
                                FatherName = "Chandra",
                                MotherName="Anitha",
                                FatherEmail="abc@gmail",
                                MotherEmail="Abcs@gmail",
                                Phone=889709,
                                Students = new List<Student>()
                                {
                                    new Student(){FirstName="Harshitha",LastName="Shekar", DOB=DateTime.Today,Phone=89788,JoiningDate=DateTime.Today},
                                    
                                }
                            },

                        };
                        ctx.Parents.AddRange(parents);
                    }
                    ctx.SaveChanges();
                    e.Result = "Ready";
                }
            }
            catch (Exception ex)
            {
                e.Result = ex.Message;
            }
        }
        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelProcessing.Text = e.Result.ToString();
        }

        private void viewParent_Click(object sender, EventArgs e)
        {
            using (var ctx = new SchoolContext())
            {
                var viewParents = ctx.Parents.Select(view => new { view.ID, view.FatherName, view.FatherEmail, view.MotherName, view.MotherEmail, view.Phone });
                dgvdetail.DataSource = viewParents.ToList();
            }
        }
    }
}
