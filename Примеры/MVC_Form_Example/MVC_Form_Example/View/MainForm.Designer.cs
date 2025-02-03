namespace MVC_Form_Example
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdd = new Button();
            buttonRemove = new Button();
            listBoxContacts = new ListBox();
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxPhoneNumber = new MaskedTextBox();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 88);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(93, 88);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 1;
            buttonRemove.Text = "Удалить";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // listBoxContacts
            // 
            listBoxContacts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxContacts.FormattingEnabled = true;
            listBoxContacts.ItemHeight = 15;
            listBoxContacts.Location = new Point(12, 117);
            listBoxContacts.Name = "listBoxContacts";
            listBoxContacts.Size = new Size(351, 319);
            listBoxContacts.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(50, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(118, 23);
            textBoxName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 5;
            label1.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 44);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 6;
            label2.Text = "Тел:";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(50, 41);
            textBoxPhoneNumber.Mask = "(999) 000-0000";
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(118, 23);
            textBoxPhoneNumber.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 450);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(listBoxContacts);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Name = "MainForm";
            Text = "Контакты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonRemove;
        private ListBox listBoxContacts;
        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private MaskedTextBox textBoxPhoneNumber;
    }
}
