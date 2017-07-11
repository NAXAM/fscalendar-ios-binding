using System.Reflection;
using System.Runtime.CompilerServices;

using Foundation;
using ObjCRuntime;

// This attribute allows you to mark your assemblies as “safe to link”. 
// When the attribute is present, the linker—if enabled—will process the assembly 
// even if you’re using the “Link SDK assemblies only” option, which is the default for device builds.

[assembly: LinkerSafe]

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("Naxam.FSCalendar.iOS")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Naxam Co., LTD")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("(c) 2017 Naxam")]
[assembly: AssemblyTrademark("Naxam")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("1.0.*")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]
[assembly: LinkWith("FSCalendar.framework", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, "-ObjC", ForceLoad = true, Frameworks = "Foundation UIKit CoreGraphics")]
//[assembly: LinkWith("FSCalendar.framework", LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Simulator64, ForceLoad = true, SmartLink = true, LinkerFlags = "-ObjC -all_load -fobjc-arc", Frameworks = "Foundation UIKit CoreGraphics CoreAnimation")]