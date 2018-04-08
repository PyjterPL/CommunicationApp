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
            this.richTextBoxAllEvents = new System.Windows.Forms.RichTextBox();
            this.richTextBoxActions = new System.Windows.Forms.RichTextBox();
            this.lblActions = new System.Windows.Forms.Label();
            this.richTextBoxParameters = new System.Windows.Forms.RichTextBox();
            this.labelParameters = new System.Windows.Forms.Label();
            this.richTextBoxScores = new System.Windows.Forms.RichTextBox();
            this.labelScores = new System.Windows.Forms.Label();
            this.richTextBoxEquipments = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLastTurnEvents = new System.Windows.Forms.RichTextBox();
            this.labelEquipments = new System.Windows.Forms.Label();
            this.labelLastTurnEvents = new System.Windows.Forms.Label();
            this.labelTurn = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelTerminated = new System.Windows.Forms.Label();
            this.buttonShowFullResponse = new System.Windows.Forms.Button();
            this.labelAllEvents = new System.Windows.Forms.Label();
            this.labelLogBook = new System.Windows.Forms.Label();
            this.richTextBoxLogBook = new System.Windows.Forms.RichTextBox();
            this.checkBoxShowImportantOnly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(636, 42);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnMoveTo
            // 
            this.btnMoveTo.Location = new System.Drawing.Point(636, 71);
            this.btnMoveTo.Name = "btnMoveTo";
            this.btnMoveTo.Size = new System.Drawing.Size(75, 23);
            this.btnMoveTo.TabIndex = 1;
            this.btnMoveTo.Text = "Move To";
            this.btnMoveTo.UseVisualStyleBackColor = true;
            this.btnMoveTo.Click += new System.EventHandler(this.btnMoveTo_Click);
            // 
            // btnProduce
            // 
            this.btnProduce.Location = new System.Drawing.Point(636, 100);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Size = new System.Drawing.Size(75, 23);
            this.btnProduce.TabIndex = 2;
            this.btnProduce.Text = "Produce";
            this.btnProduce.UseVisualStyleBackColor = true;
            this.btnProduce.Click += new System.EventHandler(this.btnProduce_Click);
            // 
            // btnHarvest
            // 
            this.btnHarvest.Location = new System.Drawing.Point(636, 129);
            this.btnHarvest.Name = "btnHarvest";
            this.btnHarvest.Size = new System.Drawing.Size(75, 23);
            this.btnHarvest.TabIndex = 3;
            this.btnHarvest.Text = "Harvest";
            this.btnHarvest.UseVisualStyleBackColor = true;
            this.btnHarvest.Click += new System.EventHandler(this.btnHarvest_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Location = new System.Drawing.Point(636, 158);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(75, 23);
            this.btnRepair.TabIndex = 4;
            this.btnRepair.Text = "Repair";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(636, 187);
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
            this.radioButtonSimulation.Location = new System.Drawing.Point(577, 12);
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
            this.radioButtonChaarr.Location = new System.Drawing.Point(656, 12);
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
            this.btnStatus.Location = new System.Drawing.Point(636, 216);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 8;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(636, 633);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // richTextBoxAllEvents
            // 
            this.richTextBoxAllEvents.Location = new System.Drawing.Point(214, 87);
            this.richTextBoxAllEvents.Name = "richTextBoxAllEvents";
            this.richTextBoxAllEvents.ReadOnly = true;
            this.richTextBoxAllEvents.Size = new System.Drawing.Size(194, 186);
            this.richTextBoxAllEvents.TabIndex = 10;
            this.richTextBoxAllEvents.Text = "";
            // 
            // richTextBoxActions
            // 
            this.richTextBoxActions.Location = new System.Drawing.Point(15, 87);
            this.richTextBoxActions.Name = "richTextBoxActions";
            this.richTextBoxActions.ReadOnly = true;
            this.richTextBoxActions.Size = new System.Drawing.Size(192, 186);
            this.richTextBoxActions.TabIndex = 11;
            this.richTextBoxActions.Text = "";
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Location = new System.Drawing.Point(12, 71);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(45, 13);
            this.lblActions.TabIndex = 12;
            this.lblActions.Text = "Actions:";
            // 
            // richTextBoxParameters
            // 
            this.richTextBoxParameters.Location = new System.Drawing.Point(15, 301);
            this.richTextBoxParameters.Name = "richTextBoxParameters";
            this.richTextBoxParameters.ReadOnly = true;
            this.richTextBoxParameters.Size = new System.Drawing.Size(194, 186);
            this.richTextBoxParameters.TabIndex = 13;
            this.richTextBoxParameters.Text = "";
            // 
            // labelParameters
            // 
            this.labelParameters.AutoSize = true;
            this.labelParameters.Location = new System.Drawing.Point(12, 285);
            this.labelParameters.Name = "labelParameters";
            this.labelParameters.Size = new System.Drawing.Size(63, 13);
            this.labelParameters.TabIndex = 14;
            this.labelParameters.Text = "Parameters:";
            // 
            // richTextBoxScores
            // 
            this.richTextBoxScores.Location = new System.Drawing.Point(216, 301);
            this.richTextBoxScores.Name = "richTextBoxScores";
            this.richTextBoxScores.ReadOnly = true;
            this.richTextBoxScores.Size = new System.Drawing.Size(194, 186);
            this.richTextBoxScores.TabIndex = 15;
            this.richTextBoxScores.Text = "";
            // 
            // labelScores
            // 
            this.labelScores.AutoSize = true;
            this.labelScores.Location = new System.Drawing.Point(213, 285);
            this.labelScores.Name = "labelScores";
            this.labelScores.Size = new System.Drawing.Size(43, 13);
            this.labelScores.TabIndex = 16;
            this.labelScores.Text = "Scores:";
            // 
            // richTextBoxEquipments
            // 
            this.richTextBoxEquipments.Location = new System.Drawing.Point(416, 301);
            this.richTextBoxEquipments.Name = "richTextBoxEquipments";
            this.richTextBoxEquipments.ReadOnly = true;
            this.richTextBoxEquipments.Size = new System.Drawing.Size(194, 186);
            this.richTextBoxEquipments.TabIndex = 17;
            this.richTextBoxEquipments.Text = "";
            // 
            // richTextBoxLastTurnEvents
            // 
            this.richTextBoxLastTurnEvents.Location = new System.Drawing.Point(414, 87);
            this.richTextBoxLastTurnEvents.Name = "richTextBoxLastTurnEvents";
            this.richTextBoxLastTurnEvents.ReadOnly = true;
            this.richTextBoxLastTurnEvents.Size = new System.Drawing.Size(194, 186);
            this.richTextBoxLastTurnEvents.TabIndex = 18;
            this.richTextBoxLastTurnEvents.Text = "";
            // 
            // labelEquipments
            // 
            this.labelEquipments.AutoSize = true;
            this.labelEquipments.Location = new System.Drawing.Point(413, 285);
            this.labelEquipments.Name = "labelEquipments";
            this.labelEquipments.Size = new System.Drawing.Size(65, 13);
            this.labelEquipments.TabIndex = 19;
            this.labelEquipments.Text = "Equipments:";
            // 
            // labelLastTurnEvents
            // 
            this.labelLastTurnEvents.AutoSize = true;
            this.labelLastTurnEvents.Location = new System.Drawing.Point(411, 71);
            this.labelLastTurnEvents.Name = "labelLastTurnEvents";
            this.labelLastTurnEvents.Size = new System.Drawing.Size(86, 13);
            this.labelLastTurnEvents.TabIndex = 20;
            this.labelLastTurnEvents.Text = "Last turn events:";
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Location = new System.Drawing.Point(12, 9);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(35, 13);
            this.labelTurn.TabIndex = 21;
            this.labelTurn.Text = "Turn: ";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(12, 29);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(54, 13);
            this.labelLocation.TabIndex = 22;
            this.labelLocation.Text = "Location: ";
            // 
            // labelTerminated
            // 
            this.labelTerminated.AutoSize = true;
            this.labelTerminated.Location = new System.Drawing.Point(12, 47);
            this.labelTerminated.Name = "labelTerminated";
            this.labelTerminated.Size = new System.Drawing.Size(73, 13);
            this.labelTerminated.TabIndex = 23;
            this.labelTerminated.Text = "Is terminated: ";
            // 
            // buttonShowFullResponse
            // 
            this.buttonShowFullResponse.Location = new System.Drawing.Point(636, 245);
            this.buttonShowFullResponse.Name = "buttonShowFullResponse";
            this.buttonShowFullResponse.Size = new System.Drawing.Size(76, 23);
            this.buttonShowFullResponse.TabIndex = 24;
            this.buttonShowFullResponse.Text = "Show all";
            this.buttonShowFullResponse.UseVisualStyleBackColor = true;
            this.buttonShowFullResponse.Click += new System.EventHandler(this.buttonShowFullResponse_Click);
            // 
            // labelAllEvents
            // 
            this.labelAllEvents.AutoSize = true;
            this.labelAllEvents.Location = new System.Drawing.Point(211, 71);
            this.labelAllEvents.Name = "labelAllEvents";
            this.labelAllEvents.Size = new System.Drawing.Size(56, 13);
            this.labelAllEvents.TabIndex = 25;
            this.labelAllEvents.Text = "All events:";
            // 
            // labelLogBook
            // 
            this.labelLogBook.AutoSize = true;
            this.labelLogBook.Location = new System.Drawing.Point(12, 495);
            this.labelLogBook.Name = "labelLogBook";
            this.labelLogBook.Size = new System.Drawing.Size(55, 13);
            this.labelLogBook.TabIndex = 26;
            this.labelLogBook.Text = "Log book:";
            // 
            // richTextBoxLogBook
            // 
            this.richTextBoxLogBook.Location = new System.Drawing.Point(14, 511);
            this.richTextBoxLogBook.Name = "richTextBoxLogBook";
            this.richTextBoxLogBook.ReadOnly = true;
            this.richTextBoxLogBook.Size = new System.Drawing.Size(596, 145);
            this.richTextBoxLogBook.TabIndex = 27;
            this.richTextBoxLogBook.Text = "";
            // 
            // checkBoxShowImportantOnly
            // 
            this.checkBoxShowImportantOnly.AutoSize = true;
            this.checkBoxShowImportantOnly.Location = new System.Drawing.Point(414, 12);
            this.checkBoxShowImportantOnly.Name = "checkBoxShowImportantOnly";
            this.checkBoxShowImportantOnly.Size = new System.Drawing.Size(156, 17);
            this.checkBoxShowImportantOnly.TabIndex = 28;
            this.checkBoxShowImportantOnly.Text = "Show only important events";
            this.checkBoxShowImportantOnly.UseVisualStyleBackColor = true;
            this.checkBoxShowImportantOnly.CheckedChanged += new System.EventHandler(this.checkBoxShowImportantOnly_CheckedChanged);
            // 
            // controlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 678);
            this.Controls.Add(this.checkBoxShowImportantOnly);
            this.Controls.Add(this.richTextBoxLogBook);
            this.Controls.Add(this.labelLogBook);
            this.Controls.Add(this.labelAllEvents);
            this.Controls.Add(this.buttonShowFullResponse);
            this.Controls.Add(this.labelTerminated);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.labelLastTurnEvents);
            this.Controls.Add(this.labelEquipments);
            this.Controls.Add(this.richTextBoxLastTurnEvents);
            this.Controls.Add(this.richTextBoxEquipments);
            this.Controls.Add(this.labelScores);
            this.Controls.Add(this.richTextBoxScores);
            this.Controls.Add(this.labelParameters);
            this.Controls.Add(this.richTextBoxParameters);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.richTextBoxActions);
            this.Controls.Add(this.richTextBoxAllEvents);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.RichTextBox richTextBoxAllEvents;
        private System.Windows.Forms.RichTextBox richTextBoxActions;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.RichTextBox richTextBoxParameters;
        private System.Windows.Forms.Label labelParameters;
        private System.Windows.Forms.RichTextBox richTextBoxScores;
        private System.Windows.Forms.Label labelScores;
        private System.Windows.Forms.RichTextBox richTextBoxEquipments;
        private System.Windows.Forms.RichTextBox richTextBoxLastTurnEvents;
        private System.Windows.Forms.Label labelEquipments;
        private System.Windows.Forms.Label labelLastTurnEvents;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelTerminated;
        private System.Windows.Forms.Button buttonShowFullResponse;
        private System.Windows.Forms.Label labelAllEvents;
        private System.Windows.Forms.Label labelLogBook;
        private System.Windows.Forms.RichTextBox richTextBoxLogBook;
        private System.Windows.Forms.CheckBox checkBoxShowImportantOnly;
    }
}

