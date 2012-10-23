using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship {

	[global::Android.Runtime.Register ("com/urbanairship/UAirship", DoNotGenerateAcw=true)]
	public partial class UAirship : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/UAirship", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UAirship); }
		}

		protected UAirship (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAirshipConfigOptions;
#pragma warning disable 0169
		static Delegate GetGetAirshipConfigOptionsHandler ()
		{
			if (cb_getAirshipConfigOptions == null)
				cb_getAirshipConfigOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAirshipConfigOptions);
			return cb_getAirshipConfigOptions;
		}

		static IntPtr n_GetAirshipConfigOptions (IntPtr jnienv, IntPtr native__this)
		{
			UAirship __this = Java.Lang.Object.GetObject<UAirship> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AirshipConfigOptions);
		}
#pragma warning restore 0169

		static IntPtr id_getAirshipConfigOptions;
		public virtual global::Com.Urbanairship.AirshipConfigOptions AirshipConfigOptions {
			[Register ("getAirshipConfigOptions", "()Lcom/urbanairship/AirshipConfigOptions;", "GetGetAirshipConfigOptionsHandler")]
			get {
				if (id_getAirshipConfigOptions == IntPtr.Zero)
					id_getAirshipConfigOptions = JNIEnv.GetMethodID (class_ref, "getAirshipConfigOptions", "()Lcom/urbanairship/AirshipConfigOptions;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.AirshipConfigOptions> (JNIEnv.CallObjectMethod  (Handle, id_getAirshipConfigOptions), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.AirshipConfigOptions> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAirshipConfigOptions), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAnalytics;
#pragma warning disable 0169
		static Delegate GetGetAnalyticsHandler ()
		{
			if (cb_getAnalytics == null)
				cb_getAnalytics = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnalytics);
			return cb_getAnalytics;
		}

		static IntPtr n_GetAnalytics (IntPtr jnienv, IntPtr native__this)
		{
			UAirship __this = Java.Lang.Object.GetObject<UAirship> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Analytics);
		}
#pragma warning restore 0169

		static IntPtr id_getAnalytics;
		public virtual global::Com.Urbanairship.Analytics.Analytics Analytics {
			[Register ("getAnalytics", "()Lcom/urbanairship/analytics/Analytics;", "GetGetAnalyticsHandler")]
			get {
				if (id_getAnalytics == IntPtr.Zero)
					id_getAnalytics = JNIEnv.GetMethodID (class_ref, "getAnalytics", "()Lcom/urbanairship/analytics/Analytics;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Analytics.Analytics> (JNIEnv.CallObjectMethod  (Handle, id_getAnalytics), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Analytics.Analytics> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAnalytics), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getAppIcon;
		public static int AppIcon {
			[Register ("getAppIcon", "()I", "GetGetAppIconHandler")]
			get {
				if (id_getAppIcon == IntPtr.Zero)
					id_getAppIcon = JNIEnv.GetStaticMethodID (class_ref, "getAppIcon", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getAppIcon);
			}
		}

		static IntPtr id_getAppInfo;
		public static global::Android.Content.PM.ApplicationInfo AppInfo {
			[Register ("getAppInfo", "()Landroid/content/pm/ApplicationInfo;", "GetGetAppInfoHandler")]
			get {
				if (id_getAppInfo == IntPtr.Zero)
					id_getAppInfo = JNIEnv.GetStaticMethodID (class_ref, "getAppInfo", "()Landroid/content/pm/ApplicationInfo;");
				return Java.Lang.Object.GetObject<global::Android.Content.PM.ApplicationInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getApplicationContext;
#pragma warning disable 0169
		static Delegate GetGetApplicationContextHandler ()
		{
			if (cb_getApplicationContext == null)
				cb_getApplicationContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationContext);
			return cb_getApplicationContext;
		}

		static IntPtr n_GetApplicationContext (IntPtr jnienv, IntPtr native__this)
		{
			UAirship __this = Java.Lang.Object.GetObject<UAirship> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApplicationContext);
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationContext;
		public virtual global::Android.Content.Context ApplicationContext {
			[Register ("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get {
				if (id_getApplicationContext == IntPtr.Zero)
					id_getApplicationContext = JNIEnv.GetMethodID (class_ref, "getApplicationContext", "()Landroid/content/Context;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod  (Handle, id_getApplicationContext), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getApplicationContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getAppName;
		public static string AppName {
			[Register ("getAppName", "()Ljava/lang/String;", "GetGetAppNameHandler")]
			get {
				if (id_getAppName == IntPtr.Zero)
					id_getAppName = JNIEnv.GetStaticMethodID (class_ref, "getAppName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isFlying;
#pragma warning disable 0169
		static Delegate GetIsFlyingHandler ()
		{
			if (cb_isFlying == null)
				cb_isFlying = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFlying);
			return cb_isFlying;
		}

		static bool n_IsFlying (IntPtr jnienv, IntPtr native__this)
		{
			UAirship __this = Java.Lang.Object.GetObject<UAirship> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFlying;
		}
#pragma warning restore 0169

		static IntPtr id_isFlying;
		public virtual bool IsFlying {
			[Register ("isFlying", "()Z", "GetIsFlyingHandler")]
			get {
				if (id_isFlying == IntPtr.Zero)
					id_isFlying = JNIEnv.GetMethodID (class_ref, "isFlying", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFlying);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isFlying);
			}
		}

		static IntPtr id_getPackageInfo;
		public static global::Android.Content.PM.PackageInfo PackageInfo {
			[Register ("getPackageInfo", "()Landroid/content/pm/PackageInfo;", "GetGetPackageInfoHandler")]
			get {
				if (id_getPackageInfo == IntPtr.Zero)
					id_getPackageInfo = JNIEnv.GetStaticMethodID (class_ref, "getPackageInfo", "()Landroid/content/pm/PackageInfo;");
				return Java.Lang.Object.GetObject<global::Android.Content.PM.PackageInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPackageManager;
		public static global::Android.Content.PM.PackageManager PackageManager {
			[Register ("getPackageManager", "()Landroid/content/pm/PackageManager;", "GetGetPackageManagerHandler")]
			get {
				if (id_getPackageManager == IntPtr.Zero)
					id_getPackageManager = JNIEnv.GetStaticMethodID (class_ref, "getPackageManager", "()Landroid/content/pm/PackageManager;");
				return Java.Lang.Object.GetObject<global::Android.Content.PM.PackageManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageManager), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPackageName;
		public static string PackageName {
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				if (id_getPackageName == IntPtr.Zero)
					id_getPackageName = JNIEnv.GetStaticMethodID (class_ref, "getPackageName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getVersion;
		public static string Version {
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetStaticMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_land;
		[Register ("land", "()V", "")]
		public static void Land ()
		{
			if (id_land == IntPtr.Zero)
				id_land = JNIEnv.GetStaticMethodID (class_ref, "land", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_land);
		}

		static IntPtr id_shared;
		[Register ("shared", "()Lcom/urbanairship/UAirship;", "")]
		public static global::Com.Urbanairship.UAirship Shared ()
		{
			if (id_shared == IntPtr.Zero)
				id_shared = JNIEnv.GetStaticMethodID (class_ref, "shared", "()Lcom/urbanairship/UAirship;");
			return Java.Lang.Object.GetObject<global::Com.Urbanairship.UAirship> (JNIEnv.CallStaticObjectMethod  (class_ref, id_shared), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_takeOff_Landroid_app_Application_;
		[Register ("takeOff", "(Landroid/app/Application;)V", "")]
		public static void TakeOff (global::Android.App.Application p0)
		{
			if (id_takeOff_Landroid_app_Application_ == IntPtr.Zero)
				id_takeOff_Landroid_app_Application_ = JNIEnv.GetStaticMethodID (class_ref, "takeOff", "(Landroid/app/Application;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_takeOff_Landroid_app_Application_, new JValue (p0));
		}

		static IntPtr id_takeOff_Landroid_app_Application_Lcom_urbanairship_AirshipConfigOptions_;
		[Register ("takeOff", "(Landroid/app/Application;Lcom/urbanairship/AirshipConfigOptions;)V", "")]
		public static void TakeOff (global::Android.App.Application p0, global::Com.Urbanairship.AirshipConfigOptions p1)
		{
			if (id_takeOff_Landroid_app_Application_Lcom_urbanairship_AirshipConfigOptions_ == IntPtr.Zero)
				id_takeOff_Landroid_app_Application_Lcom_urbanairship_AirshipConfigOptions_ = JNIEnv.GetStaticMethodID (class_ref, "takeOff", "(Landroid/app/Application;Lcom/urbanairship/AirshipConfigOptions;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_takeOff_Landroid_app_Application_Lcom_urbanairship_AirshipConfigOptions_, new JValue (p0), new JValue (p1));
		}

	}
}
