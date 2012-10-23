using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push.Embedded {

	[global::Android.Runtime.Register ("com/urbanairship/push/embedded/Config", DoNotGenerateAcw=true)]
	public partial class Config : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/push/embedded/Config$BoxOffice", DoNotGenerateAcw=true)]
		public partial class BoxOffice : global::Java.Lang.Object {


			[Register ("MAX_HOLDING_PATTERN")]
			public const long MaxHoldingPattern = (long) 604800L;

			static IntPtr url_jfieldId;

			[Register ("url")]
			public static string Url {
				get {
					if (url_jfieldId == IntPtr.Zero)
						url_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "url", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, url_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (url_jfieldId == IntPtr.Zero)
						url_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "url", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetStaticField (class_ref, url_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/embedded/Config$BoxOffice", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BoxOffice); }
			}

			protected BoxOffice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			[Register (".ctor", "()V", "")]
			public BoxOffice () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (BoxOffice)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/push/embedded/Config$Helium", DoNotGenerateAcw=true)]
		public partial class Helium : global::Java.Lang.Object {


			[Register ("MAX_HELIUM_CACHE_TTL_MS")]
			public const long MaxHeliumCacheTtlMs = (long) 86400000L;

			[Register ("backoffFactor")]
			public const long BackoffFactor = (long) 2L;

			static IntPtr heliumCacheTTL_jfieldId;

			[Register ("heliumCacheTTL")]
			public static long HeliumCacheTTL {
				get {
					if (heliumCacheTTL_jfieldId == IntPtr.Zero)
						heliumCacheTTL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "heliumCacheTTL", "J");
					return JNIEnv.GetStaticLongField (class_ref, heliumCacheTTL_jfieldId);
				}
				set {
					if (heliumCacheTTL_jfieldId == IntPtr.Zero)
						heliumCacheTTL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "heliumCacheTTL", "J");
					JNIEnv.SetStaticField (class_ref, heliumCacheTTL_jfieldId, value);
				}
			}

			[Register ("initialRetryInterval")]
			public const long InitialRetryInterval = (long) 10000L;

			[Register ("maxFailureCount")]
			public const int MaxFailureCount = (int) 3;

			[Register ("maxRetryInterval")]
			public const long MaxRetryInterval = (long) 640000L;

			static IntPtr max_keepalive_interval_jfieldId;

			[Register ("max_keepalive_interval")]
			public static long MaxKeepaliveInterval {
				get {
					if (max_keepalive_interval_jfieldId == IntPtr.Zero)
						max_keepalive_interval_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "max_keepalive_interval", "J");
					return JNIEnv.GetStaticLongField (class_ref, max_keepalive_interval_jfieldId);
				}
				set {
					if (max_keepalive_interval_jfieldId == IntPtr.Zero)
						max_keepalive_interval_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "max_keepalive_interval", "J");
					JNIEnv.SetStaticField (class_ref, max_keepalive_interval_jfieldId, value);
				}
			}

			static IntPtr minHeliumCacheTTL_jfieldId;

			[Register ("minHeliumCacheTTL")]
			public static long MinHeliumCacheTTL {
				get {
					if (minHeliumCacheTTL_jfieldId == IntPtr.Zero)
						minHeliumCacheTTL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "minHeliumCacheTTL", "J");
					return JNIEnv.GetStaticLongField (class_ref, minHeliumCacheTTL_jfieldId);
				}
				set {
					if (minHeliumCacheTTL_jfieldId == IntPtr.Zero)
						minHeliumCacheTTL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "minHeliumCacheTTL", "J");
					JNIEnv.SetStaticField (class_ref, minHeliumCacheTTL_jfieldId, value);
				}
			}

			[Register ("postFirstRunDelay")]
			public const long PostFirstRunDelay = (long) 3000L;

			[Register ("postLookupDelay")]
			public const long PostLookupDelay = (long) 3000L;

			[Register ("readSleep")]
			public const long ReadSleep = (long) 100L;

			[Register ("retryResetThreshold")]
			public const long RetryResetThreshold = (long) 180000L;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/embedded/Config$Helium", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Helium); }
			}

			protected Helium (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			[Register (".ctor", "()V", "")]
			public Helium () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Helium)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/embedded/Config", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Config); }
		}

		protected Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public Config () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Config)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

	}
}
