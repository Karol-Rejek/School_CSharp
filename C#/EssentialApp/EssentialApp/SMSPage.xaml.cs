using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace EssentialApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SMSPage : ContentPage
    {
        private string messageContent;

        public string MessageContent
        {
            get { return messageContent; }
            set { messageContent = value; }
        }
        
        private string recipient;

        public string Recipient
        {
            get { return recipient; }
            set { recipient = value; }
        }

        public SMSPage()
        {
            InitializeComponent();
        }

        private void SendSMS_Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Sms.ComposeAsync(new SmsMessage(MessageContent, Recipient));
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}