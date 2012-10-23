using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Richpush {

	[global::Android.Runtime.Register ("com/urbanairship/richpush/RichPushInbox", DoNotGenerateAcw=true)]
	public partial class RichPushInbox : global::Com.Urbanairship.Util.UACursorWrapper {

		[global::Android.Runtime.Register ("com/urbanairship/richpush/RichPushInbox$RichPushDatabaseChangeReceiver", DoNotGenerateAcw=true)]
		public partial class RichPushDatabaseChangeReceiver : global::Android.Content.BroadcastReceiver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/richpush/RichPushInbox$RichPushDatabaseChangeReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RichPushDatabaseChangeReceiver); }
			}

			protected RichPushDatabaseChangeReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
			{
				if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
					cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
				return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			}

			static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				RichPushDatabaseChangeReceiver __this = Java.Lang.Object.GetObject<RichPushDatabaseChangeReceiver> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReceive (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
			public override void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/richpush/RichPushInbox", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RichPushInbox); }
		}

		protected RichPushInbox (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_deleteMessages_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetDeleteMessages_Ljava_util_Set_Handler ()
		{
			if (cb_deleteMessages_Ljava_util_Set_ == null)
				cb_deleteMessages_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DeleteMessages_Ljava_util_Set_);
			return cb_deleteMessages_Ljava_util_Set_;
		}

		static int n_DeleteMessages_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RichPushInbox __this = Java.Lang.Object.GetObject<RichPushInbox> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DeleteMessages (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessages_Ljava_util_Set_;
		[Register ("deleteMessages", "(Ljava/util/Set;)I", "GetDeleteMessages_Ljava_util_Set_Handler")]
		public virtual int DeleteMessages (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_deleteMessages_Ljava_util_Set_ == IntPtr.Zero)
				id_deleteMessages_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "deleteMessages", "(Ljava/util/Set;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_deleteMessages_Ljava_util_Set_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_deleteMessages_Ljava_util_Set_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_getMessage_Ljava_lang_String_ == null)
				cb_getMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessage_Ljava_lang_String_);
			return cb_getMessage_Ljava_lang_String_;
		}

		static IntPtr n_GetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RichPushInbox __this = Java.Lang.Object.GetObject<RichPushInbox> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage_Ljava_lang_String_;
		[Register ("getMessage", "(Ljava/lang/String;)Lcom/urbanairship/richpush/RichPushMessage;", "GetGetMessage_Ljava_lang_String_Handler")]
		public virtual global::Com.Urbanairship.Richpush.RichPushMessage GetMessage (string p0)
		{
			if (id_getMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_getMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMessage", "(Ljava/lang/String;)Lcom/urbanairship/richpush/RichPushMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Urbanairship.Richpush.RichPushMessage __ret;
			if (GetType () == ThresholdType)
				__ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushMessage> (JNIEnv.CallObjectMethod  (Handle, id_getMessage_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushMessage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMessage_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getMessageAtPosition_I;
#pragma warning disable 0169
		static Delegate GetGetMessageAtPosition_IHandler ()
		{
			if (cb_getMessageAtPosition_I == null)
				cb_getMessageAtPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMessageAtPosition_I);
			return cb_getMessageAtPosition_I;
		}

		static IntPtr n_GetMessageAtPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			RichPushInbox __this = Java.Lang.Object.GetObject<RichPushInbox> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMessageAtPosition (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getMessageAtPosition_I;
		[Register ("getMessageAtPosition", "(I)Lcom/urbanairship/richpush/RichPushMessage;", "GetGetMessageAtPosition_IHandler")]
		public virtual global::Com.Urbanairship.Richpush.RichPushMessage GetMessageAtPosition (int p0)
		{
			if (id_getMessageAtPosition_I == IntPtr.Zero)
				id_getMessageAtPosition_I = JNIEnv.GetMethodID (class_ref, "getMessageAtPosition", "(I)Lcom/urbanairship/richpush/RichPushMessage;");

			if (GetType () == ThresholdType)
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushMessage> (JNIEnv.CallObjectMethod  (Handle, id_getMessageAtPosition_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushMessage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMessageAtPosition_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getMessageIdAtPosition_I;
#pragma warning disable 0169
		static Delegate GetGetMessageIdAtPosition_IHandler ()
		{
			if (cb_getMessageIdAtPosition_I == null)
				cb_getMessageIdAtPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMessageIdAtPosition_I);
			return cb_getMessageIdAtPosition_I;
		}

		static IntPtr n_GetMessageIdAtPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			RichPushInbox __this = Java.Lang.Object.GetObject<RichPushInbox> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetMessageIdAtPosition (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getMessageIdAtPosition_I;
		[Register ("getMessageIdAtPosition", "(I)Ljava/lang/String;", "GetGetMessageIdAtPosition_IHandler")]
		public virtual string GetMessageIdAtPosition (int p0)
		{
			if (id_getMessageIdAtPosition_I == IntPtr.Zero)
				id_getMessageIdAtPosition_I = JNIEnv.GetMethodID (class_ref, "getMessageIdAtPosition", "(I)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageIdAtPosition_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMessageIdAtPosition_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getMessagePosition_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMessagePosition_Ljava_lang_String_Handler ()
		{
			if (cb_getMessagePosition_Ljava_lang_String_ == null)
				cb_getMessagePosition_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetMessagePosition_Ljava_lang_String_);
			return cb_getMessagePosition_Ljava_lang_String_;
		}

		static int n_GetMessagePosition_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RichPushInbox __this = Java.Lang.Object.GetObject<RichPushInbox> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetMessagePosition (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessagePosition_Ljava_lang_String_;
		[Register ("getMessagePosition", "(Ljava/lang/String;)I", "GetGetMessagePosition_Ljava_lang_String_Handler")]
		public virtual int GetMessagePosition (string p0)
		{
			if (id_getMessagePosition_Ljava_lang_String_ == IntPtr.Zero)
				id_getMessagePosition_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMessagePosition", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getMessagePosition_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getMessagePosition_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_markMessagesRead_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetMarkMessagesRead_Ljava_util_Set_Handler ()
		{
			if (cb_markMessagesRead_Ljava_util_Set_ == null)
				cb_markMessagesRead_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_MarkMessagesRead_Ljava_util_Set_);
			return cb_markMessagesRead_Ljava_util_Set_;
		}

		static int n_MarkMessagesRead_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RichPushInbox __this = Java.Lang.Object.GetObject<RichPushInbox> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.MarkMessagesRead (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_markMessagesRead_Ljava_util_Set_;
		[Register ("markMessagesRead", "(Ljava/util/Set;)I", "GetMarkMessagesRead_Ljava_util_Set_Handler")]
		public virtual int MarkMessagesRead (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_markMessagesRead_Ljava_util_Set_ == IntPtr.Zero)
				id_markMessagesRead_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "markMessagesRead", "(Ljava/util/Set;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_markMessagesRead_Ljava_util_Set_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_markMessagesRead_Ljava_util_Set_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_markMessagesUnread_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetMarkMessagesUnread_Ljava_util_Set_Handler ()
		{
			if (cb_markMessagesUnread_Ljava_util_Set_ == null)
				cb_markMessagesUnread_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_MarkMessagesUnread_Ljava_util_Set_);
			return cb_markMessagesUnread_Ljava_util_Set_;
		}

		static int n_MarkMessagesUnread_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RichPushInbox __this = Java.Lang.Object.GetObject<RichPushInbox> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.MarkMessagesUnread (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_markMessagesUnread_Ljava_util_Set_;
		[Register ("markMessagesUnread", "(Ljava/util/Set;)I", "GetMarkMessagesUnread_Ljava_util_Set_Handler")]
		public virtual int MarkMessagesUnread (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_markMessagesUnread_Ljava_util_Set_ == IntPtr.Zero)
				id_markMessagesUnread_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "markMessagesUnread", "(Ljava/util/Set;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_markMessagesUnread_Ljava_util_Set_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_markMessagesUnread_Ljava_util_Set_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_refresh;
#pragma warning disable 0169
		static Delegate GetRefreshHandler ()
		{
			if (cb_refresh == null)
				cb_refresh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Refresh);
			return cb_refresh;
		}

		static IntPtr n_Refresh (IntPtr jnienv, IntPtr native__this)
		{
			RichPushInbox __this = Java.Lang.Object.GetObject<RichPushInbox> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Refresh ());
		}
#pragma warning restore 0169

		static IntPtr id_refresh;
		[Register ("refresh", "()Landroid/database/Cursor;", "GetRefreshHandler")]
		public virtual global::Android.Database.ICursor Refresh ()
		{
			if (id_refresh == IntPtr.Zero)
				id_refresh = JNIEnv.GetMethodID (class_ref, "refresh", "()Landroid/database/Cursor;");

			if (GetType () == ThresholdType)
				return Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod  (Handle, id_refresh), JniHandleOwnership.TransferLocalRef);
			else
				return Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_refresh), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_shared;
		[Register ("shared", "()Lcom/urbanairship/richpush/RichPushInbox;", "")]
		public static global::Com.Urbanairship.Richpush.RichPushInbox Shared ()
		{
			if (id_shared == IntPtr.Zero)
				id_shared = JNIEnv.GetStaticMethodID (class_ref, "shared", "()Lcom/urbanairship/richpush/RichPushInbox;");
			return Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushInbox> (JNIEnv.CallStaticObjectMethod  (class_ref, id_shared), JniHandleOwnership.TransferLocalRef);
		}

	}
}
