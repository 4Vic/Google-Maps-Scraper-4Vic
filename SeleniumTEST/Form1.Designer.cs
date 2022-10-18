namespace SeleniumTEST
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.search_box_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.StartButton = new ePOSOne.btnProduct.Button_WOC();
            this.export_Button = new ePOSOne.btnProduct.Button_WOC();
            this.ClearDataButton = new ePOSOne.btnProduct.Button_WOC();
            this.ShowHideButton = new ePOSOne.btnProduct.Button_WOC();
            this.UpdataDataButton = new ePOSOne.btnProduct.Button_WOC();
            this.StopButton = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // search_box_text
            // 
            resources.ApplyResources(this.search_box_text, "search_box_text");
            this.search_box_text.Name = "search_box_text";
            this.search_box_text.TextChanged += new System.EventHandler(this.search_box_text_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // dataGridView2
            // 
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Salmon;
            this.StartButton.BorderColor = System.Drawing.SystemColors.Highlight;
            this.StartButton.ButtonColor = System.Drawing.SystemColors.Highlight;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.StartButton.Name = "StartButton";
            this.StartButton.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.StartButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.StartButton.OnHoverTextColor = System.Drawing.Color.White;
            this.StartButton.TextColor = System.Drawing.Color.White;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // export_Button
            // 
            resources.ApplyResources(this.export_Button, "export_Button");
            this.export_Button.BorderColor = System.Drawing.SystemColors.Highlight;
            this.export_Button.ButtonColor = System.Drawing.SystemColors.Highlight;
            this.export_Button.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.export_Button.FlatAppearance.BorderSize = 0;
            this.export_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Brown;
            this.export_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.export_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.export_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.export_Button.Name = "export_Button";
            this.export_Button.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.export_Button.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.export_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.export_Button.TextColor = System.Drawing.Color.White;
            this.export_Button.UseVisualStyleBackColor = true;
            this.export_Button.Click += new System.EventHandler(this.export_Button_Click);
            // 
            // ClearDataButton
            // 
            this.ClearDataButton.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ClearDataButton.ButtonColor = System.Drawing.SystemColors.Highlight;
            this.ClearDataButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.ClearDataButton.FlatAppearance.BorderSize = 0;
            this.ClearDataButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Brown;
            this.ClearDataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.ClearDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.ClearDataButton, "ClearDataButton");
            this.ClearDataButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ClearDataButton.Name = "ClearDataButton";
            this.ClearDataButton.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.ClearDataButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.ClearDataButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ClearDataButton.TextColor = System.Drawing.Color.White;
            this.ClearDataButton.UseVisualStyleBackColor = true;
            this.ClearDataButton.Click += new System.EventHandler(this.ClearDataButton_Click);
            // 
            // ShowHideButton
            // 
            this.ShowHideButton.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ShowHideButton.ButtonColor = System.Drawing.SystemColors.Highlight;
            this.ShowHideButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.ShowHideButton.FlatAppearance.BorderSize = 0;
            this.ShowHideButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Brown;
            this.ShowHideButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.ShowHideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.ShowHideButton, "ShowHideButton");
            this.ShowHideButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ShowHideButton.Name = "ShowHideButton";
            this.ShowHideButton.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.ShowHideButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.ShowHideButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ShowHideButton.TextColor = System.Drawing.Color.White;
            this.ShowHideButton.UseVisualStyleBackColor = true;
            this.ShowHideButton.Click += new System.EventHandler(this.ShowHideButton_Click);
            // 
            // UpdataDataButton
            // 
            this.UpdataDataButton.BorderColor = System.Drawing.SystemColors.Highlight;
            this.UpdataDataButton.ButtonColor = System.Drawing.SystemColors.Highlight;
            this.UpdataDataButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.UpdataDataButton.FlatAppearance.BorderSize = 0;
            this.UpdataDataButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Brown;
            this.UpdataDataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.UpdataDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.UpdataDataButton, "UpdataDataButton");
            this.UpdataDataButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UpdataDataButton.Name = "UpdataDataButton";
            this.UpdataDataButton.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.UpdataDataButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.UpdataDataButton.OnHoverTextColor = System.Drawing.Color.White;
            this.UpdataDataButton.TextColor = System.Drawing.Color.White;
            this.UpdataDataButton.UseVisualStyleBackColor = true;
            this.UpdataDataButton.Click += new System.EventHandler(this.UpdataDataButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BorderColor = System.Drawing.SystemColors.Highlight;
            this.StopButton.ButtonColor = System.Drawing.SystemColors.Highlight;
            this.StopButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.StopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.StopButton, "StopButton");
            this.StopButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.StopButton.Name = "StopButton";
            this.StopButton.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.StopButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.StopButton.OnHoverTextColor = System.Drawing.Color.White;
            this.StopButton.TextColor = System.Drawing.Color.White;
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.export_Button);
            this.Controls.Add(this.ClearDataButton);
            this.Controls.Add(this.ShowHideButton);
            this.Controls.Add(this.UpdataDataButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_box_text);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox search_box_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ePOSOne.btnProduct.Button_WOC StopButton;
        private ePOSOne.btnProduct.Button_WOC UpdataDataButton;
        private ePOSOne.btnProduct.Button_WOC ShowHideButton;
        private ePOSOne.btnProduct.Button_WOC ClearDataButton;
        private ePOSOne.btnProduct.Button_WOC export_Button;
        private ePOSOne.btnProduct.Button_WOC StartButton;
    }
}

