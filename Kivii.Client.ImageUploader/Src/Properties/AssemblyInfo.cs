using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Kivii Client Imaging Uploader")]
[assembly: AssemblyDescription("客户端图片处理程序")]

[assembly: AssemblyVersion("5.2.2017.9271")]
[assembly: AssemblyFileVersion("5.2.2017.9271")]

#if DEBUG
[assembly: AssemblyCompany("Kivii.Org")]
#else
[assembly: AssemblyCompany("Kivii.Com")]
#endif
[assembly: AssemblyProduct("Kivii Dev Platform")]
[assembly: AssemblyCopyright("Copyright (c) Kivii 2015-2017")]
[assembly: AssemblyTrademark("Kivii")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyConfiguration("")]
[assembly:AssemblyLoadFeature(typeof(Kivii.Imaging.Uploader.Features.UploaderFeature))]