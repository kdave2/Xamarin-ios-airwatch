using Foundation;
using UIKit;
using AirWatchSDK;
using System;
using ObjCRuntime;
using System.Diagnostics;

namespace SDKSampleApp
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		public override UIWindow Window {
			get;
			set;
		}

		public override bool HandleOpenURL (UIApplication application, NSUrl url)
		{
			return AWController.ClientInstance ().HandleOpenURL (url, "SDKAirwatchSampleAPP");
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			if (Runtime.Arch == Arch.SIMULATOR) {
				Debug.WriteLine ("Running in Simulator, skipping initialization of the AirWatch SDK!");
				return true;
			} else {
				Debug.WriteLine ("Running on Device, beginning initialization of the AirWatch SDK.");

				// Configure the Controller by:
				var sdkController = AWController.ClientInstance ();
				// 1) defining the callback scheme so the app can get called back,
				sdkController.CallbackScheme = "mysampleapp"; // defined in Info.plist
				// 2) set the delegate to know when the initialization has been completed.
				sdkController.Delegate = AirWatchSDKManager.Instance;
				return true;
			}
		}

		public override void OnActivated (UIApplication application)
		{
			AWController.ClientInstance ().Start ();
		}

		public override void OnResignActivation (UIApplication application)
		{
			// Invoked when the application is about to move from active to inactive state.
			// This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
			// or when the user quits the application and it begins the transition to the background state.
			// Games should use this method to pause the game.
		}

		public override void DidEnterBackground (UIApplication application)
		{
			// Use this method to release shared resources, save user data, invalidate timers and store the application state.
			// If your application supports background exection this method is called instead of WillTerminate when the user quits.
		}

		public override void WillEnterForeground (UIApplication application)
		{
			// Called as part of the transiton from background to active state.
			// Here you can undo many of the changes made on entering the background.
		}

		public override void WillTerminate (UIApplication application)
		{
			// Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
		}
	}
}


