using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;

namespace HomeyApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = false)]
    public class MainMenu : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.main_menu);
            var userData = Application.Context.GetSharedPreferences("userData", FileCreationMode.Private);
            var name = userData.GetString("Name", "");
            var nickname = userData.GetString("Nickname", "");

            
        }
    }
}