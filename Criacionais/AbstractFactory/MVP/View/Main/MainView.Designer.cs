namespace AbstractFactory;

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
        cmbConstructor = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        btnSuv = new Button();
        btnSportCar = new Button();
        SuspendLayout();
        // 
        // cmbConstructor
        // 
        cmbConstructor.FormattingEnabled = true;
        cmbConstructor.Location = new Point(124, 75);
        cmbConstructor.Name = "cmbConstructor";
        cmbConstructor.Size = new Size(164, 23);
        cmbConstructor.TabIndex = 0;
        cmbConstructor.Items.Add("Ferrari");
        cmbConstructor.Items.Add("Mercedes");
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(0, 9);
        label1.Name = "label1";
        label1.Size = new Size(435, 25);
        label1.TabIndex = 3;
        label1.Text = "Criando tipos de carros de diversas montadoras";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(124, 55);
        label2.Name = "label2";
        label2.Size = new Size(80, 17);
        label2.TabIndex = 4;
        label2.Text = "Montadora:";
        // 
        // btnSuv
        // 
        btnSuv.Location = new Point(79, 128);
        btnSuv.Name = "btnSuv";
        btnSuv.Size = new Size(86, 58);
        btnSuv.TabIndex = 7;
        btnSuv.Text = "Suv";
        btnSuv.UseVisualStyleBackColor = true;
        btnSuv.Click += SavingSuv;
        // 
        // btnSportCar
        // 
        btnSportCar.Location = new Point(253, 128);
        btnSportCar.Name = "btnSportCar";
        btnSportCar.Size = new Size(86, 58);
        btnSportCar.TabIndex = 8;
        btnSportCar.Text = "Sport Car";
        btnSportCar.UseVisualStyleBackColor = true;
        btnSportCar.Click += SavingSportCar;
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(434, 230);
        Controls.Add(btnSportCar);
        Controls.Add(btnSuv);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(cmbConstructor);
        Name = "MainView";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox cmbConstructor;
    private Label label1;
    private Label label2;
    private Button btnSuv;
    private Button btnSportCar;
}
