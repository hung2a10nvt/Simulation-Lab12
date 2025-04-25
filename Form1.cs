using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Lab12
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private int currentState = 1; // Clear weather
        private double[] stateTimes = new double[3]; // To track time spent in each state (in hours)
        private double currentTime = 0; 
        private double totalTime = 0; 
        private int currentDay = 1;

        private double[,] rateMatrix = new double[3, 3]
        {
            { -0.4, 0.3, 0.1 },
            { 0.4, -0.8, 0.4 },
            { 0.1, 0.4, -0.5 }
        };

        // lambda_i = -q_ii
        private double[] holdingRates = new double[] { 0.4, 0.8, 0.5 };

        private double[,] transitionProbs = new double[3, 2]; 

        private Timer timer;
        private double nextTransitionTime = 0;
        private double dtBase = 1.0; 
        private double dt; 
        private readonly double[] speedMultipliers = new double[] { 0.25, 0.5, 1, 2, 4 }; 
        public Form1()
        {
            InitializeComponent();

            transitionProbs[0, 0] = rateMatrix[0, 1] / holdingRates[0]; // Clear -> Cloudy
            transitionProbs[0, 1] = rateMatrix[0, 2] / holdingRates[0]; 
            transitionProbs[1, 0] = rateMatrix[1, 0] / holdingRates[1]; 
            transitionProbs[1, 1] = rateMatrix[1, 2] / holdingRates[1]; 
            transitionProbs[2, 0] = rateMatrix[2, 0] / holdingRates[2]; 
            transitionProbs[2, 1] = rateMatrix[2, 1] / holdingRates[2];

            nextTransitionTime = GenerateHoldingTime(currentState);

            dt = dtBase * speedMultipliers[trackBar1.Value];

            lbCurWeather.Text = "Current Weather: Clear";

            double[] stationaryDist = new double[] { 8.0 / 21, 19.0 / 63, 20.0 / 63 };
            lbClear.Text = $"Clear: {stationaryDist[0]:F3}";
            lbCloudy.Text = $"Cloudy: {stationaryDist[1]:F3}";
            lbOvercast.Text = $"Overcast: {stationaryDist[2]:F3}";

            timer1.Tick += (s, e) =>
            {
                // Update statistics
                double total = stateTimes[0] + stateTimes[1] + stateTimes[2];
                if (total > 0)
                {
                    lbState.Text = $"Day: {currentDay}, Time: {currentTime:F1}h\n" +
                                   $"Clear: {stateTimes[0]:F1}h ({stateTimes[0] / total:P1})\n" +
                                   $"Cloudy: {stateTimes[1]:F1}h ({stateTimes[1] / total:P1})\n" +
                                   $"Overcast: {stateTimes[2]:F1}h ({stateTimes[2] / total:P1})";
                }
            };
        }

        private void btToggle_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btToggle.Text = "Run";
            }
            else
            {
                timer1.Start();
                btToggle.Text = "Stop";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime += dt;
            totalTime += dt;

            // Track time spent in the current state
            stateTimes[currentState - 1] += dt;

            if (currentTime >= nextTransitionTime)
            {
                // Determine next state
                double r = rand.NextDouble();
                int nextState;
                if (currentState == 1) 
                {
                    if (r < transitionProbs[0, 0]) nextState = 2; 
                    else nextState = 3; 
                }
                else if (currentState == 2) 
                {
                    if (r < transitionProbs[1, 0]) nextState = 1; 
                    else nextState = 3;
                }
                else 
                {
                    if (r < transitionProbs[2, 0]) nextState = 1; 
                    else nextState = 2; 
                }

                currentState = nextState;

                // Update lbCurWeather
                switch (currentState)
                {
                    case 1:
                        lbCurWeather.Text = "Current Weather: Clear";
                        break;
                    case 2:
                        lbCurWeather.Text = "Current Weather: Cloudy";
                        break;
                    case 3:
                        lbCurWeather.Text = "Current Weather: Overcast";
                        break;
                }

                nextTransitionTime += GenerateHoldingTime(currentState);
            }

            if (currentTime >= 24)
            {
                currentTime = 0;
                currentDay++;
                nextTransitionTime -= 24; 
                if (nextTransitionTime < 0) nextTransitionTime = GenerateHoldingTime(currentState);
            }
        }
        private double GenerateHoldingTime(int state)
        {
            // Generate holding time
            double lambda = holdingRates[state - 1];
            double u = rand.NextDouble();
            return -Math.Log(1 - u) / lambda; 
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            dt = dtBase * speedMultipliers[trackBar1.Value]; 
        }
    }
}
