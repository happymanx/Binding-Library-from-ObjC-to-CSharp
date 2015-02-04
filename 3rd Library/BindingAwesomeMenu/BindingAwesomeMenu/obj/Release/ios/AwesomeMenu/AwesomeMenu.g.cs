//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using MapKit;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using NewsstandKit;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;

namespace AwesomeMenu {
	[Register("AwesomeMenu", true)]
	public unsafe partial class AwesomeMenu : global::UIKit.UIView, IAwesomeMenuItemDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AwesomeMenu");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AwesomeMenu () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public AwesomeMenu (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AwesomeMenu (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AwesomeMenu (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:startItem:optionMenus:")]
		[CompilerGenerated]
		public AwesomeMenu (CGRect frame, AwesomeMenuItem startItem, NSObject[] aMenusArray)
			: base (NSObjectFlag.Empty)
		{
			if (startItem == null)
				throw new ArgumentNullException ("startItem");
			if (aMenusArray == null)
				throw new ArgumentNullException ("aMenusArray");
			var nsa_aMenusArray = NSArray.FromNSObjects (aMenusArray);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithFrame:startItem:optionMenus:"), frame, startItem.Handle, nsa_aMenusArray.Handle), "initWithFrame:startItem:optionMenus:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFrame:startItem:optionMenus:"), frame, startItem.Handle, nsa_aMenusArray.Handle), "initWithFrame:startItem:optionMenus:");
			}
			nsa_aMenusArray.Dispose ();
			
		}
		
		[Export ("AwesomeMenuItemTouchesBegan:")]
		[CompilerGenerated]
		public virtual void AwesomeMenuItemTouchesBegan (AwesomeMenuItem item)
		{
			if (item == null)
				throw new ArgumentNullException ("item");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("AwesomeMenuItemTouchesBegan:"), item.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("AwesomeMenuItemTouchesBegan:"), item.Handle);
			}
		}
		
		[Export ("AwesomeMenuItemTouchesEnd:")]
		[CompilerGenerated]
		public virtual void AwesomeMenuItemTouchesEnd (AwesomeMenuItem item)
		{
			if (item == null)
				throw new ArgumentNullException ("item");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("AwesomeMenuItemTouchesEnd:"), item.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("AwesomeMenuItemTouchesEnd:"), item.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat AnimationDuration {
			[Export ("animationDuration", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("animationDuration"));
				} else {
					return ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("animationDuration"));
				}
			}
			
			[Export ("setAnimationDuration:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAnimationDuration:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setAnimationDuration:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat CloseRotation {
			[Export ("closeRotation", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("closeRotation"));
				} else {
					return ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("closeRotation"));
				}
			}
			
			[Export ("setCloseRotation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setCloseRotation:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setCloseRotation:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ContentImage_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage ContentImage {
			[Export ("contentImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentImage")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentImage_var = ret;
				return ret;
			}
			
			[Export ("setContentImage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setContentImage:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setContentImage:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentImage_var = value;
			}
		}
		
		[CompilerGenerated]
		public AwesomeMenuDelegate Delegate {
			get {
				return WeakDelegate as /**/AwesomeMenuDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat EndRadius {
			[Export ("endRadius", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("endRadius"));
				} else {
					return ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endRadius"));
				}
			}
			
			[Export ("setEndRadius:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setEndRadius:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setEndRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Expanding {
			[Export ("isExpanding")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isExpanding"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isExpanding"));
				}
			}
			
			[Export ("setExpanding:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setExpanding:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setExpanding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat ExpandRotation {
			[Export ("expandRotation", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("expandRotation"));
				} else {
					return ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("expandRotation"));
				}
			}
			
			[Export ("setExpandRotation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setExpandRotation:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setExpandRotation:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat FarRadius {
			[Export ("farRadius", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("farRadius"));
				} else {
					return ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("farRadius"));
				}
			}
			
			[Export ("setFarRadius:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setFarRadius:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setFarRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_HighlightedContentImage_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage HighlightedContentImage {
			[Export ("highlightedContentImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("highlightedContentImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("highlightedContentImage")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_HighlightedContentImage_var = ret;
				return ret;
			}
			
			[Export ("setHighlightedContentImage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHighlightedContentImage:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHighlightedContentImage:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_HighlightedContentImage_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_HighlightedImage_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage HighlightedImage {
			[Export ("highlightedImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("highlightedImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("highlightedImage")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_HighlightedImage_var = ret;
				return ret;
			}
			
			[Export ("setHighlightedImage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHighlightedImage:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHighlightedImage:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_HighlightedImage_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Image_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage Image {
			[Export ("image", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("image")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("image")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Image_var = ret;
				return ret;
			}
			
			[Export ("setImage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setImage:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setImage:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Image_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_MenusArray_var;
		[CompilerGenerated]
		public virtual NSObject[] MenusArray {
			[Export ("menusArray", ArgumentSemantic.Copy)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("menusArray")));
				} else {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("menusArray")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_MenusArray_var = ret;
				return ret;
			}
			
			[Export ("setMenusArray:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMenusArray:"), nsa_value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMenusArray:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_MenusArray_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat MenuWholeAngle {
			[Export ("menuWholeAngle", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("menuWholeAngle"));
				} else {
					return ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("menuWholeAngle"));
				}
			}
			
			[Export ("setMenuWholeAngle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMenuWholeAngle:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setMenuWholeAngle:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat NearRadius {
			[Export ("nearRadius", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("nearRadius"));
				} else {
					return ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("nearRadius"));
				}
			}
			
			[Export ("setNearRadius:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setNearRadius:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setNearRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RotateAddButton {
			[Export ("rotateAddButton", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("rotateAddButton"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rotateAddButton"));
				}
			}
			
			[Export ("setRotateAddButton:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRotateAddButton:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRotateAddButton:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat RotateAngle {
			[Export ("rotateAngle", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rotateAngle"));
				} else {
					return ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rotateAngle"));
				}
			}
			
			[Export ("setRotateAngle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRotateAngle:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRotateAngle:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGPoint StartPoint {
			[Export ("startPoint", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("startPoint"));
						} else {
							ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("startPoint"));
						}
					} else if (IntPtr.Size == 8) {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("startPoint"));
					} else {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("startPoint"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startPoint"));
						} else {
							ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("startPoint"));
						}
					} else if (IntPtr.Size == 8) {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startPoint"));
					} else {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startPoint"));
					}
				}
				return ret;
			}
			
			[Export ("setStartPoint:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setStartPoint:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setStartPoint:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat TimeOffset {
			[Export ("timeOffset", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("timeOffset"));
				} else {
					return ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("timeOffset"));
				}
			}
			
			[Export ("setTimeOffset:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setTimeOffset:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setTimeOffset:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ContentImage_var = null;
				__mt_HighlightedContentImage_var = null;
				__mt_HighlightedImage_var = null;
				__mt_Image_var = null;
				__mt_MenusArray_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class AwesomeMenu */
}
