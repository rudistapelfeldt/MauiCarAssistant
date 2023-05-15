using AndroidCarAssistant.Platforms.Android.OnClickListeners;
using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;
using Action = AndroidX.Car.App.Model.Action;

namespace AndroidCarAssistant.Platforms.Android.Screens
{
    public class AAPaneScreen : Screen
    {
        public AAPaneScreen(CarContext carContext) : base(carContext)
        {
        }

        public override ITemplate OnGetTemplate()
        {

            var panelIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.panel);

            var panelAndroidIcon = new CarIcon.Builder(panelIconCompat).Build();

            var panelAction = new Action.Builder()
                .SetIcon(panelAndroidIcon)
                .SetTitle("Go Back")
                .SetBackgroundColor(CarColor.Red)
                .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, Enums.AAScreenEnums.Pop))
                .Build();

            var actionOne = new Action.Builder()
                .SetIcon(panelAndroidIcon)
                .SetOnClickListener(new ActionOnClickListener(CarContext, "Action strip 1 was clicked"))
                .Build();

            var actionTwo = new Action.Builder()
                .SetIcon(panelAndroidIcon)
                .SetOnClickListener(new ActionOnClickListener(CarContext, "Action strip 2 was clicked"))
                .Build();

            var panelBuilder = new Pane.Builder()
                .SetImage(panelAndroidIcon)
                .AddAction(panelAction);

            var actionStrip = new ActionStrip.Builder()
                .AddAction(actionOne)
                .AddAction(actionTwo)
                .Build();

            for (var i = 0; i < 10; i++)
            {
                var row = new Row.Builder()
                    .SetTitle($"Row {i}.")
                    .SetImage(panelAndroidIcon)
                    .AddText($"This is row {i}.")
                    .Build();

                panelBuilder.AddRow(row);
            }
            var pane = panelBuilder.Build();

            return new PaneTemplate.Builder(pane)
                .SetHeaderAction(Action.Back)
                .SetActionStrip(actionStrip)
                .Build();

        }
    }
}

