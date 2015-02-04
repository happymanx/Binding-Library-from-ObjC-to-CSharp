using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace AwesomeMenuProject
{
	public partial class AwesomeMenuProjectViewController : UIViewController
	{
		public AwesomeMenuProjectViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			UIImage storyMenuItemImage = UIImage.FromFile ("images/bg-menuitem.png");
			UIImage storyMenuItemImagePressed = UIImage.FromFile ("images/bg-menuitem-highlighted.png");

			UIImage starImage = UIImage.FromFile ("images/icon-star.png");


			AwesomeMenu.AwesomeMenuItem starMenuItem1 = new AwesomeMenu.AwesomeMenuItem (storyMenuItemImage, storyMenuItemImagePressed, starImage, starImage);
			AwesomeMenu.AwesomeMenuItem starMenuItem2 = new AwesomeMenu.AwesomeMenuItem (storyMenuItemImage, storyMenuItemImagePressed, starImage, starImage);
			AwesomeMenu.AwesomeMenuItem starMenuItem3 = new AwesomeMenu.AwesomeMenuItem (storyMenuItemImage, storyMenuItemImagePressed, starImage, starImage);
			AwesomeMenu.AwesomeMenuItem starMenuItem4 = new AwesomeMenu.AwesomeMenuItem (storyMenuItemImage, storyMenuItemImagePressed, starImage, starImage);
			AwesomeMenu.AwesomeMenuItem starMenuItem5 = new AwesomeMenu.AwesomeMenuItem (storyMenuItemImage, storyMenuItemImagePressed, starImage, starImage);

			AwesomeMenu.AwesomeMenuItem[] menus = new AwesomeMenu.AwesomeMenuItem[] {
				starMenuItem1,
				starMenuItem2,
				starMenuItem3,
				starMenuItem4,
				starMenuItem5
			};

			AwesomeMenu.AwesomeMenuItem startItem = new AwesomeMenu.AwesomeMenuItem (UIImage.FromFile ("images/bg-addbutton.png"), UIImage.FromFile ("images/bg-addbutton-highlighted.png"), UIImage.FromFile ("images/icon-plus.png"), UIImage.FromFile ("images/icon-plus-highlighted.png") );

			AwesomeMenu.AwesomeMenu menu = new AwesomeMenu.AwesomeMenu (View.Frame, startItem, menus);

			menu.MenuWholeAngle = (float)-Math.PI/2;
			menu.FarRadius = 110.0f;
			menu.EndRadius = 100.0f;
			menu.NearRadius = 90.0f;
			menu.AnimationDuration = 0.3f;
			menu.StartPoint = new CoreGraphics.CGPoint (250.0f, 410.0f);

			View.Add (menu);
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

