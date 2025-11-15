using System.Linq;
using System.Windows.Forms;
using MasonryEstimator.Core.Models;
using MasonryEstimator.Data;

namespace MasonryEstimator.App
{
    public partial class MainForm : Form
    {
        // This talks to the database through EF Core.
        private readonly Repository _repo = new();

        public MainForm()
        {
            InitializeComponent(); // sets up the window
            SeedIfEmpty();         // makes sure there are demo projects in the DB
            SetupUi();             // builds the label that shows how many projects exist
        }

        /// <summary>
        /// If there are no rows in the Projects table, insert two demo projects.
        /// This only runs the first time the DB is empty.
        /// </summary>
        private void SeedIfEmpty()
        {
            var existing = _repo.GetProjects().ToList();

            if (!existing.Any())
            {
                _repo.AddProject(new Project
                {
                    Name = "Demo Project 1",
                    ClientName = "Sample Client",
                    Location = "Sample Location"
                });

                _repo.AddProject(new Project
                {
                    Name = "Demo Project 2",
                    ClientName = "Another Client",
                    Location = "Somewhere Else"
                });
            }
        }

        /// <summary>
        /// Builds a simple UI and shows how many projects are in the database.
        /// </summary>
        private void SetupUi()
        {
            // Text in the window title bar
            Text = "Masonry Estimator - Database Test";

            // Pull all projects from the DB
            var projects = _repo.GetProjects().ToList();
            var count = projects.Count;

            // Build a label to display the count
            var lbl = new Label
            {
                Text = $"Projects in database: {count}",
                AutoSize = true,
                Left = 20,
                Top = 20
            };

            // Add the label control to the form so it displays
            Controls.Add(lbl);
        }
    }
}
