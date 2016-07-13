﻿namespace Wpf.Demonstrations {
    using System.Windows;

    public partial class App : Application {

        protected override void OnStartup(StartupEventArgs e) {
            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }

    }
}
