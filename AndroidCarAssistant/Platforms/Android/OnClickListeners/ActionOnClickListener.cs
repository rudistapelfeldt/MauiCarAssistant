using System;
using AndroidX.Car.App;
using AndroidX.Car.App.Model;

namespace AndroidCarAssistant.Platforms.Android.OnClickListeners
{
    public class ActionOnClickListener : Java.Lang.Object, IOnClickListener
    {
        readonly CarContext _carContext;

        readonly string _message;

        public ActionOnClickListener(CarContext carContext, string message)
        {
            _carContext = carContext;
            _message = message;
        }

        void IOnClickListener.OnClick()
        {
            CarToast.MakeText(_carContext, _message, CarToast.LengthLong).Show();
        }
    }
}

