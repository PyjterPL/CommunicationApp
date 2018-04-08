namespace CommunicationApp
{
    partial class controlPanelForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnScan = new System.Windows.Forms.Button();
            this.btnMoveTo = new System.Windows.Forms.Button();
            this.btnProduce = new System.Windows.Forms.Button();
            this.btnHarvest = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.radioButtonSimulation = new System.Windows.Forms.RadioButton();
            this.radioButtonChaarr = new System.Windows.Forms.RadioButton();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(276, 14);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnMoveTo
            // 
            this.btnMoveTo.Location = new System.Drawing.Point(276, 43);
            this.btnMoveTo.Name = "btnMoveTo";
            this.btnMoveTo.Size = new System.Drawing.Size(75, 23);
            this.btnMoveTo.TabIndex = 1;
            this.btnMoveTo.Text = "Move To";
            this.btnMoveTo.UseVisualStyleBackColor = true;
            this.btnMoveTo.Click += new System.EventHandler(this.btnMoveTo_Click);
            // 
            // btnProduce
            // 
            this.btnProduce.Location = new System.Drawing.Point(276, 72);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Size = new System.Drawing.Size(75, 23);
            this.btnProduce.TabIndex = 2;
            this.btnProduce.Text = "Produce";
            this.btnProduce.UseVisualStyleBackColor = true;
            this.btnProduce.Click += new System.EventHandler(this.btnProduce_Click);
            // 
            // btnHarvest
            // 
            this.btnHarvest.Location = new System.Drawing.Point(276, 101);
            this.btnHarvest.Name = "btnHarvest";
            this.btnHarvest.Size = new System.Drawing.Size(75, 23);
            this.btnHarvest.TabIndex = 3;
            this.btnHarvest.Text = "Harvest";
            this.btnHarvest.UseVisualStyleBackColor = true;
            this.btnHarvest.Click += new System.EventHandler(this.btnHarvest_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Location = new System.Drawing.Point(276, 130);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(75, 23);
            this.btnRepair.TabIndex = 4;
            this.btnRepair.Text = "Repair";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(276, 159);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // radioButtonSimulation
            // 
            this.radioButtonSimulation.AutoSize = true;
            this.radioButtonSimulation.Location = new System.Drawing.Point(13, 14);
            this.radioButtonSimulation.Name = "radioButtonSimulation";
            this.radioButtonSimulation.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSimulation.TabIndex = 6;
            this.radioButtonSimulation.TabStop = true;
            this.radioButtonSimulation.Text = "Simulation";
            this.radioButtonSimulation.UseVisualStyleBackColor = true;
            this.radioButtonSimulation.CheckedChanged += new System.EventHandler(this.radioButtonSimulation_CheckedChanged);
            // 
            // radioButtonChaarr
            // 
            this.radioButtonChaarr.AutoSize = true;
            this.radioButtonChaarr.Location = new System.Drawing.Point(13, 38);
            this.radioButtonChaarr.Name = "radioButtonChaarr";
            this.radioButtonChaarr.Size = new System.Drawing.Size(56, 17);
            this.radioButtonChaarr.TabIndex = 7;
            this.radioButtonChaarr.TabStop = true;
            this.radioButtonChaarr.Text = "Chaarr";
            this.radioButtonChaarr.UseVisualStyleBackColor = true;
            this.radioButtonChaarr.CheckedChanged += new System.EventHandler(this.radioButtonChaarr_CheckedChanged);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(276, 188);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 8;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(276, 218);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Location = new System.Drawing.Point(13, 62);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.ReadOnly = true;
            this.richTextBoxStatus.Size = new System.Drawing.Size(257, 179);
            this.richTextBoxStatus.TabIndex = 10;
            this.richTextBoxStatus.Text = "";
            // 
            // controlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 255);
            this.Controls.Add(this.richTextBoxStatus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.radioButtonChaarr);
            this.Controls.Add(this.radioButtonSimulation);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.btnHarvest);
            this.Controls.Add(this.btnProduce);
            this.Controls.Add(this.btnMoveTo);
            this.Controls.Add(this.btnScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "controlPanelForm";
            this.Text = "Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.controlPanelForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnMoveTo;
        private System.Windows.Forms.Button btnProduce;
        private System.Windows.Forms.Button btnHarvest;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.RadioButton radioButtonSimulation;
        private System.Windows.Forms.RadioButton radioButtonChaarr;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
    }
}

