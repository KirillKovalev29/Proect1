namespace Proects1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pBar = new CircularProgressBar.CircularProgressBar();
            this.timers = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pBar
            // 
            this.pBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pBar.AnimationSpeed = 500;
            this.pBar.BackColor = System.Drawing.Color.Transparent;
            this.pBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pBar.ForeColor = System.Drawing.Color.White;
            this.pBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pBar.InnerMargin = 2;
            this.pBar.InnerWidth = -1;
            this.pBar.Location = new System.Drawing.Point(108, 40);
            this.pBar.MarqueeAnimationSpeed = 2000;
            this.pBar.Name = "pBar";
            this.pBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pBar.OuterMargin = -25;
            this.pBar.OuterWidth = 26;
            this.pBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pBar.ProgressWidth = 20;
            this.pBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pBar.Size = new System.Drawing.Size(303, 292);
            this.pBar.StartAngle = 270;
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pBar.SubscriptText = "";
            this.pBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pBar.SuperscriptText = "";
            this.pBar.TabIndex = 1;
            this.pBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pBar.Value = 68;
            // 
            // timers
            // 
            this.timers.Enabled = true;
            this.timers.Tick += new System.EventHandler(this.timers_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(522, 368);
            this.Controls.Add(this.pBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar pBar;
        private System.Windows.Forms.Timer timers;
    }
}

