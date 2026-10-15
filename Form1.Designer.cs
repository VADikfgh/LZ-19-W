namespace LZ_19_W
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            textBoxEvent = new TextBox();
            btnAddEvent = new Button();
            btnCalculatePoints = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(325, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(325, 53);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // textBoxEvent
            // 
            textBoxEvent.Location = new Point(82, 53);
            textBoxEvent.Name = "textBoxEvent";
            textBoxEvent.Size = new Size(100, 23);
            textBoxEvent.TabIndex = 2;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(83, 115);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(75, 23);
            btnAddEvent.TabIndex = 3;
            btnAddEvent.Text = "Додати подію";
            btnAddEvent.UseVisualStyleBackColor = true;
            // 
            // btnCalculatePoints
            // 
            btnCalculatePoints.Location = new Point(83, 170);
            btnCalculatePoints.Name = "btnCalculatePoints";
            btnCalculatePoints.Size = new Size(75, 23);
            btnCalculatePoints.TabIndex = 4;
            btnCalculatePoints.Text = "Відстань точок";
            btnCalculatePoints.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculatePoints);
            Controls.Add(btnAddEvent);
            Controls.Add(textBoxEvent);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxEvent;
        private Button btnAddEvent;
        private Button btnCalculatePoints;
    }
}
