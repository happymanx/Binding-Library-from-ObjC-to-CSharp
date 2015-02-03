using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;

using CoreGraphics;

namespace AwesomeMenu {

	// @interface AwesomeMenuItem : UIImageView
	[BaseType (typeof (UIImageView))]
	interface AwesomeMenuItem {

		// -(id)initWithImage:(UIImage *)img highlightedImage:(UIImage *)himg ContentImage:(UIImage *)cimg highlightedContentImage:(UIImage *)hcimg;
		[Export ("initWithImage:highlightedImage:ContentImage:highlightedContentImage:")]
		IntPtr Constructor (UIImage img, UIImage himg, UIImage cimg, UIImage hcimg);

		// @property (readonly, nonatomic, strong) UIImageView * contentImageView;
		[Export ("contentImageView", ArgumentSemantic.Retain)]
		UIImageView ContentImageView { get; }

		// @property (nonatomic) CGPoint startPoint;
		[Export ("startPoint")]
		CGPoint StartPoint { get; set; }

		// @property (nonatomic) CGPoint endPoint;
		[Export ("endPoint")]
		CGPoint EndPoint { get; set; }

		// @property (nonatomic) CGPoint nearPoint;
		[Export ("nearPoint")]
		CGPoint NearPoint { get; set; }

		// @property (nonatomic) CGPoint farPoint;
		[Export ("farPoint")]
		CGPoint FarPoint { get; set; }

		// @property (nonatomic, weak) id<AwesomeMenuItemDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<AwesomeMenuItemDelegate> delegate;
		[Wrap ("WeakDelegate")]
		AwesomeMenuItemDelegate Delegate { get; set; }
	}

	// @protocol AwesomeMenuItemDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface AwesomeMenuItemDelegate {

		// @required -(void)AwesomeMenuItemTouchesBegan:(AwesomeMenuItem *)item;
		[Export ("AwesomeMenuItemTouchesBegan:")]
		[Abstract]
		void AwesomeMenuItemTouchesBegan (AwesomeMenuItem item);

		// @required -(void)AwesomeMenuItemTouchesEnd:(AwesomeMenuItem *)item;
		[Export ("AwesomeMenuItemTouchesEnd:")]
		[Abstract]
		void AwesomeMenuItemTouchesEnd (AwesomeMenuItem item);
	}

	// @interface AwesomeMenu : UIView <AwesomeMenuItemDelegate>
	[BaseType (typeof (UIView))]
	interface AwesomeMenu : AwesomeMenuItemDelegate {

		// -(id)initWithFrame:(CGRect)frame startItem:(AwesomeMenuItem *)startItem optionMenus:(NSArray *)aMenusArray;
		[Export ("initWithFrame:startItem:optionMenus:")]
		IntPtr Constructor (CGRect frame, AwesomeMenuItem startItem, NSObject [] aMenusArray);

		// @property (copy, nonatomic) NSArray * menusArray;
		[Export ("menusArray", ArgumentSemantic.Copy)]
		NSObject [] MenusArray { get; set; }

		// @property (nonatomic, getter = isExpanding) BOOL expanding;
		[Export ("expanding")]
		bool Expanding { [Bind ("isExpanding")] get; set; }

		// @property (nonatomic, weak) id<AwesomeMenuDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<AwesomeMenuDelegate> delegate;
		[Wrap ("WeakDelegate")]
		AwesomeMenuDelegate Delegate { get; set; }

		// @property (nonatomic, strong) UIImage * image;
		[Export ("image", ArgumentSemantic.Retain)]
		UIImage Image { get; set; }

		// @property (nonatomic, strong) UIImage * highlightedImage;
		[Export ("highlightedImage", ArgumentSemantic.Retain)]
		UIImage HighlightedImage { get; set; }

		// @property (nonatomic, strong) UIImage * contentImage;
		[Export ("contentImage", ArgumentSemantic.Retain)]
		UIImage ContentImage { get; set; }

		// @property (nonatomic, strong) UIImage * highlightedContentImage;
		[Export ("highlightedContentImage", ArgumentSemantic.Retain)]
		UIImage HighlightedContentImage { get; set; }

		// @property (assign, nonatomic) CGFloat nearRadius;
		[Export ("nearRadius", ArgumentSemantic.UnsafeUnretained)]
		nfloat NearRadius { get; set; }

		// @property (assign, nonatomic) CGFloat endRadius;
		[Export ("endRadius", ArgumentSemantic.UnsafeUnretained)]
		nfloat EndRadius { get; set; }

		// @property (assign, nonatomic) CGFloat farRadius;
		[Export ("farRadius", ArgumentSemantic.UnsafeUnretained)]
		nfloat FarRadius { get; set; }

		// @property (assign, nonatomic) CGPoint startPoint;
		[Export ("startPoint", ArgumentSemantic.UnsafeUnretained)]
		CGPoint StartPoint { get; set; }

		// @property (assign, nonatomic) CGFloat timeOffset;
		[Export ("timeOffset", ArgumentSemantic.UnsafeUnretained)]
		nfloat TimeOffset { get; set; }

		// @property (assign, nonatomic) CGFloat rotateAngle;
		[Export ("rotateAngle", ArgumentSemantic.UnsafeUnretained)]
		nfloat RotateAngle { get; set; }

		// @property (assign, nonatomic) CGFloat menuWholeAngle;
		[Export ("menuWholeAngle", ArgumentSemantic.UnsafeUnretained)]
		nfloat MenuWholeAngle { get; set; }

		// @property (assign, nonatomic) CGFloat expandRotation;
		[Export ("expandRotation", ArgumentSemantic.UnsafeUnretained)]
		nfloat ExpandRotation { get; set; }

		// @property (assign, nonatomic) CGFloat closeRotation;
		[Export ("closeRotation", ArgumentSemantic.UnsafeUnretained)]
		nfloat CloseRotation { get; set; }

		// @property (assign, nonatomic) CGFloat animationDuration;
		[Export ("animationDuration", ArgumentSemantic.UnsafeUnretained)]
		nfloat AnimationDuration { get; set; }

		// @property (assign, nonatomic) BOOL rotateAddButton;
		[Export ("rotateAddButton", ArgumentSemantic.UnsafeUnretained)]
		bool RotateAddButton { get; set; }
	}

	// @protocol AwesomeMenuDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface AwesomeMenuDelegate {

		// @required -(void)awesomeMenu:(AwesomeMenu *)menu didSelectIndex:(NSInteger)idx;
		[Export ("awesomeMenu:didSelectIndex:")]
		[Abstract]
		void DidSelectIndex (AwesomeMenu menu, nint idx);

		// @optional -(void)awesomeMenuDidFinishAnimationClose:(AwesomeMenu *)menu;
		[Export ("awesomeMenuDidFinishAnimationClose:")]
		void AwesomeMenuDidFinishAnimationClose (AwesomeMenu menu);

		// @optional -(void)awesomeMenuDidFinishAnimationOpen:(AwesomeMenu *)menu;
		[Export ("awesomeMenuDidFinishAnimationOpen:")]
		void AwesomeMenuDidFinishAnimationOpen (AwesomeMenu menu);

		// @optional -(void)awesomeMenuWillAnimateOpen:(AwesomeMenu *)menu;
		[Export ("awesomeMenuWillAnimateOpen:")]
		void AwesomeMenuWillAnimateOpen (AwesomeMenu menu);

		// @optional -(void)awesomeMenuWillAnimateClose:(AwesomeMenu *)menu;
		[Export ("awesomeMenuWillAnimateClose:")]
		void AwesomeMenuWillAnimateClose (AwesomeMenu menu);
	}
}

