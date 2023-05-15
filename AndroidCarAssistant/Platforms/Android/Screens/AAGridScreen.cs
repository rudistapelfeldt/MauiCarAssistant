using System;
using AndroidCarAssistant.Platforms.Android.OnClickListeners;
using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;
using Action = AndroidX.Car.App.Model.Action;

namespace AndroidCarAssistant.Platforms.Android.Screens
{
    public class AAGridScreen : Screen
    {
        public AAGridScreen(CarContext carContext) : base(carContext)
        {
        }

        public override ITemplate OnGetTemplate()
        {
            try
            {
                var gridIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.grid);

                var gridAndroidIcon = new CarIcon.Builder(gridIconCompat).Build();

                var gridItemListBuilder = new ItemList.Builder().SetNoItemsMessage("No list items found.");

                var actionOne = new Action.Builder()
                    .SetIcon(gridAndroidIcon)
                    .SetOnClickListener(new ActionOnClickListener(CarContext, "Action strip 1 was clicked"))
                    .Build();

                var actionTwo = new Action.Builder()
                    .SetIcon(gridAndroidIcon)
                    .SetOnClickListener(new ActionOnClickListener(CarContext, "Action strip 2 was clicked"))
                    .Build();

                var actionStrip = new ActionStrip.Builder()
                    .AddAction(actionOne)
                    .AddAction(actionTwo)
                    .Build();

                for (var i = 0; i < 10; i++)
                {
                    var gridItem = new GridItem.Builder()
                        .SetTitle($"Grid Header {i}.")
                        .SetText($"Grid body text {i}.")
                        .SetImage(gridAndroidIcon)
                        .SetOnClickListener(new ActionOnClickListener(CarContext, $"Grid item {i} was clicked"))
                        .Build();
                    gridItemListBuilder.AddItem(gridItem);
                }

                var grid = gridItemListBuilder.Build();

                return new GridTemplate.Builder()
                    .SetHeaderAction(Action.Back)
                    .SetSingleList(grid)
                    .SetActionStrip(actionStrip)
                    .Build();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}

