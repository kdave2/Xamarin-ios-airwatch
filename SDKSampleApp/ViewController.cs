using System;

using UIKit;
using Foundation;
using System.Diagnostics;

namespace SDKSampleApp
{
	public partial class ViewController : UIViewController
	{
		const string LogCategory = "ViewController";

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			/*
			 * This example app uses NotificationCenter to pass the status back to the
			 * User Interface for demo purposes.  You do not need this if you 
			 * are simply using the SDK.  No configuration is needed in the
			 * View Controllers at all for SDK integration.  */
			NSString n = (NSString)AirWatchSDKManager.ReceivedProfilesNotification;
			NSNotificationCenter.DefaultCenter.AddObserver (n, OnProfilesReceived);

			n = (NSString)AirWatchSDKManager.InitialCheckDoneWithErrorNotification;
			NSNotificationCenter.DefaultCenter.AddObserver (n, OnInitialCheckDone);

			// SDK initialized in the AppDelegate
			InitStartedView.BackgroundColor = UIColor.Green;
			// make the UIViews into circles
			InitStartedView.Layer.CornerRadius = InitStartedView.Frame.Width / 2;
			InitCheckCompletedView.Layer.CornerRadius = InitCheckCompletedView.Frame.Width / 2;
			ProfilesReceivedView.Layer.CornerRadius = ProfilesReceivedView.Frame.Width / 2;
		}

		void OnInitialCheckDone (NSNotification notification)
		{
			InitCheckCompletedView.BackgroundColor = UIColor.Green;
		}

		void OnProfilesReceived (NSNotification notification)
		{
			ProfilesReceivedView.BackgroundColor = UIColor.Green;
		}
	}
}

