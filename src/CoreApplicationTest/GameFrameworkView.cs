// Copyright (c) Peter Nylander. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Windows.ApplicationModel;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace CoreApplicationTest
{
    public class GameFrameworkView : IFrameworkView
    {
        private Window window;

        public void Initialize(CoreApplicationView applicationView)
        {
            applicationView.Activated += this.ApplicationView_Activated;
            CoreApplication.Suspending += this.CoreApplication_Suspending;
            CoreApplication.Resuming += this.CoreApplication_Resuming;
        }

        public void SetWindow(CoreWindow coreWindow)
        {
            this.window = new Window(coreWindow);
        }

        public void Load(string entryPoint)
        {
        }

        public void Run()
        {
            this.window.Run();
        }

        public void Uninitialize()
        {
        }

        private void ApplicationView_Activated(CoreApplicationView sender, Windows.ApplicationModel.Activation.IActivatedEventArgs args)
        {
            var window = CoreWindow.GetForCurrentThread();
            window.Activate();
        }

        private void CoreApplication_Suspending(object sender, Windows.ApplicationModel.SuspendingEventArgs e)
        {
            SuspendingDeferral deferral = e.SuspendingOperation.GetDeferral();

            deferral.Complete();
        }

        private void CoreApplication_Resuming(object sender, object e)
        {
        }
    }
}
