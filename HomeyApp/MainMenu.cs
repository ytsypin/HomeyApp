using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Net.Wifi.P2p;
using Android.Net.Wifi;
using System.Collections.Generic;

namespace HomeyApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = false)]
    public class MainMenu : AppCompatActivity
    {
        WifiP2pManager wifiManager;

        List<string> deviceNameArray;
        List<WifiP2pDevice> deviceArray;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.main_menu);
            var userData = Application.Context.GetSharedPreferences("userData", FileCreationMode.Private);
            var name = userData.GetString("Name", "");
            var nickname = userData.GetString("Nickname", "");

            wifiManager = (WifiP2pManager)Application.Context.GetSystemService(Context.WifiP2pService);


            var intentFilter = new IntentFilter();
            intentFilter.AddAction(WifiP2pManager.WifiP2pStateChangedAction);
            intentFilter.AddAction(WifiP2pManager.WifiP2pPeersChangedAction);
            intentFilter.AddAction(WifiP2pManager.WifiP2pConnectionChangedAction);
            intentFilter.AddAction(WifiP2pManager.WifiP2pThisDeviceChangedAction);


        }
    }
}