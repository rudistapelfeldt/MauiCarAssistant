using System;
using Android.App;
using AndroidCarAssistant.Platforms.Android.Session;
using AndroidX.Car.App;
using AndroidX.Car.App.Validation;

namespace AndroidCarAssistant.Platforms.Android.Service
{
    [Service(Exported = true)]
    [IntentFilter(new string[] { "androidx.car.app.CarAppService" }, Categories = new[] { "androidx.car.app.category.POI" })]
    public class AACarService : CarAppService
    {
        public override HostValidator CreateHostValidator()
        {
            return HostValidator.AllowAllHostsValidator;
        }

        public override AndroidX.Car.App.Session OnCreateSession()
        {
            return new AASession();
        }
    }
}

