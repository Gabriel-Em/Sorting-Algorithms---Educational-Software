namespace Sorting_Algorithms
{
    partial class GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelInterfata = new System.Windows.Forms.Panel();
            this.variableDataGridView = new System.Windows.Forms.DataGridView();
            this.Variabila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGenerateRandomList = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.lblStepsTitle = new System.Windows.Forms.Label();
            this.btnNewList = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelExplanation = new System.Windows.Forms.Panel();
            this.rchExplanation = new System.Windows.Forms.RichTextBox();
            this.panelCode = new System.Windows.Forms.Panel();
            this.rchCode = new System.Windows.Forms.RichTextBox();
            this.panelAnimation = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panelInterfata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variableDataGridView)).BeginInit();
            this.panelControls.SuspendLayout();
            this.panelExplanation.SuspendLayout();
            this.panelCode.SuspendLayout();
            this.panelAnimation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInterfata
            // 
            this.panelInterfata.BackColor = System.Drawing.Color.Black;
            this.panelInterfata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInterfata.Controls.Add(this.variableDataGridView);
            this.panelInterfata.Controls.Add(this.panelControls);
            this.panelInterfata.Controls.Add(this.panelExplanation);
            this.panelInterfata.Controls.Add(this.panelCode);
            this.panelInterfata.Controls.Add(this.panelAnimation);
            this.panelInterfata.Location = new System.Drawing.Point(12, 12);
            this.panelInterfata.Name = "panelInterfata";
            this.panelInterfata.Size = new System.Drawing.Size(1122, 526);
            this.panelInterfata.TabIndex = 0;
            // 
            // variableDataGridView
            // 
            this.variableDataGridView.AllowUserToAddRows = false;
            this.variableDataGridView.AllowUserToDeleteRows = false;
            this.variableDataGridView.AllowUserToResizeColumns = false;
            this.variableDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            this.variableDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.variableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.variableDataGridView.BackgroundColor = System.Drawing.Color.GreenYellow;
            this.variableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.variableDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.variableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.variableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.variableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Variabila,
            this.Valoare});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.variableDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.variableDataGridView.EnableHeadersVisualStyles = false;
            this.variableDataGridView.GridColor = System.Drawing.Color.Black;
            this.variableDataGridView.Location = new System.Drawing.Point(592, 5);
            this.variableDataGridView.Name = "variableDataGridView";
            this.variableDataGridView.ReadOnly = true;
            this.variableDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.variableDataGridView.RowHeadersVisible = false;
            this.variableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.variableDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.variableDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.variableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.variableDataGridView.Size = new System.Drawing.Size(143, 362);
            this.variableDataGridView.TabIndex = 1;
            // 
            // Variabila
            // 
            this.Variabila.HeaderText = "Variabila";
            this.Variabila.Name = "Variabila";
            this.Variabila.ReadOnly = true;
            this.Variabila.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Valoare
            // 
            this.Valoare.HeaderText = "Valoare";
            this.Valoare.Name = "Valoare";
            this.Valoare.ReadOnly = true;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.GreenYellow;
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControls.Controls.Add(this.btnSave);
            this.panelControls.Controls.Add(this.btnGenerateRandomList);
            this.panelControls.Controls.Add(this.btnModify);
            this.panelControls.Controls.Add(this.txtList);
            this.panelControls.Controls.Add(this.lblStepsTitle);
            this.panelControls.Controls.Add(this.btnNewList);
            this.panelControls.Controls.Add(this.lblListTitle);
            this.panelControls.Controls.Add(this.btnPrevious);
            this.panelControls.Controls.Add(this.btnNext);
            this.panelControls.Location = new System.Drawing.Point(739, 371);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(377, 149);
            this.panelControls.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Location = new System.Drawing.Point(176, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 35);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Salveaza";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGenerateRandomList
            // 
            this.btnGenerateRandomList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnGenerateRandomList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateRandomList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateRandomList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRandomList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerateRandomList.Location = new System.Drawing.Point(253, 38);
            this.btnGenerateRandomList.Name = "btnGenerateRandomList";
            this.btnGenerateRandomList.Size = new System.Drawing.Size(115, 35);
            this.btnGenerateRandomList.TabIndex = 19;
            this.btnGenerateRandomList.Text = "Genereaza lista random";
            this.btnGenerateRandomList.UseVisualStyleBackColor = false;
            this.btnGenerateRandomList.Click += new System.EventHandler(this.btnGenerateRandomList_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Enabled = false;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModify.Location = new System.Drawing.Point(99, 38);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(72, 35);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "Modifica";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtList
            // 
            this.txtList.Enabled = false;
            this.txtList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtList.Location = new System.Drawing.Point(52, 6);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(316, 25);
            this.txtList.TabIndex = 17;
            // 
            // lblStepsTitle
            // 
            this.lblStepsTitle.AutoSize = true;
            this.lblStepsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepsTitle.Location = new System.Drawing.Point(3, 78);
            this.lblStepsTitle.Name = "lblStepsTitle";
            this.lblStepsTitle.Size = new System.Drawing.Size(219, 21);
            this.lblStepsTitle.TabIndex = 16;
            this.lblStepsTitle.Text = "Etape desfasurare algoritm:";
            // 
            // btnNewList
            // 
            this.btnNewList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnNewList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewList.Location = new System.Drawing.Point(5, 38);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(88, 35);
            this.btnNewList.TabIndex = 12;
            this.btnNewList.Text = "Lista noua";
            this.btnNewList.UseVisualStyleBackColor = false;
            this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListTitle.Location = new System.Drawing.Point(2, 8);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(49, 21);
            this.lblListTitle.TabIndex = 10;
            this.lblListTitle.Text = "Lista:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrevious.Location = new System.Drawing.Point(6, 104);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(178, 35);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "<< pasul anterior <<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNext.Location = new System.Drawing.Point(190, 104);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(178, 35);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">> pasul urmator >>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelExplanation
            // 
            this.panelExplanation.BackColor = System.Drawing.Color.GreenYellow;
            this.panelExplanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExplanation.Controls.Add(this.rchExplanation);
            this.panelExplanation.Location = new System.Drawing.Point(4, 371);
            this.panelExplanation.Name = "panelExplanation";
            this.panelExplanation.Size = new System.Drawing.Size(732, 149);
            this.panelExplanation.TabIndex = 2;
            // 
            // rchExplanation
            // 
            this.rchExplanation.BackColor = System.Drawing.Color.Azure;
            this.rchExplanation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchExplanation.Location = new System.Drawing.Point(3, 3);
            this.rchExplanation.Name = "rchExplanation";
            this.rchExplanation.ReadOnly = true;
            this.rchExplanation.Size = new System.Drawing.Size(725, 141);
            this.rchExplanation.TabIndex = 1;
            this.rchExplanation.Text = "";
            // 
            // panelCode
            // 
            this.panelCode.BackColor = System.Drawing.Color.GreenYellow;
            this.panelCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCode.Controls.Add(this.rchCode);
            this.panelCode.Location = new System.Drawing.Point(739, 4);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(377, 363);
            this.panelCode.TabIndex = 1;
            // 
            // rchCode
            // 
            this.rchCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.rchCode.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchCode.ForeColor = System.Drawing.Color.White;
            this.rchCode.Location = new System.Drawing.Point(3, 3);
            this.rchCode.Name = "rchCode";
            this.rchCode.ReadOnly = true;
            this.rchCode.Size = new System.Drawing.Size(369, 355);
            this.rchCode.TabIndex = 0;
            this.rchCode.Text = "";
            // 
            // panelAnimation
            // 
            this.panelAnimation.BackColor = System.Drawing.Color.GreenYellow;
            this.panelAnimation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAnimation.Controls.Add(this.labelTitle);
            this.panelAnimation.Location = new System.Drawing.Point(4, 4);
            this.panelAnimation.Name = "panelAnimation";
            this.panelAnimation.Size = new System.Drawing.Size(584, 363);
            this.panelAnimation.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(209, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 37);
            this.labelTitle.TabIndex = 11;
            // 
            // btnBubble
            // 
            this.btnBubble.BackColor = System.Drawing.Color.Green;
            this.btnBubble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBubble.Enabled = false;
            this.btnBubble.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBubble.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubble.ForeColor = System.Drawing.Color.Azure;
            this.btnBubble.Location = new System.Drawing.Point(12, 544);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(150, 35);
            this.btnBubble.TabIndex = 1;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.UseVisualStyleBackColor = false;
            this.btnBubble.Click += new System.EventHandler(this.btnPickAlgorithm);
            // 
            // btnInsertion
            // 
            this.btnInsertion.BackColor = System.Drawing.Color.Green;
            this.btnInsertion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertion.Enabled = false;
            this.btnInsertion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertion.ForeColor = System.Drawing.Color.Azure;
            this.btnInsertion.Location = new System.Drawing.Point(168, 544);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(150, 35);
            this.btnInsertion.TabIndex = 2;
            this.btnInsertion.Text = "Insertion Sort";
            this.btnInsertion.UseVisualStyleBackColor = false;
            this.btnInsertion.Click += new System.EventHandler(this.btnPickAlgorithm);
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.Green;
            this.btnSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelection.Enabled = false;
            this.btnSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelection.ForeColor = System.Drawing.Color.Azure;
            this.btnSelection.Location = new System.Drawing.Point(324, 544);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(150, 35);
            this.btnSelection.TabIndex = 3;
            this.btnSelection.Text = "Selection Sort";
            this.btnSelection.UseVisualStyleBackColor = false;
            this.btnSelection.Click += new System.EventHandler(this.btnPickAlgorithm);
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.Green;
            this.btnCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCount.Enabled = false;
            this.btnCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.ForeColor = System.Drawing.Color.Azure;
            this.btnCount.Location = new System.Drawing.Point(480, 544);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(150, 35);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Count Sort";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnPickAlgorithm);
            // 
            // btnMerge
            // 
            this.btnMerge.BackColor = System.Drawing.Color.Green;
            this.btnMerge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMerge.Enabled = false;
            this.btnMerge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMerge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.ForeColor = System.Drawing.Color.Azure;
            this.btnMerge.Location = new System.Drawing.Point(636, 544);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(150, 35);
            this.btnMerge.TabIndex = 5;
            this.btnMerge.Text = "Merge Sort";
            this.btnMerge.UseVisualStyleBackColor = false;
            this.btnMerge.Click += new System.EventHandler(this.btnPickAlgorithm);
            // 
            // btnQuick
            // 
            this.btnQuick.BackColor = System.Drawing.Color.Green;
            this.btnQuick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuick.Enabled = false;
            this.btnQuick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuick.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuick.ForeColor = System.Drawing.Color.Azure;
            this.btnQuick.Location = new System.Drawing.Point(792, 544);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(150, 35);
            this.btnQuick.TabIndex = 6;
            this.btnQuick.Text = "Quick Sort";
            this.btnQuick.UseVisualStyleBackColor = false;
            this.btnQuick.Click += new System.EventHandler(this.btnPickAlgorithm);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Azure;
            this.btnQuit.Location = new System.Drawing.Point(1015, 544);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(120, 35);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Iesire";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Maroon;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Azure;
            this.btnAbout.Location = new System.Drawing.Point(948, 544);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(61, 35);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "Depre";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1147, 586);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.panelInterfata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmi de sortare";
            this.panelInterfata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.variableDataGridView)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelExplanation.ResumeLayout(false);
            this.panelCode.ResumeLayout(false);
            this.panelAnimation.ResumeLayout(false);
            this.panelAnimation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInterfata;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Panel panelAnimation;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelExplanation;
        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.RichTextBox rchExplanation;
        private System.Windows.Forms.RichTextBox rchCode;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblStepsTitle;
        private System.Windows.Forms.Button btnNewList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView variableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variabila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoare;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGenerateRandomList;
        private System.Windows.Forms.Button btnAbout;
    }
}

