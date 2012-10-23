using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Richpush {

	[Register ("com/urbanairship/richpush/RichPushMessageJavaScriptInterface", "", "Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker")]
	public partial interface IRichPushMessageJavaScriptInterface : IJavaObject {

		string DeviceModel {
			[Register ("getDeviceModel", "()Ljava/lang/String;", "GetGetDeviceModelHandler:Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker, AndroidSDK.Binding")] get;
		}

		string DeviceOrientation {
			[Register ("getDeviceOrientation", "()Ljava/lang/String;", "GetGetDeviceOrientationHandler:Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker, AndroidSDK.Binding")] get;
		}

		string MessageId {
			[Register ("getMessageId", "()Ljava/lang/String;", "GetGetMessageIdHandler:Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker, AndroidSDK.Binding")] get;
		}

		string MessageSentDate {
			[Register ("getMessageSentDate", "()Ljava/lang/String;", "GetGetMessageSentDateHandler:Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker, AndroidSDK.Binding")] get;
		}

		string MessageTitle {
			[Register ("getMessageTitle", "()Ljava/lang/String;", "GetGetMessageTitleHandler:Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker, AndroidSDK.Binding")] get;
		}

		string UserId {
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler:Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker, AndroidSDK.Binding")] get;
		}

		int ViewHeight {
			[Register ("getViewHeight", "()I", "GetGetViewHeightHandler:Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker, AndroidSDK.Binding")] get;
		}

		int ViewWidth {
			[Register ("getViewWidth", "()I", "GetGetViewWidthHandler:Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker, AndroidSDK.Binding")] get;
		}

		[Register ("deleteMessage", "()V", "GetDeleteMessageHandler:Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker, AndroidSDK.Binding")]
		void DeleteMessage ();

		[Register ("markMessageRead", "()V", "GetMarkMessageReadHandler:Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker, AndroidSDK.Binding")]
		void MarkMessageRead ();

		[Register ("markMessageUnread", "()V", "GetMarkMessageUnreadHandler:Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker, AndroidSDK.Binding")]
		void MarkMessageUnread ();

		[Register ("navigateTo", "(Ljava/lang/String;)V", "GetNavigateTo_Ljava_lang_String_Handler:Com.Urbanairship.Richpush.IRichPushMessageJavaScriptInterfaceInvoker, AndroidSDK.Binding")]
		void NavigateTo (string p0);

	}

	[global::Android.Runtime.Register ("com/urbanairship/richpush/RichPushMessageJavaScriptInterface", DoNotGenerateAcw=true)]
	internal class IRichPushMessageJavaScriptInterfaceInvoker : Java.Lang.Object, IRichPushMessageJavaScriptInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/urbanairship/richpush/RichPushMessageJavaScriptInterface");
		IntPtr class_ref;

		public static IRichPushMessageJavaScriptInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.urbanairship.richpush.RichPushMessageJavaScriptInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRichPushMessageJavaScriptInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRichPushMessageJavaScriptInterfaceInvoker); }
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
			IRichPushMessageJavaScriptInterface __this = Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceModel);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceModel;
		public string DeviceModel {
			get {
				if (id_getDeviceModel == IntPtr.Zero)
					id_getDeviceModel = JNIEnv.GetMethodID (class_ref, "getDeviceModel", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDeviceModel), JniHandleOwnership.TransferLocalRef);
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
			IRichPushMessageJavaScriptInterface __this = Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceOrientation);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceOrientation;
		public string DeviceOrientation {
			get {
				if (id_getDeviceOrientation == IntPtr.Zero)
					id_getDeviceOrientation = JNIEnv.GetMethodID (class_ref, "getDeviceOrientation", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDeviceOrientation), JniHandleOwnership.TransferLocalRef);
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
			IRichPushMessageJavaScriptInterface __this = Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageId);
		}
#pragma warning restore 0169

		IntPtr id_getMessageId;
		public string MessageId {
			get {
				if (id_getMessageId == IntPtr.Zero)
					id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMessageId), JniHandleOwnership.TransferLocalRef);
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
			IRichPushMessageJavaScriptInterface __this = Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageSentDate);
		}
#pragma warning restore 0169

		IntPtr id_getMessageSentDate;
		public string MessageSentDate {
			get {
				if (id_getMessageSentDate == IntPtr.Zero)
					id_getMessageSentDate = JNIEnv.GetMethodID (class_ref, "getMessageSentDate", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMessageSentDate), JniHandleOwnership.TransferLocalRef);
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
			IRichPushMessageJavaScriptInterface __this = Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageTitle);
		}
#pragma warning restore 0169

		IntPtr id_getMessageTitle;
		public string MessageTitle {
			get {
				if (id_getMessageTitle == IntPtr.Zero)
					id_getMessageTitle = JNIEnv.GetMethodID (class_ref, "getMessageTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMessageTitle), JniHandleOwnership.TransferLocalRef);
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
			IRichPushMessageJavaScriptInterface __this = Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		IntPtr id_getUserId;
		public string UserId {
			get {
				if (id_getUserId == IntPtr.Zero)
					id_getUserId = JNIEnv.GetMethodID (class_ref, "getUserId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getUserId), JniHandleOwnership.TransferLocalRef);
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
			IRichPushMessageJavaScriptInterface __this = Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ViewHeight;
		}
#pragma warning restore 0169

		IntPtr id_getViewHeight;
		public int ViewHeight {
			get {
				if (id_getViewHeight == IntPtr.Zero)
					id_getViewHeight = JNIEnv.GetMethodID (class_ref, "getViewHeight", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getViewHeight);
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
			IRichPushMessageJavaScriptInterface __this = Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ViewWidth;
		}
#pragma warning restore 0169

		IntPtr id_getViewWidth;
		public int ViewWidth {
			get {
				if (id_getViewWidth == IntPtr.Zero)
					id_getViewWidth = JNIEnv.GetMethodID (class_ref, "getViewWidth", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getViewWidth);
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
			IRichPushMessageJavaScriptInterface __this = Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteMessage ();
		}
#pragma warning restore 0169

		IntPtr id_deleteMessage;
		public void DeleteMessage ()
		{
			if (id_deleteMessage == IntPtr.Zero)
				id_deleteMessage = JNIEnv.GetMethodID (class_ref, "deleteMessage", "()V");
			JNIEnv.CallVoidMethod (Handle, id_deleteMessage);
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
			IRichPushMessageJavaScriptInterface __this = Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkMessageRead ();
		}
#pragma warning restore 0169

		IntPtr id_markMessageRead;
		public void MarkMessageRead ()
		{
			if (id_markMessageRead == IntPtr.Zero)
				id_markMessageRead = JNIEnv.GetMethodID (class_ref, "markMessageRead", "()V");
			JNIEnv.CallVoidMethod (Handle, id_markMessageRead);
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
			IRichPushMessageJavaScriptInterface __this = Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkMessageUnread ();
		}
#pragma warning restore 0169

		IntPtr id_markMessageUnread;
		public void MarkMessageUnread ()
		{
			if (id_markMessageUnread == IntPtr.Zero)
				id_markMessageUnread = JNIEnv.GetMethodID (class_ref, "markMessageUnread", "()V");
			JNIEnv.CallVoidMethod (Handle, id_markMessageUnread);
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
			IRichPushMessageJavaScriptInterface __this = Java.Lang.Object.GetObject<IRichPushMessageJavaScriptInterface> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NavigateTo (p0);
		}
#pragma warning restore 0169

		IntPtr id_navigateTo_Ljava_lang_String_;
		public void NavigateTo (string p0)
		{
			if (id_navigateTo_Ljava_lang_String_ == IntPtr.Zero)
				id_navigateTo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "navigateTo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_navigateTo_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
