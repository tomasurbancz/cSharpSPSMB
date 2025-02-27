﻿using System.ComponentModel;

namespace DatabaseViewForm;

partial class DatabaseForm
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        UserListView = new System.Windows.Forms.ListView();
        idCol = new System.Windows.Forms.ColumnHeader();
        usernameCol = new System.Windows.Forms.ColumnHeader();
        createdDateCol = new System.Windows.Forms.ColumnHeader();
        modifiedDateCol = new System.Windows.Forms.ColumnHeader();
        button1 = new System.Windows.Forms.Button();
        ErrorLabel = new System.Windows.Forms.Label();
        usernameButton = new System.Windows.Forms.Button();
        username = new System.Windows.Forms.TextBox();
        IdButton = new System.Windows.Forms.Button();
        IdBox = new System.Windows.Forms.TextBox();
        finding = new System.Windows.Forms.TextBox();
        nameBox = new System.Windows.Forms.TextBox();
        idBox2 = new System.Windows.Forms.TextBox();
        nameButton = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        ErrorLabel = new System.Windows.Forms.Label();
        TextBoxNewUser = new System.Windows.Forms.TextBox();
        CreateUserButton = new System.Windows.Forms.Button();
        ButtonDelete = new System.Windows.Forms.Button();
        TextBoxDeleteUser = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // UserListView
        // 
        UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idCol, usernameCol, createdDateCol, modifiedDateCol });
        UserListView.Location = new System.Drawing.Point(12, 41);
        UserListView.Name = "UserListView";
        UserListView.Size = new System.Drawing.Size(483, 352);
        UserListView.Size = new System.Drawing.Size(590, 169);
        UserListView.TabIndex = 0;
        UserListView.UseCompatibleStateImageBehavior = false;
        UserListView.View = System.Windows.Forms.View.Details;
        // 
        // idCol
        // 
        idCol.Name = "idCol";
        idCol.Text = "Id";
        idCol.Width = 56;
        // 
        // usernameCol
        // 
        usernameCol.Name = "usernameCol";
        usernameCol.Text = "Username";
        usernameCol.Width = 153;
        // 
        // createdDateCol
        // 
        createdDateCol.Name = "createdDateCol";
        createdDateCol.Text = "Created";
        createdDateCol.Width = 94;
        // 
        // modifiedDateCol
        // 
        modifiedDateCol.Name = "modifiedDateCol";
        modifiedDateCol.Text = "Modified";
        modifiedDateCol.Width = 218;
        // 
        // PasswordTextBox
        // 
        PasswordTextBox.Location = new System.Drawing.Point(176, 232);
        PasswordTextBox.Name = "PasswordTextBox";
        PasswordTextBox.Size = new System.Drawing.Size(287, 23);
        PasswordTextBox.TabIndex = 1;
        PasswordTextBox.Enter += PasswordTextBox_Enter;
        PasswordTextBox.KeyPress += PasswordTextBox_KeyPressed;
        PasswordTextBox.Leave += PasswordTextBox_Leave;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(665, 9);
        button1.Location = new System.Drawing.Point(479, 232);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(123, 26);
        button1.TabIndex = 2;
        button1.Text = "Fetch";
        button1.UseVisualStyleBackColor = true;
        button1.Click += FetchButton_Click;
        // 
        // ErrorLabel
        // 
        ErrorLabel.Enabled = false;
        ErrorLabel.Location = new System.Drawing.Point(12, 418);
        ErrorLabel.Name = "ErrorLabel";
        ErrorLabel.Size = new System.Drawing.Size(197, 23);
        ErrorLabel.TabIndex = 3;
        ErrorLabel.Text = "label1";
        ErrorLabel.Visible = false;
        // 
        // usernameButton
        // 
        usernameButton.Location = new System.Drawing.Point(665, 169);
        usernameButton.Name = "usernameButton";
        usernameButton.Size = new System.Drawing.Size(123, 26);
        usernameButton.TabIndex = 5;
        usernameButton.Text = "Add";
        usernameButton.UseVisualStyleBackColor = true;
        usernameButton.Click += usernameButton_Click;
        // 
        // username
        // 
        username.Location = new System.Drawing.Point(501, 140);
        username.Name = "username";
        username.Size = new System.Drawing.Size(287, 23);
        username.TabIndex = 4;
        username.Enter += username_Enter;
        username.KeyPress += username_KeyPress;
        username.Leave += username_Leave;
        // 
        // IdButton
        // 
        IdButton.Location = new System.Drawing.Point(665, 321);
        IdButton.Name = "IdButton";
        IdButton.Size = new System.Drawing.Size(123, 26);
        IdButton.TabIndex = 7;
        IdButton.Text = "Remove";
        IdButton.UseVisualStyleBackColor = true;
        IdButton.Click += IdButton_Click;
        // 
        // IdBox
        // 
        IdBox.Location = new System.Drawing.Point(501, 324);
        IdBox.Name = "IdBox";
        IdBox.Size = new System.Drawing.Size(158, 23);
        IdBox.TabIndex = 6;
        IdBox.KeyPress += IdBox_KeyPress;
        // 
        // finding
        // 
        finding.Location = new System.Drawing.Point(12, 12);
        finding.Name = "finding";
        finding.Size = new System.Drawing.Size(483, 23);
        finding.TabIndex = 8;
        finding.KeyUp += finding_KeyUp;
        // 
        // nameBox
        // 
        nameBox.Location = new System.Drawing.Point(501, 253);
        nameBox.Name = "nameBox";
        nameBox.Size = new System.Drawing.Size(287, 23);
        nameBox.TabIndex = 9;
        nameBox.KeyPress += nameBox_KeyPress;
        // 
        // idBox2
        // 
        idBox2.Location = new System.Drawing.Point(501, 211);
        idBox2.Name = "idBox2";
        idBox2.Size = new System.Drawing.Size(158, 23);
        idBox2.TabIndex = 10;
        // 
        // nameButton
        // 
        nameButton.Location = new System.Drawing.Point(665, 282);
        nameButton.Name = "nameButton";
        nameButton.Size = new System.Drawing.Size(123, 26);
        nameButton.TabIndex = 11;
        nameButton.Text = "Name";
        nameButton.UseVisualStyleBackColor = true;
        nameButton.Click += nameButton_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(665, 412);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(123, 26);
        button2.TabIndex = 12;
        button2.Text = "Back";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // ErrorLabel
        // 
        ErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        ErrorLabel.ForeColor = System.Drawing.Color.Red;
        ErrorLabel.Location = new System.Drawing.Point(306, 312);
        ErrorLabel.Name = "ErrorLabel";
        ErrorLabel.Size = new System.Drawing.Size(426, 24);
        ErrorLabel.TabIndex = 3;
        // 
        // TextBoxNewUser
        // 
        TextBoxNewUser.Location = new System.Drawing.Point(608, 41);
        TextBoxNewUser.Name = "TextBoxNewUser";
        TextBoxNewUser.Size = new System.Drawing.Size(180, 23);
        TextBoxNewUser.TabIndex = 4;
        TextBoxNewUser.KeyDown += TextBoxNewUser_KeyDown;
        // 
        // CreateUserButton
        // 
        CreateUserButton.Location = new System.Drawing.Point(700, 70);
        CreateUserButton.Name = "CreateUserButton";
        CreateUserButton.Size = new System.Drawing.Size(88, 25);
        CreateUserButton.TabIndex = 5;
        CreateUserButton.Text = "Create User";
        CreateUserButton.UseVisualStyleBackColor = true;
        CreateUserButton.Click += ButtonNewUser_Click;
        // 
        // ButtonDelete
        // 
        ButtonDelete.Location = new System.Drawing.Point(700, 148);
        ButtonDelete.Name = "ButtonDelete";
        ButtonDelete.Size = new System.Drawing.Size(88, 25);
        ButtonDelete.TabIndex = 6;
        ButtonDelete.Text = "Delete";
        ButtonDelete.UseVisualStyleBackColor = true;
        ButtonDelete.Click += ButtonDelete_Click;
        // 
        // TextBoxDeleteUser
        // 
        TextBoxDeleteUser.Location = new System.Drawing.Point(608, 119);
        TextBoxDeleteUser.Name = "TextBoxDeleteUser";
        TextBoxDeleteUser.Size = new System.Drawing.Size(180, 23);
        TextBoxDeleteUser.TabIndex = 7;
        TextBoxDeleteUser.KeyDown += TextBoxDeleteUser_KeyDown;
        // 
        // DatabaseForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(TextBoxDeleteUser);
        Controls.Add(ButtonDelete);
        Controls.Add(CreateUserButton);
        Controls.Add(TextBoxNewUser);
        Controls.Add(ErrorLabel);
        Controls.Add(button2);
        Controls.Add(nameButton);
        Controls.Add(idBox2);
        Controls.Add(nameBox);
        Controls.Add(finding);
        Controls.Add(IdButton);
        Controls.Add(IdBox);
        Controls.Add(usernameButton);
        Controls.Add(username);
        Controls.Add(ErrorLabel);
        Controls.Add(button1);
        Controls.Add(UserListView);
        ForeColor = System.Drawing.Color.DarkRed;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox TextBoxDeleteUser;

    private System.Windows.Forms.Button ButtonDelete;

    private System.Windows.Forms.TextBox TextBoxNewUser;
    private System.Windows.Forms.Button CreateUserButton;

    private System.Windows.Forms.Label ErrorLabel;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TextBox nameBox;
    private System.Windows.Forms.TextBox idBox2;
    private System.Windows.Forms.Button nameButton;

    private System.Windows.Forms.TextBox finding;

    private System.Windows.Forms.Button IdButton;
    private System.Windows.Forms.TextBox IdBox;

    private System.Windows.Forms.TextBox username;
    private System.Windows.Forms.Button usernameButton;

    private System.Windows.Forms.Label ErrorLabel;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.ColumnHeader idCol;
    private System.Windows.Forms.ColumnHeader usernameCol;
    private System.Windows.Forms.ColumnHeader createdDateCol;
    private System.Windows.Forms.ColumnHeader modifiedDateCol;

    private System.Windows.Forms.ListView UserListView;

    #endregion
}