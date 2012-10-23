using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Analytics {

	[global::Android.Runtime.Register ("com/urbanairship/analytics/Event", DoNotGenerateAcw=true)]
	public abstract partial class Event : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/analytics/Event$Environment", DoNotGenerateAcw=true)]
		public partial class Environment : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/analytics/Event$Environment", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Environment); }
			}

			protected Environment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_urbanairship_analytics_Event_;
			[Register (".ctor", "(Lcom/urbanairship/analytics/Event;)V", "")]
			public Environment (global::Com.Urbanairship.Analytics.Event __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Environment)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_urbanairship_analytics_Event_ == IntPtr.Zero)
					id_ctor_Lcom_urbanairship_analytics_Event_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/analytics/Event;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_analytics_Event_, new JValue (__self)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_getApid;
#pragma warning disable 0169
			static Delegate GetGetApidHandler ()
			{
				if (cb_getApid == null)
					cb_getApid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApid);
				return cb_getApid;
			}

			static IntPtr n_GetApid (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Apid);
			}
#pragma warning restore 0169

			static IntPtr id_getApid;
			public virtual string Apid {
				[Register ("getApid", "()Ljava/lang/String;", "GetGetApidHandler")]
				get {
					if (id_getApid == IntPtr.Zero)
						id_getApid = JNIEnv.GetMethodID (class_ref, "getApid", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApid), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getApid), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getCarrier;
#pragma warning disable 0169
			static Delegate GetGetCarrierHandler ()
			{
				if (cb_getCarrier == null)
					cb_getCarrier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCarrier);
				return cb_getCarrier;
			}

			static IntPtr n_GetCarrier (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Carrier);
			}
#pragma warning restore 0169

			static IntPtr id_getCarrier;
			public virtual string Carrier {
				[Register ("getCarrier", "()Ljava/lang/String;", "GetGetCarrierHandler")]
				get {
					if (id_getCarrier == IntPtr.Zero)
						id_getCarrier = JNIEnv.GetMethodID (class_ref, "getCarrier", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCarrier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCarrier), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getConnectionSubType;
#pragma warning disable 0169
			static Delegate GetGetConnectionSubTypeHandler ()
			{
				if (cb_getConnectionSubType == null)
					cb_getConnectionSubType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectionSubType);
				return cb_getConnectionSubType;
			}

			static IntPtr n_GetConnectionSubType (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ConnectionSubType);
			}
#pragma warning restore 0169

			static IntPtr id_getConnectionSubType;
			public virtual string ConnectionSubType {
				[Register ("getConnectionSubType", "()Ljava/lang/String;", "GetGetConnectionSubTypeHandler")]
				get {
					if (id_getConnectionSubType == IntPtr.Zero)
						id_getConnectionSubType = JNIEnv.GetMethodID (class_ref, "getConnectionSubType", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getConnectionSubType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getConnectionSubType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getConnectionType;
#pragma warning disable 0169
			static Delegate GetGetConnectionTypeHandler ()
			{
				if (cb_getConnectionType == null)
					cb_getConnectionType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectionType);
				return cb_getConnectionType;
			}

			static IntPtr n_GetConnectionType (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ConnectionType);
			}
#pragma warning restore 0169

			static IntPtr id_getConnectionType;
			public virtual string ConnectionType {
				[Register ("getConnectionType", "()Ljava/lang/String;", "GetGetConnectionTypeHandler")]
				get {
					if (id_getConnectionType == IntPtr.Zero)
						id_getConnectionType = JNIEnv.GetMethodID (class_ref, "getConnectionType", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getConnectionType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getConnectionType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_isDaylightSavingsTime;
#pragma warning disable 0169
			static Delegate GetIsDaylightSavingsTimeHandler ()
			{
				if (cb_isDaylightSavingsTime == null)
					cb_isDaylightSavingsTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDaylightSavingsTime);
				return cb_isDaylightSavingsTime;
			}

			static bool n_IsDaylightSavingsTime (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsDaylightSavingsTime;
			}
#pragma warning restore 0169

			static IntPtr id_isDaylightSavingsTime;
			public virtual bool IsDaylightSavingsTime {
				[Register ("isDaylightSavingsTime", "()Z", "GetIsDaylightSavingsTimeHandler")]
				get {
					if (id_isDaylightSavingsTime == IntPtr.Zero)
						id_isDaylightSavingsTime = JNIEnv.GetMethodID (class_ref, "isDaylightSavingsTime", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDaylightSavingsTime);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isDaylightSavingsTime);
				}
			}

			static Delegate cb_getLibVersion;
#pragma warning disable 0169
			static Delegate GetGetLibVersionHandler ()
			{
				if (cb_getLibVersion == null)
					cb_getLibVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLibVersion);
				return cb_getLibVersion;
			}

			static IntPtr n_GetLibVersion (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.LibVersion);
			}
#pragma warning restore 0169

			static IntPtr id_getLibVersion;
			public virtual string LibVersion {
				[Register ("getLibVersion", "()Ljava/lang/String;", "GetGetLibVersionHandler")]
				get {
					if (id_getLibVersion == IntPtr.Zero)
						id_getLibVersion = JNIEnv.GetMethodID (class_ref, "getLibVersion", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLibVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLibVersion), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getNotificationTypes;
#pragma warning disable 0169
			static Delegate GetGetNotificationTypesHandler ()
			{
				if (cb_getNotificationTypes == null)
					cb_getNotificationTypes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationTypes);
				return cb_getNotificationTypes;
			}

			static IntPtr n_GetNotificationTypes (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.NotificationTypes);
			}
#pragma warning restore 0169

			static IntPtr id_getNotificationTypes;
			public virtual global::System.Collections.Generic.IList<string> NotificationTypes {
				[Register ("getNotificationTypes", "()Ljava/util/ArrayList;", "GetGetNotificationTypesHandler")]
				get {
					if (id_getNotificationTypes == IntPtr.Zero)
						id_getNotificationTypes = JNIEnv.GetMethodID (class_ref, "getNotificationTypes", "()Ljava/util/ArrayList;");

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getNotificationTypes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getNotificationTypes), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getOsVersion;
#pragma warning disable 0169
			static Delegate GetGetOsVersionHandler ()
			{
				if (cb_getOsVersion == null)
					cb_getOsVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOsVersion);
				return cb_getOsVersion;
			}

			static IntPtr n_GetOsVersion (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.OsVersion);
			}
#pragma warning restore 0169

			static IntPtr id_getOsVersion;
			public virtual string OsVersion {
				[Register ("getOsVersion", "()Ljava/lang/String;", "GetGetOsVersionHandler")]
				get {
					if (id_getOsVersion == IntPtr.Zero)
						id_getOsVersion = JNIEnv.GetMethodID (class_ref, "getOsVersion", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOsVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getOsVersion), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getPackageVersion;
#pragma warning disable 0169
			static Delegate GetGetPackageVersionHandler ()
			{
				if (cb_getPackageVersion == null)
					cb_getPackageVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageVersion);
				return cb_getPackageVersion;
			}

			static IntPtr n_GetPackageVersion (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PackageVersion);
			}
#pragma warning restore 0169

			static IntPtr id_getPackageVersion;
			public virtual string PackageVersion {
				[Register ("getPackageVersion", "()Ljava/lang/String;", "GetGetPackageVersionHandler")]
				get {
					if (id_getPackageVersion == IntPtr.Zero)
						id_getPackageVersion = JNIEnv.GetMethodID (class_ref, "getPackageVersion", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPackageVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPackageVersion), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getPushId;
#pragma warning disable 0169
			static Delegate GetGetPushIdHandler ()
			{
				if (cb_getPushId == null)
					cb_getPushId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPushId);
				return cb_getPushId;
			}

			static IntPtr n_GetPushId (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PushId);
			}
#pragma warning restore 0169

			static IntPtr id_getPushId;
			public virtual string PushId {
				[Register ("getPushId", "()Ljava/lang/String;", "GetGetPushIdHandler")]
				get {
					if (id_getPushId == IntPtr.Zero)
						id_getPushId = JNIEnv.GetMethodID (class_ref, "getPushId", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPushId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPushId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getPushTransport;
#pragma warning disable 0169
			static Delegate GetGetPushTransportHandler ()
			{
				if (cb_getPushTransport == null)
					cb_getPushTransport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPushTransport);
				return cb_getPushTransport;
			}

			static IntPtr n_GetPushTransport (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PushTransport);
			}
#pragma warning restore 0169

			static IntPtr id_getPushTransport;
			public virtual string PushTransport {
				[Register ("getPushTransport", "()Ljava/lang/String;", "GetGetPushTransportHandler")]
				get {
					if (id_getPushTransport == IntPtr.Zero)
						id_getPushTransport = JNIEnv.GetMethodID (class_ref, "getPushTransport", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPushTransport), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPushTransport), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getSessionId;
#pragma warning disable 0169
			static Delegate GetGetSessionIdHandler ()
			{
				if (cb_getSessionId == null)
					cb_getSessionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionId);
				return cb_getSessionId;
			}

			static IntPtr n_GetSessionId (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.SessionId);
			}
#pragma warning restore 0169

			static IntPtr id_getSessionId;
			public virtual string SessionId {
				[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
				get {
					if (id_getSessionId == IntPtr.Zero)
						id_getSessionId = JNIEnv.GetMethodID (class_ref, "getSessionId", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSessionId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSessionId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getTimezone;
#pragma warning disable 0169
			static Delegate GetGetTimezoneHandler ()
			{
				if (cb_getTimezone == null)
					cb_getTimezone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimezone);
				return cb_getTimezone;
			}

			static long n_GetTimezone (IntPtr jnienv, IntPtr native__this)
			{
				Environment __this = Java.Lang.Object.GetObject<Environment> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Timezone;
			}
#pragma warning restore 0169

			static IntPtr id_getTimezone;
			public virtual long Timezone {
				[Register ("getTimezone", "()J", "GetGetTimezoneHandler")]
				get {
					if (id_getTimezone == IntPtr.Zero)
						id_getTimezone = JNIEnv.GetMethodID (class_ref, "getTimezone", "()J");

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getTimezone);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getTimezone);
				}
			}

		}

		protected Event (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[global::Android.Runtime.Register ("com/urbanairship/analytics/Event", DoNotGenerateAcw=true)]
	internal partial class EventInvoker : Event {

		public EventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventInvoker); }
		}

	}

}
