using System;
using Android.Runtime;
using AndroidCarAssistant.Platforms.Android.OnClickListeners;
using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;
using Action = AndroidX.Car.App.Model.Action;

namespace AndroidCarAssistant.Platforms.Android.Screens
{
    public class AAMessageScreen : AndroidX.Car.App.Screen
    {
        public AAMessageScreen(CarContext carContext) : base(carContext)
        {
        }

        public override ITemplate OnGetTemplate()
        {
            var messageIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.message_round);

            var messageAndroidIcon = new CarIcon.Builder(messageIconCompat).Build();

            var cancelAction = new Action.Builder()
                .SetIcon(messageAndroidIcon)
                .SetBackgroundColor(CarColor.Red)
                .SetOnClickListener(new ActionOnClickListener(CarContext, "Canceled"))
                .SetTitle("Cancel")
                .Build();

            var acceptAction = new Action.Builder()
                .SetIcon(messageAndroidIcon)
                .SetBackgroundColor(CarColor.Green)
                .SetOnClickListener(new ActionOnClickListener(CarContext, "Accepted"))
                .SetTitle("Accept")
                .Build();

            return new MessageTemplate.Builder("Message screen")
                .SetTitle("Android Car Message screen")
                .SetHeaderAction(Action.Back)
                .SetIcon(messageAndroidIcon)
                .AddAction(cancelAction)
                .AddAction(acceptAction)
                .Build();
        }
    }
}

