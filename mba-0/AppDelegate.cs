using AppKit;
using Foundation;

namespace mba0
{
	[Register ("AppDelegate")]
	public class AppDelegate : NSApplicationDelegate
	{
		public AppDelegate ()
		{
		}

		public override void DidFinishLaunching (NSNotification notification)
		{
			// Insert code here to initialize your application
		}

		[Export ("openDocument:")]
		void OpenDialog (NSObject sender)
		{
			var dlg = NSOpenPanel.OpenPanel;
			dlg.CanChooseFiles = true;
			dlg.CanChooseDirectories = false;

			if (dlg.RunModal () == 1) {
				var alert = new NSAlert () {
					AlertStyle = NSAlertStyle.Informational,
					InformativeText = "At this point we should do something with the file that the user just selected in the Open File Dialog box...",
					MessageText = "File Selected"
				};
				alert.RunModal ();
			}
		}
		public override void WillTerminate (NSNotification notification)
		{
			// Insert code here to tear down your application
		}
	}
}

