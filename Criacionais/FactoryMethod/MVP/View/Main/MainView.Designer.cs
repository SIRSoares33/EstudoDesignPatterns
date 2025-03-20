namespace FactoryMethod;

partial class MainView
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
        label1 = new Label();
        cmbFurnitureAvaible = new ComboBox();
        lstChosenFurniture = new ListBox();
        imgAddMob = new PictureBox();
        imgRemoveMob = new PictureBox();
        imgOk = new PictureBox();
        imgExit = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)imgAddMob).BeginInit();
        ((System.ComponentModel.ISupportInitialize)imgRemoveMob).BeginInit();
        ((System.ComponentModel.ISupportInitialize)imgOk).BeginInit();
        ((System.ComponentModel.ISupportInitialize)imgExit).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(169, 35);
        label1.Name = "label1";
        label1.Size = new Size(184, 25);
        label1.TabIndex = 0;
        label1.Text = "Mobiliando Casa";
        // 
        // cmbMob
        // 
        cmbFurnitureAvaible.FormattingEnabled = true;
        cmbFurnitureAvaible.Location = new Point(42, 106);
        cmbFurnitureAvaible.Name = "cmbMob";
        cmbFurnitureAvaible.Size = new Size(121, 23);
        cmbFurnitureAvaible.TabIndex = 1;
        cmbFurnitureAvaible.Items.Add("Sofá");
        cmbFurnitureAvaible.Items.Add("Table");
        cmbFurnitureAvaible.Items.Add("Chair");
        cmbFurnitureAvaible.Items.Add("Bed");
        // 
        // lstMob
        // 
        lstChosenFurniture.FormattingEnabled = true;
        lstChosenFurniture.ItemHeight = 15;
        lstChosenFurniture.Location = new Point(325, 106);
        lstChosenFurniture.Name = "lstMob";
        lstChosenFurniture.Size = new Size(120, 109);
        lstChosenFurniture.TabIndex = 2;
        // 
        // imgAddMob
        // 
        imgAddMob.Image = Properties.Resources.CollectorSend;
        imgAddMob.Location = new Point(169, 94);
        imgAddMob.Name = "imgAddMob";
        imgAddMob.Size = new Size(70, 47);
        imgAddMob.SizeMode = PictureBoxSizeMode.Zoom;
        imgAddMob.TabIndex = 3;
        imgAddMob.TabStop = false;
        imgAddMob.Click += AddChosenFurniture;
        imgAddMob.Cursor = Cursors.Hand;
        // 
        // imgRemoveMob
        // 
        imgRemoveMob.Image = Properties.Resources.ColetorOff;
        imgRemoveMob.Location = new Point(451, 106);
        imgRemoveMob.Name = "imgRemoveMob";
        imgRemoveMob.Size = new Size(69, 50);
        imgRemoveMob.SizeMode = PictureBoxSizeMode.Zoom;
        imgRemoveMob.TabIndex = 4;
        imgRemoveMob.TabStop = false;
        imgRemoveMob.Click += RemoveChosenFurniture;
        imgRemoveMob.Cursor = Cursors.Hand;
        // 
        // imgOk
        // 
        imgOk.Image = Properties.Resources.Databases;
        imgOk.Location = new Point(42, 202);
        imgOk.Name = "imgOk";
        imgOk.Size = new Size(95, 98);
        imgOk.SizeMode = PictureBoxSizeMode.Zoom;
        imgOk.TabIndex = 5;
        imgOk.TabStop = false;
        imgOk.Click += SendingFurniture;   
        imgOk.Cursor = Cursors.Hand;
        // 
        // imgExit
        // 
        imgExit.Image = (Image)resources.GetObject("imgExit.Image");
        imgExit.Location = new Point(467, 10);
        imgExit.Name = "imgExit";
        imgExit.Size = new Size(69, 50);
        imgExit.SizeMode = PictureBoxSizeMode.Zoom;
        imgExit.TabIndex = 6;
        imgExit.TabStop = false;
        imgExit.Click += Exit;
        imgExit.Cursor = Cursors.Hand;
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDarkDark;
        ClientSize = new Size(548, 312);
        Controls.Add(imgExit);
        Controls.Add(imgOk);
        Controls.Add(imgRemoveMob);
        Controls.Add(imgAddMob);
        Controls.Add(lstChosenFurniture);
        Controls.Add(cmbFurnitureAvaible);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MainView";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)imgAddMob).EndInit();
        ((System.ComponentModel.ISupportInitialize)imgRemoveMob).EndInit();
        ((System.ComponentModel.ISupportInitialize)imgOk).EndInit();
        ((System.ComponentModel.ISupportInitialize)imgExit).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private ComboBox cmbFurnitureAvaible;
    private ListBox lstChosenFurniture;
    private PictureBox imgAddMob;
    private PictureBox imgRemoveMob;
    private PictureBox imgOk;
    private PictureBox imgExit;
}
