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
	[Register("AwesomeMenuItem", true)]
	public unsafe partial class AwesomeMenuItem : global::UIKit.UIImageView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AwesomeMenuItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AwesomeMenuItem () : base (NSObjectFlag.Empty)
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
		public AwesomeMenuItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected AwesomeMenuItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AwesomeMenuItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithImage:highlightedImage:ContentImage:highlightedContentImage:")]
		[CompilerGenerated]
		public AwesomeMenuItem (global::UIKit.UIImage img, global::UIKit.UIImage himg, global::UIKit.UIImage cimg, global::UIKit.UIImage hcimg)
			: base (NSObjectFlag.Empty)
		{
			if (img == null)
				throw new ArgumentNullException ("img");
			if (himg == null)
				throw new ArgumentNullException ("himg");
			if (cimg == null)
				throw new ArgumentNullException ("cimg");
			if (hcimg == null)
				throw new ArgumentNullException ("hcimg");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithImage:highlightedImage:ContentImage:highlightedContentImage:"), img.Handle, himg.Handle, cimg.Handle, hcimg.Handle), "initWithImage:highlightedImage:ContentImage:highlightedContentImage:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithImage:highlightedImage:ContentImage:highlightedContentImage:"), img.Handle, himg.Handle, cimg.Handle, hcimg.Handle), "initWithImage:highlightedImage:ContentImage:highlightedContentImage:");
			}
		}
		
		[CompilerGenerated]
		object __mt_ContentImageView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImageView ContentImageView {
			[Export ("contentImageView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentImageView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentImageView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentImageView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public AwesomeMenuItemDelegate Delegate {
			get {
				return WeakDelegate as /**/AwesomeMenuItemDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual CGPoint EndPoint {
			[Export ("endPoint")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("endPoint"));
						} else {
							ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("endPoint"));
						}
					} else if (IntPtr.Size == 8) {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("endPoint"));
					} else {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("endPoint"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endPoint"));
						} else {
							ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("endPoint"));
						}
					} else if (IntPtr.Size == 8) {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endPoint"));
					} else {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endPoint"));
					}
				}
				return ret;
			}
			
			[Export ("setEndPoint:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setEndPoint:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setEndPoint:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGPoint FarPoint {
			[Export ("farPoint")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("farPoint"));
						} else {
							ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("farPoint"));
						}
					} else if (IntPtr.Size == 8) {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("farPoint"));
					} else {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("farPoint"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("farPoint"));
						} else {
							ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("farPoint"));
						}
					} else if (IntPtr.Size == 8) {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("farPoint"));
					} else {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("farPoint"));
					}
				}
				return ret;
			}
			
			[Export ("setFarPoint:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setFarPoint:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setFarPoint:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGPoint NearPoint {
			[Export ("nearPoint")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("nearPoint"));
						} else {
							ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("nearPoint"));
						}
					} else if (IntPtr.Size == 8) {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("nearPoint"));
					} else {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("nearPoint"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("nearPoint"));
						} else {
							ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("nearPoint"));
						}
					} else if (IntPtr.Size == 8) {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("nearPoint"));
					} else {
						ret = ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("nearPoint"));
					}
				}
				return ret;
			}
			
			[Export ("setNearPoint:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setNearPoint:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setNearPoint:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGPoint StartPoint {
			[Export ("startPoint")]
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
			
			[Export ("setStartPoint:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setStartPoint:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setStartPoint:"), value);
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
				__mt_ContentImageView_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class AwesomeMenuItem */
}
