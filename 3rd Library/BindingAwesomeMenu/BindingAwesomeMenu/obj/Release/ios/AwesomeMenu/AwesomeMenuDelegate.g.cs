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
	[Protocol (Name = "AwesomeMenuDelegate", WrapperType = typeof (AwesomeMenuDelegateWrapper))]
	public interface IAwesomeMenuDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("awesomeMenu:didSelectIndex:")]
		[Preserve (Conditional = true)]
		void DidSelectIndex (AwesomeMenu menu, global::System.nint idx);
		
	}
	
	public static partial class AwesomeMenuDelegate_Extensions {
		[CompilerGenerated]
		public static void AwesomeMenuDidFinishAnimationClose (this IAwesomeMenuDelegate This, AwesomeMenu menu)
		{
			if (menu == null)
				throw new ArgumentNullException ("menu");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("awesomeMenuDidFinishAnimationClose:"), menu.Handle);
		}
		
		[CompilerGenerated]
		public static void AwesomeMenuDidFinishAnimationOpen (this IAwesomeMenuDelegate This, AwesomeMenu menu)
		{
			if (menu == null)
				throw new ArgumentNullException ("menu");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("awesomeMenuDidFinishAnimationOpen:"), menu.Handle);
		}
		
		[CompilerGenerated]
		public static void AwesomeMenuWillAnimateOpen (this IAwesomeMenuDelegate This, AwesomeMenu menu)
		{
			if (menu == null)
				throw new ArgumentNullException ("menu");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("awesomeMenuWillAnimateOpen:"), menu.Handle);
		}
		
		[CompilerGenerated]
		public static void AwesomeMenuWillAnimateClose (this IAwesomeMenuDelegate This, AwesomeMenu menu)
		{
			if (menu == null)
				throw new ArgumentNullException ("menu");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("awesomeMenuWillAnimateClose:"), menu.Handle);
		}
		
	}
	
	internal sealed class AwesomeMenuDelegateWrapper : BaseWrapper, IAwesomeMenuDelegate {
		public AwesomeMenuDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public AwesomeMenuDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("awesomeMenu:didSelectIndex:")]
		[CompilerGenerated]
		public void DidSelectIndex (AwesomeMenu menu, global::System.nint idx)
		{
			if (menu == null)
				throw new ArgumentNullException ("menu");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("awesomeMenu:didSelectIndex:"), menu.Handle, idx);
		}
		
	}
}
namespace AwesomeMenu {
	[Protocol]
	[Register("AwesomeMenuDelegate", true)]
	[Model]
	public unsafe abstract partial class AwesomeMenuDelegate : NSObject, IAwesomeMenuDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AwesomeMenuDelegate () : base (NSObjectFlag.Empty)
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
		protected AwesomeMenuDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AwesomeMenuDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("awesomeMenuDidFinishAnimationClose:")]
		[CompilerGenerated]
		public virtual void AwesomeMenuDidFinishAnimationClose (AwesomeMenu menu)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("awesomeMenuDidFinishAnimationOpen:")]
		[CompilerGenerated]
		public virtual void AwesomeMenuDidFinishAnimationOpen (AwesomeMenu menu)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("awesomeMenuWillAnimateClose:")]
		[CompilerGenerated]
		public virtual void AwesomeMenuWillAnimateClose (AwesomeMenu menu)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("awesomeMenuWillAnimateOpen:")]
		[CompilerGenerated]
		public virtual void AwesomeMenuWillAnimateOpen (AwesomeMenu menu)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("awesomeMenu:didSelectIndex:")]
		[CompilerGenerated]
		public abstract void DidSelectIndex (AwesomeMenu menu, global::System.nint idx);
	} /* class AwesomeMenuDelegate */
}
