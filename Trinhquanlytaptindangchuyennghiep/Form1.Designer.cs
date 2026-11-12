namespace Trinhquanlytaptindangchuyennghiep
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblView = new System.Windows.Forms.Label();
            this.cboViewMode = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvDepartments = new System.Windows.Forms.TreeView();
            this.lsvEmployees = new System.Windows.Forms.ListView();
            this.imgListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imgListLarge = new System.Windows.Forms.ImageList(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cboViewMode);
            this.panelTop.Controls.Add(this.lblView);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 50);
            this.panelTop.TabIndex = 0;
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Location = new System.Drawing.Point(12, 18);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(84, 16);
            this.lblView.TabIndex = 0;
            this.lblView.Text = "Chế độ xem:";
            // 
            // cboViewMode
            // 
            this.cboViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViewMode.FormattingEnabled = true;
            this.cboViewMode.Location = new System.Drawing.Point(102, 15);
            this.cboViewMode.Name = "cboViewMode";
            this.cboViewMode.Size = new System.Drawing.Size(150, 24);
            this.cboViewMode.TabIndex = 1;
            this.cboViewMode.SelectedIndexChanged += new System.EventHandler(this.cboViewMode_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvDepartments);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lsvEmployees);
            this.splitContainer1.Size = new System.Drawing.Size(800, 400);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvDepartments
            // 
            this.tvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDepartments.Location = new System.Drawing.Point(0, 0);
            this.tvDepartments.Name = "tvDepartments";
            this.tvDepartments.Size = new System.Drawing.Size(250, 400);
            this.tvDepartments.TabIndex = 0;
            this.tvDepartments.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDepartments_AfterSelect);
            // 
            // lsvEmployees
            // 
            this.lsvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvEmployees.FullRowSelect = true;
            this.lsvEmployees.GridLines = true;
            this.lsvEmployees.HideSelection = false;
            this.lsvEmployees.LargeImageList = this.imgListLarge;
            this.lsvEmployees.Location = new System.Drawing.Point(0, 0);
            this.lsvEmployees.Name = "lsvEmployees";
            this.lsvEmployees.Size = new System.Drawing.Size(546, 400);
            this.lsvEmployees.SmallImageList = this.imgListSmall;
            this.lsvEmployees.TabIndex = 0;
            this.lsvEmployees.UseCompatibleStateImageBehavior = false;
            this.lsvEmployees.View = System.Windows.Forms.View.Details;
            // 
            // imgListSmall
            // 
            this.imgListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgListLarge
            // 
            this.imgListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.imgListLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trình Quản Lý Tập Tin Chuyên Nghiệp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox cboViewMode;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.ListView lsvEmployees;
        private System.Windows.Forms.ImageList imgListSmall;
        private System.Windows.Forms.ImageList imgListLarge;
    }
}