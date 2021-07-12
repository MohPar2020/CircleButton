using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleButton
{
    public partial class Form1 : Form
    {
        int current_X_Currsor = -1;
        int current_Y_Cursor = -1;

        private Timer dwellTimer;
        private Timer transitionTimer;

        private int MAX_MEASUREMENT_COUNT = 5;

        private int counter = 5;
        private int delayCounter = 1;
        private int generalCounter = 3;
        private static int MAX_TESTING_SPOTS = 6;

        private int basicGreenLeft = 0;
        private int basicBlueLeft = 0;
        private int basicRedLeft = 0;
        private int basicCounterLeft = 0;

        private int basicGreenTop = 0;
        private int basicBlueTop = 0;
        private int basicRedTop = 0;
        private int basicCounterTop = 0;

        Boolean testStarted = false;
        int userId = 0;

        String testingMode = null;
        List<String> measurements = new List<string>();
        List<String> pointerMovements = new List<string>();
        ResultManager rsm = new ResultManager();

        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnStart;

            this.MouseMove += OnMouseMove;
            this.MouseClick += OnMouseClick;

            DisableButtons();            
        }

        private void DisableButtons()
        {
            btnGreen.Enabled = false;
            btnBlue.Enabled = false;
            btnRed.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEvent();
        }

        private void SetUserId()
        {
            String value = txtId.Text;
            if (String.IsNullOrEmpty(value))
            {
                userId = 0;
            }
            else
            {
                userId = Convert.ToInt32(value);
            }
        }

        private void LoadEvent()
        {
            InitDartElements();
            PrepareDwellTimer();
            PrepareTransitionTimer();
            HideButtons();
            
            lblCountDown.Visible = false;
        }

        private void HideButtons()
        {
            btnGreen.Visible = false;
            btnBlue.Visible = false;
            btnRed.Visible = false;
        }

        private void PrepareDwellTimer()
        {
            dwellTimer = new Timer();
            dwellTimer.Tick += new EventHandler(DwellTimer_Tick);
            dwellTimer.Interval = 100; // 0.1 second
        }

        
        private void PrepareTransitionTimer()
        {
            transitionTimer = new Timer();
            transitionTimer.Tick += new EventHandler(TransitionTimer_Tick);
            transitionTimer.Interval = 500; // 0.5 second
        }
        

        private void InitDartElements()
        {
            int x = this.Width / 2;
            int y = this.Height / 2;            

            btnGreen.Left = x;
            btnBlue.Left = x - (btnBlue.Width / 4);
            btnRed.Left = btnBlue.Left - (btnGreen.Width / 2);
            lblCountDown.Left = btnRed.Left;

            btnGreen.Top = y;
            btnBlue.Top = y - (btnBlue.Height / 4);
            btnRed.Top = btnBlue.Top - (btnGreen.Height / 2);
            lblCountDown.Top = btnRed.Top;

            basicGreenLeft = btnGreen.Left;
            basicBlueLeft = btnBlue.Left;
            basicRedLeft = btnRed.Left;
            basicCounterLeft = lblCountDown.Left;

            basicGreenTop = btnGreen.Top;
            basicBlueTop = btnBlue.Top;
            basicRedTop = btnRed.Top;
            basicCounterTop = lblCountDown.Top;
        }

        private void Start()
        {
            SetUserId();
            if (userId < 1)
            {
                MessageBox.Show("Please enter user id");
                return;
            }

            RunTest();

            if (DwellTimeSelected())
            {
                ShowCounterLabel();
            }
            else
            {
                HideCounterLabel();
            }

            ShowButtons();
        }

        private void ShowButtons()
        {
            btnGreen.Visible = true;
            btnBlue.Visible = true;
            btnRed.Visible = true;
        }

        private void RunTest()
        {
            ResetDwellCounter();
            lblResult.Text = String.Empty;
            lblCountDown.Text = counter.ToString();
            dwellTimer.Start();
            testStarted = true;
        }

        private void DwellTimer_Tick(object sender, EventArgs e)
        {
            if (IsTestModeSet())
            {
                if (DwellTimeSelected())
                {
                    counter--;
                    if (counter == 0)
                    {
                        DoStopTimer();
                    }
                }
            }

            lblCountDown.Text = counter.ToString();
        }

        private int[] GetRandomLocation()
        {
            int[] location = new int[2];

            int x = this.Width / 5;
            int y = this.Height / 5;                        
            
            Random rnd = new Random();
            int randX = rnd.Next(0, x);
            int randY = rnd.Next(0, y);

            location[0] = randX;
            location[1] = randY;

            return location;
        }

        private Boolean VoiceSelected()
        {
            return testingMode.Equals("VoiceRecognition");
        }

        private Boolean DwellTimeSelected()
        {
            return testingMode.Equals("DwellTime");
        }

        private Boolean EyeTAPSelected()
        {
            return testingMode.Equals("EyeTAP");
        }

        private Boolean MouseSelected()
        {
            return testingMode.Equals("Mouse");
        }

        private void ResetDwellCounter()
        {
            this.counter = 5;
        }

        private void ShowCounterLabel()
        {
            lblCountDown.Visible = true;
        }

        private void HideCounterLabel()
        {
            lblCountDown.Visible = false;
        }

        private void DoStopTimer()
        {
            dwellTimer.Stop();
            CalculateDistance();
            ResetDelayCounter();
            transitionTimer.Start();
        }

        private void GoToNextLocation()
        {
            CalculateDistance();
            if (generalCounter <= MAX_TESTING_SPOTS)
            {
                int[] loc = GetRandomLocation();
                MoveTargets(loc);

                RunTest();
                generalCounter++;
            }
            else
            {
                testStarted = false;
                rsm.WriteResults(userId, testingMode, measurements);
                rsm.SavePointerMovements(userId, testingMode, pointerMovements);

                measurements.Clear();
                pointerMovements.Clear();
                MessageBox.Show("End of Test");
            }
        }

        private Boolean IsTestModeSet()
        {
            return !String.IsNullOrEmpty(this.testingMode);
        }
        
        private void ResetDelayCounter()
        {
            delayCounter = 1;
        }
        
        private void TransitionTimer_Tick(object sender, EventArgs e)
        {
            if (delayCounter == 0)
            {
                transitionTimer.Stop();
                if (generalCounter <= MAX_TESTING_SPOTS)
                {                    
                    int[] loc = GetRandomLocation();
                    MoveTargets(loc);

                    RunTest();
                    generalCounter++;
                }
                else
                {
                    testStarted = false;
                    rsm.WriteResults(userId, testingMode, measurements);
                    rsm.SavePointerMovements(userId, testingMode, pointerMovements);

                    measurements.Clear();
                    pointerMovements.Clear();
                    MessageBox.Show("End of Test");
                }
            }
            delayCounter--;
        }
        
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;
            current_X_Currsor = X;
            current_Y_Cursor = Y;

            if (IsTestModeSet() && testStarted)
            {
                String line = current_X_Currsor + ";" + current_Y_Cursor;
                pointerMovements.Add(line);                
            }
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (VoiceSelected() || EyeTAPSelected() || MouseSelected())
                {
                    GoToNextLocation();
                }                
            }
        }

        private void MoveTargets(int[] location)
        {
            int x = location[0];
            int y = location[1];

            int leftOffset = x;
            int topOffset = y;

            btnBlue.Left        = leftOffset + basicBlueLeft;
            btnGreen.Left       = leftOffset + basicGreenLeft;
            btnRed.Left         = leftOffset + basicRedLeft;
            lblCountDown.Left   = leftOffset + basicCounterLeft;

            btnBlue.Top         = topOffset + basicBlueTop;
            btnGreen.Top        = topOffset + basicGreenTop;
            btnRed.Top          = topOffset + basicRedTop;
            lblCountDown.Top    = topOffset + basicCounterTop;
        }      

        private void CalculateDistance()
        {
            int x = btnGreen.Left + (btnGreen.Width / 2);
            int y = btnGreen.Top + (btnGreen.Height / 2);
            
            String finalDistance = rsm.CalculateDistance(x, y, current_X_Currsor, current_Y_Cursor);
            measurements.Add(finalDistance);
            lblResult.Text = finalDistance;            
        }

        private void dwellTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testingMode = "DwellTime";
            Start();
        }

        private void voiceRecognitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testingMode = "VoiceRecognition";
            Start();
        }

        private void eyeTAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testingMode = "EyeTAP";
            Start();
        }

        private void rESETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetEverything();
        }

        private void ResetEverything()
        {
            this.current_X_Currsor = -1;
            this.current_Y_Cursor = -1;

            this.counter = 5;
            //this.delayCounter = 3;
            this.generalCounter = 3;       
        
            this.testStarted = false;
            this.userId = 0;
            
            this.testingMode = null;
            measurements.Clear();
            pointerMovements.Clear();

            dwellTimer.Stop();
            transitionTimer.Stop();

            DisableButtons();
            LoadEvent();           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                ResetEverything();
            }catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            try
            {
                if (rbDwell.Checked)
                {
                    testingMode = "DwellTime";
                    Start();
                }
                else if (rbVoice.Checked)
                {
                    testingMode = "VoiceRecognition";
                    Start();
                }
                else if (rbEyeTAP.Checked)
                {
                    testingMode = "EyeTAP";
                    Start();
                }
                else if (rbMouse.Checked)
                {
                    testingMode = "Mouse";
                    Start();
                }
                else
                {
                    MessageBox.Show("Please select one of the modes");
                }
            }catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
