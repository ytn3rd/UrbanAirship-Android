using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Util {

	[global::Android.Runtime.Register ("com/urbanairship/util/NotificationIDGenerator", DoNotGenerateAcw=true)]
	public partial class NotificationIDGenerator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/util/NotificationIDGenerator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotificationIDGenerator); }
		}

		protected NotificationIDGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public NotificationIDGenerator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NotificationIDGenerator)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getRange;
		static IntPtr id_setRange_I;
		public static int Range {
			[Register ("getRange", "()I", "GetGetRangeHandler")]
			get {
				if (id_getRange == IntPtr.Zero)
					id_getRange = JNIEnv.GetStaticMethodID (class_ref, "getRange", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getRange);
			}
			[Register ("setRange", "(I)V", "GetSetRange_IHandler")]
			set {
				if (id_setRange_I == IntPtr.Zero)
					id_setRange_I = JNIEnv.GetStaticMethodID (class_ref, "setRange", "(I)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setRange_I, new JValue (value));
			}
		}

		static IntPtr id_getStart;
		static IntPtr id_setStart_I;
		public static int Start {
			[Register ("getStart", "()I", "GetGetStartHandler")]
			get {
				if (id_getStart == IntPtr.Zero)
					id_getStart = JNIEnv.GetStaticMethodID (class_ref, "getStart", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getStart);
			}
			[Register ("setStart", "(I)V", "GetSetStart_IHandler")]
			set {
				if (id_setStart_I == IntPtr.Zero)
					id_setStart_I = JNIEnv.GetStaticMethodID (class_ref, "setStart", "(I)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setStart_I, new JValue (value));
			}
		}

		static IntPtr id_nextID;
		[Register ("nextID", "()I", "")]
		public static int NextID ()
		{
			if (id_nextID == IntPtr.Zero)
				id_nextID = JNIEnv.GetStaticMethodID (class_ref, "nextID", "()I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_nextID);
		}

	}
}
