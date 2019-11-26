// Copyright (c) Peter Nylander. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Windows.ApplicationModel.Core;

namespace CoreApplicationTest
{
    /// <summary>
    /// Game framework factory.
    /// </summary>
    /// <typeparam name="T">The factory type that creates an instance of IGame.</typeparam>
    public class FrameworkViewSourceFactory : IFrameworkViewSource
    {
        public IFrameworkView CreateView()
        {
            return new GameFrameworkView();
        }
    }
}
