using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Richpush {

	[global::Android.Runtime.Register ("com/urbanairship/richpush/RichPushMessage", DoNotGenerateAcw=true)]
	public partial class RichPushMessage : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/richpush/RichPushMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RichPushMessage); }
		}

		protected RichPushMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDatabaseId;
#pragma warning disable 0169
		static Delegate GetGetDatabaseIdHandler ()
		{
			if (cb_getDatabaseId == null)
				cb_getDatabaseId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDatabaseId);
			return cb_getDatabaseId;
		}

		static int n_GetDatabaseId (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DatabaseId;
		}
#pragma warning restore 0169

		static IntPtr id_getDatabaseId;
		public virtual int DatabaseId {
			[Register ("getDatabaseId", "()I", "GetGetDatabaseIdHandler")]
			get {
				if (id_getDatabaseId == IntPtr.Zero)
					id_getDatabaseId = JNIEnv.GetMethodID (class_ref, "getDatabaseId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDatabaseId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getDatabaseId);
			}
		}

		static Delegate cb_getExtras;
#pragma warning disable 0169
		static Delegate GetGetExtrasHandler ()
		{
			if (cb_getExtras == null)
				cb_getExtras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtras);
			return cb_getExtras;
		}

		static IntPtr n_GetExtras (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Extras);
		}
#pragma warning restore 0169

		static IntPtr id_getExtras;
		public virtual global::Android.OS.Bundle Extras {
			[Register ("getExtras", "()Landroid/os/Bundle;", "GetGetExtrasHandler")]
			get {
				if (id_getExtras == IntPtr.Zero)
					id_getExtras = JNIEnv.GetMethodID (class_ref, "getExtras", "()Landroid/os/Bundle;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getExtras), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getExtras), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isRead;
#pragma warning disable 0169
		static Delegate GetIsReadHandler ()
		{
			if (cb_isRead == null)
				cb_isRead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRead);
			return cb_isRead;
		}

		static bool n_IsRead (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRead;
		}
#pragma warning restore 0169

		static IntPtr id_isRead;
		public virtual bool IsRead {
			[Register ("isRead", "()Z", "GetIsReadHandler")]
			get {
				if (id_isRead == IntPtr.Zero)
					id_isRead = JNIEnv.GetMethodID (class_ref, "isRead", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isRead);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isRead);
			}
		}

		static Delegate cb_getMessageBodyUrl;
#pragma warning disable 0169
		static Delegate GetGetMessageBodyUrlHandler ()
		{
			if (cb_getMessageBodyUrl == null)
				cb_getMessageBodyUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageBodyUrl);
			return cb_getMessageBodyUrl;
		}

		static IntPtr n_GetMessageBodyUrl (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageBodyUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageBodyUrl;
		public virtual string MessageBodyUrl {
			[Register ("getMessageBodyUrl", "()Ljava/lang/String;", "GetGetMessageBodyUrlHandler")]
			get {
				if (id_getMessageBodyUrl == IntPtr.Zero)
					id_getMessageBodyUrl = JNIEnv.GetMethodID (class_ref, "getMessageBodyUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageBodyUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMessageBodyUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessageId;
#pragma warning disable 0169
		static Delegate GetGetMessageIdHandler ()
		{
			if (cb_getMessageId == null)
				cb_getMessageId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageId);
			return cb_getMessageId;
		}

		static IntPtr n_GetMessageId (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageId);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageId;
		public virtual string MessageId {
			[Register ("getMessageId", "()Ljava/lang/String;", "GetGetMessageIdHandler")]
			get {
				if (id_getMessageId == IntPtr.Zero)
					id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMessageId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessageReadUrl;
#pragma warning disable 0169
		static Delegate GetGetMessageReadUrlHandler ()
		{
			if (cb_getMessageReadUrl == null)
				cb_getMessageReadUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageReadUrl);
			return cb_getMessageReadUrl;
		}

		static IntPtr n_GetMessageReadUrl (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageReadUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageReadUrl;
		public virtual string MessageReadUrl {
			[Register ("getMessageReadUrl", "()Ljava/lang/String;", "GetGetMessageReadUrlHandler")]
			get {
				if (id_getMessageReadUrl == IntPtr.Zero)
					id_getMessageReadUrl = JNIEnv.GetMethodID (class_ref, "getMessageReadUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageReadUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMessageReadUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessageUrl;
#pragma warning disable 0169
		static Delegate GetGetMessageUrlHandler ()
		{
			if (cb_getMessageUrl == null)
				cb_getMessageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageUrl);
			return cb_getMessageUrl;
		}

		static IntPtr n_GetMessageUrl (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageUrl;
		public virtual string MessageUrl {
			[Register ("getMessageUrl", "()Ljava/lang/String;", "GetGetMessageUrlHandler")]
			get {
				if (id_getMessageUrl == IntPtr.Zero)
					id_getMessageUrl = JNIEnv.GetMethodID (class_ref, "getMessageUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMessageUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSentDate;
#pragma warning disable 0169
		static Delegate GetGetSentDateHandler ()
		{
			if (cb_getSentDate == null)
				cb_getSentDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSentDate);
			return cb_getSentDate;
		}

		static IntPtr n_GetSentDate (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SentDate);
		}
#pragma warning restore 0169

		static IntPtr id_getSentDate;
		public virtual global::Java.Util.Date SentDate {
			[Register ("getSentDate", "()Ljava/util/Date;", "GetGetSentDateHandler")]
			get {
				if (id_getSentDate == IntPtr.Zero)
					id_getSentDate = JNIEnv.GetMethodID (class_ref, "getSentDate", "()Ljava/util/Date;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getSentDate), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSentDate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		public virtual string Title {
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_compareTo_Lcom_urbanairship_richpush_RichPushMessage_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_urbanairship_richpush_RichPushMessage_Handler ()
		{
			if (cb_compareTo_Lcom_urbanairship_richpush_RichPushMessage_ == null)
				cb_compareTo_Lcom_urbanairship_richpush_RichPushMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_urbanairship_richpush_RichPushMessage_);
			return cb_compareTo_Lcom_urbanairship_richpush_RichPushMessage_;
		}

		static int n_CompareTo_Lcom_urbanairship_richpush_RichPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Richpush.RichPushMessage p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_urbanairship_richpush_RichPushMessage_;
		[Register ("compareTo", "(Lcom/urbanairship/richpush/RichPushMessage;)I", "GetCompareTo_Lcom_urbanairship_richpush_RichPushMessage_Handler")]
		public virtual int CompareTo (global::Com.Urbanairship.Richpush.RichPushMessage p0)
		{
			if (id_compareTo_Lcom_urbanairship_richpush_RichPushMessage_ == IntPtr.Zero)
				id_compareTo_Lcom_urbanairship_richpush_RichPushMessage_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/urbanairship/richpush/RichPushMessage;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_urbanairship_richpush_RichPushMessage_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_compareTo_Lcom_urbanairship_richpush_RichPushMessage_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual void Delete ()
		{
			if (id_delete == IntPtr.Zero)
				id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_delete);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_delete);
		}

		static Delegate cb_markRead;
#pragma warning disable 0169
		static Delegate GetMarkReadHandler ()
		{
			if (cb_markRead == null)
				cb_markRead = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MarkRead);
			return cb_markRead;
		}

		static void n_MarkRead (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkRead ();
		}
#pragma warning restore 0169

		static IntPtr id_markRead;
		[Register ("markRead", "()V", "GetMarkReadHandler")]
		public virtual void MarkRead ()
		{
			if (id_markRead == IntPtr.Zero)
				id_markRead = JNIEnv.GetMethodID (class_ref, "markRead", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_markRead);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_markRead);
		}

		static Delegate cb_markUnread;
#pragma warning disable 0169
		static Delegate GetMarkUnreadHandler ()
		{
			if (cb_markUnread == null)
				cb_markUnread = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MarkUnread);
			return cb_markUnread;
		}

		static void n_MarkUnread (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessage __this = Java.Lang.Object.GetObject<RichPushMessage> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkUnread ();
		}
#pragma warning restore 0169

		static IntPtr id_markUnread;
		[Register ("markUnread", "()V", "GetMarkUnreadHandler")]
		public virtual void MarkUnread ()
		{
			if (id_markUnread == IntPtr.Zero)
				id_markUnread = JNIEnv.GetMethodID (class_ref, "markUnread", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_markUnread);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_markUnread);
		}

	}
}
