using MetroFramework.Controls;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Protocol;
using System.Text;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMQTT
{
  public partial class Form1 : MetroFramework.Forms.MetroForm
  {
    private IMqttClient client;
    private MqttClientOptions clientOptions;

    public delegate void _ShowMessage(MetroLabel lbl, string msg);
    public delegate void _ShowMessageTextBox(MetroTextBox txt, string msg);

    public delegate void _ShowMessageRT(string msg);
    public delegate void _ShowMessageStatus(string msg);
    public delegate void _ShowPictureBox(PictureBox pct, bool status);
    public Form1()
    {
      InitializeComponent();
    }

    private async void button_connect_Click(object sender, EventArgs e)
    {
      var BrokerAddress = textBox_broker.Text;
      // use a unique id as client id, each time we start the application
      var clientId = Guid.NewGuid().ToString();

      var factory = new MqttFactory();
      client = factory.CreateMqttClient();
      clientOptions = new MqttClientOptionsBuilder()
          .WithTcpServer(BrokerAddress, 1883) // Port is optional
          .WithClientId(clientId)
          .Build();

      client.ConnectedAsync += Client_ConnectedAsync;
      client.ConnectingAsync += Client_ConnectingAsync;
      client.DisconnectedAsync += Client_DisconnectedAsync;
      client.ApplicationMessageReceivedAsync += Client_ApplicationMessageReceivedAsync;

      await client.ConnectAsync(clientOptions, CancellationToken.None);
    }

    private Task Client_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
    {
      // get payload
      string ReceivedMessage = Encoding.UTF8.GetString(arg.ApplicationMessage.Payload);

      // get topic name
      string TopicReceived = arg.ApplicationMessage.Topic;

      //ShowMessageTextbox(this.TopicReceived, TopicReceived);

      // Show message
      ShowMessageRT(ReceivedMessage);

      return Task.CompletedTask;
    }

    // Disconnect
    private async Task Client_DisconnectedAsync(MqttClientDisconnectedEventArgs arg)
    {
      //ShowMessage(LblMqttStatus, "Disconnected");

      await Task.Delay(TimeSpan.FromSeconds(3));
      await client.ConnectAsync(clientOptions, CancellationToken.None); // Since 3.0.5 with CancellationToken
      //ShowMessage(LblMqttStatus, "Reconnecting");

      await Task.CompletedTask;
    }


    // Connecting
    private async Task Client_ConnectingAsync(MqttClientConnectingEventArgs arg)
    {
      //ShowMessage(LblMqttStatus, "Reconnecting");
      await Task.CompletedTask;
    }

    // Connected
    private async Task Client_ConnectedAsync(MqttClientConnectedEventArgs arg)
    {
      //ShowMessage(LblMqttStatus, "Connected");
      //client.SubscribeAsync(topic_sub);

      this.Invoke((MethodInvoker)delegate
      {
        button_connect.Enabled = false;
        textBox_broker.Enabled = false;

        //GBSubscribeTopic.Enabled = true;
        textBox_publish.Enabled = true;
        textBox_publish.ReadOnly = false;
      });

      await Task.CompletedTask;
    }


    // Subcribe
    private async void button_subcribe_Click(object sender, EventArgs e)
    {
      try
      {
        var topic_sub = new MqttTopicFilterBuilder()
            .WithTopic(textBox_subcribe_topic.Text)
            .WithAtMostOnceQoS()
            .Build();

        await client.SubscribeAsync(topic_sub);

        //listboxTopicSubscribe.Items.Add(TopicSubscribe.Text);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }


    // Public 
    private async void button_publish_Click(object sender, EventArgs e)
    {
      try
      {
        var message = new MqttApplicationMessageBuilder()
            .WithTopic(textBox_publish_topic.Text.Trim())
            .WithPayload(textBox_publish.Text)
            .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
            .WithRetainFlag()
            .Build();
        await client.PublishAsync(message, CancellationToken.None); // Since 3.0.5 with CancellationToken        
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }




    //#region "Delegate"
    public void ShowMessage(MetroLabel lbl, String msg)
    {
      if (InvokeRequired)
      {
        Invoke(new _ShowMessage(ShowMessage), new Object[] { lbl, msg });
        return;
      }
      lbl.Text = msg;
    }

    public void ShowMessageTextbox(MetroTextBox txt, String msg)
    {
      if (InvokeRequired)
      {
        Invoke(new _ShowMessageTextBox(ShowMessageTextbox), new Object[] { txt, msg });
        return;
      }
      txt.Text = msg;
    }


    public void ShowMessageRT(String msg)
    {
      if (InvokeRequired)
      {
        Invoke(new _ShowMessageRT(ShowMessageRT), new Object[] { msg });
        return;
      }
      textBox_subcribe.Text = msg;
    }
    //#endregion 

  }
}