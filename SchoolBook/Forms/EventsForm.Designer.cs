namespace SchoolBook.Forms
{
    partial class EventsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelEvents = new Label();
            SuspendLayout();
            // 
            // labelEvents
            // 
            labelEvents.AutoSize = true;
            labelEvents.Location = new Point(27, 24);
            labelEvents.Name = "labelEvents";
            labelEvents.Size = new Size(63, 25);
            labelEvents.TabIndex = 0;
            labelEvents.Text = "Events";
            // 
            // EventsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEvents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EventsForm";
            Text = "EventsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEvents;
    }
}