﻿using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using MvvmCross.Binding.Mac.Views;

namespace Azure.ScreenShots.Mac.Views
{
    public partial class FirstView : MvxView
    {
        #region Constructors
        // Called when created from unmanaged code
        public FirstView(IntPtr handle) : base(handle)
        {
            Initialize();
        }
        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public FirstView(NSCoder coder) : base(coder)
        {
            Initialize();
        }
        // Shared initialization code
        void Initialize()
        {
        }
        #endregion
    }
}
