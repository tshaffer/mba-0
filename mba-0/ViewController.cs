using System;

using AppKit;
using Foundation;
using System.Diagnostics;

namespace mba0
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		[Export ("openDocument:")]
		void OpenDialog (NSObject sender)
		{
			var dlg = NSOpenPanel.OpenPanel;
			dlg.Message = "Open Presentation";
			dlg.CanChooseFiles = true;
			dlg.CanChooseDirectories = false;
			dlg.AllowedFileTypes = new string[] {"bpf"};

			if (dlg.RunModal () == 1) {
				string presentationFilePath = dlg.Urls [0].Path;
				OpenPresentation (presentationFilePath);
			}
		}

		private void OpenPresentation(string filePath)
		{

			var alert = new NSAlert () {
				AlertStyle = NSAlertStyle.Informational,
				InformativeText = filePath,
				MessageText = "Presentation File Selected"
			};
			alert.RunModal ();

		}

	}
}
