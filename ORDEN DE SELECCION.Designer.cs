
namespace PROTOTIPO.TP3.CAI
{
    partial class ORDEN_DE_SELECCION
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "67887653",
            "MERCADERIA 1 (10), MERCADERIA 2 (5) ",
            "11222333"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "87766554",
            "MERCADERIA 3 (30), MERCADERIA 4 (12)",
            "99888777"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnNumOrden = new System.Windows.Forms.ColumnHeader();
            this.columnDetalle = new System.Windows.Forms.ColumnHeader();
            this.columnCliente = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumOrden,
            this.columnDetalle,
            this.columnCliente});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(725, 288);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnNumOrden
            // 
            this.columnNumOrden.Text = "NUMERO DE ORDEN";
            this.columnNumOrden.Width = 180;
            // 
            // columnDetalle
            // 
            this.columnDetalle.Text = "DETALLE";
            this.columnDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDetalle.Width = 450;
            // 
            // columnCliente
            // 
            this.columnCliente.Text = "CLIENTE";
            this.columnCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCliente.Width = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "GENERAR ORDEN ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ORDEN_DE_SELECCION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ORDEN_DE_SELECCION";
            this.Text = "ORDEN_DE_SELECCION";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnNumOrden;
        private System.Windows.Forms.ColumnHeader columnDetalle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnCliente;
    }
}