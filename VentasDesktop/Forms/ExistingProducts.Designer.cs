namespace VentasDesktop.Forms
{
    partial class ExistingProducts
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
            this.tableExistingProducts = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableExistingProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tableExistingProducts
            // 
            this.tableExistingProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableExistingProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.title,
            this.description,
            this.unitPrice,
            this.stock});
            this.tableExistingProducts.Location = new System.Drawing.Point(122, 104);
            this.tableExistingProducts.Name = "tableExistingProducts";
            this.tableExistingProducts.Size = new System.Drawing.Size(649, 190);
            this.tableExistingProducts.TabIndex = 0;
            // 
            // IdProduct
            // 
            this.IdProduct.Frozen = true;
            this.IdProduct.HeaderText = "idProducto";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
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
            this.stock.HeaderText = "Cantidad del Producto ";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 205;
            // 
            // ExistingProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableExistingProducts);
            this.Name = "ExistingProducts";
            this.Text = "ExistingProducts";
            ((System.ComponentModel.ISupportInitialize)(this.tableExistingProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableExistingProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}