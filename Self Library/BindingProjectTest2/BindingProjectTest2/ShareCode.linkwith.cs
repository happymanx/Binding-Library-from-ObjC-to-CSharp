using System;
using ObjCRuntime;

[assembly: LinkWith ("ShareCode.a", LinkTarget.Arm64 | LinkTarget.ArmV7s | LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
