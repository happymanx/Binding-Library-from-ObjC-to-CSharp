using System;
using ObjCRuntime;

[assembly: LinkWith ("AwesomeMenu.a", LinkTarget.Arm64 | LinkTarget.ArmV7s | LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
