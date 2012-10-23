using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Richpush {

	[global::Android.Runtime.Register ("com/urbanairship/richpush/RichPushMessageJavaScript", DoNotGenerateAcw=true)]
	public partial class RichPushMessageJavaScript : global::Java.Lang.Object, global::Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterface {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/richpush/RichPushMessageJavaScript", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RichPushMessageJavaScript); }
		}

		protected RichPushMessageJavaScript (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_Ljava_lang_String_;
		[Register (".ctor", "(Landroid/view/View;Ljava/lang/String;)V", "")]
		public RichPushMessageJavaScript (global::Android.Views.View p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (RichPushMessageJavaScript)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/view/View;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_view_View_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Landroid_view_View_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_view_View_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getDeviceModel;
#pragma warning disable 0169
		static Delegate GetGetDeviceModelHandler ()
		{
			if (cb_getDeviceModel == null)
				cb_getDeviceModel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceModel);
			return cb_getDeviceModel;
		}

		static IntPtr n_GetDeviceModel (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessageJavaScript __this = Java.Lang.Object.GetObject<RichPushMessageJavaScript> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceModel);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceModel;
		public virtual string DeviceModel {
			[Register ("getDeviceModel", "()Ljava/lang/String;", "GetGetDeviceModelHandler")]
			get {
				if (id_getDeviceModel == IntPtr.Zero)
					id_getDeviceModel = JNIEnv.GetMethodID (class_ref, "getDeviceModel", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceModel), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDeviceModel), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDeviceOrientation;
#pragma warning disable 0169
		static Delegate GetGetDeviceOrientationHandler ()
		{
			if (cb_getDeviceOrientation == null)
				cb_getDeviceOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceOrientation);
			return cb_getDeviceOrientation;
		}

		static IntPtr n_GetDeviceOrientation (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessageJavaScript __this = Java.Lang.Object.GetObject<RichPushMessageJavaScript> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceOrientation);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceOrientation;
		public virtual string DeviceOrientation {
			[Register ("getDeviceOrientation", "()Ljava/lang/String;", "GetGetDeviceOrientationHandler")]
			get {
				if (id_getDeviceOrientation == IntPtr.Zero)
					id_getDeviceOrientation = JNIEnv.GetMethodID (class_ref, "getDeviceOrientation", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceOrientation), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDeviceOrientation), JniHandleOwnership.TransferLocalRef);
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
			RichPushMessageJavaScript __this = Java.Lang.Object.GetObject<RichPushMessageJavaScript> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getMessageSentDate;
#pragma warning disable 0169
		static Delegate GetGetMessageSentDateHandler ()
		{
			if (cb_getMessageSentDate == null)
				cb_getMessageSentDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageSentDate);
			return cb_getMessageSentDate;
		}

		static IntPtr n_GetMessageSentDate (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessageJavaScript __this = Java.Lang.Object.GetObject<RichPushMessageJavaScript> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageSentDate);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageSentDate;
		public virtual string MessageSentDate {
			[Register ("getMessageSentDate", "()Ljava/lang/String;", "GetGetMessageSentDateHandler")]
			get {
				if (id_getMessageSentDate == IntPtr.Zero)
					id_getMessageSentDate = JNIEnv.GetMethodID (class_ref, "getMessageSentDate", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageSentDate), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMessageSentDate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessageTitle;
#pragma warning disable 0169
		static Delegate GetGetMessageTitleHandler ()
		{
			if (cb_getMessageTitle == null)
				cb_getMessageTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageTitle);
			return cb_getMessageTitle;
		}

		static IntPtr n_GetMessageTitle (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessageJavaScript __this = Java.Lang.Object.GetObject<RichPushMessageJavaScript> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageTitle);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageTitle;
		public virtual string MessageTitle {
			[Register ("getMessageTitle", "()Ljava/lang/String;", "GetGetMessageTitleHandler")]
			get {
				if (id_getMessageTitle == IntPtr.Zero)
					id_getMessageTitle = JNIEnv.GetMethodID (class_ref, "getMessageTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMessageTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessageJavaScript __this = Java.Lang.Object.GetObject<RichPushMessageJavaScript> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		public virtual string UserId {
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				if (id_getUserId == IntPtr.Zero)
					id_getUserId = JNIEnv.GetMethodID (class_ref, "getUserId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUserId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getUserId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getViewHeight;
#pragma warning disable 0169
		static Delegate GetGetViewHeightHandler ()
		{
			if (cb_getViewHeight == null)
				cb_getViewHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetViewHeight);
			return cb_getViewHeight;
		}

		static int n_GetViewHeight (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessageJavaScript __this = Java.Lang.Object.GetObject<RichPushMessageJavaScript> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ViewHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getViewHeight;
		public virtual int ViewHeight {
			[Register ("getViewHeight", "()I", "GetGetViewHeightHandler")]
			get {
				if (id_getViewHeight == IntPtr.Zero)
					id_getViewHeight = JNIEnv.GetMethodID (class_ref, "getViewHeight", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getViewHeight);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getViewHeight);
			}
		}

		static Delegate cb_getViewWidth;
#pragma warning disable 0169
		static Delegate GetGetViewWidthHandler ()
		{
			if (cb_getViewWidth == null)
				cb_getViewWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetViewWidth);
			return cb_getViewWidth;
		}

		static int n_GetViewWidth (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessageJavaScript __this = Java.Lang.Object.GetObject<RichPushMessageJavaScript> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ViewWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getViewWidth;
		public virtual int ViewWidth {
			[Register ("getViewWidth", "()I", "GetGetViewWidthHandler")]
			get {
				if (id_getViewWidth == IntPtr.Zero)
					id_getViewWidth = JNIEnv.GetMethodID (class_ref, "getViewWidth", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getViewWidth);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getViewWidth);
			}
		}

		static Delegate cb_deleteMessage;
#pragma warning disable 0169
		static Delegate GetDeleteMessageHandler ()
		{
			if (cb_deleteMessage == null)
				cb_deleteMessage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteMessage);
			return cb_deleteMessage;
		}

		static void n_DeleteMessage (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessageJavaScript __this = Java.Lang.Object.GetObject<RichPushMessageJavaScript> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteMessage ();
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessage;
		[Register ("deleteMessage", "()V", "GetDeleteMessageHandler")]
		public virtual void DeleteMessage ()
		{
			if (id_deleteMessage == IntPtr.Zero)
				id_deleteMessage = JNIEnv.GetMethodID (class_ref, "deleteMessage", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_deleteMessage);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_deleteMessage);
		}

		static Delegate cb_markMessageRead;
#pragma warning disable 0169
		static Delegate GetMarkMessageReadHandler ()
		{
			if (cb_markMessageRead == null)
				cb_markMessageRead = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MarkMessageRead);
			return cb_markMessageRead;
		}

		static void n_MarkMessageRead (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessageJavaScript __this = Java.Lang.Object.GetObject<RichPushMessageJavaScript> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkMessageRead ();
		}
#pragma warning restore 0169

		static IntPtr id_markMessageRead;
		[Register ("markMessageRead", "()V", "GetMarkMessageReadHandler")]
		public virtual void MarkMessageRead ()
		{
			if (id_markMessageRead == IntPtr.Zero)
				id_markMessageRead = JNIEnv.GetMethodID (class_ref, "markMessageRead", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_markMessageRead);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_markMessageRead);
		}

		static Delegate cb_markMessageUnread;
#pragma warning disable 0169
		static Delegate GetMarkMessageUnreadHandler ()
		{
			if (cb_markMessageUnread == null)
				cb_markMessageUnread = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MarkMessageUnread);
			return cb_markMessageUnread;
		}

		static void n_MarkMessageUnread (IntPtr jnienv, IntPtr native__this)
		{
			RichPushMessageJavaScript __this = Java.Lang.Object.GetObject<RichPushMessageJavaScript> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkMessageUnread ();
		}
#pragma warning restore 0169

		static IntPtr id_markMessageUnread;
		[Register ("markMessageUnread", "()V", "GetMarkMessageUnreadHandler")]
		public virtual void MarkMessageUnread ()
		{
			if (id_markMessageUnread == IntPtr.Zero)
				id_markMessageUnread = JNIEnv.GetMethodID (class_ref, "markMessageUnread", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_markMessageUnread);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_markMessageUnread);
		}

		static Delegate cb_navigateTo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNavigateTo_Ljava_lang_String_Handler ()
		{
			if (cb_navigateTo_Ljava_lang_String_ == null)
				cb_navigateTo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NavigateTo_Ljava_lang_String_);
			return cb_navigateTo_Ljava_lang_String_;
		}

		static void n_NavigateTo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RichPushMessageJavaScript __this = Java.Lang.Object.GetObject<RichPushMessageJavaScript> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NavigateTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_navigateTo_Ljava_lang_String_;
		[Register ("navigateTo", "(Ljava/lang/String;)V", "GetNavigateTo_Ljava_lang_String_Handler")]
		public virtual void NavigateTo (string p0)
		{
			if (id_navigateTo_Ljava_lang_String_ == IntPtr.Zero)
				id_navigateTo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "navigateTo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_navigateTo_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_navigateTo_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
