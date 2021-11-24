
namespace CustomerMaintenance
{
    partial class JobDetailsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label carNoLabel;
            System.Windows.Forms.Label jobDateLabel;
            System.Windows.Forms.Label workerIDLabel;
            System.Windows.Forms.Label kMsLabel;
            System.Windows.Forms.Label tuningLabel;
            System.Windows.Forms.Label alingnmentLabel;
            System.Windows.Forms.Label balancingLabel;
            System.Windows.Forms.Label tiersLabel;
            System.Windows.Forms.Label weightsLabel;
            System.Windows.Forms.Label oilChangedLabel;
            System.Windows.Forms.Label oilQtyLabel;
            System.Windows.Forms.Label oilFilterLabel;
            System.Windows.Forms.Label gearOilLabel;
            System.Windows.Forms.Label gearOilQtyLabel;
            System.Windows.Forms.Label pointLabel;
            System.Windows.Forms.Label condenserLabel;
            System.Windows.Forms.Label plugLabel;
            System.Windows.Forms.Label plugQtyLabel;
            System.Windows.Forms.Label fuelFilterLabel;
            System.Windows.Forms.Label airFIlterLabel;
            System.Windows.Forms.Label remarksLabel;
            this.dbCustomerDataSet = new CustomerMaintenance.dbCustomerDataSet();
            this.jobDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobDetailsTableAdapter = new CustomerMaintenance.dbCustomerDataSetTableAdapters.JobDetailsTableAdapter();
            this.tableAdapterManager1 = new CustomerMaintenance.dbCustomerDataSetTableAdapters.TableAdapterManager();
            this.carNoTextBox = new System.Windows.Forms.TextBox();
            this.jobDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workerIDTextBox = new System.Windows.Forms.TextBox();
            this.kMsTextBox = new System.Windows.Forms.TextBox();
            this.tuningTextBox = new System.Windows.Forms.TextBox();
            this.alingnmentTextBox = new System.Windows.Forms.TextBox();
            this.balancingTextBox = new System.Windows.Forms.TextBox();
            this.tiersTextBox = new System.Windows.Forms.TextBox();
            this.weightsTextBox = new System.Windows.Forms.TextBox();
            this.oilChangedTextBox = new System.Windows.Forms.TextBox();
            this.oilQtyTextBox = new System.Windows.Forms.TextBox();
            this.oilFilterTextBox = new System.Windows.Forms.TextBox();
            this.gearOilTextBox = new System.Windows.Forms.TextBox();
            this.gearOilQtyTextBox = new System.Windows.Forms.TextBox();
            this.pointTextBox = new System.Windows.Forms.TextBox();
            this.condenserTextBox = new System.Windows.Forms.TextBox();
            this.plugTextBox = new System.Windows.Forms.TextBox();
            this.plugQtyTextBox = new System.Windows.Forms.TextBox();
            this.fuelFilterTextBox = new System.Windows.Forms.TextBox();
            this.airFIlterTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMare = new System.Windows.Forms.Button();
            this.btnMareMare = new System.Windows.Forms.Button();
            this.btnMic = new System.Windows.Forms.Button();
            this.btnMicMIc = new System.Windows.Forms.Button();
            carNoLabel = new System.Windows.Forms.Label();
            jobDateLabel = new System.Windows.Forms.Label();
            workerIDLabel = new System.Windows.Forms.Label();
            kMsLabel = new System.Windows.Forms.Label();
            tuningLabel = new System.Windows.Forms.Label();
            alingnmentLabel = new System.Windows.Forms.Label();
            balancingLabel = new System.Windows.Forms.Label();
            tiersLabel = new System.Windows.Forms.Label();
            weightsLabel = new System.Windows.Forms.Label();
            oilChangedLabel = new System.Windows.Forms.Label();
            oilQtyLabel = new System.Windows.Forms.Label();
            oilFilterLabel = new System.Windows.Forms.Label();
            gearOilLabel = new System.Windows.Forms.Label();
            gearOilQtyLabel = new System.Windows.Forms.Label();
            pointLabel = new System.Windows.Forms.Label();
            condenserLabel = new System.Windows.Forms.Label();
            plugLabel = new System.Windows.Forms.Label();
            plugQtyLabel = new System.Windows.Forms.Label();
            fuelFilterLabel = new System.Windows.Forms.Label();
            airFIlterLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbCustomerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbCustomerDataSet
            // 
            this.dbCustomerDataSet.DataSetName = "dbCustomerDataSet";
            this.dbCustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobDetailsBindingSource
            // 
            this.jobDetailsBindingSource.DataMember = "JobDetails";
            this.jobDetailsBindingSource.DataSource = this.dbCustomerDataSet;
            // 
            // jobDetailsTableAdapter
            // 
            this.jobDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.JobDetailsTableAdapter = this.jobDetailsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = CustomerMaintenance.dbCustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.WorkerTableAdapter = null;
            // 
            // carNoLabel
            // 
            carNoLabel.AutoSize = true;
            carNoLabel.Location = new System.Drawing.Point(46, 29);
            carNoLabel.Name = "carNoLabel";
            carNoLabel.Size = new System.Drawing.Size(56, 17);
            carNoLabel.TabIndex = 0;
            carNoLabel.Text = "Car No:";
            // 
            // carNoTextBox
            // 
            this.carNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "CarNo", true));
            this.carNoTextBox.Location = new System.Drawing.Point(108, 29);
            this.carNoTextBox.Name = "carNoTextBox";
            this.carNoTextBox.Size = new System.Drawing.Size(200, 22);
            this.carNoTextBox.TabIndex = 1;
            // 
            // jobDateLabel
            // 
            jobDateLabel.AutoSize = true;
            jobDateLabel.Location = new System.Drawing.Point(426, 34);
            jobDateLabel.Name = "jobDateLabel";
            jobDateLabel.Size = new System.Drawing.Size(69, 17);
            jobDateLabel.TabIndex = 2;
            jobDateLabel.Text = "Job Date:";
            // 
            // jobDateDateTimePicker
            // 
            this.jobDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jobDetailsBindingSource, "JobDate", true));
            this.jobDateDateTimePicker.Location = new System.Drawing.Point(532, 27);
            this.jobDateDateTimePicker.Name = "jobDateDateTimePicker";
            this.jobDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.jobDateDateTimePicker.TabIndex = 3;
            // 
            // workerIDLabel
            // 
            workerIDLabel.AutoSize = true;
            workerIDLabel.Location = new System.Drawing.Point(27, 61);
            workerIDLabel.Name = "workerIDLabel";
            workerIDLabel.Size = new System.Drawing.Size(75, 17);
            workerIDLabel.TabIndex = 4;
            workerIDLabel.Text = "Worker ID:";
            // 
            // workerIDTextBox
            // 
            this.workerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "WorkerID", true));
            this.workerIDTextBox.Location = new System.Drawing.Point(108, 58);
            this.workerIDTextBox.Name = "workerIDTextBox";
            this.workerIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.workerIDTextBox.TabIndex = 5;
            // 
            // kMsLabel
            // 
            kMsLabel.AutoSize = true;
            kMsLabel.Location = new System.Drawing.Point(426, 61);
            kMsLabel.Name = "kMsLabel";
            kMsLabel.Size = new System.Drawing.Size(39, 17);
            kMsLabel.TabIndex = 6;
            kMsLabel.Text = "KMs:";
            // 
            // kMsTextBox
            // 
            this.kMsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "KMs", true));
            this.kMsTextBox.Location = new System.Drawing.Point(532, 58);
            this.kMsTextBox.Name = "kMsTextBox";
            this.kMsTextBox.Size = new System.Drawing.Size(200, 22);
            this.kMsTextBox.TabIndex = 7;
            // 
            // tuningLabel
            // 
            tuningLabel.AutoSize = true;
            tuningLabel.Location = new System.Drawing.Point(46, 99);
            tuningLabel.Name = "tuningLabel";
            tuningLabel.Size = new System.Drawing.Size(56, 17);
            tuningLabel.TabIndex = 8;
            tuningLabel.Text = "Tuning:";
            // 
            // tuningTextBox
            // 
            this.tuningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Tuning", true));
            this.tuningTextBox.Location = new System.Drawing.Point(108, 99);
            this.tuningTextBox.Name = "tuningTextBox";
            this.tuningTextBox.Size = new System.Drawing.Size(200, 22);
            this.tuningTextBox.TabIndex = 9;
            // 
            // alingnmentLabel
            // 
            alingnmentLabel.AutoSize = true;
            alingnmentLabel.Location = new System.Drawing.Point(424, 99);
            alingnmentLabel.Name = "alingnmentLabel";
            alingnmentLabel.Size = new System.Drawing.Size(82, 17);
            alingnmentLabel.TabIndex = 10;
            alingnmentLabel.Text = "Alingnment:";
            // 
            // alingnmentTextBox
            // 
            this.alingnmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Alingnment", true));
            this.alingnmentTextBox.Location = new System.Drawing.Point(532, 99);
            this.alingnmentTextBox.Name = "alingnmentTextBox";
            this.alingnmentTextBox.Size = new System.Drawing.Size(200, 22);
            this.alingnmentTextBox.TabIndex = 11;
            // 
            // balancingLabel
            // 
            balancingLabel.AutoSize = true;
            balancingLabel.Location = new System.Drawing.Point(28, 136);
            balancingLabel.Name = "balancingLabel";
            balancingLabel.Size = new System.Drawing.Size(74, 17);
            balancingLabel.TabIndex = 12;
            balancingLabel.Text = "Balancing:";
            // 
            // balancingTextBox
            // 
            this.balancingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Balancing", true));
            this.balancingTextBox.Location = new System.Drawing.Point(108, 136);
            this.balancingTextBox.Name = "balancingTextBox";
            this.balancingTextBox.Size = new System.Drawing.Size(200, 22);
            this.balancingTextBox.TabIndex = 13;
            // 
            // tiersLabel
            // 
            tiersLabel.AutoSize = true;
            tiersLabel.Location = new System.Drawing.Point(426, 136);
            tiersLabel.Name = "tiersLabel";
            tiersLabel.Size = new System.Drawing.Size(44, 17);
            tiersLabel.TabIndex = 14;
            tiersLabel.Text = "Tiers:";
            // 
            // tiersTextBox
            // 
            this.tiersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Tiers", true));
            this.tiersTextBox.Location = new System.Drawing.Point(532, 133);
            this.tiersTextBox.Name = "tiersTextBox";
            this.tiersTextBox.Size = new System.Drawing.Size(200, 22);
            this.tiersTextBox.TabIndex = 15;
            // 
            // weightsLabel
            // 
            weightsLabel.AutoSize = true;
            weightsLabel.Location = new System.Drawing.Point(39, 179);
            weightsLabel.Name = "weightsLabel";
            weightsLabel.Size = new System.Drawing.Size(63, 17);
            weightsLabel.TabIndex = 16;
            weightsLabel.Text = "Weights:";
            // 
            // weightsTextBox
            // 
            this.weightsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Weights", true));
            this.weightsTextBox.Location = new System.Drawing.Point(108, 174);
            this.weightsTextBox.Name = "weightsTextBox";
            this.weightsTextBox.Size = new System.Drawing.Size(200, 22);
            this.weightsTextBox.TabIndex = 17;
            // 
            // oilChangedLabel
            // 
            oilChangedLabel.AutoSize = true;
            oilChangedLabel.Location = new System.Drawing.Point(426, 174);
            oilChangedLabel.Name = "oilChangedLabel";
            oilChangedLabel.Size = new System.Drawing.Size(90, 17);
            oilChangedLabel.TabIndex = 18;
            oilChangedLabel.Text = "Oil Changed:";
            // 
            // oilChangedTextBox
            // 
            this.oilChangedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "OilChanged", true));
            this.oilChangedTextBox.Location = new System.Drawing.Point(532, 171);
            this.oilChangedTextBox.Name = "oilChangedTextBox";
            this.oilChangedTextBox.Size = new System.Drawing.Size(200, 22);
            this.oilChangedTextBox.TabIndex = 19;
            // 
            // oilQtyLabel
            // 
            oilQtyLabel.AutoSize = true;
            oilQtyLabel.Location = new System.Drawing.Point(47, 215);
            oilQtyLabel.Name = "oilQtyLabel";
            oilQtyLabel.Size = new System.Drawing.Size(55, 17);
            oilQtyLabel.TabIndex = 20;
            oilQtyLabel.Text = "Oil Qty:";
            // 
            // oilQtyTextBox
            // 
            this.oilQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "OilQty", true));
            this.oilQtyTextBox.Location = new System.Drawing.Point(108, 212);
            this.oilQtyTextBox.Name = "oilQtyTextBox";
            this.oilQtyTextBox.Size = new System.Drawing.Size(200, 22);
            this.oilQtyTextBox.TabIndex = 21;
            // 
            // oilFilterLabel
            // 
            oilFilterLabel.AutoSize = true;
            oilFilterLabel.Location = new System.Drawing.Point(424, 219);
            oilFilterLabel.Name = "oilFilterLabel";
            oilFilterLabel.Size = new System.Drawing.Size(64, 17);
            oilFilterLabel.TabIndex = 22;
            oilFilterLabel.Text = "Oil Filter:";
            // 
            // oilFilterTextBox
            // 
            this.oilFilterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "OilFilter", true));
            this.oilFilterTextBox.Location = new System.Drawing.Point(532, 212);
            this.oilFilterTextBox.Name = "oilFilterTextBox";
            this.oilFilterTextBox.Size = new System.Drawing.Size(200, 22);
            this.oilFilterTextBox.TabIndex = 23;
            // 
            // gearOilLabel
            // 
            gearOilLabel.AutoSize = true;
            gearOilLabel.Location = new System.Drawing.Point(37, 256);
            gearOilLabel.Name = "gearOilLabel";
            gearOilLabel.Size = new System.Drawing.Size(65, 17);
            gearOilLabel.TabIndex = 24;
            gearOilLabel.Text = "Gear Oil:";
            // 
            // gearOilTextBox
            // 
            this.gearOilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "GearOil", true));
            this.gearOilTextBox.Location = new System.Drawing.Point(108, 256);
            this.gearOilTextBox.Name = "gearOilTextBox";
            this.gearOilTextBox.Size = new System.Drawing.Size(200, 22);
            this.gearOilTextBox.TabIndex = 25;
            // 
            // gearOilQtyLabel
            // 
            gearOilQtyLabel.AutoSize = true;
            gearOilQtyLabel.Location = new System.Drawing.Point(426, 261);
            gearOilQtyLabel.Name = "gearOilQtyLabel";
            gearOilQtyLabel.Size = new System.Drawing.Size(91, 17);
            gearOilQtyLabel.TabIndex = 26;
            gearOilQtyLabel.Text = "Gear Oil Qty:";
            // 
            // gearOilQtyTextBox
            // 
            this.gearOilQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "GearOilQty", true));
            this.gearOilQtyTextBox.Location = new System.Drawing.Point(532, 256);
            this.gearOilQtyTextBox.Name = "gearOilQtyTextBox";
            this.gearOilQtyTextBox.Size = new System.Drawing.Size(200, 22);
            this.gearOilQtyTextBox.TabIndex = 27;
            // 
            // pointLabel
            // 
            pointLabel.AutoSize = true;
            pointLabel.Location = new System.Drawing.Point(58, 310);
            pointLabel.Name = "pointLabel";
            pointLabel.Size = new System.Drawing.Size(44, 17);
            pointLabel.TabIndex = 28;
            pointLabel.Text = "Point:";
            // 
            // pointTextBox
            // 
            this.pointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Point", true));
            this.pointTextBox.Location = new System.Drawing.Point(108, 305);
            this.pointTextBox.Name = "pointTextBox";
            this.pointTextBox.Size = new System.Drawing.Size(200, 22);
            this.pointTextBox.TabIndex = 29;
            // 
            // condenserLabel
            // 
            condenserLabel.AutoSize = true;
            condenserLabel.Location = new System.Drawing.Point(426, 310);
            condenserLabel.Name = "condenserLabel";
            condenserLabel.Size = new System.Drawing.Size(81, 17);
            condenserLabel.TabIndex = 30;
            condenserLabel.Text = "Condenser:";
            // 
            // condenserTextBox
            // 
            this.condenserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Condenser", true));
            this.condenserTextBox.Location = new System.Drawing.Point(532, 310);
            this.condenserTextBox.Name = "condenserTextBox";
            this.condenserTextBox.Size = new System.Drawing.Size(200, 22);
            this.condenserTextBox.TabIndex = 31;
            // 
            // plugLabel
            // 
            plugLabel.AutoSize = true;
            plugLabel.Location = new System.Drawing.Point(62, 354);
            plugLabel.Name = "plugLabel";
            plugLabel.Size = new System.Drawing.Size(40, 17);
            plugLabel.TabIndex = 32;
            plugLabel.Text = "Plug:";
            // 
            // plugTextBox
            // 
            this.plugTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Plug", true));
            this.plugTextBox.Location = new System.Drawing.Point(108, 354);
            this.plugTextBox.Name = "plugTextBox";
            this.plugTextBox.Size = new System.Drawing.Size(200, 22);
            this.plugTextBox.TabIndex = 33;
            // 
            // plugQtyLabel
            // 
            plugQtyLabel.AutoSize = true;
            plugQtyLabel.Location = new System.Drawing.Point(426, 354);
            plugQtyLabel.Name = "plugQtyLabel";
            plugQtyLabel.Size = new System.Drawing.Size(66, 17);
            plugQtyLabel.TabIndex = 34;
            plugQtyLabel.Text = "Plug Qty:";
            // 
            // plugQtyTextBox
            // 
            this.plugQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "PlugQty", true));
            this.plugQtyTextBox.Location = new System.Drawing.Point(532, 354);
            this.plugQtyTextBox.Name = "plugQtyTextBox";
            this.plugQtyTextBox.Size = new System.Drawing.Size(200, 22);
            this.plugQtyTextBox.TabIndex = 35;
            // 
            // fuelFilterLabel
            // 
            fuelFilterLabel.AutoSize = true;
            fuelFilterLabel.Location = new System.Drawing.Point(27, 399);
            fuelFilterLabel.Name = "fuelFilterLabel";
            fuelFilterLabel.Size = new System.Drawing.Size(74, 17);
            fuelFilterLabel.TabIndex = 36;
            fuelFilterLabel.Text = "Fuel Filter:";
            // 
            // fuelFilterTextBox
            // 
            this.fuelFilterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "FuelFilter", true));
            this.fuelFilterTextBox.Location = new System.Drawing.Point(107, 399);
            this.fuelFilterTextBox.Name = "fuelFilterTextBox";
            this.fuelFilterTextBox.Size = new System.Drawing.Size(200, 22);
            this.fuelFilterTextBox.TabIndex = 37;
            // 
            // airFIlterLabel
            // 
            airFIlterLabel.AutoSize = true;
            airFIlterLabel.Location = new System.Drawing.Point(426, 404);
            airFIlterLabel.Name = "airFIlterLabel";
            airFIlterLabel.Size = new System.Drawing.Size(64, 17);
            airFIlterLabel.TabIndex = 38;
            airFIlterLabel.Text = "Air FIlter:";
            // 
            // airFIlterTextBox
            // 
            this.airFIlterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "AirFIlter", true));
            this.airFIlterTextBox.Location = new System.Drawing.Point(532, 404);
            this.airFIlterTextBox.Name = "airFIlterTextBox";
            this.airFIlterTextBox.Size = new System.Drawing.Size(200, 22);
            this.airFIlterTextBox.TabIndex = 39;
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(34, 442);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(68, 17);
            remarksLabel.TabIndex = 40;
            remarksLabel.Text = "Remarks:";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(108, 442);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(200, 22);
            this.remarksTextBox.TabIndex = 41;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(42, 616);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(66, 25);
            this.btnLoad.TabIndex = 42;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(141, 616);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 25);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(241, 616);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 25);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(349, 616);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 25);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.Location = new System.Drawing.Point(460, 616);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(78, 25);
            this.btnCancelAll.TabIndex = 46;
            this.btnCancelAll.Text = "CancelAll";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(573, 616);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 25);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(686, 616);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 25);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 517);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 22);
            this.textBox1.TabIndex = 49;
            // 
            // btnMare
            // 
            this.btnMare.Location = new System.Drawing.Point(581, 517);
            this.btnMare.Name = "btnMare";
            this.btnMare.Size = new System.Drawing.Size(65, 23);
            this.btnMare.TabIndex = 50;
            this.btnMare.Text = ">";
            this.btnMare.UseVisualStyleBackColor = true;
            // 
            // btnMareMare
            // 
            this.btnMareMare.Location = new System.Drawing.Point(652, 517);
            this.btnMareMare.Name = "btnMareMare";
            this.btnMareMare.Size = new System.Drawing.Size(65, 23);
            this.btnMareMare.TabIndex = 51;
            this.btnMareMare.Text = ">>";
            this.btnMareMare.UseVisualStyleBackColor = true;
            // 
            // btnMic
            // 
            this.btnMic.Location = new System.Drawing.Point(278, 517);
            this.btnMic.Name = "btnMic";
            this.btnMic.Size = new System.Drawing.Size(65, 23);
            this.btnMic.TabIndex = 52;
            this.btnMic.Text = "<";
            this.btnMic.UseVisualStyleBackColor = true;
            // 
            // btnMicMIc
            // 
            this.btnMicMIc.Location = new System.Drawing.Point(207, 517);
            this.btnMicMIc.Name = "btnMicMIc";
            this.btnMicMIc.Size = new System.Drawing.Size(65, 23);
            this.btnMicMIc.TabIndex = 53;
            this.btnMicMIc.Text = "<<";
            this.btnMicMIc.UseVisualStyleBackColor = true;
            // 
            // JobDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 692);
            this.Controls.Add(this.btnMicMIc);
            this.Controls.Add(this.btnMic);
            this.Controls.Add(this.btnMareMare);
            this.Controls.Add(this.btnMare);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(carNoLabel);
            this.Controls.Add(this.carNoTextBox);
            this.Controls.Add(jobDateLabel);
            this.Controls.Add(this.jobDateDateTimePicker);
            this.Controls.Add(workerIDLabel);
            this.Controls.Add(this.workerIDTextBox);
            this.Controls.Add(kMsLabel);
            this.Controls.Add(this.kMsTextBox);
            this.Controls.Add(tuningLabel);
            this.Controls.Add(this.tuningTextBox);
            this.Controls.Add(alingnmentLabel);
            this.Controls.Add(this.alingnmentTextBox);
            this.Controls.Add(balancingLabel);
            this.Controls.Add(this.balancingTextBox);
            this.Controls.Add(tiersLabel);
            this.Controls.Add(this.tiersTextBox);
            this.Controls.Add(weightsLabel);
            this.Controls.Add(this.weightsTextBox);
            this.Controls.Add(oilChangedLabel);
            this.Controls.Add(this.oilChangedTextBox);
            this.Controls.Add(oilQtyLabel);
            this.Controls.Add(this.oilQtyTextBox);
            this.Controls.Add(oilFilterLabel);
            this.Controls.Add(this.oilFilterTextBox);
            this.Controls.Add(gearOilLabel);
            this.Controls.Add(this.gearOilTextBox);
            this.Controls.Add(gearOilQtyLabel);
            this.Controls.Add(this.gearOilQtyTextBox);
            this.Controls.Add(pointLabel);
            this.Controls.Add(this.pointTextBox);
            this.Controls.Add(condenserLabel);
            this.Controls.Add(this.condenserTextBox);
            this.Controls.Add(plugLabel);
            this.Controls.Add(this.plugTextBox);
            this.Controls.Add(plugQtyLabel);
            this.Controls.Add(this.plugQtyTextBox);
            this.Controls.Add(fuelFilterLabel);
            this.Controls.Add(this.fuelFilterTextBox);
            this.Controls.Add(airFIlterLabel);
            this.Controls.Add(this.airFIlterTextBox);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Name = "JobDetailsForm";
            this.Text = "JobDetailsForm";
            this.Load += new System.EventHandler(this.JobDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbCustomerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dbCustomerDataSet dbCustomerDataSet;
        private System.Windows.Forms.BindingSource jobDetailsBindingSource;
        private dbCustomerDataSetTableAdapters.JobDetailsTableAdapter jobDetailsTableAdapter;
        private dbCustomerDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox carNoTextBox;
        private System.Windows.Forms.DateTimePicker jobDateDateTimePicker;
        private System.Windows.Forms.TextBox workerIDTextBox;
        private System.Windows.Forms.TextBox kMsTextBox;
        private System.Windows.Forms.TextBox tuningTextBox;
        private System.Windows.Forms.TextBox alingnmentTextBox;
        private System.Windows.Forms.TextBox balancingTextBox;
        private System.Windows.Forms.TextBox tiersTextBox;
        private System.Windows.Forms.TextBox weightsTextBox;
        private System.Windows.Forms.TextBox oilChangedTextBox;
        private System.Windows.Forms.TextBox oilQtyTextBox;
        private System.Windows.Forms.TextBox oilFilterTextBox;
        private System.Windows.Forms.TextBox gearOilTextBox;
        private System.Windows.Forms.TextBox gearOilQtyTextBox;
        private System.Windows.Forms.TextBox pointTextBox;
        private System.Windows.Forms.TextBox condenserTextBox;
        private System.Windows.Forms.TextBox plugTextBox;
        private System.Windows.Forms.TextBox plugQtyTextBox;
        private System.Windows.Forms.TextBox fuelFilterTextBox;
        private System.Windows.Forms.TextBox airFIlterTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMare;
        private System.Windows.Forms.Button btnMareMare;
        private System.Windows.Forms.Button btnMic;
        private System.Windows.Forms.Button btnMicMIc;
    }
}