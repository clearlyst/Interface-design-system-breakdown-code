using System;
using System.Drawing;
using System.Windows.Forms;

namespace project
{
    public partial class font_animation_utils : Form
    {
        private Timer animationTimer;
        private int animationSteps;
        private int currentStep;
        private Control targetControl;
        private float originalFontSize;
        private float targetFontSize;
        private bool isExpanding;

        public font_animation_utils(Control control, float targetFontSize, int steps = 10, int interval = 20)
        {
            targetControl = control;
            originalFontSize = control.Font.Size;
            this.targetFontSize = targetFontSize;
            animationSteps = steps;

            animationTimer = new Timer
            {
                Interval = interval
            };

            animationTimer.Tick += AnimationTimer_Tick;
        }

        public void StartExpand()
        {
            isExpanding = true;
            currentStep = 0;
            animationTimer.Start();
        }

        public void StartCollapse()
        {
            isExpanding = false;
            currentStep = 0;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (currentStep <= animationSteps)
            {
                float progress = (float)currentStep / animationSteps;

                float newFontSize = originalFontSize + (targetFontSize - originalFontSize) * (isExpanding ? progress : 1 - progress);

                targetControl.Font = new Font(targetControl.Font.FontFamily, newFontSize, targetControl.Font.Style);

                currentStep++;
            }
            else
            {
                animationTimer.Stop();
            }
        }
    }
}