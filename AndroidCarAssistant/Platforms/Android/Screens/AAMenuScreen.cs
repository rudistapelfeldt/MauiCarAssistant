using System;
using AndroidCarAssistant.Platforms.Android.OnClickListeners;
using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;
using Action = AndroidX.Car.App.Model.Action;

namespace AndroidCarAssistant.Platforms.Android.Screens
{
    public class AAMenuScreen : Screen
    {
        public AAMenuScreen(CarContext carContext) : base(carContext)
        {
        }

        public override ITemplate OnGetTemplate()
        {
            var carIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.car_round);

            var carAndroidIcon = new CarIcon.Builder(carIconCompat).Build();

            var rowMessageItem = new Row.Builder()
                .SetTitle("Message Template")
                .SetImage(carAndroidIcon)
                .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, Enums.AAScreenEnums.RowMessageItem))
                .SetBrowsable(true)
                .Build();

            var rowPaneItem = new Row.Builder()
                .SetTitle("Pane Template")
                .SetImage(carAndroidIcon)
                .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, Enums.AAScreenEnums.RowPanelItem))
                .SetBrowsable(true)
                .Build();

            var rowGridItem = new Row.Builder()
                .SetTitle("Grid Template")
                .SetImage(carAndroidIcon)
                .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, Enums.AAScreenEnums.RowGridItem))
                .SetBrowsable(true)
                .Build();

            var itemList = new ItemList.Builder()
                .SetNoItemsMessage("This app is running on Android Auto")
                .AddItem(rowMessageItem)
                .AddItem(rowPaneItem)
                .AddItem(rowGridItem)
                .Build();

            return new ListTemplate.Builder()
                .SetTitle("Android Car Menu")
                .SetHeaderAction(Action.AppIcon)
                .SetSingleList(itemList)
                .Build();
        }
    }
}

