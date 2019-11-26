// Copyright (c) Peter Nylander. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;

namespace CoreApplicationTest
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var frameworkViewSourceFactory = new FrameworkViewSourceFactory();

            CoreApplication.Run(frameworkViewSourceFactory);
        }
    }
}
