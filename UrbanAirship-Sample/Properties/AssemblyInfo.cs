using System.Reflection;
using System.Runtime.CompilerServices;
using Android.App;

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("UrbanAirship-Sample")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("brads_000")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("1.0.0")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]


/*

// REQUIRED PERMISSIONS (for Urban Airship GCM)
[assembly: UsesPermission(Name = "android.permission.INTERNET")]
[assembly: UsesPermission(Name = "android.permission.ACCESS_NETWORK_STATE")]
[assembly: UsesPermission(Name = "android.permission.VIBRATE")]

// GCM requires a Google account.
[assembly: UsesPermission(Name = "android.permission.GET_ACCOUNTS")]
// Keeps the processor from sleeping when a message is received.
[assembly: UsesPermission(Name = "android.permission.WAKE_LOCK")]

// This app has permission to register with GCM and receive message -->
[assembly: UsesPermission(Name = "com.google.android.c2dm.permission.RECEIVE")]


// MODIFICATION REQUIRED - Replace "com.urbanairship.push.sample" with your package name -->
[assembly: Permission(Name = "com.urbanairship.push.sample.permission.C2D_MESSAGE")] // /* Android.Content.PM.Protection.Signature*/
//<permission android:name="" android:protectionLevel="signature" />
// The two elements above ensure that only this application can receive the messages and registration result -->*/