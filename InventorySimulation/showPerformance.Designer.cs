
namespace InventorySimulation
{
    partial class showPerformance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        ///         private System.Windows.Forms.Label label1;
     
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
            this.AveShQuantityVal = new System.Windows.Forms.Label();
            this.AveShQuantity = new System.Windows.Forms.Label();
            this.AveEndInventory = new System.Windows.Forms.Label();
            this.AveEndInventoryVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AveShQuantityVal
            // 
            this.AveShQuantityVal.AutoSize = true;
            this.AveShQuantityVal.Location = new System.Drawing.Point(269, 104);
            this.AveShQuantityVal.Name = "AveShQuantityVal";
            this.AveShQuantityVal.Size = new System.Drawing.Size(22, 13);
            this.AveShQuantityVal.TabIndex = 0;
            this.AveShQuantityVal.Text = "0.0";
            this.AveShQuantityVal.Click += new System.EventHandler(this.label3_Click);
            // 
            // AveShQuantity
            // 
            this.AveShQuantity.AutoSize = true;
            this.AveShQuantity.Location = new System.Drawing.Point(31, 104);
            this.AveShQuantity.Name = "AveShQuantity";
            this.AveShQuantity.Size = new System.Drawing.Size(162, 13);
            this.AveShQuantity.TabIndex = 1;
            this.AveShQuantity.Text = "Total Shortage Quantity Average";
            this.AveShQuantity.Click += new System.EventHandler(this.label4_Click);
            // 
            // AveEndInventory
            // 
            this.AveEndInventory.AutoSize = true;
            this.AveEndInventory.Location = new System.Drawing.Point(31, 167);
            this.AveEndInventory.Name = "AveEndInventory";
            this.AveEndInventory.Size = new System.Drawing.Size(157, 13);
            this.AveEndInventory.TabIndex = 2;
            this.AveEndInventory.Text = "Total Ending Inventory Average";
            // 
            // AveEndInventoryVal
            // 
            this.AveEndInventoryVal.AutoSize = true;
            this.AveEndInventoryVal.Location = new System.Drawing.Point(272, 167);
            this.AveEndInventoryVal.Name = "AveEndInventoryVal";
            this.AveEndInventoryVal.Size = new System.Drawing.Size(22, 13);
            this.AveEndInventoryVal.TabIndex = 3;
            this.AveEndInventoryVal.Text = "0.0";
            this.AveEndInventoryVal.Click += new System.EventHandler(this.label6_Click);
            // 
            // showPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 298);
            this.Controls.Add(this.AveEndInventoryVal);
            this.Controls.Add(this.AveEndInventory);
            this.Controls.Add(this.AveShQuantity);
            this.Controls.Add(this.AveShQuantityVal);
            this.Name = "showPerformance";
            this.Text = "Performance Measures";
            this.Load += new System.EventHandler(this.showPerformance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AveShQuantityVal;
        private System.Windows.Forms.Label AveShQuantity;
        private System.Windows.Forms.Label AveEndInventory;
        private System.Windows.Forms.Label AveEndInventoryVal;
    }
}