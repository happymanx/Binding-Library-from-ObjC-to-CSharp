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
	[Protocol (Name = "AwesomeMenuItemDelegate", WrapperType = typeof (AwesomeMenuItemDelegateWrapper))]
	public interface IAwesomeMenuItemDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("AwesomeMenuItemTouchesBegan:")]
		[Preserve (Conditional = true)]
		void AwesomeMenuItemTouchesBegan (AwesomeMenuItem item);
		
		[CompilerGenerated]
		[Export ("AwesomeMenuItemTouchesEnd:")]
		[Preserve (Conditional = true)]
		void AwesomeMenuItemTouchesEnd (AwesomeMenuItem item);
		
	}
	
	internal sealed class AwesomeMenuItemDelegateWrapper : BaseWrapper, IAwesomeMenuItemDelegate {
		public AwesomeMenuItemDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public AwesomeMenuItemDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("AwesomeMenuItemTouchesBegan:")]
		[CompilerGenerated]
		public void AwesomeMenuItemTouchesBegan (AwesomeMenuItem item)
		{
			if (item == null)
				throw new ArgumentNullException ("item");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("AwesomeMenuItemTouchesBegan:"), item.Handle);
		}
		
		[Export ("AwesomeMenuItemTouchesEnd:")]
		[CompilerGenerated]
		public void AwesomeMenuItemTouchesEnd (AwesomeMenuItem item)
		{
			if (item == null)
				throw new ArgumentNullException ("item");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("AwesomeMenuItemTouchesEnd:"), item.Handle);
		}
		
	}
}
namespace AwesomeMenu {
	[Protocol]
	[Register("AwesomeMenuItemDelegate", true)]
	[Model]
	public unsafe abstract partial class AwesomeMenuItemDelegate : NSObject, IAwesomeMenuItemDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AwesomeMenuItemDelegate () : base (NSObjectFlag.Empty)
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
		protected AwesomeMenuItemDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AwesomeMenuItemDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("AwesomeMenuItemTouchesBegan:")]
		[CompilerGenerated]
		public abstract void AwesomeMenuItemTouchesBegan (AwesomeMenuItem item);
		[Export ("AwesomeMenuItemTouchesEnd:")]
		[CompilerGenerated]
		public abstract void AwesomeMenuItemTouchesEnd (AwesomeMenuItem item);
	} /* class AwesomeMenuItemDelegate */
}
