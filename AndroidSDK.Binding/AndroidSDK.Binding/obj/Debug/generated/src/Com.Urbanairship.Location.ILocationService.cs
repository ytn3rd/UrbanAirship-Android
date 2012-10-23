using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Location {

	[global::Android.Runtime.Register ("com/urbanairship/location/ILocationService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class LocationServiceStub : global::Android.OS.Binder, global::Com.Urbanairship.Location.ILocationService {

		[global::Android.Runtime.Register ("com/urbanairship/location/ILocationService$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::Com.Urbanairship.Location.ILocationService {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/location/ILocationService$Stub$Proxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Proxy); }
			}

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getBestProvider;
#pragma warning disable 0169
			static Delegate GetGetBestProviderHandler ()
			{
				if (cb_getBestProvider == null)
					cb_getBestProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBestProvider);
				return cb_getBestProvider;
			}

			static IntPtr n_GetBestProvider (IntPtr jnienv, IntPtr native__this)
			{
				Proxy __this = Java.Lang.Object.GetObject<Proxy> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.BestProvider);
			}
#pragma warning restore 0169

			static IntPtr id_getBestProvider;
			public virtual string BestProvider {
				[Register ("getBestProvider", "()Ljava/lang/String;", "GetGetBestProviderHandler")]
				get {
					if (id_getBestProvider == IntPtr.Zero)
						id_getBestProvider = JNIEnv.GetMethodID (class_ref, "getBestProvider", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBestProvider), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getBestProvider), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getCriteria;
#pragma warning disable 0169
			static Delegate GetGetCriteriaHandler ()
			{
				if (cb_getCriteria == null)
					cb_getCriteria = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCriteria);
				return cb_getCriteria;
			}

			static IntPtr n_GetCriteria (IntPtr jnienv, IntPtr native__this)
			{
				Proxy __this = Java.Lang.Object.GetObject<Proxy> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Criteria);
			}
#pragma warning restore 0169

			static Delegate cb_setCriteria_Landroid_location_Criteria_;
#pragma warning disable 0169
			static Delegate GetSetCriteria_Landroid_location_Criteria_Handler ()
			{
				if (cb_setCriteria_Landroid_location_Criteria_ == null)
					cb_setCriteria_Landroid_location_Criteria_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCriteria_Landroid_location_Criteria_);
				return cb_setCriteria_Landroid_location_Criteria_;
			}

			static void n_SetCriteria_Landroid_location_Criteria_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Proxy __this = Java.Lang.Object.GetObject<Proxy> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Locations.Criteria p0 = Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Criteria = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getCriteria;
			static IntPtr id_setCriteria_Landroid_location_Criteria_;
			public virtual global::Android.Locations.Criteria Criteria {
				[Register ("getCriteria", "()Landroid/location/Criteria;", "GetGetCriteriaHandler")]
				get {
					if (id_getCriteria == IntPtr.Zero)
						id_getCriteria = JNIEnv.GetMethodID (class_ref, "getCriteria", "()Landroid/location/Criteria;");

					if (GetType () == ThresholdType)
						return Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (JNIEnv.CallObjectMethod  (Handle, id_getCriteria), JniHandleOwnership.TransferLocalRef);
					else
						return Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCriteria), JniHandleOwnership.TransferLocalRef);
				}
				[Register ("setCriteria", "(Landroid/location/Criteria;)V", "GetSetCriteria_Landroid_location_Criteria_Handler")]
				set {
					if (id_setCriteria_Landroid_location_Criteria_ == IntPtr.Zero)
						id_setCriteria_Landroid_location_Criteria_ = JNIEnv.GetMethodID (class_ref, "setCriteria", "(Landroid/location/Criteria;)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCriteria_Landroid_location_Criteria_, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setCriteria_Landroid_location_Criteria_, new JValue (value));
				}
			}

			static Delegate cb_getCurrentProvider;
#pragma warning disable 0169
			static Delegate GetGetCurrentProviderHandler ()
			{
				if (cb_getCurrentProvider == null)
					cb_getCurrentProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentProvider);
				return cb_getCurrentProvider;
			}

			static IntPtr n_GetCurrentProvider (IntPtr jnienv, IntPtr native__this)
			{
				Proxy __this = Java.Lang.Object.GetObject<Proxy> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CurrentProvider);
			}
#pragma warning restore 0169

			static IntPtr id_getCurrentProvider;
			public virtual string CurrentProvider {
				[Register ("getCurrentProvider", "()Ljava/lang/String;", "GetGetCurrentProviderHandler")]
				get {
					if (id_getCurrentProvider == IntPtr.Zero)
						id_getCurrentProvider = JNIEnv.GetMethodID (class_ref, "getCurrentProvider", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCurrentProvider), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCurrentProvider), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getInterfaceDescriptor;
#pragma warning disable 0169
			static Delegate GetGetInterfaceDescriptorHandler ()
			{
				if (cb_getInterfaceDescriptor == null)
					cb_getInterfaceDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterfaceDescriptor);
				return cb_getInterfaceDescriptor;
			}

			static IntPtr n_GetInterfaceDescriptor (IntPtr jnienv, IntPtr native__this)
			{
				Proxy __this = Java.Lang.Object.GetObject<Proxy> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual string InterfaceDescriptor {
				[Register ("getInterfaceDescriptor", "()Ljava/lang/String;", "GetGetInterfaceDescriptorHandler")]
				get {
					if (id_getInterfaceDescriptor == IntPtr.Zero)
						id_getInterfaceDescriptor = JNIEnv.GetMethodID (class_ref, "getInterfaceDescriptor", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInterfaceDescriptor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getInterfaceDescriptor), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getLocation;
#pragma warning disable 0169
			static Delegate GetGetLocationHandler ()
			{
				if (cb_getLocation == null)
					cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
				return cb_getLocation;
			}

			static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
			{
				Proxy __this = Java.Lang.Object.GetObject<Proxy> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Location);
			}
#pragma warning restore 0169

			static IntPtr id_getLocation;
			public virtual global::Android.Locations.Location Location {
				[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")]
				get {
					if (id_getLocation == IntPtr.Zero)
						id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");

					if (GetType () == ThresholdType)
						return Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
					else
						return Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocation), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_asBinder;
#pragma warning disable 0169
			static Delegate GetAsBinderHandler ()
			{
				if (cb_asBinder == null)
					cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
				return cb_asBinder;
			}

			static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
			{
				Proxy __this = Java.Lang.Object.GetObject<Proxy> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
			public virtual global::Android.OS.IBinder AsBinder ()
			{
				if (id_asBinder == IntPtr.Zero)
					id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_asBinder), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_createLocationEvent_Landroid_location_Location_II;
#pragma warning disable 0169
			static Delegate GetCreateLocationEvent_Landroid_location_Location_IIHandler ()
			{
				if (cb_createLocationEvent_Landroid_location_Location_II == null)
					cb_createLocationEvent_Landroid_location_Location_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_CreateLocationEvent_Landroid_location_Location_II);
				return cb_createLocationEvent_Landroid_location_Location_II;
			}

			static void n_CreateLocationEvent_Landroid_location_Location_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				Proxy __this = Java.Lang.Object.GetObject<Proxy> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Locations.Location p0 = Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.CreateLocationEvent (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_createLocationEvent_Landroid_location_Location_II;
			[Register ("createLocationEvent", "(Landroid/location/Location;II)V", "GetCreateLocationEvent_Landroid_location_Location_IIHandler")]
			public virtual void CreateLocationEvent (global::Android.Locations.Location p0, int p1, int p2)
			{
				if (id_createLocationEvent_Landroid_location_Location_II == IntPtr.Zero)
					id_createLocationEvent_Landroid_location_Location_II = JNIEnv.GetMethodID (class_ref, "createLocationEvent", "(Landroid/location/Location;II)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_createLocationEvent_Landroid_location_Location_II, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_createLocationEvent_Landroid_location_Location_II, new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_requestSingleLocationUpdate_Landroid_location_Criteria_;
#pragma warning disable 0169
			static Delegate GetRequestSingleLocationUpdate_Landroid_location_Criteria_Handler ()
			{
				if (cb_requestSingleLocationUpdate_Landroid_location_Criteria_ == null)
					cb_requestSingleLocationUpdate_Landroid_location_Criteria_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestSingleLocationUpdate_Landroid_location_Criteria_);
				return cb_requestSingleLocationUpdate_Landroid_location_Criteria_;
			}

			static void n_RequestSingleLocationUpdate_Landroid_location_Criteria_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Proxy __this = Java.Lang.Object.GetObject<Proxy> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Locations.Criteria p0 = Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.RequestSingleLocationUpdate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_requestSingleLocationUpdate_Landroid_location_Criteria_;
			[Register ("requestSingleLocationUpdate", "(Landroid/location/Criteria;)V", "GetRequestSingleLocationUpdate_Landroid_location_Criteria_Handler")]
			public virtual void RequestSingleLocationUpdate (global::Android.Locations.Criteria p0)
			{
				if (id_requestSingleLocationUpdate_Landroid_location_Criteria_ == IntPtr.Zero)
					id_requestSingleLocationUpdate_Landroid_location_Criteria_ = JNIEnv.GetMethodID (class_ref, "requestSingleLocationUpdate", "(Landroid/location/Criteria;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_requestSingleLocationUpdate_Landroid_location_Criteria_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_requestSingleLocationUpdate_Landroid_location_Criteria_, new JValue (p0));
			}

			static Delegate cb_resetProviders;
#pragma warning disable 0169
			static Delegate GetResetProvidersHandler ()
			{
				if (cb_resetProviders == null)
					cb_resetProviders = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetProviders);
				return cb_resetProviders;
			}

			static void n_ResetProviders (IntPtr jnienv, IntPtr native__this)
			{
				Proxy __this = Java.Lang.Object.GetObject<Proxy> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.ResetProviders ();
			}
#pragma warning restore 0169

			static IntPtr id_resetProviders;
			[Register ("resetProviders", "()V", "GetResetProvidersHandler")]
			public virtual void ResetProviders ()
			{
				if (id_resetProviders == IntPtr.Zero)
					id_resetProviders = JNIEnv.GetMethodID (class_ref, "resetProviders", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resetProviders);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_resetProviders);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/location/ILocationService$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationServiceStub); }
		}

		protected LocationServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public LocationServiceStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LocationServiceStub)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			LocationServiceStub __this = Java.Lang.Object.GetObject<LocationServiceStub> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");

			if (GetType () == ThresholdType)
				return Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
			else
				return Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_asInterface_Landroid_os_IBinder_;
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/urbanairship/location/ILocationService;", "")]
		public static global::Com.Urbanairship.Location.ILocationService AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/urbanairship/location/ILocationService;");
			global::Com.Urbanairship.Location.ILocationService __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Location.ILocationService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			LocationServiceStub __this = Java.Lang.Object.GetObject<LocationServiceStub> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual bool OnTransact (int p0, global::Android.OS.Parcel p1, global::Android.OS.Parcel p2, int p3)
		{
			if (id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			return __ret;
		}

		static Delegate cb_createLocationEvent_Landroid_location_Location_II;
#pragma warning disable 0169
		static Delegate GetCreateLocationEvent_Landroid_location_Location_IIHandler ()
		{
			if (cb_createLocationEvent_Landroid_location_Location_II == null)
				cb_createLocationEvent_Landroid_location_Location_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_CreateLocationEvent_Landroid_location_Location_II);
			return cb_createLocationEvent_Landroid_location_Location_II;
		}

		static void n_CreateLocationEvent_Landroid_location_Location_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			LocationServiceStub __this = Java.Lang.Object.GetObject<LocationServiceStub> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateLocationEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		[Register ("createLocationEvent", "(Landroid/location/Location;II)V", "GetCreateLocationEvent_Landroid_location_Location_IIHandler")]
		public abstract void CreateLocationEvent (global::Android.Locations.Location p0, int p1, int p2);

		static Delegate cb_requestSingleLocationUpdate_Landroid_location_Criteria_;
#pragma warning disable 0169
		static Delegate GetRequestSingleLocationUpdate_Landroid_location_Criteria_Handler ()
		{
			if (cb_requestSingleLocationUpdate_Landroid_location_Criteria_ == null)
				cb_requestSingleLocationUpdate_Landroid_location_Criteria_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestSingleLocationUpdate_Landroid_location_Criteria_);
			return cb_requestSingleLocationUpdate_Landroid_location_Criteria_;
		}

		static void n_RequestSingleLocationUpdate_Landroid_location_Criteria_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			LocationServiceStub __this = Java.Lang.Object.GetObject<LocationServiceStub> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Criteria p0 = Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestSingleLocationUpdate (p0);
		}
#pragma warning restore 0169

		[Register ("requestSingleLocationUpdate", "(Landroid/location/Criteria;)V", "GetRequestSingleLocationUpdate_Landroid_location_Criteria_Handler")]
		public abstract void RequestSingleLocationUpdate (global::Android.Locations.Criteria p0);

		static Delegate cb_resetProviders;
#pragma warning disable 0169
		static Delegate GetResetProvidersHandler ()
		{
			if (cb_resetProviders == null)
				cb_resetProviders = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetProviders);
			return cb_resetProviders;
		}

		static void n_ResetProviders (IntPtr jnienv, IntPtr native__this)
		{
			LocationServiceStub __this = Java.Lang.Object.GetObject<LocationServiceStub> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetProviders ();
		}
#pragma warning restore 0169

		[Register ("resetProviders", "()V", "GetResetProvidersHandler")]
		public abstract void ResetProviders ();

		static Delegate cb_getBestProvider;
#pragma warning disable 0169
		static Delegate GetGetBestProviderHandler ()
		{
			if (cb_getBestProvider == null)
				cb_getBestProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBestProvider);
			return cb_getBestProvider;
		}

		static IntPtr n_GetBestProvider (IntPtr jnienv, IntPtr native__this)
		{
			LocationServiceStub __this = Java.Lang.Object.GetObject<LocationServiceStub> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BestProvider);
		}
#pragma warning restore 0169

		public abstract string BestProvider { [Register ("getBestProvider", "()Ljava/lang/String;", "GetGetBestProviderHandler")] get; }

		static Delegate cb_getCriteria;
#pragma warning disable 0169
		static Delegate GetGetCriteriaHandler ()
		{
			if (cb_getCriteria == null)
				cb_getCriteria = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCriteria);
			return cb_getCriteria;
		}

		static IntPtr n_GetCriteria (IntPtr jnienv, IntPtr native__this)
		{
			LocationServiceStub __this = Java.Lang.Object.GetObject<LocationServiceStub> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Criteria);
		}
#pragma warning restore 0169

		static Delegate cb_setCriteria_Landroid_location_Criteria_;
#pragma warning disable 0169
		static Delegate GetSetCriteria_Landroid_location_Criteria_Handler ()
		{
			if (cb_setCriteria_Landroid_location_Criteria_ == null)
				cb_setCriteria_Landroid_location_Criteria_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCriteria_Landroid_location_Criteria_);
			return cb_setCriteria_Landroid_location_Criteria_;
		}

		static void n_SetCriteria_Landroid_location_Criteria_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			LocationServiceStub __this = Java.Lang.Object.GetObject<LocationServiceStub> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Criteria p0 = Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Criteria = p0;
		}
#pragma warning restore 0169

		public abstract global::Android.Locations.Criteria Criteria { [Register ("getCriteria", "()Landroid/location/Criteria;", "GetGetCriteriaHandler")] get; [Register ("setCriteria", "(Landroid/location/Criteria;)V", "GetSetCriteria_Landroid_location_Criteria_Handler")] set; }

		static Delegate cb_getCurrentProvider;
#pragma warning disable 0169
		static Delegate GetGetCurrentProviderHandler ()
		{
			if (cb_getCurrentProvider == null)
				cb_getCurrentProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentProvider);
			return cb_getCurrentProvider;
		}

		static IntPtr n_GetCurrentProvider (IntPtr jnienv, IntPtr native__this)
		{
			LocationServiceStub __this = Java.Lang.Object.GetObject<LocationServiceStub> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrentProvider);
		}
#pragma warning restore 0169

		public abstract string CurrentProvider { [Register ("getCurrentProvider", "()Ljava/lang/String;", "GetGetCurrentProviderHandler")] get; }

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			LocationServiceStub __this = Java.Lang.Object.GetObject<LocationServiceStub> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		public abstract global::Android.Locations.Location Location { [Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")] get; }

	}

	[global::Android.Runtime.Register ("com/urbanairship/location/ILocationService$Stub", DoNotGenerateAcw=true)]
	internal partial class LocationServiceStubInvoker : LocationServiceStub {

		public LocationServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationServiceStubInvoker); }
		}

		static IntPtr id_getBestProvider;
		public override string BestProvider {
			[Register ("getBestProvider", "()Ljava/lang/String;", "GetGetBestProviderHandler")]
			get {
				if (id_getBestProvider == IntPtr.Zero)
					id_getBestProvider = JNIEnv.GetMethodID (class_ref, "getBestProvider", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBestProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getCriteria;
		static IntPtr id_setCriteria_Landroid_location_Criteria_;
		public override global::Android.Locations.Criteria Criteria {
			[Register ("getCriteria", "()Landroid/location/Criteria;", "GetGetCriteriaHandler")]
			get {
				if (id_getCriteria == IntPtr.Zero)
					id_getCriteria = JNIEnv.GetMethodID (class_ref, "getCriteria", "()Landroid/location/Criteria;");
				return Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (JNIEnv.CallObjectMethod  (Handle, id_getCriteria), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setCriteria", "(Landroid/location/Criteria;)V", "GetSetCriteria_Landroid_location_Criteria_Handler")]
			set {
				if (id_setCriteria_Landroid_location_Criteria_ == IntPtr.Zero)
					id_setCriteria_Landroid_location_Criteria_ = JNIEnv.GetMethodID (class_ref, "setCriteria", "(Landroid/location/Criteria;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setCriteria_Landroid_location_Criteria_, new JValue (value));
			}
		}

		static IntPtr id_getCurrentProvider;
		public override string CurrentProvider {
			[Register ("getCurrentProvider", "()Ljava/lang/String;", "GetGetCurrentProviderHandler")]
			get {
				if (id_getCurrentProvider == IntPtr.Zero)
					id_getCurrentProvider = JNIEnv.GetMethodID (class_ref, "getCurrentProvider", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCurrentProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getLocation;
		public override global::Android.Locations.Location Location {
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");
				return Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_createLocationEvent_Landroid_location_Location_II;
		[Register ("createLocationEvent", "(Landroid/location/Location;II)V", "GetCreateLocationEvent_Landroid_location_Location_IIHandler")]
		public override void CreateLocationEvent (global::Android.Locations.Location p0, int p1, int p2)
		{
			if (id_createLocationEvent_Landroid_location_Location_II == IntPtr.Zero)
				id_createLocationEvent_Landroid_location_Location_II = JNIEnv.GetMethodID (class_ref, "createLocationEvent", "(Landroid/location/Location;II)V");
			JNIEnv.CallVoidMethod  (Handle, id_createLocationEvent_Landroid_location_Location_II, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_requestSingleLocationUpdate_Landroid_location_Criteria_;
		[Register ("requestSingleLocationUpdate", "(Landroid/location/Criteria;)V", "GetRequestSingleLocationUpdate_Landroid_location_Criteria_Handler")]
		public override void RequestSingleLocationUpdate (global::Android.Locations.Criteria p0)
		{
			if (id_requestSingleLocationUpdate_Landroid_location_Criteria_ == IntPtr.Zero)
				id_requestSingleLocationUpdate_Landroid_location_Criteria_ = JNIEnv.GetMethodID (class_ref, "requestSingleLocationUpdate", "(Landroid/location/Criteria;)V");
			JNIEnv.CallVoidMethod  (Handle, id_requestSingleLocationUpdate_Landroid_location_Criteria_, new JValue (p0));
		}

		static IntPtr id_resetProviders;
		[Register ("resetProviders", "()V", "GetResetProvidersHandler")]
		public override void ResetProviders ()
		{
			if (id_resetProviders == IntPtr.Zero)
				id_resetProviders = JNIEnv.GetMethodID (class_ref, "resetProviders", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_resetProviders);
		}

	}


	[Register ("com/urbanairship/location/ILocationService", "", "Com.Urbanairship.Location.ILocationServiceInvoker")]
	public partial interface ILocationService : global::Android.OS.IInterface {

		string BestProvider {
			[Register ("getBestProvider", "()Ljava/lang/String;", "GetGetBestProviderHandler:Com.Urbanairship.Location.ILocationServiceInvoker, AndroidSDK.Binding")] get;
		}

		global::Android.Locations.Criteria Criteria {
			[Register ("getCriteria", "()Landroid/location/Criteria;", "GetGetCriteriaHandler:Com.Urbanairship.Location.ILocationServiceInvoker, AndroidSDK.Binding")] get;
			[Register ("setCriteria", "(Landroid/location/Criteria;)V", "GetSetCriteria_Landroid_location_Criteria_Handler:Com.Urbanairship.Location.ILocationServiceInvoker, AndroidSDK.Binding")] set;
		}

		string CurrentProvider {
			[Register ("getCurrentProvider", "()Ljava/lang/String;", "GetGetCurrentProviderHandler:Com.Urbanairship.Location.ILocationServiceInvoker, AndroidSDK.Binding")] get;
		}

		global::Android.Locations.Location Location {
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler:Com.Urbanairship.Location.ILocationServiceInvoker, AndroidSDK.Binding")] get;
		}

		[Register ("createLocationEvent", "(Landroid/location/Location;II)V", "GetCreateLocationEvent_Landroid_location_Location_IIHandler:Com.Urbanairship.Location.ILocationServiceInvoker, AndroidSDK.Binding")]
		void CreateLocationEvent (global::Android.Locations.Location p0, int p1, int p2);

		[Register ("requestSingleLocationUpdate", "(Landroid/location/Criteria;)V", "GetRequestSingleLocationUpdate_Landroid_location_Criteria_Handler:Com.Urbanairship.Location.ILocationServiceInvoker, AndroidSDK.Binding")]
		void RequestSingleLocationUpdate (global::Android.Locations.Criteria p0);

		[Register ("resetProviders", "()V", "GetResetProvidersHandler:Com.Urbanairship.Location.ILocationServiceInvoker, AndroidSDK.Binding")]
		void ResetProviders ();

	}

	[global::Android.Runtime.Register ("com/urbanairship/location/ILocationService", DoNotGenerateAcw=true)]
	internal class ILocationServiceInvoker : Java.Lang.Object, ILocationService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/urbanairship/location/ILocationService");
		IntPtr class_ref;

		public static ILocationService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILocationService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.urbanairship.location.ILocationService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILocationServiceInvoker); }
		}

		static Delegate cb_getBestProvider;
#pragma warning disable 0169
		static Delegate GetGetBestProviderHandler ()
		{
			if (cb_getBestProvider == null)
				cb_getBestProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBestProvider);
			return cb_getBestProvider;
		}

		static IntPtr n_GetBestProvider (IntPtr jnienv, IntPtr native__this)
		{
			ILocationService __this = Java.Lang.Object.GetObject<ILocationService> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BestProvider);
		}
#pragma warning restore 0169

		IntPtr id_getBestProvider;
		public string BestProvider {
			get {
				if (id_getBestProvider == IntPtr.Zero)
					id_getBestProvider = JNIEnv.GetMethodID (class_ref, "getBestProvider", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getBestProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCriteria;
#pragma warning disable 0169
		static Delegate GetGetCriteriaHandler ()
		{
			if (cb_getCriteria == null)
				cb_getCriteria = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCriteria);
			return cb_getCriteria;
		}

		static IntPtr n_GetCriteria (IntPtr jnienv, IntPtr native__this)
		{
			ILocationService __this = Java.Lang.Object.GetObject<ILocationService> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Criteria);
		}
#pragma warning restore 0169

		static Delegate cb_setCriteria_Landroid_location_Criteria_;
#pragma warning disable 0169
		static Delegate GetSetCriteria_Landroid_location_Criteria_Handler ()
		{
			if (cb_setCriteria_Landroid_location_Criteria_ == null)
				cb_setCriteria_Landroid_location_Criteria_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCriteria_Landroid_location_Criteria_);
			return cb_setCriteria_Landroid_location_Criteria_;
		}

		static void n_SetCriteria_Landroid_location_Criteria_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ILocationService __this = Java.Lang.Object.GetObject<ILocationService> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Criteria p0 = Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Criteria = p0;
		}
#pragma warning restore 0169

		IntPtr id_getCriteria;
		IntPtr id_setCriteria_Landroid_location_Criteria_;
		public global::Android.Locations.Criteria Criteria {
			get {
				if (id_getCriteria == IntPtr.Zero)
					id_getCriteria = JNIEnv.GetMethodID (class_ref, "getCriteria", "()Landroid/location/Criteria;");
				return Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (JNIEnv.CallObjectMethod (Handle, id_getCriteria), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setCriteria_Landroid_location_Criteria_ == IntPtr.Zero)
					id_setCriteria_Landroid_location_Criteria_ = JNIEnv.GetMethodID (class_ref, "setCriteria", "(Landroid/location/Criteria;)V");
				JNIEnv.CallVoidMethod (Handle, id_setCriteria_Landroid_location_Criteria_, new JValue (value));
			}
		}

		static Delegate cb_getCurrentProvider;
#pragma warning disable 0169
		static Delegate GetGetCurrentProviderHandler ()
		{
			if (cb_getCurrentProvider == null)
				cb_getCurrentProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentProvider);
			return cb_getCurrentProvider;
		}

		static IntPtr n_GetCurrentProvider (IntPtr jnienv, IntPtr native__this)
		{
			ILocationService __this = Java.Lang.Object.GetObject<ILocationService> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrentProvider);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentProvider;
		public string CurrentProvider {
			get {
				if (id_getCurrentProvider == IntPtr.Zero)
					id_getCurrentProvider = JNIEnv.GetMethodID (class_ref, "getCurrentProvider", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getCurrentProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			ILocationService __this = Java.Lang.Object.GetObject<ILocationService> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		IntPtr id_getLocation;
		public global::Android.Locations.Location Location {
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");
				return Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_createLocationEvent_Landroid_location_Location_II;
#pragma warning disable 0169
		static Delegate GetCreateLocationEvent_Landroid_location_Location_IIHandler ()
		{
			if (cb_createLocationEvent_Landroid_location_Location_II == null)
				cb_createLocationEvent_Landroid_location_Location_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_CreateLocationEvent_Landroid_location_Location_II);
			return cb_createLocationEvent_Landroid_location_Location_II;
		}

		static void n_CreateLocationEvent_Landroid_location_Location_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			ILocationService __this = Java.Lang.Object.GetObject<ILocationService> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateLocationEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_createLocationEvent_Landroid_location_Location_II;
		public void CreateLocationEvent (global::Android.Locations.Location p0, int p1, int p2)
		{
			if (id_createLocationEvent_Landroid_location_Location_II == IntPtr.Zero)
				id_createLocationEvent_Landroid_location_Location_II = JNIEnv.GetMethodID (class_ref, "createLocationEvent", "(Landroid/location/Location;II)V");
			JNIEnv.CallVoidMethod (Handle, id_createLocationEvent_Landroid_location_Location_II, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_requestSingleLocationUpdate_Landroid_location_Criteria_;
#pragma warning disable 0169
		static Delegate GetRequestSingleLocationUpdate_Landroid_location_Criteria_Handler ()
		{
			if (cb_requestSingleLocationUpdate_Landroid_location_Criteria_ == null)
				cb_requestSingleLocationUpdate_Landroid_location_Criteria_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestSingleLocationUpdate_Landroid_location_Criteria_);
			return cb_requestSingleLocationUpdate_Landroid_location_Criteria_;
		}

		static void n_RequestSingleLocationUpdate_Landroid_location_Criteria_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ILocationService __this = Java.Lang.Object.GetObject<ILocationService> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Criteria p0 = Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestSingleLocationUpdate (p0);
		}
#pragma warning restore 0169

		IntPtr id_requestSingleLocationUpdate_Landroid_location_Criteria_;
		public void RequestSingleLocationUpdate (global::Android.Locations.Criteria p0)
		{
			if (id_requestSingleLocationUpdate_Landroid_location_Criteria_ == IntPtr.Zero)
				id_requestSingleLocationUpdate_Landroid_location_Criteria_ = JNIEnv.GetMethodID (class_ref, "requestSingleLocationUpdate", "(Landroid/location/Criteria;)V");
			JNIEnv.CallVoidMethod (Handle, id_requestSingleLocationUpdate_Landroid_location_Criteria_, new JValue (p0));
		}

		static Delegate cb_resetProviders;
#pragma warning disable 0169
		static Delegate GetResetProvidersHandler ()
		{
			if (cb_resetProviders == null)
				cb_resetProviders = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetProviders);
			return cb_resetProviders;
		}

		static void n_ResetProviders (IntPtr jnienv, IntPtr native__this)
		{
			ILocationService __this = Java.Lang.Object.GetObject<ILocationService> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetProviders ();
		}
#pragma warning restore 0169

		IntPtr id_resetProviders;
		public void ResetProviders ()
		{
			if (id_resetProviders == IntPtr.Zero)
				id_resetProviders = JNIEnv.GetMethodID (class_ref, "resetProviders", "()V");
			JNIEnv.CallVoidMethod (Handle, id_resetProviders);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			ILocationService __this = Java.Lang.Object.GetObject<ILocationService> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
