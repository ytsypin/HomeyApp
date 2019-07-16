using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Net.Wifi.P2p;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HomeyApp
{
    class WifiDirectBroadcastReceiver : BroadcastReceiver
    {
        private WifiP2pManager mManager;
        private WifiP2pManager.Channel mChannel;
        private MainActivity mMainActivity;

        public WifiDirectBroadcastReceiver(WifiP2pManager p2pManager, WifiP2pManager.Channel p2pChannel, MainActivity mainActivity)
        {
            this.mManager = p2pManager;
            this.mChannel = p2pChannel;
            this.mMainActivity = mainActivity;
        }

        public override void OnReceive(Context context, Intent intent)
        {
            throw new NotImplementedException();
        }
    }
}