using System;

using AppKit;
using Foundation;
using System.Diagnostics;

using BAModel;

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
			Console.WriteLine ("presentation file path is: " + filePath);

			Sign sign = new Sign ("fred");

		}

	}
}
