namespace Tree
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Глеб");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ваня");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Дима");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Бармен", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 2);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "gleb";
            treeNode5.Tag = "1";
            treeNode5.Text = "Глеб";
            treeNode6.Name = "van";
            treeNode6.Tag = "2";
            treeNode6.Text = "Ваня";
            treeNode7.Name = "dima";
            treeNode7.Tag = "3";
            treeNode7.Text = "Дима";
            treeNode8.Name = "barmen";
            treeNode8.Tag = "0";
            treeNode8.Text = "Бармен";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(240, 579);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(239, 2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(668, 578);
            this.panelControl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 576);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panelControl;
    }
}

