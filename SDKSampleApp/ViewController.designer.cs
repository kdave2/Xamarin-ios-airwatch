// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SDKSampleApp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView InitCheckCompletedView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView InitStartedView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView ProfilesReceivedView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (InitCheckCompletedView != null) {
				InitCheckCompletedView.Dispose ();
				InitCheckCompletedView = null;
			}
			if (InitStartedView != null) {
				InitStartedView.Dispose ();
				InitStartedView = null;
			}
			if (ProfilesReceivedView != null) {
				ProfilesReceivedView.Dispose ();
				ProfilesReceivedView = null;
			}
		}
	}
}
