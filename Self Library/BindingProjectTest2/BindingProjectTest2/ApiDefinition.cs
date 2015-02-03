using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace ShareCode {

	// @interface ShareCode : NSObject
	[BaseType (typeof (NSObject))]
	interface ShareCode {

		// -(NSString *)sayHello:(NSString *)name;
		[Export ("sayHello:")]
		string SayHello (string name);
	}
}


