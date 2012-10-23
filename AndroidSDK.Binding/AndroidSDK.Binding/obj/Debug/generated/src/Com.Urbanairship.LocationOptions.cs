using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship {

	[global::Android.Runtime.Register ("com/urbanairship/LocationOptions", DoNotGenerateAcw=true)]
	public partial class LocationOptions : global::Com.Urbanairship.Options {


		static IntPtr allowGPSForLocationTracking_jfieldId;

		[Register ("allowGPSForLocationTracking")]
		public bool AllowGPSForLocationTracking {
			get {
				if (allowGPSForLocationTracking_jfieldId == IntPtr.Zero)
					allowGPSForLocationTracking_jfieldId = JNIEnv.GetFieldID (class_ref, "allowGPSForLocationTracking", "Z");
				return JNIEnv.GetBooleanField (Handle, allowGPSForLocationTracking_jfieldId);
			}
			set {
				if (allowGPSForLocationTracking_jfieldId == IntPtr.Zero)
					allowGPSForLocationTracking_jfieldId = JNIEnv.GetFieldID (class_ref, "allowGPSForLocationTracking", "Z");
				JNIEnv.SetField (Handle, allowGPSForLocationTracking_jfieldId, value);
			}
		}

		static IntPtr altitudeRequired_jfieldId;

		[Register ("altitudeRequired")]
		public bool AltitudeRequired {
			get {
				if (altitudeRequired_jfieldId == IntPtr.Zero)
					altitudeRequired_jfieldId = JNIEnv.GetFieldID (class_ref, "altitudeRequired", "Z");
				return JNIEnv.GetBooleanField (Handle, altitudeRequired_jfieldId);
			}
			set {
				if (altitudeRequired_jfieldId == IntPtr.Zero)
					altitudeRequired_jfieldId = JNIEnv.GetFieldID (class_ref, "altitudeRequired", "Z");
				JNIEnv.SetField (Handle, altitudeRequired_jfieldId, value);
			}
		}

		static IntPtr backgroundReportingIntervalSeconds_jfieldId;

		[Register ("backgroundReportingIntervalSeconds")]
		public long BackgroundReportingIntervalSeconds {
			get {
				if (backgroundReportingIntervalSeconds_jfieldId == IntPtr.Zero)
					backgroundReportingIntervalSeconds_jfieldId = JNIEnv.GetFieldID (class_ref, "backgroundReportingIntervalSeconds", "J");
				return JNIEnv.GetLongField (Handle, backgroundReportingIntervalSeconds_jfieldId);
			}
			set {
				if (backgroundReportingIntervalSeconds_jfieldId == IntPtr.Zero)
					backgroundReportingIntervalSeconds_jfieldId = JNIEnv.GetFieldID (class_ref, "backgroundReportingIntervalSeconds", "J");
				JNIEnv.SetField (Handle, backgroundReportingIntervalSeconds_jfieldId, value);
			}
		}

		static IntPtr bearingRequired_jfieldId;

		[Register ("bearingRequired")]
		public bool BearingRequired {
			get {
				if (bearingRequired_jfieldId == IntPtr.Zero)
					bearingRequired_jfieldId = JNIEnv.GetFieldID (class_ref, "bearingRequired", "Z");
				return JNIEnv.GetBooleanField (Handle, bearingRequired_jfieldId);
			}
			set {
				if (bearingRequired_jfieldId == IntPtr.Zero)
					bearingRequired_jfieldId = JNIEnv.GetFieldID (class_ref, "bearingRequired", "Z");
				JNIEnv.SetField (Handle, bearingRequired_jfieldId, value);
			}
		}

		static IntPtr costAllowed_jfieldId;

		[Register ("costAllowed")]
		public bool CostAllowed {
			get {
				if (costAllowed_jfieldId == IntPtr.Zero)
					costAllowed_jfieldId = JNIEnv.GetFieldID (class_ref, "costAllowed", "Z");
				return JNIEnv.GetBooleanField (Handle, costAllowed_jfieldId);
			}
			set {
				if (costAllowed_jfieldId == IntPtr.Zero)
					costAllowed_jfieldId = JNIEnv.GetFieldID (class_ref, "costAllowed", "Z");
				JNIEnv.SetField (Handle, costAllowed_jfieldId, value);
			}
		}

		static IntPtr horizontalAccuracy_jfieldId;

		[Register ("horizontalAccuracy")]
		public int HorizontalAccuracy {
			get {
				if (horizontalAccuracy_jfieldId == IntPtr.Zero)
					horizontalAccuracy_jfieldId = JNIEnv.GetFieldID (class_ref, "horizontalAccuracy", "I");
				return JNIEnv.GetIntField (Handle, horizontalAccuracy_jfieldId);
			}
			set {
				if (horizontalAccuracy_jfieldId == IntPtr.Zero)
					horizontalAccuracy_jfieldId = JNIEnv.GetFieldID (class_ref, "horizontalAccuracy", "I");
				JNIEnv.SetField (Handle, horizontalAccuracy_jfieldId, value);
			}
		}

		static IntPtr locationServiceEnabled_jfieldId;

		[Register ("locationServiceEnabled")]
		public bool LocationServiceEnabled {
			get {
				if (locationServiceEnabled_jfieldId == IntPtr.Zero)
					locationServiceEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "locationServiceEnabled", "Z");
				return JNIEnv.GetBooleanField (Handle, locationServiceEnabled_jfieldId);
			}
			set {
				if (locationServiceEnabled_jfieldId == IntPtr.Zero)
					locationServiceEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "locationServiceEnabled", "Z");
				JNIEnv.SetField (Handle, locationServiceEnabled_jfieldId, value);
			}
		}

		static IntPtr powerRequirement_jfieldId;

		[Register ("powerRequirement")]
		public int PowerRequirement {
			get {
				if (powerRequirement_jfieldId == IntPtr.Zero)
					powerRequirement_jfieldId = JNIEnv.GetFieldID (class_ref, "powerRequirement", "I");
				return JNIEnv.GetIntField (Handle, powerRequirement_jfieldId);
			}
			set {
				if (powerRequirement_jfieldId == IntPtr.Zero)
					powerRequirement_jfieldId = JNIEnv.GetFieldID (class_ref, "powerRequirement", "I");
				JNIEnv.SetField (Handle, powerRequirement_jfieldId, value);
			}
		}

		static IntPtr speedRequired_jfieldId;

		[Register ("speedRequired")]
		public bool SpeedRequired {
			get {
				if (speedRequired_jfieldId == IntPtr.Zero)
					speedRequired_jfieldId = JNIEnv.GetFieldID (class_ref, "speedRequired", "Z");
				return JNIEnv.GetBooleanField (Handle, speedRequired_jfieldId);
			}
			set {
				if (speedRequired_jfieldId == IntPtr.Zero)
					speedRequired_jfieldId = JNIEnv.GetFieldID (class_ref, "speedRequired", "Z");
				JNIEnv.SetField (Handle, speedRequired_jfieldId, value);
			}
		}

		static IntPtr updateIntervalMeters_jfieldId;

		[Register ("updateIntervalMeters")]
		public int UpdateIntervalMeters {
			get {
				if (updateIntervalMeters_jfieldId == IntPtr.Zero)
					updateIntervalMeters_jfieldId = JNIEnv.GetFieldID (class_ref, "updateIntervalMeters", "I");
				return JNIEnv.GetIntField (Handle, updateIntervalMeters_jfieldId);
			}
			set {
				if (updateIntervalMeters_jfieldId == IntPtr.Zero)
					updateIntervalMeters_jfieldId = JNIEnv.GetFieldID (class_ref, "updateIntervalMeters", "I");
				JNIEnv.SetField (Handle, updateIntervalMeters_jfieldId, value);
			}
		}

		static IntPtr updateIntervalSeconds_jfieldId;

		[Register ("updateIntervalSeconds")]
		public long UpdateIntervalSeconds {
			get {
				if (updateIntervalSeconds_jfieldId == IntPtr.Zero)
					updateIntervalSeconds_jfieldId = JNIEnv.GetFieldID (class_ref, "updateIntervalSeconds", "J");
				return JNIEnv.GetLongField (Handle, updateIntervalSeconds_jfieldId);
			}
			set {
				if (updateIntervalSeconds_jfieldId == IntPtr.Zero)
					updateIntervalSeconds_jfieldId = JNIEnv.GetFieldID (class_ref, "updateIntervalSeconds", "J");
				JNIEnv.SetField (Handle, updateIntervalSeconds_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/LocationOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationOptions); }
		}

		protected LocationOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public LocationOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LocationOptions)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getDefaultPropertiesFilename;
#pragma warning disable 0169
		static Delegate GetGetDefaultPropertiesFilenameHandler ()
		{
			if (cb_getDefaultPropertiesFilename == null)
				cb_getDefaultPropertiesFilename = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultPropertiesFilename);
			return cb_getDefaultPropertiesFilename;
		}

		static IntPtr n_GetDefaultPropertiesFilename (IntPtr jnienv, IntPtr native__this)
		{
			LocationOptions __this = Java.Lang.Object.GetObject<LocationOptions> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultPropertiesFilename);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultPropertiesFilename;
		public override string DefaultPropertiesFilename {
			[Register ("getDefaultPropertiesFilename", "()Ljava/lang/String;", "GetGetDefaultPropertiesFilenameHandler")]
			get {
				if (id_getDefaultPropertiesFilename == IntPtr.Zero)
					id_getDefaultPropertiesFilename = JNIEnv.GetMethodID (class_ref, "getDefaultPropertiesFilename", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDefaultPropertiesFilename), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDefaultPropertiesFilename), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			LocationOptions __this = Java.Lang.Object.GetObject<LocationOptions> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isValid;
		public override bool IsValid {
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isValid);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isValid);
			}
		}

		static IntPtr id_loadDefaultOptions_Landroid_content_Context_;
		[Register ("loadDefaultOptions", "(Landroid/content/Context;)Lcom/urbanairship/LocationOptions;", "")]
		public static global::Com.Urbanairship.LocationOptions LoadDefaultOptions (global::Android.Content.Context p0)
		{
			if (id_loadDefaultOptions_Landroid_content_Context_ == IntPtr.Zero)
				id_loadDefaultOptions_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "loadDefaultOptions", "(Landroid/content/Context;)Lcom/urbanairship/LocationOptions;");
			global::Com.Urbanairship.LocationOptions __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.LocationOptions> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadDefaultOptions_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
