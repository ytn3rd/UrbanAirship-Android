using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship {

	[global::Android.Runtime.Register ("com/urbanairship/AirshipConfigOptions", DoNotGenerateAcw=true)]
	public partial class AirshipConfigOptions : global::Com.Urbanairship.Options {


		static IntPtr analyticsEnabled_jfieldId;

		[Register ("analyticsEnabled")]
		public bool AnalyticsEnabled {
			get {
				if (analyticsEnabled_jfieldId == IntPtr.Zero)
					analyticsEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "analyticsEnabled", "Z");
				return JNIEnv.GetBooleanField (Handle, analyticsEnabled_jfieldId);
			}
			set {
				if (analyticsEnabled_jfieldId == IntPtr.Zero)
					analyticsEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "analyticsEnabled", "Z");
				JNIEnv.SetField (Handle, analyticsEnabled_jfieldId, value);
			}
		}

		static IntPtr analyticsServer_jfieldId;

		[Register ("analyticsServer")]
		public string AnalyticsServer {
			get {
				if (analyticsServer_jfieldId == IntPtr.Zero)
					analyticsServer_jfieldId = JNIEnv.GetFieldID (class_ref, "analyticsServer", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, analyticsServer_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (analyticsServer_jfieldId == IntPtr.Zero)
					analyticsServer_jfieldId = JNIEnv.GetFieldID (class_ref, "analyticsServer", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, analyticsServer_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr developmentAppKey_jfieldId;

		[Register ("developmentAppKey")]
		public string DevelopmentAppKey {
			get {
				if (developmentAppKey_jfieldId == IntPtr.Zero)
					developmentAppKey_jfieldId = JNIEnv.GetFieldID (class_ref, "developmentAppKey", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, developmentAppKey_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (developmentAppKey_jfieldId == IntPtr.Zero)
					developmentAppKey_jfieldId = JNIEnv.GetFieldID (class_ref, "developmentAppKey", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, developmentAppKey_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr developmentAppSecret_jfieldId;

		[Register ("developmentAppSecret")]
		public string DevelopmentAppSecret {
			get {
				if (developmentAppSecret_jfieldId == IntPtr.Zero)
					developmentAppSecret_jfieldId = JNIEnv.GetFieldID (class_ref, "developmentAppSecret", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, developmentAppSecret_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (developmentAppSecret_jfieldId == IntPtr.Zero)
					developmentAppSecret_jfieldId = JNIEnv.GetFieldID (class_ref, "developmentAppSecret", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, developmentAppSecret_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr developmentLogLevel_jfieldId;

		[Register ("developmentLogLevel")]
		public int DevelopmentLogLevel {
			get {
				if (developmentLogLevel_jfieldId == IntPtr.Zero)
					developmentLogLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "developmentLogLevel", "I");
				return JNIEnv.GetIntField (Handle, developmentLogLevel_jfieldId);
			}
			set {
				if (developmentLogLevel_jfieldId == IntPtr.Zero)
					developmentLogLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "developmentLogLevel", "I");
				JNIEnv.SetField (Handle, developmentLogLevel_jfieldId, value);
			}
		}

		static IntPtr gcmSender_jfieldId;

		[Register ("gcmSender")]
		public string GcmSender {
			get {
				if (gcmSender_jfieldId == IntPtr.Zero)
					gcmSender_jfieldId = JNIEnv.GetFieldID (class_ref, "gcmSender", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, gcmSender_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (gcmSender_jfieldId == IntPtr.Zero)
					gcmSender_jfieldId = JNIEnv.GetFieldID (class_ref, "gcmSender", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, gcmSender_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr hostURL_jfieldId;

		[Register ("hostURL")]
		public string HostURL {
			get {
				if (hostURL_jfieldId == IntPtr.Zero)
					hostURL_jfieldId = JNIEnv.GetFieldID (class_ref, "hostURL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, hostURL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (hostURL_jfieldId == IntPtr.Zero)
					hostURL_jfieldId = JNIEnv.GetFieldID (class_ref, "hostURL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, hostURL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr iapEnabled_jfieldId;

		[Register ("iapEnabled")]
		public bool IapEnabled {
			get {
				if (iapEnabled_jfieldId == IntPtr.Zero)
					iapEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "iapEnabled", "Z");
				return JNIEnv.GetBooleanField (Handle, iapEnabled_jfieldId);
			}
			set {
				if (iapEnabled_jfieldId == IntPtr.Zero)
					iapEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "iapEnabled", "Z");
				JNIEnv.SetField (Handle, iapEnabled_jfieldId, value);
			}
		}

		static IntPtr inProduction_jfieldId;

		[Register ("inProduction")]
		public bool InProduction {
			get {
				if (inProduction_jfieldId == IntPtr.Zero)
					inProduction_jfieldId = JNIEnv.GetFieldID (class_ref, "inProduction", "Z");
				return JNIEnv.GetBooleanField (Handle, inProduction_jfieldId);
			}
			set {
				if (inProduction_jfieldId == IntPtr.Zero)
					inProduction_jfieldId = JNIEnv.GetFieldID (class_ref, "inProduction", "Z");
				JNIEnv.SetField (Handle, inProduction_jfieldId, value);
			}
		}

		static IntPtr locationOptions_jfieldId;

		[Register ("locationOptions")]
		public global::Com.Urbanairship.LocationOptions LocationOptions {
			get {
				if (locationOptions_jfieldId == IntPtr.Zero)
					locationOptions_jfieldId = JNIEnv.GetFieldID (class_ref, "locationOptions", "Lcom/urbanairship/LocationOptions;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, locationOptions_jfieldId);
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.LocationOptions> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (locationOptions_jfieldId == IntPtr.Zero)
					locationOptions_jfieldId = JNIEnv.GetFieldID (class_ref, "locationOptions", "Lcom/urbanairship/LocationOptions;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, locationOptions_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr productionAppKey_jfieldId;

		[Register ("productionAppKey")]
		public string ProductionAppKey {
			get {
				if (productionAppKey_jfieldId == IntPtr.Zero)
					productionAppKey_jfieldId = JNIEnv.GetFieldID (class_ref, "productionAppKey", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, productionAppKey_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (productionAppKey_jfieldId == IntPtr.Zero)
					productionAppKey_jfieldId = JNIEnv.GetFieldID (class_ref, "productionAppKey", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, productionAppKey_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr productionAppSecret_jfieldId;

		[Register ("productionAppSecret")]
		public string ProductionAppSecret {
			get {
				if (productionAppSecret_jfieldId == IntPtr.Zero)
					productionAppSecret_jfieldId = JNIEnv.GetFieldID (class_ref, "productionAppSecret", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, productionAppSecret_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (productionAppSecret_jfieldId == IntPtr.Zero)
					productionAppSecret_jfieldId = JNIEnv.GetFieldID (class_ref, "productionAppSecret", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, productionAppSecret_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr productionLogLevel_jfieldId;

		[Register ("productionLogLevel")]
		public int ProductionLogLevel {
			get {
				if (productionLogLevel_jfieldId == IntPtr.Zero)
					productionLogLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "productionLogLevel", "I");
				return JNIEnv.GetIntField (Handle, productionLogLevel_jfieldId);
			}
			set {
				if (productionLogLevel_jfieldId == IntPtr.Zero)
					productionLogLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "productionLogLevel", "I");
				JNIEnv.SetField (Handle, productionLogLevel_jfieldId, value);
			}
		}

		static IntPtr pushServiceEnabled_jfieldId;

		[Register ("pushServiceEnabled")]
		public bool PushServiceEnabled {
			get {
				if (pushServiceEnabled_jfieldId == IntPtr.Zero)
					pushServiceEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "pushServiceEnabled", "Z");
				return JNIEnv.GetBooleanField (Handle, pushServiceEnabled_jfieldId);
			}
			set {
				if (pushServiceEnabled_jfieldId == IntPtr.Zero)
					pushServiceEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "pushServiceEnabled", "Z");
				JNIEnv.SetField (Handle, pushServiceEnabled_jfieldId, value);
			}
		}

		static IntPtr richPushEnabled_jfieldId;

		[Register ("richPushEnabled")]
		public bool RichPushEnabled {
			get {
				if (richPushEnabled_jfieldId == IntPtr.Zero)
					richPushEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "richPushEnabled", "Z");
				return JNIEnv.GetBooleanField (Handle, richPushEnabled_jfieldId);
			}
			set {
				if (richPushEnabled_jfieldId == IntPtr.Zero)
					richPushEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "richPushEnabled", "Z");
				JNIEnv.SetField (Handle, richPushEnabled_jfieldId, value);
			}
		}
		[global::Android.Runtime.Register ("com/urbanairship/AirshipConfigOptions$TransportType", DoNotGenerateAcw=true)]
		public sealed partial class TransportType : global::Java.Lang.Enum {


			static IntPtr GCM_jfieldId;

			[Register ("GCM")]
			public static global::Com.Urbanairship.AirshipConfigOptions.TransportType Gcm {
				get {
					if (GCM_jfieldId == IntPtr.Zero)
						GCM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GCM", "Lcom/urbanairship/AirshipConfigOptions$TransportType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GCM_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.AirshipConfigOptions.TransportType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GCM_jfieldId == IntPtr.Zero)
						GCM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GCM", "Lcom/urbanairship/AirshipConfigOptions$TransportType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GCM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr HELIUM_jfieldId;

			[Register ("HELIUM")]
			public static global::Com.Urbanairship.AirshipConfigOptions.TransportType Helium {
				get {
					if (HELIUM_jfieldId == IntPtr.Zero)
						HELIUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HELIUM", "Lcom/urbanairship/AirshipConfigOptions$TransportType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HELIUM_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.AirshipConfigOptions.TransportType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (HELIUM_jfieldId == IntPtr.Zero)
						HELIUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HELIUM", "Lcom/urbanairship/AirshipConfigOptions$TransportType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, HELIUM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr HYBRID_jfieldId;

			[Register ("HYBRID")]
			public static global::Com.Urbanairship.AirshipConfigOptions.TransportType Hybrid {
				get {
					if (HYBRID_jfieldId == IntPtr.Zero)
						HYBRID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HYBRID", "Lcom/urbanairship/AirshipConfigOptions$TransportType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HYBRID_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.AirshipConfigOptions.TransportType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (HYBRID_jfieldId == IntPtr.Zero)
						HYBRID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HYBRID", "Lcom/urbanairship/AirshipConfigOptions$TransportType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, HYBRID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/AirshipConfigOptions$TransportType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TransportType); }
			}

			internal TransportType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/urbanairship/AirshipConfigOptions$TransportType;", "")]
			public static global::Com.Urbanairship.AirshipConfigOptions.TransportType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/urbanairship/AirshipConfigOptions$TransportType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Urbanairship.AirshipConfigOptions.TransportType __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.AirshipConfigOptions.TransportType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			[Register ("values", "()[Lcom/urbanairship/AirshipConfigOptions$TransportType;", "")]
			public static global::Com.Urbanairship.AirshipConfigOptions.TransportType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/urbanairship/AirshipConfigOptions$TransportType;");
				return (Com.Urbanairship.AirshipConfigOptions.TransportType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Urbanairship.AirshipConfigOptions.TransportType));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/AirshipConfigOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AirshipConfigOptions); }
		}

		protected AirshipConfigOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public AirshipConfigOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AirshipConfigOptions)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getAppKey;
#pragma warning disable 0169
		static Delegate GetGetAppKeyHandler ()
		{
			if (cb_getAppKey == null)
				cb_getAppKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppKey);
			return cb_getAppKey;
		}

		static IntPtr n_GetAppKey (IntPtr jnienv, IntPtr native__this)
		{
			AirshipConfigOptions __this = Java.Lang.Object.GetObject<AirshipConfigOptions> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppKey);
		}
#pragma warning restore 0169

		static IntPtr id_getAppKey;
		public virtual string AppKey {
			[Register ("getAppKey", "()Ljava/lang/String;", "GetGetAppKeyHandler")]
			get {
				if (id_getAppKey == IntPtr.Zero)
					id_getAppKey = JNIEnv.GetMethodID (class_ref, "getAppKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAppKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAppSecret;
#pragma warning disable 0169
		static Delegate GetGetAppSecretHandler ()
		{
			if (cb_getAppSecret == null)
				cb_getAppSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppSecret);
			return cb_getAppSecret;
		}

		static IntPtr n_GetAppSecret (IntPtr jnienv, IntPtr native__this)
		{
			AirshipConfigOptions __this = Java.Lang.Object.GetObject<AirshipConfigOptions> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppSecret);
		}
#pragma warning restore 0169

		static IntPtr id_getAppSecret;
		public virtual string AppSecret {
			[Register ("getAppSecret", "()Ljava/lang/String;", "GetGetAppSecretHandler")]
			get {
				if (id_getAppSecret == IntPtr.Zero)
					id_getAppSecret = JNIEnv.GetMethodID (class_ref, "getAppSecret", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppSecret), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAppSecret), JniHandleOwnership.TransferLocalRef);
			}
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
			AirshipConfigOptions __this = Java.Lang.Object.GetObject<AirshipConfigOptions> (native__this, JniHandleOwnership.DoNotTransfer);
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
			AirshipConfigOptions __this = Java.Lang.Object.GetObject<AirshipConfigOptions> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getLoggerLevel;
#pragma warning disable 0169
		static Delegate GetGetLoggerLevelHandler ()
		{
			if (cb_getLoggerLevel == null)
				cb_getLoggerLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLoggerLevel);
			return cb_getLoggerLevel;
		}

		static int n_GetLoggerLevel (IntPtr jnienv, IntPtr native__this)
		{
			AirshipConfigOptions __this = Java.Lang.Object.GetObject<AirshipConfigOptions> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LoggerLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getLoggerLevel;
		public virtual int LoggerLevel {
			[Register ("getLoggerLevel", "()I", "GetGetLoggerLevelHandler")]
			get {
				if (id_getLoggerLevel == IntPtr.Zero)
					id_getLoggerLevel = JNIEnv.GetMethodID (class_ref, "getLoggerLevel", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLoggerLevel);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getLoggerLevel);
			}
		}

		static Delegate cb_getTransport;
#pragma warning disable 0169
		static Delegate GetGetTransportHandler ()
		{
			if (cb_getTransport == null)
				cb_getTransport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransport);
			return cb_getTransport;
		}

		static IntPtr n_GetTransport (IntPtr jnienv, IntPtr native__this)
		{
			AirshipConfigOptions __this = Java.Lang.Object.GetObject<AirshipConfigOptions> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transport);
		}
#pragma warning restore 0169

		static IntPtr id_getTransport;
		public virtual global::Com.Urbanairship.AirshipConfigOptions.TransportType Transport {
			[Register ("getTransport", "()Lcom/urbanairship/AirshipConfigOptions$TransportType;", "GetGetTransportHandler")]
			get {
				if (id_getTransport == IntPtr.Zero)
					id_getTransport = JNIEnv.GetMethodID (class_ref, "getTransport", "()Lcom/urbanairship/AirshipConfigOptions$TransportType;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.AirshipConfigOptions.TransportType> (JNIEnv.CallObjectMethod  (Handle, id_getTransport), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.AirshipConfigOptions.TransportType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTransport), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_loadDefaultOptions_Landroid_content_Context_;
		[Register ("loadDefaultOptions", "(Landroid/content/Context;)Lcom/urbanairship/AirshipConfigOptions;", "")]
		public static global::Com.Urbanairship.AirshipConfigOptions LoadDefaultOptions (global::Android.Content.Context p0)
		{
			if (id_loadDefaultOptions_Landroid_content_Context_ == IntPtr.Zero)
				id_loadDefaultOptions_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "loadDefaultOptions", "(Landroid/content/Context;)Lcom/urbanairship/AirshipConfigOptions;");
			global::Com.Urbanairship.AirshipConfigOptions __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.AirshipConfigOptions> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadDefaultOptions_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
