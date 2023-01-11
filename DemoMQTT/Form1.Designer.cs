namespace DemoMQTT
{
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
      this.button_connect = new System.Windows.Forms.Button();
      this.textBox_broker = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBox_subcribe = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox_subcribe_topic = new System.Windows.Forms.TextBox();
      this.button_subcribe = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.textBox_publish = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox_publish_topic = new System.Windows.Forms.TextBox();
      this.button_publish = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // button_connect
      // 
      this.button_connect.Location = new System.Drawing.Point(343, 82);
      this.button_connect.Name = "button_connect";
      this.button_connect.Size = new System.Drawing.Size(94, 29);
      this.button_connect.TabIndex = 0;
      this.button_connect.Text = "Connect";
      this.button_connect.UseVisualStyleBackColor = true;
      this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
      // 
      // textBox_broker
      // 
      this.textBox_broker.Location = new System.Drawing.Point(93, 83);
      this.textBox_broker.Name = "textBox_broker";
      this.textBox_broker.Size = new System.Drawing.Size(222, 27);
      this.textBox_broker.TabIndex = 1;
      this.textBox_broker.Text = "ismaillowkey.my.id";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(30, 86);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "MQTT";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.textBox_subcribe);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.textBox_subcribe_topic);
      this.groupBox1.Controls.Add(this.button_subcribe);
      this.groupBox1.Location = new System.Drawing.Point(30, 168);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(347, 246);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Subcribe";
      // 
      // textBox_subcribe
      // 
      this.textBox_subcribe.Location = new System.Drawing.Point(21, 73);
      this.textBox_subcribe.Multiline = true;
      this.textBox_subcribe.Name = "textBox_subcribe";
      this.textBox_subcribe.Size = new System.Drawing.Size(315, 153);
      this.textBox_subcribe.TabIndex = 8;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 29);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 20);
      this.label2.TabIndex = 7;
      this.label2.Text = "Topic";
      // 
      // textBox_subcribe_topic
      // 
      this.textBox_subcribe_topic.Location = new System.Drawing.Point(84, 26);
      this.textBox_subcribe_topic.Name = "textBox_subcribe_topic";
      this.textBox_subcribe_topic.Size = new System.Drawing.Size(126, 27);
      this.textBox_subcribe_topic.TabIndex = 6;
      // 
      // button_subcribe
      // 
      this.button_subcribe.Location = new System.Drawing.Point(242, 26);
      this.button_subcribe.Name = "button_subcribe";
      this.button_subcribe.Size = new System.Drawing.Size(94, 29);
      this.button_subcribe.TabIndex = 5;
      this.button_subcribe.Text = "Subcribe";
      this.button_subcribe.UseVisualStyleBackColor = true;
      this.button_subcribe.Click += new System.EventHandler(this.button_subcribe_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.textBox_publish);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.textBox_publish_topic);
      this.groupBox2.Controls.Add(this.button_publish);
      this.groupBox2.Location = new System.Drawing.Point(415, 168);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(347, 246);
      this.groupBox2.TabIndex = 8;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Publish";
      // 
      // textBox_publish
      // 
      this.textBox_publish.Location = new System.Drawing.Point(21, 73);
      this.textBox_publish.Multiline = true;
      this.textBox_publish.Name = "textBox_publish";
      this.textBox_publish.Size = new System.Drawing.Size(315, 153);
      this.textBox_publish.TabIndex = 8;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(21, 29);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 20);
      this.label3.TabIndex = 7;
      this.label3.Text = "Topic";
      // 
      // textBox_publish_topic
      // 
      this.textBox_publish_topic.Location = new System.Drawing.Point(84, 26);
      this.textBox_publish_topic.Name = "textBox_publish_topic";
      this.textBox_publish_topic.Size = new System.Drawing.Size(126, 27);
      this.textBox_publish_topic.TabIndex = 6;
      // 
      // button_publish
      // 
      this.button_publish.Location = new System.Drawing.Point(242, 26);
      this.button_publish.Name = "button_publish";
      this.button_publish.Size = new System.Drawing.Size(94, 29);
      this.button_publish.TabIndex = 5;
      this.button_publish.Text = "Publish";
      this.button_publish.UseVisualStyleBackColor = true;
      this.button_publish.Click += new System.EventHandler(this.button_publish_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(799, 443);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox_broker);
      this.Controls.Add(this.button_connect);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button button_connect;
    private TextBox textBox_broker;
    private Label label1;
    private GroupBox groupBox1;
    private TextBox textBox_subcribe;
    private Label label2;
    private TextBox textBox_subcribe_topic;
    private Button button_subcribe;
    private GroupBox groupBox2;
    private TextBox textBox_publish;
    private Label label3;
    private TextBox textBox_publish_topic;
    private Button button_publish;
  }
}