// Copyright (c) Peter Nylander. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Windows.UI.Core;

namespace CoreApplicationTest
{
    public class Window
    {
        private bool isVisible = true;
        private bool isClosed = false;

        public Window(CoreWindow coreWindow)
        {
            this.CoreWindow = coreWindow;
            this.CoreWindow.SizeChanged += this.CoreWindow_SizeChanged;
            this.CoreWindow.VisibilityChanged += this.CoreWindow_VisibilityChanged;
            this.CoreWindow.Closed += this.CoreWindow_Closed;

            this.Width = (int)this.CoreWindow.Bounds.Width;
            this.Height = (int)this.CoreWindow.Bounds.Height;
        }

        public CoreWindow CoreWindow { get; }

        public int Width { get; }

        public int Height { get; }

        public void Run()
        {
            while (!this.isClosed)
            {
                if (this.isVisible)
                {
                    CoreWindow.GetForCurrentThread().Dispatcher.ProcessEvents(CoreProcessEventsOption.ProcessAllIfPresent);
                }
                else
                {
                    CoreWindow.GetForCurrentThread().Dispatcher.ProcessEvents(CoreProcessEventsOption.ProcessOneAndAllPending);
                }
            }
        }

        private void CoreWindow_Closed(CoreWindow sender, CoreWindowEventArgs args)
        {
            this.isClosed = true;
        }

        private void CoreWindow_VisibilityChanged(CoreWindow sender, VisibilityChangedEventArgs args)
        {
            this.isVisible = args.Visible;
        }

        private void CoreWindow_SizeChanged(CoreWindow sender, WindowSizeChangedEventArgs args)
        {
        }
    }
}
