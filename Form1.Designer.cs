namespace c_sharp_DeskLibrary
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.libraryTabPage = new System.Windows.Forms.TabPage();
            this.delButton = new System.Windows.Forms.Button();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.libraryDataGridView = new System.Windows.Forms.DataGridView();
            this.libraryContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.читаюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.readingDataGridView = new System.Windows.Forms.DataGridView();
            this.readingContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alreadyReadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.alreadyReadDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ChangeProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.libraryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataGridView)).BeginInit();
            this.libraryContextMenuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readingDataGridView)).BeginInit();
            this.readingContextMenuStrip.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alreadyReadDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.libraryTabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 150);
            this.tabControl1.Location = new System.Drawing.Point(0, 22);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 427);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // libraryTabPage
            // 
            this.libraryTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.libraryTabPage.Controls.Add(this.delButton);
            this.libraryTabPage.Controls.Add(this.authorTextBox);
            this.libraryTabPage.Controls.Add(this.nameTextBox);
            this.libraryTabPage.Controls.Add(this.authorLabel);
            this.libraryTabPage.Controls.Add(this.nameLabel);
            this.libraryTabPage.Controls.Add(this.AddButton);
            this.libraryTabPage.Controls.Add(this.libraryDataGridView);
            this.libraryTabPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.libraryTabPage.Location = new System.Drawing.Point(154, 4);
            this.libraryTabPage.Name = "libraryTabPage";
            this.libraryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.libraryTabPage.Size = new System.Drawing.Size(678, 419);
            this.libraryTabPage.TabIndex = 0;
            this.libraryTabPage.Text = "Библиотека";
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delButton.Location = new System.Drawing.Point(547, 140);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(123, 29);
            this.delButton.TabIndex = 9;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.authorTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorTextBox.Location = new System.Drawing.Point(547, 75);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(123, 25);
            this.authorTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(547, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(123, 25);
            this.nameTextBox.TabIndex = 7;
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(547, 53);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(123, 19);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Автор";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(547, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(123, 19);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Название";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(547, 106);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 28);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // libraryDataGridView
            // 
            this.libraryDataGridView.AllowUserToAddRows = false;
            this.libraryDataGridView.AllowUserToDeleteRows = false;
            this.libraryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libraryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.libraryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.libraryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libraryDataGridView.ContextMenuStrip = this.libraryContextMenuStrip;
            this.libraryDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libraryDataGridView.Location = new System.Drawing.Point(3, 3);
            this.libraryDataGridView.MultiSelect = false;
            this.libraryDataGridView.Name = "libraryDataGridView";
            this.libraryDataGridView.ReadOnly = true;
            this.libraryDataGridView.Size = new System.Drawing.Size(538, 413);
            this.libraryDataGridView.TabIndex = 0;
            // 
            // libraryContextMenuStrip
            // 
            this.libraryContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.читаюToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.libraryContextMenuStrip.Name = "libraryContextMenuStrip";
            this.libraryContextMenuStrip.Size = new System.Drawing.Size(185, 48);
            // 
            // читаюToolStripMenuItem
            // 
            this.читаюToolStripMenuItem.Name = "читаюToolStripMenuItem";
            this.читаюToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.читаюToolStripMenuItem.Text = "Добавить в \"Читаю\"";
            this.читаюToolStripMenuItem.Click += new System.EventHandler(this.readingButton_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.delButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.readingDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Читаю";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // readingDataGridView
            // 
            this.readingDataGridView.AllowUserToAddRows = false;
            this.readingDataGridView.AllowUserToDeleteRows = false;
            this.readingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.readingDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.readingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readingDataGridView.ContextMenuStrip = this.readingContextMenuStrip;
            this.readingDataGridView.Location = new System.Drawing.Point(3, 3);
            this.readingDataGridView.MultiSelect = false;
            this.readingDataGridView.Name = "readingDataGridView";
            this.readingDataGridView.ReadOnly = true;
            this.readingDataGridView.Size = new System.Drawing.Size(538, 408);
            this.readingDataGridView.TabIndex = 1;
            // 
            // readingContextMenuStrip
            // 
            this.readingContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.alreadyReadToolStripMenuItem});
            this.readingContextMenuStrip.Name = "libraryContextMenuStrip";
            this.readingContextMenuStrip.Size = new System.Drawing.Size(231, 48);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.removeToolStripMenuItem.Text = "Убрать из списка";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // alreadyReadToolStripMenuItem
            // 
            this.alreadyReadToolStripMenuItem.Name = "alreadyReadToolStripMenuItem";
            this.alreadyReadToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.alreadyReadToolStripMenuItem.Text = "Переместить в \"Прочитано\"";
            this.alreadyReadToolStripMenuItem.Click += new System.EventHandler(this.alreadyReadToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.alreadyReadDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(678, 247);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Прочитано";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // alreadyReadDataGridView
            // 
            this.alreadyReadDataGridView.AllowUserToAddRows = false;
            this.alreadyReadDataGridView.AllowUserToDeleteRows = false;
            this.alreadyReadDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alreadyReadDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.alreadyReadDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.alreadyReadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alreadyReadDataGridView.Location = new System.Drawing.Point(3, 3);
            this.alreadyReadDataGridView.MultiSelect = false;
            this.alreadyReadDataGridView.Name = "alreadyReadDataGridView";
            this.alreadyReadDataGridView.ReadOnly = true;
            this.alreadyReadDataGridView.Size = new System.Drawing.Size(538, 408);
            this.alreadyReadDataGridView.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ChangeProfileToolStripMenuItem
            // 
            this.ChangeProfileToolStripMenuItem.Name = "ChangeProfileToolStripMenuItem";
            this.ChangeProfileToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.ChangeProfileToolStripMenuItem.Text = "Сменить профиль";
            this.ChangeProfileToolStripMenuItem.Click += new System.EventHandler(this.ChangeProfileToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "DeskLibrary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.libraryTabPage.ResumeLayout(false);
            this.libraryTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataGridView)).EndInit();
            this.libraryContextMenuStrip.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readingDataGridView)).EndInit();
            this.readingContextMenuStrip.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alreadyReadDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage libraryTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView libraryDataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.DataGridView readingDataGridView;
        private System.Windows.Forms.ContextMenuStrip libraryContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem читаюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip readingContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alreadyReadToolStripMenuItem;
        private System.Windows.Forms.DataGridView alreadyReadDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChangeProfileToolStripMenuItem;
    }
}

