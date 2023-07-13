namespace DakTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            _bgPicture = new PictureBox();
            _time = new Label();
            _Min5Btn = new Button();
            _Min15Btn = new Button();
            _Min20Btn = new Button();
            _Min30Btn = new Button();
            _Min45Btn = new Button();
            _Min60Btn = new Button();
            _playBtn = new Button();
            _pauseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)_bgPicture).BeginInit();
            SuspendLayout();
            // 
            // _bgPicture
            // 
            _bgPicture.Image = (Image)resources.GetObject("_bgPicture.Image");
            _bgPicture.Location = new Point(350, 12);
            _bgPicture.Name = "_bgPicture";
            _bgPicture.Size = new Size(662, 617);
            _bgPicture.TabIndex = 1;
            _bgPicture.TabStop = false;
            _bgPicture.Click += BgPicture_Click;
            // 
            // _time
            // 
            _time.BackColor = Color.Transparent;
            _time.Font = new Font("Rubik", 50F, FontStyle.Regular, GraphicsUnit.Point);
            _time.ForeColor = Color.DarkSlateGray;
            _time.Location = new Point(176, 127);
            _time.Name = "_time";
            _time.Size = new Size(410, 106);
            _time.TabIndex = 0;
            _time.Text = "XX:XX:XX";
            _time.Click += Time_Click;
            // 
            // _Min5Btn
            // 
            _Min5Btn.BackColor = Color.LightSeaGreen;
            _Min5Btn.Cursor = Cursors.Hand;
            _Min5Btn.FlatAppearance.CheckedBackColor = Color.DarkSlateGray;
            _Min5Btn.FlatStyle = FlatStyle.Flat;
            _Min5Btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _Min5Btn.ForeColor = Color.Azure;
            _Min5Btn.Location = new Point(25, 25);
            _Min5Btn.Name = "_Min5Btn";
            _Min5Btn.Size = new Size(104, 50);
            _Min5Btn.TabIndex = 2;
            _Min5Btn.Text = "5 min";
            _Min5Btn.UseVisualStyleBackColor = false;
            _Min5Btn.Click += _Min5Btn_Click;
            // 
            // _Min15Btn
            // 
            _Min15Btn.BackColor = Color.LightSeaGreen;
            _Min15Btn.Cursor = Cursors.Hand;
            _Min15Btn.FlatAppearance.CheckedBackColor = Color.DarkSlateGray;
            _Min15Btn.FlatStyle = FlatStyle.Flat;
            _Min15Btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _Min15Btn.ForeColor = Color.Azure;
            _Min15Btn.Location = new Point(154, 25);
            _Min15Btn.Name = "_Min15Btn";
            _Min15Btn.Size = new Size(104, 50);
            _Min15Btn.TabIndex = 2;
            _Min15Btn.Text = "15 min";
            _Min15Btn.UseVisualStyleBackColor = false;
            _Min15Btn.Click += _Min15Btn_Click;
            // 
            // _Min20Btn
            // 
            _Min20Btn.BackColor = Color.LightSeaGreen;
            _Min20Btn.Cursor = Cursors.Hand;
            _Min20Btn.FlatAppearance.CheckedBackColor = Color.DarkSlateGray;
            _Min20Btn.FlatStyle = FlatStyle.Flat;
            _Min20Btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _Min20Btn.ForeColor = Color.Azure;
            _Min20Btn.Location = new Point(277, 25);
            _Min20Btn.Name = "_Min20Btn";
            _Min20Btn.Size = new Size(104, 50);
            _Min20Btn.TabIndex = 2;
            _Min20Btn.Text = "20 min";
            _Min20Btn.UseVisualStyleBackColor = false;
            _Min20Btn.Click += _Min20Btn_Click;
            // 
            // _Min30Btn
            // 
            _Min30Btn.BackColor = Color.LightSeaGreen;
            _Min30Btn.Cursor = Cursors.Hand;
            _Min30Btn.FlatAppearance.CheckedBackColor = Color.DarkSlateGray;
            _Min30Btn.FlatStyle = FlatStyle.Flat;
            _Min30Btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _Min30Btn.ForeColor = Color.Azure;
            _Min30Btn.Location = new Point(406, 25);
            _Min30Btn.Name = "_Min30Btn";
            _Min30Btn.Size = new Size(104, 50);
            _Min30Btn.TabIndex = 2;
            _Min30Btn.Text = "30 min";
            _Min30Btn.UseVisualStyleBackColor = false;
            _Min30Btn.Click += _Min30Btn_Click;
            // 
            // _Min45Btn
            // 
            _Min45Btn.BackColor = Color.LightSeaGreen;
            _Min45Btn.Cursor = Cursors.Hand;
            _Min45Btn.FlatAppearance.CheckedBackColor = Color.DarkSlateGray;
            _Min45Btn.FlatStyle = FlatStyle.Flat;
            _Min45Btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _Min45Btn.ForeColor = Color.Azure;
            _Min45Btn.Location = new Point(532, 25);
            _Min45Btn.Name = "_Min45Btn";
            _Min45Btn.Size = new Size(104, 50);
            _Min45Btn.TabIndex = 2;
            _Min45Btn.Text = "45 min";
            _Min45Btn.UseVisualStyleBackColor = false;
            _Min45Btn.Click += _Min45Btn_Click;
            // 
            // _Min60Btn
            // 
            _Min60Btn.BackColor = Color.LightSeaGreen;
            _Min60Btn.Cursor = Cursors.Hand;
            _Min60Btn.FlatAppearance.CheckedBackColor = Color.DarkSlateGray;
            _Min60Btn.FlatStyle = FlatStyle.Flat;
            _Min60Btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _Min60Btn.ForeColor = Color.Azure;
            _Min60Btn.Location = new Point(663, 25);
            _Min60Btn.Name = "_Min60Btn";
            _Min60Btn.Size = new Size(104, 50);
            _Min60Btn.TabIndex = 2;
            _Min60Btn.Text = "60 min";
            _Min60Btn.UseVisualStyleBackColor = false;
            _Min60Btn.Click += _Min60Btn_Click;
            // 
            // _playBtn
            // 
            _playBtn.BackColor = Color.Tomato;
            _playBtn.Cursor = Cursors.Hand;
            _playBtn.FlatStyle = FlatStyle.Flat;
            _playBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            _playBtn.ForeColor = SystemColors.ButtonFace;
            _playBtn.Location = new Point(192, 225);
            _playBtn.Name = "_playBtn";
            _playBtn.Size = new Size(394, 58);
            _playBtn.TabIndex = 3;
            _playBtn.Text = "PLAY";
            _playBtn.UseVisualStyleBackColor = false;
            _playBtn.Click += _playBtn_Click;
            // 
            // _pauseBtn
            // 
            _pauseBtn.BackColor = Color.Tomato;
            _pauseBtn.Cursor = Cursors.Hand;
            _pauseBtn.FlatStyle = FlatStyle.Flat;
            _pauseBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            _pauseBtn.ForeColor = SystemColors.ButtonFace;
            _pauseBtn.Location = new Point(192, 289);
            _pauseBtn.Name = "_pauseBtn";
            _pauseBtn.Size = new Size(394, 58);
            _pauseBtn.TabIndex = 3;
            _pauseBtn.Text = "PAUSE";
            _pauseBtn.UseVisualStyleBackColor = false;
            _pauseBtn.Click += _pauseBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 614);
            Controls.Add(_pauseBtn);
            Controls.Add(_playBtn);
            Controls.Add(_Min60Btn);
            Controls.Add(_Min45Btn);
            Controls.Add(_Min30Btn);
            Controls.Add(_Min20Btn);
            Controls.Add(_Min15Btn);
            Controls.Add(_Min5Btn);
            Controls.Add(_time);
            Controls.Add(_bgPicture);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "DakTimer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)_bgPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox _bgPicture;
        private Label _time;
        private Button _Min5Btn;
        private Button _Min15Btn;
        private Button _Min20Btn;
        private Button _Min30Btn;
        private Button _Min45Btn;
        private Button _Min60Btn;
        private Button _playBtn;
        private Button _pauseBtn;
    }
}