namespace VentasDesktop.Forms
{
    partial class BestSelling
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
            this.tableBestSellings = new System.Windows.Forms.DataGridView();
            this.idSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amoutSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableBestSellings)).BeginInit();
            this.SuspendLayout();
            // 
            // tableBestSellings
            // 
            this.tableBestSellings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableBestSellings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSale,
            this.title,
            this.description,
            this.unitPrice,
            this.stock,
            this.amoutSale,
            this.total,
            this.date});
            this.tableBestSellings.Location = new System.Drawing.Point(35, 133);
            this.tableBestSellings.Name = "tableBestSellings";
            this.tableBestSellings.Size = new System.Drawing.Size(888, 109);
            this.tableBestSellings.TabIndex = 0;
            this.tableBestSellings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableBestSellings_CellContentClick);
            // 
            // idSale
            // 
            this.idSale.Frozen = true;
            this.idSale.HeaderText = "idVentas";
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
            this.stock.HeaderText = "Cantidad del Producto";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // amoutSale
            // 
            this.amoutSale.Frozen = true;
            this.amoutSale.HeaderText = "Cantidad Vendida";
            this.amoutSale.Name = "amoutSale";
            this.amoutSale.ReadOnly = true;
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
            // BestSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.tableBestSellings);
            this.Name = "BestSelling";
            this.Text = "BestSelling";
            ((System.ComponentModel.ISupportInitialize)(this.tableBestSellings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableBestSellings;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn amoutSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}