namespace WindowsFormsDGV
{
    partial class ShohinForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            WindowsFormsDGV.Shohin shohin1 = new WindowsFormsDGV.Shohin();
            this.dgvShohin = new System.Windows.Forms.DataGridView();
            this.btnExtractSQL = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.shohinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbError = new System.Windows.Forms.TextBox();
            this.ShohinID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShohinMei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShohinBunrui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanbaiTanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiireTanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Torokubi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShohin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shohinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShohin
            // 
            this.dgvShohin.AllowUserToAddRows = false;
            this.dgvShohin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShohin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShohinID,
            this.ShohinMei,
            this.ShohinBunrui,
            this.HanbaiTanka,
            this.ShiireTanka,
            this.Torokubi});
            this.dgvShohin.Location = new System.Drawing.Point(12, 12);
            this.dgvShohin.Name = "dgvShohin";
            this.dgvShohin.RowTemplate.Height = 21;
            this.dgvShohin.Size = new System.Drawing.Size(660, 315);
            this.dgvShohin.TabIndex = 0;
            // 
            // btnExtractSQL
            // 
            this.btnExtractSQL.Location = new System.Drawing.Point(476, 418);
            this.btnExtractSQL.Name = "btnExtractSQL";
            this.btnExtractSQL.Size = new System.Drawing.Size(95, 25);
            this.btnExtractSQL.TabIndex = 1;
            this.btnExtractSQL.Text = "抽出SQL";
            this.btnExtractSQL.UseVisualStyleBackColor = true;
            this.btnExtractSQL.Click += new System.EventHandler(this.btnExtractSQL_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(577, 418);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClearGridView_Click);
            // 
            // shohinBindingSource
            // 
            this.shohinBindingSource.DataSource = shohin1;
            this.shohinBindingSource.Position = 0;
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(13, 333);
            this.tbError.Multiline = true;
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(659, 79);
            this.tbError.TabIndex = 4;
            // 
            // ShohinID
            // 
            this.ShohinID.HeaderText = "商品ID";
            this.ShohinID.Name = "ShohinID";
            this.ShohinID.ReadOnly = true;
            // 
            // ShohinMei
            // 
            this.ShohinMei.HeaderText = "商品名";
            this.ShohinMei.Name = "ShohinMei";
            this.ShohinMei.ReadOnly = true;
            // 
            // ShohinBunrui
            // 
            this.ShohinBunrui.HeaderText = "商品分類";
            this.ShohinBunrui.Name = "ShohinBunrui";
            this.ShohinBunrui.ReadOnly = true;
            // 
            // HanbaiTanka
            // 
            this.HanbaiTanka.HeaderText = "販売単価";
            this.HanbaiTanka.Name = "HanbaiTanka";
            // 
            // ShiireTanka
            // 
            this.ShiireTanka.HeaderText = "仕入単価";
            this.ShiireTanka.Name = "ShiireTanka";
            // 
            // Torokubi
            // 
            this.Torokubi.HeaderText = "登録日";
            this.Torokubi.Name = "Torokubi";
            // 
            // ShohinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 449);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExtractSQL);
            this.Controls.Add(this.dgvShohin);
            this.Name = "ShohinForm";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShohin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shohinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShohin;
        private System.Windows.Forms.Button btnExtractSQL;
        private System.Windows.Forms.Button btnClear;
        private Shohin shohin;
        private System.Windows.Forms.BindingSource shohinBindingSource;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShohinID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShohinMei;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShohinBunrui;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanbaiTanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiireTanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Torokubi;
    }
}

