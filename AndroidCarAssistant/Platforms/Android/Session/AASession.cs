using System;
using Android.Content;
using AndroidCarAssistant.Platforms.Android.Screens;
using AndroidX.Car.App;
namespace AndroidCarAssistant.Platforms.Android.Session
{
    public class AASession : AndroidX.Car.App.Session
    {
        public override Screen OnCreateScreen(Intent p0)
        {
            return new AAMenuScreen(CarContext);
        }
    }
}

