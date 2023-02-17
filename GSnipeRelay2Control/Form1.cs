using System.Collections;
using UsbRelayNet.RelayLib;
using UsbRelayNet.HidLib;
using UsbRelayNet.Win32;
using DemoUI;

namespace GSnipeRelay2Control
{
    public partial class Form1 : Form
    {

        private RelaysEnumerator relaysEnumerator = new();

        private RelayItem[] devices;

        private Relay selectedRelay;

        private List<bool> lightOn = new();

        public Form1()
        {
            InitializeComponent();
            RefreshDevices();
            RefreshTogglesButton();
            ToggleRelayConnection();
        }

        private void RefreshDevices()
        {
            if(devices != null) Array.Clear(devices);

            DevicesComboList.Items.Clear();

            devices = relaysEnumerator.CollectInfo().Select(x => new RelayItem(x)).ToArray();

            foreach (RelayItem item in devices)
            {
                DevicesComboList.Items.Add
                    (item.RelayInfo.Id + " " + item.RelayInfo.HidInfo.Version + " (" + item.RelayInfo.HidInfo.Vendor + ") ");
            }

            if(DevicesComboList.SelectedIndex < 0 && DevicesComboList.Items.Count > 0)
            {
                DevicesComboList.SelectedIndex = 0;
            }
        }

        private void ToggleRelay(int index)
        {
            Panel a = new Panel();

        }

        private void RefreshTogglesButton()
        {
            foreach(Button button in ToggleButtonsLay.Controls)
            {
                button.Enabled = false;

                button.ForeColor= Color.White;
            }

            if (selectedRelay == null || !selectedRelay.IsOpened) return;

            for(int i = 0; i < selectedRelay.ChannelsCount; i++)
            {
                ToggleButtonsLay.Controls[i].Enabled = true;

                if (!selectedRelay.ReadChannel(i + 1))
                {
                    ToggleButtonsLay.Controls[i].BackColor = Color.Red;
                    continue;
                }

                ToggleButtonsLay.Controls[i].BackColor = Color.Green;

            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        private void OnToggleButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse((sender as Button).Text.Last().ToString());
            
            if(selectedRelay.ReadChannel(index))
            {
                selectedRelay.WriteChannel(index, false);
                (sender as Button).BackColor = Color.Red;
            }
            else
            {
                selectedRelay.WriteChannel(index, true);
                (sender as Button).BackColor = Color.Green;
            }

            

        }

        private void DevicesComboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = DevicesComboList.SelectedIndex;
            selectedRelay = devices.Select(x => new Relay(x.RelayInfo)).ElementAt(index);
            CheckRelayConnection();

        }

        private void OnToggleRelayConnection(object sender, EventArgs e)
        {
            ToggleRelayConnection();
        }

        private void CheckRelayConnection()
        {
            if(!selectedRelay.IsOpened)
            {
                RelayConnectionToggleButton.Text = "Relay Status : OFFLINE";
                RelayConnectionToggleButton.ForeColor = Color.Red;
            }
               
            else
            {
                RelayConnectionToggleButton.Text = "Relay Status : ONLINE";
                RelayConnectionToggleButton.ForeColor = Color.Green;
            }
                
                
        }

        private void ToggleRelayConnection()
        {
            if (selectedRelay == null)
            {
                MessageBox.Show("Pilih device yang valid!");
                return;
            }

            if (selectedRelay.IsOpened)
            {
                selectedRelay.Close();
                CheckRelayConnection();
            }
            else
            {
                selectedRelay.Open();
                CheckRelayConnection();
            }

            RefreshTogglesButton();
        }

        private void OnOpenAll(object sender, EventArgs e)
        {
            selectedRelay.WriteChannels(true);
            RefreshTogglesButton();
        }

        private void OnCloseAll(object sender, EventArgs e)
        {
            selectedRelay.WriteChannels(false);
            RefreshTogglesButton();
        }

    }
}