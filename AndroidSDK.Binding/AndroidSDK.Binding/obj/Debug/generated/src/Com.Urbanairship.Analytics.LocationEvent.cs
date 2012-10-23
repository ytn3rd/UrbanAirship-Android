using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Analytics {

	[global::Android.Runtime.Register ("com/urbanairship/analytics/LocationEvent", DoNotGenerateAcw=true)]
	public partial class LocationEvent : global::Com.Urbanairship.Analytics.Event {

		[global::Android.Runtime.Register ("com/urbanairship/analytics/LocationEvent$AllowableProvider", DoNotGenerateAcw=true)]
		public sealed partial class AllowableProvider : global::Java.Lang.Enum {


			static IntPtr GPS_jfieldId;

			[Register ("GPS")]
			public static global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider Gps {
				get {
					if (GPS_jfieldId == IntPtr.Zero)
						GPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GPS", "Lcom/urbanairship/analytics/LocationEvent$AllowableProvider;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GPS_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GPS_jfieldId == IntPtr.Zero)
						GPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GPS", "Lcom/urbanairship/analytics/LocationEvent$AllowableProvider;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GPS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NETWORK_jfieldId;

			[Register ("NETWORK")]
			public static global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider Network {
				get {
					if (NETWORK_jfieldId == IntPtr.Zero)
						NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK", "Lcom/urbanairship/analytics/LocationEvent$AllowableProvider;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NETWORK_jfieldId == IntPtr.Zero)
						NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK", "Lcom/urbanairship/analytics/LocationEvent$AllowableProvider;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NETWORK_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PASSIVE_jfieldId;

			[Register ("PASSIVE")]
			public static global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider Passive {
				get {
					if (PASSIVE_jfieldId == IntPtr.Zero)
						PASSIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PASSIVE", "Lcom/urbanairship/analytics/LocationEvent$AllowableProvider;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PASSIVE_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PASSIVE_jfieldId == IntPtr.Zero)
						PASSIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PASSIVE", "Lcom/urbanairship/analytics/LocationEvent$AllowableProvider;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PASSIVE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			[Register ("UNKNOWN")]
			public static global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/urbanairship/analytics/LocationEvent$AllowableProvider;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/urbanairship/analytics/LocationEvent$AllowableProvider;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNKNOWN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/analytics/LocationEvent$AllowableProvider", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AllowableProvider); }
			}

			internal AllowableProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/urbanairship/analytics/LocationEvent$AllowableProvider;", "")]
			public static global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/urbanairship/analytics/LocationEvent$AllowableProvider;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			[Register ("values", "()[Lcom/urbanairship/analytics/LocationEvent$AllowableProvider;", "")]
			public static global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/urbanairship/analytics/LocationEvent$AllowableProvider;");
				return (Com.Urbanairship.Analytics.LocationEvent.AllowableProvider[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Urbanairship.Analytics.LocationEvent.AllowableProvider));
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/analytics/LocationEvent$UpdateType", DoNotGenerateAcw=true)]
		public sealed partial class UpdateType : global::Java.Lang.Enum {


			static IntPtr CHANGE_jfieldId;

			[Register ("CHANGE")]
			public static global::Com.Urbanairship.Analytics.LocationEvent.UpdateType Change {
				get {
					if (CHANGE_jfieldId == IntPtr.Zero)
						CHANGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHANGE", "Lcom/urbanairship/analytics/LocationEvent$UpdateType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHANGE_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Analytics.LocationEvent.UpdateType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CHANGE_jfieldId == IntPtr.Zero)
						CHANGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHANGE", "Lcom/urbanairship/analytics/LocationEvent$UpdateType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CHANGE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CONTINUOUS_jfieldId;

			[Register ("CONTINUOUS")]
			public static global::Com.Urbanairship.Analytics.LocationEvent.UpdateType Continuous {
				get {
					if (CONTINUOUS_jfieldId == IntPtr.Zero)
						CONTINUOUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTINUOUS", "Lcom/urbanairship/analytics/LocationEvent$UpdateType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTINUOUS_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Analytics.LocationEvent.UpdateType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CONTINUOUS_jfieldId == IntPtr.Zero)
						CONTINUOUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTINUOUS", "Lcom/urbanairship/analytics/LocationEvent$UpdateType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CONTINUOUS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SINGLE_jfieldId;

			[Register ("SINGLE")]
			public static global::Com.Urbanairship.Analytics.LocationEvent.UpdateType Single {
				get {
					if (SINGLE_jfieldId == IntPtr.Zero)
						SINGLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINGLE", "Lcom/urbanairship/analytics/LocationEvent$UpdateType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINGLE_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Analytics.LocationEvent.UpdateType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SINGLE_jfieldId == IntPtr.Zero)
						SINGLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINGLE", "Lcom/urbanairship/analytics/LocationEvent$UpdateType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SINGLE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/analytics/LocationEvent$UpdateType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UpdateType); }
			}

			internal UpdateType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/urbanairship/analytics/LocationEvent$UpdateType;", "")]
			public static global::Com.Urbanairship.Analytics.LocationEvent.UpdateType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/urbanairship/analytics/LocationEvent$UpdateType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Urbanairship.Analytics.LocationEvent.UpdateType __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Analytics.LocationEvent.UpdateType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			[Register ("values", "()[Lcom/urbanairship/analytics/LocationEvent$UpdateType;", "")]
			public static global::Com.Urbanairship.Analytics.LocationEvent.UpdateType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/urbanairship/analytics/LocationEvent$UpdateType;");
				return (Com.Urbanairship.Analytics.LocationEvent.UpdateType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Urbanairship.Analytics.LocationEvent.UpdateType));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/analytics/LocationEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationEvent); }
		}

		protected LocationEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_location_Location_Lcom_urbanairship_analytics_LocationEvent_UpdateType_II;
		[Register (".ctor", "(Landroid/location/Location;Lcom/urbanairship/analytics/LocationEvent$UpdateType;II)V", "")]
		public LocationEvent (global::Android.Locations.Location p0, global::Com.Urbanairship.Analytics.LocationEvent.UpdateType p1, int p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LocationEvent)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/location/Location;Lcom/urbanairship/analytics/LocationEvent$UpdateType;II)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_location_Location_Lcom_urbanairship_analytics_LocationEvent_UpdateType_II == IntPtr.Zero)
				id_ctor_Landroid_location_Location_Lcom_urbanairship_analytics_LocationEvent_UpdateType_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/location/Location;Lcom/urbanairship/analytics/LocationEvent$UpdateType;II)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_location_Location_Lcom_urbanairship_analytics_LocationEvent_UpdateType_II, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
