namespace BookStoreApp.WFM
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxBookStore = new System.Windows.Forms.ListBox();
            this.listBoxDepartment = new System.Windows.Forms.ListBox();
            this.buttonAddBookStore = new System.Windows.Forms.Button();
            this.buttonRemoveBookStore = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.buttonTotalSum = new System.Windows.Forms.Button();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridAttribs = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAttribs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Списки объектов";
            // 
            // listBoxBookStore
            // 
            this.listBoxBookStore.FormattingEnabled = true;
            this.listBoxBookStore.Location = new System.Drawing.Point(15, 34);
            this.listBoxBookStore.Name = "listBoxBookStore";
            this.listBoxBookStore.Size = new System.Drawing.Size(190, 134);
            this.listBoxBookStore.TabIndex = 14;
            // 
            // listBoxDepartment
            // 
            this.listBoxDepartment.FormattingEnabled = true;
            this.listBoxDepartment.Location = new System.Drawing.Point(261, 34);
            this.listBoxDepartment.Name = "listBoxDepartment";
            this.listBoxDepartment.Size = new System.Drawing.Size(190, 134);
            this.listBoxDepartment.TabIndex = 15;
            // 
            // buttonAddBookStore
            // 
            this.buttonAddBookStore.Location = new System.Drawing.Point(18, 188);
            this.buttonAddBookStore.Name = "buttonAddBookStore";
            this.buttonAddBookStore.Size = new System.Drawing.Size(89, 23);
            this.buttonAddBookStore.TabIndex = 16;
            this.buttonAddBookStore.Text = "Добавить ";
            this.buttonAddBookStore.UseVisualStyleBackColor = true;
            this.buttonAddBookStore.Click += new System.EventHandler(this.buttonAddBookStore_Click);
            // 
            // buttonRemoveBookStore
            // 
            this.buttonRemoveBookStore.Location = new System.Drawing.Point(124, 188);
            this.buttonRemoveBookStore.Name = "buttonRemoveBookStore";
            this.buttonRemoveBookStore.Size = new System.Drawing.Size(81, 23);
            this.buttonRemoveBookStore.TabIndex = 17;
            this.buttonRemoveBookStore.Text = "Удалить";
            this.buttonRemoveBookStore.UseVisualStyleBackColor = true;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(261, 188);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(88, 23);
            this.buttonAddBook.TabIndex = 18;
            this.buttonAddBook.Text = "Добавить";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.Location = new System.Drawing.Point(362, 188);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(89, 23);
            this.buttonRemoveBook.TabIndex = 19;
            this.buttonRemoveBook.Text = "Продать";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            // 
            // buttonTotalSum
            // 
            this.buttonTotalSum.Location = new System.Drawing.Point(18, 247);
            this.buttonTotalSum.Name = "buttonTotalSum";
            this.buttonTotalSum.Size = new System.Drawing.Size(190, 23);
            this.buttonTotalSum.TabIndex = 20;
            this.buttonTotalSum.Text = "Суммарная стоимость книг";
            this.buttonTotalSum.UseVisualStyleBackColor = true;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(229, 247);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Сумма, ₽:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(362, 244);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridAttribs
            // 
            this.dataGridAttribs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAttribs.Location = new System.Drawing.Point(18, 276);
            this.dataGridAttribs.Name = "dataGridAttribs";
            this.dataGridAttribs.Size = new System.Drawing.Size(433, 134);
            this.dataGridAttribs.TabIndex = 24;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(18, 426);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 23);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Сохранить данные";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(338, 426);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(113, 23);
            this.buttonLoad.TabIndex = 26;
            this.buttonLoad.Text = "Загрузить данные";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 486);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridAttribs);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.buttonTotalSum);
            this.Controls.Add(this.buttonRemoveBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonRemoveBookStore);
            this.Controls.Add(this.buttonAddBookStore);
            this.Controls.Add(this.listBoxDepartment);
            this.Controls.Add(this.listBoxBookStore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAttribs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxBookStore;
        private System.Windows.Forms.ListBox listBoxDepartment;
        private System.Windows.Forms.Button buttonAddBookStore;
        private System.Windows.Forms.Button buttonRemoveBookStore;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.Button buttonTotalSum;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridAttribs;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
    }
}

