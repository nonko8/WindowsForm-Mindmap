namespace SimpleMindmapForm
{
    partial class SimpleMaindmapForm
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
            this.formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.toolsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addNodeButton = new System.Windows.Forms.Button();
            this.deleteNodeButton = new System.Windows.Forms.Button();
            this.editNodeText = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.formTableLayoutPanel.SuspendLayout();
            this.toolsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // formTableLayoutPanel
            // 
            this.formTableLayoutPanel.ColumnCount = 1;
            this.formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formTableLayoutPanel.Controls.Add(this.toolsTableLayoutPanel, 0, 0);
            this.formTableLayoutPanel.Controls.Add(this.pictureBox, 0, 1);
            this.formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.formTableLayoutPanel.Name = "formTableLayoutPanel";
            this.formTableLayoutPanel.RowCount = 2;
            this.formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.formTableLayoutPanel.TabIndex = 0;
            // 
            // toolsTableLayoutPanel
            // 
            this.toolsTableLayoutPanel.ColumnCount = 4;
            this.toolsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.toolsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.toolsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.toolsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.toolsTableLayoutPanel.Controls.Add(this.addNodeButton, 0, 0);
            this.toolsTableLayoutPanel.Controls.Add(this.deleteNodeButton, 1, 0);
            this.toolsTableLayoutPanel.Controls.Add(this.editNodeText, 2, 0);
            this.toolsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.toolsTableLayoutPanel.Name = "toolsTableLayoutPanel";
            this.toolsTableLayoutPanel.RowCount = 1;
            this.toolsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolsTableLayoutPanel.Size = new System.Drawing.Size(794, 44);
            this.toolsTableLayoutPanel.TabIndex = 0;
            // 
            // addNodeButton
            // 
            this.addNodeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNodeButton.Location = new System.Drawing.Point(3, 3);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(144, 38);
            this.addNodeButton.TabIndex = 0;
            this.addNodeButton.Text = "add node";
            this.addNodeButton.UseVisualStyleBackColor = true;
            this.addNodeButton.Click += new System.EventHandler(this.AddNodeButton_Click);
            // 
            // deleteNodeButton
            // 
            this.deleteNodeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteNodeButton.Location = new System.Drawing.Point(153, 3);
            this.deleteNodeButton.Name = "deleteNodeButton";
            this.deleteNodeButton.Size = new System.Drawing.Size(144, 38);
            this.deleteNodeButton.TabIndex = 1;
            this.deleteNodeButton.Text = "delete node";
            this.deleteNodeButton.UseVisualStyleBackColor = true;
            this.deleteNodeButton.Click += new System.EventHandler(this.DeleteNodeButton_Click);
            // 
            // editNodeText
            // 
            this.editNodeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editNodeText.Font = new System.Drawing.Font("MS UI Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.editNodeText.Location = new System.Drawing.Point(303, 3);
            this.editNodeText.Name = "editNodeText";
            this.editNodeText.Size = new System.Drawing.Size(294, 35);
            this.editNodeText.TabIndex = 2;
            this.editNodeText.TextChanged += new System.EventHandler(this.EditNodeText_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 53);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(794, 394);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // SimpleMaindmapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formTableLayoutPanel);
            this.Name = "SimpleMaindmapForm";
            this.Text = "simple mindmap";
            this.formTableLayoutPanel.ResumeLayout(false);
            this.toolsTableLayoutPanel.ResumeLayout(false);
            this.toolsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel toolsTableLayoutPanel;
        private System.Windows.Forms.Button addNodeButton;
        private System.Windows.Forms.Button deleteNodeButton;
        private System.Windows.Forms.TextBox editNodeText;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

