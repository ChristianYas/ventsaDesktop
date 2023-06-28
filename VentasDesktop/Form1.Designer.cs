namespace VentasDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAmountSales = new System.Windows.Forms.Button();
            this.btnBestSelling = new System.Windows.Forms.Button();
            this.btnAllSales = new System.Windows.Forms.Button();
            this.btnSalesByProduct = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDekstopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnAmountSales);
            this.panelMenu.Controls.Add(this.btnBestSelling);
            this.panelMenu.Controls.Add(this.btnAllSales);
            this.panelMenu.Controls.Add(this.btnSalesByProduct);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAmountSales
            // 
            this.btnAmountSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAmountSales.FlatAppearance.BorderSize = 0;
            this.btnAmountSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmountSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAmountSales.Image = global::VentasDesktop.Properties.Resources.bolsa_de_la_compra;
            this.btnAmountSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAmountSales.Location = new System.Drawing.Point(0, 260);
            this.btnAmountSales.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnAmountSales.Name = "btnAmountSales";
            this.btnAmountSales.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAmountSales.Size = new System.Drawing.Size(220, 60);
            this.btnAmountSales.TabIndex = 5;
            this.btnAmountSales.Text = "Amount Sales";
            this.btnAmountSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAmountSales.UseVisualStyleBackColor = true;
            this.btnAmountSales.Click += new System.EventHandler(this.amountSales_Click);
            // 
            // btnBestSelling
            // 
            this.btnBestSelling.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBestSelling.FlatAppearance.BorderSize = 0;
            this.btnBestSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestSelling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBestSelling.Image = global::VentasDesktop.Properties.Resources.beneficio_financiero;
            this.btnBestSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBestSelling.Location = new System.Drawing.Point(0, 200);
            this.btnBestSelling.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnBestSelling.Name = "btnBestSelling";
            this.btnBestSelling.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBestSelling.Size = new System.Drawing.Size(220, 60);
            this.btnBestSelling.TabIndex = 4;
            this.btnBestSelling.Text = "Best Selling";
            this.btnBestSelling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBestSelling.UseVisualStyleBackColor = true;
            this.btnBestSelling.Click += new System.EventHandler(this.bestSelling_Click);
            // 
            // btnAllSales
            // 
            this.btnAllSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllSales.FlatAppearance.BorderSize = 0;
            this.btnAllSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAllSales.Image = global::VentasDesktop.Properties.Resources.ventas;
            this.btnAllSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllSales.Location = new System.Drawing.Point(0, 140);
            this.btnAllSales.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnAllSales.Name = "btnAllSales";
            this.btnAllSales.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAllSales.Size = new System.Drawing.Size(220, 60);
            this.btnAllSales.TabIndex = 3;
            this.btnAllSales.Text = "All Sales";
            this.btnAllSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllSales.UseVisualStyleBackColor = true;
            this.btnAllSales.Click += new System.EventHandler(this.allSales_Click);
            // 
            // btnSalesByProduct
            // 
            this.btnSalesByProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesByProduct.FlatAppearance.BorderSize = 0;
            this.btnSalesByProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesByProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesByProduct.Image = global::VentasDesktop.Properties.Resources.articulos_a_la_venta;
            this.btnSalesByProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesByProduct.Location = new System.Drawing.Point(0, 80);
            this.btnSalesByProduct.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnSalesByProduct.Name = "btnSalesByProduct";
            this.btnSalesByProduct.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSalesByProduct.Size = new System.Drawing.Size(220, 60);
            this.btnSalesByProduct.TabIndex = 2;
            this.btnSalesByProduct.Text = " Sales By Prodcut";
            this.btnSalesByProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesByProduct.UseVisualStyleBackColor = true;
            this.btnSalesByProduct.Click += new System.EventHandler(this.salesByProduct_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(777, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelTitle.Location = new System.Drawing.Point(400, 26);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(80, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panelDekstopPane
            // 
            this.panelDekstopPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelDekstopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDekstopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDekstopPane.Name = "panelDekstopPane";
            this.panelDekstopPane.Size = new System.Drawing.Size(777, 370);
            this.panelDekstopPane.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.panelDekstopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSalesByProduct;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnAmountSales;
        private System.Windows.Forms.Button btnBestSelling;
        private System.Windows.Forms.Button btnAllSales;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDekstopPane;
    }
}

