﻿using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Preview10
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}