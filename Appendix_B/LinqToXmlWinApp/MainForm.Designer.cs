namespace LinqToXmlWinApp
{
  partial class MainForm
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
        this.label1 = new System.Windows.Forms.Label();
        this.txtInventory = new System.Windows.Forms.TextBox();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.btnAddNewItem = new System.Windows.Forms.Button();
        this.txtPetName = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.txtColor = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.txtMake = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.btnLookUpColors = new System.Windows.Forms.Button();
        this.txtMakeToLookUp = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(13, 13);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(88, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Current Inventory";
        // 
        // txtInventory
        // 
        this.txtInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtInventory.Location = new System.Drawing.Point(16, 39);
        this.txtInventory.Multiline = true;
        this.txtInventory.Name = "txtInventory";
        this.txtInventory.ReadOnly = true;
        this.txtInventory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        this.txtInventory.Size = new System.Drawing.Size(255, 195);
        this.txtInventory.TabIndex = 1;
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.btnAddNewItem);
        this.groupBox1.Controls.Add(this.txtPetName);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.txtColor);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.txtMake);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Location = new System.Drawing.Point(296, 39);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(301, 153);
        this.groupBox1.TabIndex = 2;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Add Inventory Item";
        // 
        // btnAddNewItem
        // 
        this.btnAddNewItem.Location = new System.Drawing.Point(167, 114);
        this.btnAddNewItem.Name = "btnAddNewItem";
        this.btnAddNewItem.Size = new System.Drawing.Size(109, 23);
        this.btnAddNewItem.TabIndex = 6;
        this.btnAddNewItem.Text = "Add";
        this.btnAddNewItem.UseVisualStyleBackColor = true;
        this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
        // 
        // txtPetName
        // 
        this.txtPetName.Location = new System.Drawing.Point(77, 88);
        this.txtPetName.Name = "txtPetName";
        this.txtPetName.Size = new System.Drawing.Size(200, 20);
        this.txtPetName.TabIndex = 5;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(16, 88);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(54, 13);
        this.label4.TabIndex = 4;
        this.label4.Text = "Pet Name";
        // 
        // txtColor
        // 
        this.txtColor.Location = new System.Drawing.Point(76, 61);
        this.txtColor.Name = "txtColor";
        this.txtColor.Size = new System.Drawing.Size(200, 20);
        this.txtColor.TabIndex = 3;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(15, 61);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(31, 13);
        this.label3.TabIndex = 2;
        this.label3.Text = "Color";
        // 
        // txtMake
        // 
        this.txtMake.Location = new System.Drawing.Point(76, 35);
        this.txtMake.Name = "txtMake";
        this.txtMake.Size = new System.Drawing.Size(200, 20);
        this.txtMake.TabIndex = 1;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(15, 35);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(34, 13);
        this.label2.TabIndex = 0;
        this.label2.Text = "Make";
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.btnLookUpColors);
        this.groupBox2.Controls.Add(this.txtMakeToLookUp);
        this.groupBox2.Controls.Add(this.label5);
        this.groupBox2.Location = new System.Drawing.Point(296, 211);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(301, 105);
        this.groupBox2.TabIndex = 3;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Look up Colors for Make";
        // 
        // btnLookUpColors
        // 
        this.btnLookUpColors.Location = new System.Drawing.Point(126, 69);
        this.btnLookUpColors.Name = "btnLookUpColors";
        this.btnLookUpColors.Size = new System.Drawing.Size(150, 23);
        this.btnLookUpColors.TabIndex = 2;
        this.btnLookUpColors.Text = "Look Up Colors";
        this.btnLookUpColors.UseVisualStyleBackColor = true;
        this.btnLookUpColors.Click += new System.EventHandler(this.btnLookUpColors_Click);
        // 
        // txtMakeToLookUp
        // 
        this.txtMakeToLookUp.Location = new System.Drawing.Point(126, 36);
        this.txtMakeToLookUp.Name = "txtMakeToLookUp";
        this.txtMakeToLookUp.Size = new System.Drawing.Size(150, 20);
        this.txtMakeToLookUp.TabIndex = 1;
        this.txtMakeToLookUp.Text = "BMW";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(18, 36);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(90, 13);
        this.label5.TabIndex = 0;
        this.label5.Text = "Make to Look Up";
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(619, 351);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.txtInventory);
        this.Controls.Add(this.label1);
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Fun with LINQ to XML";
        this.Load += new System.EventHandler(this.MainForm_Load);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtInventory;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtPetName;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtColor;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtMake;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAddNewItem;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnLookUpColors;
    private System.Windows.Forms.TextBox txtMakeToLookUp;
    private System.Windows.Forms.Label label5;
  }
}

