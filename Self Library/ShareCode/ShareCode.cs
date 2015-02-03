namespace ShareCode {

	// @interface ShareCode : NSObject
	[BaseType (typeof (NSObject))]
	interface ShareCode {

		// -(NSString *)sayHello:(NSString *)name;
		[Export ("sayHello:")]
		string SayHello (string name);
	}
}
