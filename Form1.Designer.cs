namespace form_03;

partial class Form1
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
        this.action = new System.Windows.Forms.Button();
        //
        // action
        //
        this.action.Location = new System.Drawing.Point(92, 62);
        this.action.Name = "action";
        this.action.Size = new System.Drawing.Size(75, 23);
        this.action.TabIndex = 0;
        this.action.Text = "実行";
        this.action.UseVisualStyleBackColor = true;
        this.action.Click += new System.EventHandler(this.action_Click);

        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
        this.Controls.Add(this.action);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

    }

    #endregion
    private Button action;
}
