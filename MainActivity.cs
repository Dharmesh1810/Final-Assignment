using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using Android.Content;

namespace Final_Assignment
{
    [Activity(Label = "Final_Assignment", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


        }
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }


        async void SimulateStartup()
        {
            await Task.Delay(7000);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

    }
}

