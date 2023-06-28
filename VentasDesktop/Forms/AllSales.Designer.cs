namespace VentasDesktop.Forms
{
    partial class AllSales
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
            this.tableAllSales = new System.Windows.Forms.DataGridView();
            this.idSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitySold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllSales)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAllSales
            // 
            this.tableAllSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAllSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSale,
            this.title,
            this.description,
            this.unitPrice,
            this.stock,
            this.quantitySold,
            this.total,
            this.date});
            this.tableAllSales.Location = new System.Drawing.Point(29, 83);
            this.tableAllSales.Name = "tableAllSales";
            this.tableAllSales.Size = new System.Drawing.Size(890, 256);
            this.tableAllSales.TabIndex = 0;
            // 
            // idSale
            // 
            this.idSale.Frozen = true;
            this.idSale.HeaderText = "IdVenta";
            this.idSale.Name = "idSale";
            this.idSale.ReadOnly = true;
            // 
            // title
            // 
            this.title.Frozen = true;
            this.title.HeaderText = "Titulo";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // description
            // 
            this.description.Frozen = true;
            this.description.HeaderText = "Descripcion";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // unitPrice
            // 
            this.unitPrice.Frozen = true;
            this.unitPrice.HeaderText = "Precio Unitario";
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.Frozen = true;
            this.stock.HeaderText = "Cantidad de Producto";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // quantitySold
            // 
            this.quantitySold.Frozen = true;
            this.quantitySold.HeaderText = "Cantidad Vendida";
            this.quantitySold.Name = "quantitySold";
            this.quantitySold.ReadOnly = true;
            // 
            // total
            // 
            this.total.Frozen = true;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // date
            // 
            this.date.Frozen = true;
            this.date.HeaderText = "Fecha";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 145;
            // 
            // AllSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.tableAllSales);
            this.Name = "AllSales";
            this.Text = "AllSales";
            ((System.ComponentModel.ISupportInitialize)(this.tableAllSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableAllSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitySold;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}