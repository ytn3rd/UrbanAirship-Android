using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship {

	[global::Android.Runtime.Register ("com/urbanairship/UrbanAirshipResolver", DoNotGenerateAcw=true)]
	public abstract partial class UrbanAirshipResolver : global::Java.Lang.Object {


		[Register ("WHERE_CLAUSE_KEY")]
		protected const string WhereClauseKey = (string) "_id = ?";

		static IntPtr context_jfieldId;

		[Register ("context")]
		protected global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, context_jfieldId);
				return Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, context_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/UrbanAirshipResolver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrbanAirshipResolver); }
		}

		protected UrbanAirshipResolver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public UrbanAirshipResolver () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UrbanAirshipResolver)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_bulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetBulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_Handler ()
		{
			if (cb_bulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_ == null)
				cb_bulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_BulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_);
			return cb_bulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_;
		}

		static int n_BulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			UrbanAirshipResolver __this = Java.Lang.Object.GetObject<UrbanAirshipResolver> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			Android.Content.ContentValues[] p1 = (Android.Content.ContentValues[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (Android.Content.ContentValues));
			int __ret = __this.BulkInsert (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_bulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_;
		[Register ("bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", "GetBulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_Handler")]
		protected virtual int BulkInsert (global::Android.Net.Uri p0, global::Android.Content.ContentValues[] p1)
		{
			if (id_bulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_ == IntPtr.Zero)
				id_bulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_bulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_, new JValue (p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_bulkInsert_Landroid_net_Uri_arrayLandroid_content_ContentValues_, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static int n_Delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			UrbanAirshipResolver __this = Java.Lang.Object.GetObject<UrbanAirshipResolver> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.Delete (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
		[Register ("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", "GetDelete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		protected virtual int Delete (global::Android.Net.Uri p0, string p1, string[] p2)
		{
			if (id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetInsert_Landroid_net_Uri_Landroid_content_ContentValues_Handler ()
		{
			if (cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_ == null)
				cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Insert_Landroid_net_Uri_Landroid_content_ContentValues_);
			return cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
		}

		static IntPtr n_Insert_Landroid_net_Uri_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			UrbanAirshipResolver __this = Java.Lang.Object.GetObject<UrbanAirshipResolver> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p1 = Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
		[Register ("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", "GetInsert_Landroid_net_Uri_Landroid_content_ContentValues_Handler")]
		protected virtual global::Android.Net.Uri Insert (global::Android.Net.Uri p0, global::Android.Content.ContentValues p1)
		{
			if (id_insert_Landroid_net_Uri_Landroid_content_ContentValues_ == IntPtr.Zero)
				id_insert_Landroid_net_Uri_Landroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");

			global::Android.Net.Uri __ret;
			if (GetType () == ThresholdType)
				__ret = Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_insert_Landroid_net_Uri_Landroid_content_ContentValues_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_insert_Landroid_net_Uri_Landroid_content_ContentValues_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == null)
				cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_);
			return cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			UrbanAirshipResolver __this = Java.Lang.Object.GetObject<UrbanAirshipResolver> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0, p1, p2, p3, p4));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		[Register ("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "GetQuery_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler")]
		protected virtual global::Android.Database.ICursor Query (global::Android.Net.Uri p0, string[] p1, string p2, string[] p3, string p4)
		{
			if (id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);

			global::Android.Database.ICursor __ret;
			if (GetType () == ThresholdType)
				__ret = Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod  (Handle, id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static Delegate cb_registerContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_;
#pragma warning disable 0169
		static Delegate GetRegisterContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_Handler ()
		{
			if (cb_registerContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_ == null)
				cb_registerContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_RegisterContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_);
			return cb_registerContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_;
		}

		static void n_RegisterContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2)
		{
			UrbanAirshipResolver __this = Java.Lang.Object.GetObject<UrbanAirshipResolver> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ContentObserver p2 = Java.Lang.Object.GetObject<global::Android.Database.ContentObserver> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RegisterContentObserver (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_registerContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_;
		[Register ("registerContentObserver", "(Landroid/net/Uri;ZLandroid/database/ContentObserver;)V", "GetRegisterContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_Handler")]
		public virtual void RegisterContentObserver (global::Android.Net.Uri p0, bool p1, global::Android.Database.ContentObserver p2)
		{
			if (id_registerContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_ == IntPtr.Zero)
				id_registerContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_ = JNIEnv.GetMethodID (class_ref, "registerContentObserver", "(Landroid/net/Uri;ZLandroid/database/ContentObserver;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_registerContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_registerContentObserver_Landroid_net_Uri_ZLandroid_database_ContentObserver_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_unregisterContentObserver_Landroid_database_ContentObserver_;
#pragma warning disable 0169
		static Delegate GetUnregisterContentObserver_Landroid_database_ContentObserver_Handler ()
		{
			if (cb_unregisterContentObserver_Landroid_database_ContentObserver_ == null)
				cb_unregisterContentObserver_Landroid_database_ContentObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterContentObserver_Landroid_database_ContentObserver_);
			return cb_unregisterContentObserver_Landroid_database_ContentObserver_;
		}

		static void n_UnregisterContentObserver_Landroid_database_ContentObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UrbanAirshipResolver __this = Java.Lang.Object.GetObject<UrbanAirshipResolver> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ContentObserver p0 = Java.Lang.Object.GetObject<global::Android.Database.ContentObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterContentObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterContentObserver_Landroid_database_ContentObserver_;
		[Register ("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", "GetUnregisterContentObserver_Landroid_database_ContentObserver_Handler")]
		public virtual void UnregisterContentObserver (global::Android.Database.ContentObserver p0)
		{
			if (id_unregisterContentObserver_Landroid_database_ContentObserver_ == IntPtr.Zero)
				id_unregisterContentObserver_Landroid_database_ContentObserver_ = JNIEnv.GetMethodID (class_ref, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_unregisterContentObserver_Landroid_database_ContentObserver_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_unregisterContentObserver_Landroid_database_ContentObserver_, new JValue (p0));
		}

		static Delegate cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdate_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static int n_Update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			UrbanAirshipResolver __this = Java.Lang.Object.GetObject<UrbanAirshipResolver> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p1 = Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.Update (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		[Register ("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", "GetUpdate_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		protected virtual int Update (global::Android.Net.Uri p0, global::Android.Content.ContentValues p1, string p2, string[] p3)
		{
			if (id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("com/urbanairship/UrbanAirshipResolver", DoNotGenerateAcw=true)]
	internal partial class UrbanAirshipResolverInvoker : UrbanAirshipResolver {

		public UrbanAirshipResolverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrbanAirshipResolverInvoker); }
		}

	}

}
