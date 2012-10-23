using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Richpush {

	[global::Android.Runtime.Register ("com/urbanairship/richpush/RichPushManager", DoNotGenerateAcw=true)]
	public partial class RichPushManager : global::Java.Lang.Object {

		[Register ("com/urbanairship/richpush/RichPushManager$Listener", "", "Com.Urbanairship.Richpush.RichPushManager/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			[Register ("onRetrieveMessage", "(ZLjava/lang/String;)V", "GetOnRetrieveMessage_ZLjava_lang_String_Handler:Com.Urbanairship.Richpush.RichPushManager/IListenerInvoker, AndroidSDK.Binding")]
			void OnRetrieveMessage (bool p0, string p1);

			[Register ("onUpdateMessages", "(Z)V", "GetOnUpdateMessages_ZHandler:Com.Urbanairship.Richpush.RichPushManager/IListenerInvoker, AndroidSDK.Binding")]
			void OnUpdateMessages (bool p0);

			[Register ("onUpdateUser", "(Z)V", "GetOnUpdateUser_ZHandler:Com.Urbanairship.Richpush.RichPushManager/IListenerInvoker, AndroidSDK.Binding")]
			void OnUpdateUser (bool p0);

		}

		[global::Android.Runtime.Register ("com/urbanairship/richpush/RichPushManager$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/urbanairship/richpush/RichPushManager$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.urbanairship.richpush.RichPushManager.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			static Delegate cb_onRetrieveMessage_ZLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnRetrieveMessage_ZLjava_lang_String_Handler ()
			{
				if (cb_onRetrieveMessage_ZLjava_lang_String_ == null)
					cb_onRetrieveMessage_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_OnRetrieveMessage_ZLjava_lang_String_);
				return cb_onRetrieveMessage_ZLjava_lang_String_;
			}

			static void n_OnRetrieveMessage_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
			{
				IListener __this = Java.Lang.Object.GetObject<IListener> (native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnRetrieveMessage (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onRetrieveMessage_ZLjava_lang_String_;
			public void OnRetrieveMessage (bool p0, string p1)
			{
				if (id_onRetrieveMessage_ZLjava_lang_String_ == IntPtr.Zero)
					id_onRetrieveMessage_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRetrieveMessage", "(ZLjava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JNIEnv.CallVoidMethod (Handle, id_onRetrieveMessage_ZLjava_lang_String_, new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static Delegate cb_onUpdateMessages_Z;
#pragma warning disable 0169
			static Delegate GetOnUpdateMessages_ZHandler ()
			{
				if (cb_onUpdateMessages_Z == null)
					cb_onUpdateMessages_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnUpdateMessages_Z);
				return cb_onUpdateMessages_Z;
			}

			static void n_OnUpdateMessages_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				IListener __this = Java.Lang.Object.GetObject<IListener> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnUpdateMessages (p0);
			}
#pragma warning restore 0169

			IntPtr id_onUpdateMessages_Z;
			public void OnUpdateMessages (bool p0)
			{
				if (id_onUpdateMessages_Z == IntPtr.Zero)
					id_onUpdateMessages_Z = JNIEnv.GetMethodID (class_ref, "onUpdateMessages", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_onUpdateMessages_Z, new JValue (p0));
			}

			static Delegate cb_onUpdateUser_Z;
#pragma warning disable 0169
			static Delegate GetOnUpdateUser_ZHandler ()
			{
				if (cb_onUpdateUser_Z == null)
					cb_onUpdateUser_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnUpdateUser_Z);
				return cb_onUpdateUser_Z;
			}

			static void n_OnUpdateUser_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				IListener __this = Java.Lang.Object.GetObject<IListener> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnUpdateUser (p0);
			}
#pragma warning restore 0169

			IntPtr id_onUpdateUser_Z;
			public void OnUpdateUser (bool p0)
			{
				if (id_onUpdateUser_Z == IntPtr.Zero)
					id_onUpdateUser_Z = JNIEnv.GetMethodID (class_ref, "onUpdateUser", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_onUpdateUser_Z, new JValue (p0));
			}

		}

		public partial class RetrieveMessageEventArgs : global::System.EventArgs {

			public RetrieveMessageEventArgs (bool p0, string p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}

			string p1;
			public string P1 {
				get { return p1; }
			}
		}

		public partial class UpdateMessagesEventArgs : global::System.EventArgs {

			public UpdateMessagesEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		public partial class UpdateUserEventArgs : global::System.EventArgs {

			public UpdateUserEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/urbanairship/richpush/RichPushManager_ListenerImplementor")]
		internal sealed class IListenerImplementor : Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/urbanairship/richpush/RichPushManager_ListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RetrieveMessageEventArgs> OnRetrieveMessageHandler;
#pragma warning restore 0649

			public void OnRetrieveMessage (bool p0, string p1)
			{
				if (OnRetrieveMessageHandler != null)
					OnRetrieveMessageHandler (sender, new RetrieveMessageEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<UpdateMessagesEventArgs> OnUpdateMessagesHandler;
#pragma warning restore 0649

			public void OnUpdateMessages (bool p0)
			{
				if (OnUpdateMessagesHandler != null)
					OnUpdateMessagesHandler (sender, new UpdateMessagesEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<UpdateUserEventArgs> OnUpdateUserHandler;
#pragma warning restore 0649

			public void OnUpdateUser (bool p0)
			{
				if (OnUpdateUserHandler != null)
					OnUpdateUserHandler (sender, new UpdateUserEventArgs (p0));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.OnRetrieveMessageHandler == null && value.OnUpdateMessagesHandler == null && value.OnUpdateUserHandler == null;
			}
		}


		[global::Android.Runtime.Register ("com/urbanairship/richpush/RichPushManager$UpdateResultReceiver", DoNotGenerateAcw=true)]
		public abstract partial class UpdateResultReceiver : global::Android.OS.ResultReceiver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/richpush/RichPushManager$UpdateResultReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UpdateResultReceiver); }
			}

			protected UpdateResultReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_urbanairship_richpush_RichPushManager_;
			[Register (".ctor", "(Lcom/urbanairship/richpush/RichPushManager;)V", "")]
			public UpdateResultReceiver (global::Com.Urbanairship.Richpush.RichPushManager __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (UpdateResultReceiver)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_urbanairship_richpush_RichPushManager_ == IntPtr.Zero)
					id_ctor_Lcom_urbanairship_richpush_RichPushManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/richpush/RichPushManager;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_richpush_RichPushManager_, new JValue (__self)), JniHandleOwnership.TransferLocalRef);
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/richpush/RichPushManager$UpdateResultReceiver", DoNotGenerateAcw=true)]
		internal partial class UpdateResultReceiverInvoker : UpdateResultReceiver {

			public UpdateResultReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (UpdateResultReceiverInvoker); }
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/richpush/RichPushManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RichPushManager); }
		}

		protected RichPushManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isRefreshingMessages;
#pragma warning disable 0169
		static Delegate GetIsRefreshingMessagesHandler ()
		{
			if (cb_isRefreshingMessages == null)
				cb_isRefreshingMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRefreshingMessages);
			return cb_isRefreshingMessages;
		}

		static bool n_IsRefreshingMessages (IntPtr jnienv, IntPtr native__this)
		{
			RichPushManager __this = Java.Lang.Object.GetObject<RichPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRefreshingMessages;
		}
#pragma warning restore 0169

		static IntPtr id_isRefreshingMessages;
		public virtual bool IsRefreshingMessages {
			[Register ("isRefreshingMessages", "()Z", "GetIsRefreshingMessagesHandler")]
			get {
				if (id_isRefreshingMessages == IntPtr.Zero)
					id_isRefreshingMessages = JNIEnv.GetMethodID (class_ref, "isRefreshingMessages", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isRefreshingMessages);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isRefreshingMessages);
			}
		}

		static IntPtr id_getJsIdentifier;
		public static string JsIdentifier {
			[Register ("getJsIdentifier", "()Ljava/lang/String;", "GetGetJsIdentifierHandler")]
			get {
				if (id_getJsIdentifier == IntPtr.Zero)
					id_getJsIdentifier = JNIEnv.GetStaticMethodID (class_ref, "getJsIdentifier", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJsIdentifier), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getJsInterface;
		public static global::Java.Lang.Class JsInterface {
			[Register ("getJsInterface", "()Ljava/lang/Class;", "GetGetJsInterfaceHandler")]
			get {
				if (id_getJsInterface == IntPtr.Zero)
					id_getJsInterface = JNIEnv.GetStaticMethodID (class_ref, "getJsInterface", "()Ljava/lang/Class;");
				return Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJsInterface), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRichPushUser;
#pragma warning disable 0169
		static Delegate GetGetRichPushUserHandler ()
		{
			if (cb_getRichPushUser == null)
				cb_getRichPushUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRichPushUser);
			return cb_getRichPushUser;
		}

		static IntPtr n_GetRichPushUser (IntPtr jnienv, IntPtr native__this)
		{
			RichPushManager __this = Java.Lang.Object.GetObject<RichPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RichPushUser);
		}
#pragma warning restore 0169

		static IntPtr id_getRichPushUser;
		public virtual global::Com.Urbanairship.Richpush.RichPushUser RichPushUser {
			[Register ("getRichPushUser", "()Lcom/urbanairship/richpush/RichPushUser;", "GetGetRichPushUserHandler")]
			get {
				if (id_getRichPushUser == IntPtr.Zero)
					id_getRichPushUser = JNIEnv.GetMethodID (class_ref, "getRichPushUser", "()Lcom/urbanairship/richpush/RichPushUser;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushUser> (JNIEnv.CallObjectMethod  (Handle, id_getRichPushUser), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushUser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getRichPushUser), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addListener_Lcom_urbanairship_richpush_RichPushManager_Listener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_urbanairship_richpush_RichPushManager_Listener_Handler ()
		{
			if (cb_addListener_Lcom_urbanairship_richpush_RichPushManager_Listener_ == null)
				cb_addListener_Lcom_urbanairship_richpush_RichPushManager_Listener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Lcom_urbanairship_richpush_RichPushManager_Listener_);
			return cb_addListener_Lcom_urbanairship_richpush_RichPushManager_Listener_;
		}

		static void n_AddListener_Lcom_urbanairship_richpush_RichPushManager_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RichPushManager __this = Java.Lang.Object.GetObject<RichPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Richpush.RichPushManager.IListener p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushManager.IListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addListener_Lcom_urbanairship_richpush_RichPushManager_Listener_;
		[Register ("addListener", "(Lcom/urbanairship/richpush/RichPushManager$Listener;)V", "GetAddListener_Lcom_urbanairship_richpush_RichPushManager_Listener_Handler")]
		public virtual void AddListener (global::Com.Urbanairship.Richpush.RichPushManager.IListener p0)
		{
			if (id_addListener_Lcom_urbanairship_richpush_RichPushManager_Listener_ == IntPtr.Zero)
				id_addListener_Lcom_urbanairship_richpush_RichPushManager_Listener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lcom/urbanairship/richpush/RichPushManager$Listener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addListener_Lcom_urbanairship_richpush_RichPushManager_Listener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addListener_Lcom_urbanairship_richpush_RichPushManager_Listener_, new JValue (p0));
		}

		static IntPtr id_init;
		[Register ("init", "()V", "")]
		public static void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetStaticMethodID (class_ref, "init", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_init);
		}

		static IntPtr id_isRichPushMessage_Landroid_os_Bundle_;
		[Register ("isRichPushMessage", "(Landroid/os/Bundle;)Z", "")]
		public static bool IsRichPushMessage (global::Android.OS.Bundle p0)
		{
			if (id_isRichPushMessage_Landroid_os_Bundle_ == IntPtr.Zero)
				id_isRichPushMessage_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "isRichPushMessage", "(Landroid/os/Bundle;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isRichPushMessage_Landroid_os_Bundle_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isRichPushMessage_Ljava_util_Map_;
		[Register ("isRichPushMessage", "(Ljava/util/Map;)Z", "")]
		public static bool IsRichPushMessage (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_isRichPushMessage_Ljava_util_Map_ == IntPtr.Zero)
				id_isRichPushMessage_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "isRichPushMessage", "(Ljava/util/Map;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isRichPushMessage_Ljava_util_Map_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_refreshMessages;
#pragma warning disable 0169
		static Delegate GetRefreshMessagesHandler ()
		{
			if (cb_refreshMessages == null)
				cb_refreshMessages = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RefreshMessages);
			return cb_refreshMessages;
		}

		static void n_RefreshMessages (IntPtr jnienv, IntPtr native__this)
		{
			RichPushManager __this = Java.Lang.Object.GetObject<RichPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RefreshMessages ();
		}
#pragma warning restore 0169

		static IntPtr id_refreshMessages;
		[Register ("refreshMessages", "()V", "GetRefreshMessagesHandler")]
		public virtual void RefreshMessages ()
		{
			if (id_refreshMessages == IntPtr.Zero)
				id_refreshMessages = JNIEnv.GetMethodID (class_ref, "refreshMessages", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_refreshMessages);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_refreshMessages);
		}

		static Delegate cb_removeListener_Lcom_urbanairship_richpush_RichPushManager_Listener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_urbanairship_richpush_RichPushManager_Listener_Handler ()
		{
			if (cb_removeListener_Lcom_urbanairship_richpush_RichPushManager_Listener_ == null)
				cb_removeListener_Lcom_urbanairship_richpush_RichPushManager_Listener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lcom_urbanairship_richpush_RichPushManager_Listener_);
			return cb_removeListener_Lcom_urbanairship_richpush_RichPushManager_Listener_;
		}

		static void n_RemoveListener_Lcom_urbanairship_richpush_RichPushManager_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RichPushManager __this = Java.Lang.Object.GetObject<RichPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Richpush.RichPushManager.IListener p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushManager.IListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeListener_Lcom_urbanairship_richpush_RichPushManager_Listener_;
		[Register ("removeListener", "(Lcom/urbanairship/richpush/RichPushManager$Listener;)V", "GetRemoveListener_Lcom_urbanairship_richpush_RichPushManager_Listener_Handler")]
		public virtual void RemoveListener (global::Com.Urbanairship.Richpush.RichPushManager.IListener p0)
		{
			if (id_removeListener_Lcom_urbanairship_richpush_RichPushManager_Listener_ == IntPtr.Zero)
				id_removeListener_Lcom_urbanairship_richpush_RichPushManager_Listener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/urbanairship/richpush/RichPushManager$Listener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeListener_Lcom_urbanairship_richpush_RichPushManager_Listener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeListener_Lcom_urbanairship_richpush_RichPushManager_Listener_, new JValue (p0));
		}

		static IntPtr id_retrieveRichPushMessage_Ljava_util_Map_;
		[Register ("retrieveRichPushMessage", "(Ljava/util/Map;)V", "")]
		public static void RetrieveRichPushMessage (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_retrieveRichPushMessage_Ljava_util_Map_ == IntPtr.Zero)
				id_retrieveRichPushMessage_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "retrieveRichPushMessage", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_retrieveRichPushMessage_Ljava_util_Map_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_setJavascriptInterface_Ljava_lang_Class_;
		[Register ("setJavascriptInterface", "(Ljava/lang/Class;)V", "")]
		public static void SetJavascriptInterface (global::Java.Lang.Class p0)
		{
			if (id_setJavascriptInterface_Ljava_lang_Class_ == IntPtr.Zero)
				id_setJavascriptInterface_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "setJavascriptInterface", "(Ljava/lang/Class;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setJavascriptInterface_Ljava_lang_Class_, new JValue (p0));
		}

		static IntPtr id_setJavascriptInterface_Ljava_lang_Class_Ljava_lang_String_;
		[Register ("setJavascriptInterface", "(Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public static void SetJavascriptInterface (global::Java.Lang.Class p0, string p1)
		{
			if (id_setJavascriptInterface_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_setJavascriptInterface_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setJavascriptInterface", "(Ljava/lang/Class;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setJavascriptInterface_Ljava_lang_Class_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_shared;
		[Register ("shared", "()Lcom/urbanairship/richpush/RichPushManager;", "")]
		public static global::Com.Urbanairship.Richpush.RichPushManager Shared ()
		{
			if (id_shared == IntPtr.Zero)
				id_shared = JNIEnv.GetStaticMethodID (class_ref, "shared", "()Lcom/urbanairship/richpush/RichPushManager;");
			return Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_shared), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_updateUser;
#pragma warning disable 0169
		static Delegate GetUpdateUserHandler ()
		{
			if (cb_updateUser == null)
				cb_updateUser = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateUser);
			return cb_updateUser;
		}

		static void n_UpdateUser (IntPtr jnienv, IntPtr native__this)
		{
			RichPushManager __this = Java.Lang.Object.GetObject<RichPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateUser ();
		}
#pragma warning restore 0169

		static IntPtr id_updateUser;
		[Register ("updateUser", "()V", "GetUpdateUserHandler")]
		public virtual void UpdateUser ()
		{
			if (id_updateUser == IntPtr.Zero)
				id_updateUser = JNIEnv.GetMethodID (class_ref, "updateUser", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_updateUser);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_updateUser);
		}

#region "Event implementation for Com.Urbanairship.Richpush.RichPushManager.IListener"

		global::Com.Urbanairship.Richpush.RichPushManager.IListenerImplementor __CreateIListenerImplementor ()
		{
			return new global::Com.Urbanairship.Richpush.RichPushManager.IListenerImplementor (this);
		}
#endregion
	}
}
