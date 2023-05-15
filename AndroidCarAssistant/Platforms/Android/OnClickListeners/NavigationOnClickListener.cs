using System;
using AndroidCarAssistant.Platforms.Android.Enums;
using AndroidCarAssistant.Platforms.Android.Screens;
using AndroidX.Car.App;
using AndroidX.Car.App.Model;

namespace AndroidCarAssistant.Platforms.Android.OnClickListeners
{
    public class NavigationOnClickListener : Java.Lang.Object, IOnClickListener
    {
        readonly CarContext _carContext;

        readonly ScreenManager _screenManager;

        readonly AAScreenEnums _screenToNavigateTo;

        public NavigationOnClickListener(CarContext carContext, ScreenManager screenManager, AAScreenEnums screenToNavigateTo)
        {
            _carContext = carContext;
            _screenManager = screenManager;
            _screenToNavigateTo = screenToNavigateTo;
        }

        public void OnClick()
        {
            switch(_screenToNavigateTo)
            {
                case AAScreenEnums.None:
                    return;
                case AAScreenEnums.Menu:
                    _screenManager.Push(new AAMenuScreen(_carContext));
                    break;
                case AAScreenEnums.RowGridItem:
                    _screenManager.Push(new AAGridScreen(_carContext));
                    break;
                case AAScreenEnums.RowMessageItem:
                    _screenManager.Push(new AAMessageScreen(_carContext));
                    break;
                case AAScreenEnums.RowPanelItem:
                    _screenManager.Push(new AAPaneScreen(_carContext));
                    break;
                case AAScreenEnums.Pop:
                    _screenManager.Pop();
                    break;
                default:
                    return;
            }
        }
    }
}

