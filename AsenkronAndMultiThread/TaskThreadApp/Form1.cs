using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskThreadApp
{
    public partial class Form1 : Form
    {
        // Usage of Task.Run() (without object)
        public static int Counter { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            // When the button is clicked, increment the Counter and set the button's text to the Counter value
            btnCounter.Text = Counter++.ToString();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            // Start the Go function for both ProgressBars to observe their progress
            var task1 = Go(progressBar1);
            var task2 = Go(progressBar2);

            // Await both tasks to finish
            await Task.WhenAll(task1, task2);
        }

        // Asynchronous function used to observe the progress of the ProgressBar
        public async Task Go(ProgressBar progressBar)
        {
            // Start a task to increment the ProgressBar to 100
            await Task.Run(() =>
            {
                // Repeat operations for numbers 1 to 100
                Enumerable.Range(1, 100).ToList().ForEach(i =>
                {
                    // Wait for 100 milliseconds
                    Thread.Sleep(100);

                    // Update the ProgressBar's progress
                    progressBar.Invoke
                    (
                        (MethodInvoker)delegate { progressBar.Value = i; }
                    );
                });
            });
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // This method is currently empty, i.e., not performing any operations
        }
    }
}
