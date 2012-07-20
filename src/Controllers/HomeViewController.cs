
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Aeolus
{
	public partial class HomeViewController : UIViewController
	{
		public HomeViewController () : base ("HomeViewController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;
			var imgView = new UIImageView
			{
				Image = UIImage.FromFile ("images/paradise.png"),
				Frame = new RectangleF(0,0,View.Bounds.Width, View.Bounds.Height)
			};
			View.AddSubview (imgView);

			var odessianLogo = new UIImageView
			{
				Image = UIImage.FromFile ("images/odessian_logo.png"),
				Frame = new RectangleF(30f,25f,275, 98)
			};
			View.AddSubview (odessianLogo);

			var nav = new UIView
			{
				Frame = new RectangleF(0f, 120f, View.Bounds.Width, 200f),
				BackgroundColor = UIColor.FromRGBA (0,0,0,.50f)
			};
			View.AddSubview (nav);

			var shopButton = new UIButton ();
			shopButton.SetTitle ("Shop", UIControlState.Normal);
			shopButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.60f);
			shopButton.Font = UIFont.FromName ("Arial", 25f);
			shopButton.Frame = new RectangleF (30f, 133f, 230f, 175f);
			shopButton.Layer.BorderWidth = 1f;
			shopButton.Layer.CornerRadius = 15f;
			shopButton.TouchUpInside += (sender, e) => 
				{
					shopButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.60f);
					using (var alertView = new UIAlertView("Shop", "You clicked the shop button", null, "Cancel"))
						alertView.Show ();
				};
			shopButton.TouchDown += (sender, e) => 
				{
					shopButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.40f);
				};
			shopButton.TouchUpOutside += (sender, e) => 
			{
					shopButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.60f);
			};
			View.AddSubview (shopButton);
			
			var helpButton = new UIButton ();
			helpButton.SetTitle ("Let Us Help", UIControlState.Normal);
			helpButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.60f);
			helpButton.Font = UIFont.FromName ("Arial", 25f);
			helpButton.Frame = new RectangleF (275f, 133f, 230f, 175f);
			helpButton.Layer.BorderWidth = 1f;
			helpButton.Layer.CornerRadius = 15f;
			helpButton.TouchUpInside += (sender, e) => 
				{
					helpButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.60f);
					using (var alertView = new UIAlertView("Help", "You clicked the help button", null, "Cancel"))
						alertView.Show ();
				};
			helpButton.TouchDown += (sender, e) => 
				{
					helpButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.40f);
				};
			helpButton.TouchUpOutside += (sender, e) => 
			{
					helpButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.60f);
			};
			
			View.AddSubview (helpButton);
			
			var newsButton = new UIButton ();
			newsButton.SetTitle ("News & Events", UIControlState.Normal);
			newsButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.60f);
			newsButton.Font = UIFont.FromName ("Arial", 25f);
			newsButton.Frame = new RectangleF (520f, 133f, 230f, 175f);
			newsButton.Layer.BorderWidth = 1f;
			newsButton.Layer.CornerRadius = 15f;
			newsButton.TouchUpInside += (sender, e) => 
				{
					newsButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.60f);
					using (var alertView = new UIAlertView("News", "You clicked the news button", null, "Cancel"))
						alertView.Show ();
				};
			newsButton.TouchDown += (sender, e) => 
				{
					newsButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.40f);
				};
			newsButton.TouchUpOutside += (sender, e) => 
			{
					newsButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.60f);
			};
			View.AddSubview (newsButton);
			
			var accountButton = new UIButton ();
			accountButton.SetTitle ("My Account", UIControlState.Normal);
			accountButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.60f);
			accountButton.Font = UIFont.FromName ("Arial", 25f);
			accountButton.Frame = new RectangleF (765f, 133f, 230f, 175f);
			accountButton.Layer.BorderWidth = 1f;
			accountButton.Layer.CornerRadius = 15f;
			accountButton.TouchUpInside += (sender, e) => 
				{
					accountButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.60f);
					using (var alertView = new UIAlertView("Account", "You clicked the account button", null, "Cancel"))
						alertView.Show ();
				};
			accountButton.TouchDown += (sender, e) => 
				{
					accountButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.40f);
				};
			accountButton.TouchUpOutside += (sender, e) => 
			{
					accountButton.BackgroundColor = UIColor.FromRGBA (0,0,0,.60f);
			};
			View.AddSubview (accountButton);
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return true;
		}
	}
}

