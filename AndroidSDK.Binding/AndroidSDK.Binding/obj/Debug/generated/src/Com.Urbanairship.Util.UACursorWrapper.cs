using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Util {

	[global::Android.Runtime.Register ("com/urbanairship/util/UACursorWrapper", DoNotGenerateAcw=true)]
	public partial class UACursorWrapper : global::Java.Lang.Object, global::Android.Database.ICursor {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/util/UACursorWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UACursorWrapper); }
		}

		protected UACursorWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_database_Cursor_;
		[Register (".ctor", "(Landroid/database/Cursor;)V", "")]
		public UACursorWrapper (global::Android.Database.ICursor p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UACursorWrapper)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/database/Cursor;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_ctor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/database/Cursor;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_database_Cursor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getColumnCount;
#pragma warning disable 0169
		static Delegate GetGetColumnCountHandler ()
		{
			if (cb_getColumnCount == null)
				cb_getColumnCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColumnCount);
			return cb_getColumnCount;
		}

		static int n_GetColumnCount (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ColumnCount;
		}
#pragma warning restore 0169

		static IntPtr id_getColumnCount;
		public virtual int ColumnCount {
			[Register ("getColumnCount", "()I", "GetGetColumnCountHandler")]
			get {
				if (id_getColumnCount == IntPtr.Zero)
					id_getColumnCount = JNIEnv.GetMethodID (class_ref, "getColumnCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getColumnCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getColumnCount);
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public virtual int Count {
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getCount);
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
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_isAfterLast;
#pragma warning disable 0169
		static Delegate GetIsAfterLastHandler ()
		{
			if (cb_isAfterLast == null)
				cb_isAfterLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAfterLast);
			return cb_isAfterLast;
		}

		static bool n_IsAfterLast (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAfterLast;
		}
#pragma warning restore 0169

		static IntPtr id_isAfterLast;
		public virtual bool IsAfterLast {
			[Register ("isAfterLast", "()Z", "GetIsAfterLastHandler")]
			get {
				if (id_isAfterLast == IntPtr.Zero)
					id_isAfterLast = JNIEnv.GetMethodID (class_ref, "isAfterLast", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isAfterLast);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isAfterLast);
			}
		}

		static Delegate cb_isBeforeFirst;
#pragma warning disable 0169
		static Delegate GetIsBeforeFirstHandler ()
		{
			if (cb_isBeforeFirst == null)
				cb_isBeforeFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBeforeFirst);
			return cb_isBeforeFirst;
		}

		static bool n_IsBeforeFirst (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBeforeFirst;
		}
#pragma warning restore 0169

		static IntPtr id_isBeforeFirst;
		public virtual bool IsBeforeFirst {
			[Register ("isBeforeFirst", "()Z", "GetIsBeforeFirstHandler")]
			get {
				if (id_isBeforeFirst == IntPtr.Zero)
					id_isBeforeFirst = JNIEnv.GetMethodID (class_ref, "isBeforeFirst", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isBeforeFirst);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isBeforeFirst);
			}
		}

		static Delegate cb_isClosed;
#pragma warning disable 0169
		static Delegate GetIsClosedHandler ()
		{
			if (cb_isClosed == null)
				cb_isClosed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClosed);
			return cb_isClosed;
		}

		static bool n_IsClosed (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		static IntPtr id_isClosed;
		public virtual bool IsClosed {
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isClosed);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isClosed);
			}
		}

		static Delegate cb_isFirst;
#pragma warning disable 0169
		static Delegate GetIsFirstHandler ()
		{
			if (cb_isFirst == null)
				cb_isFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFirst);
			return cb_isFirst;
		}

		static bool n_IsFirst (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFirst;
		}
#pragma warning restore 0169

		static IntPtr id_isFirst;
		public virtual bool IsFirst {
			[Register ("isFirst", "()Z", "GetIsFirstHandler")]
			get {
				if (id_isFirst == IntPtr.Zero)
					id_isFirst = JNIEnv.GetMethodID (class_ref, "isFirst", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFirst);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isFirst);
			}
		}

		static Delegate cb_isLast;
#pragma warning disable 0169
		static Delegate GetIsLastHandler ()
		{
			if (cb_isLast == null)
				cb_isLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLast);
			return cb_isLast;
		}

		static bool n_IsLast (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLast;
		}
#pragma warning restore 0169

		static IntPtr id_isLast;
		public virtual bool IsLast {
			[Register ("isLast", "()Z", "GetIsLastHandler")]
			get {
				if (id_isLast == IntPtr.Zero)
					id_isLast = JNIEnv.GetMethodID (class_ref, "isLast", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isLast);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isLast);
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPosition);
			return cb_getPosition;
		}

		static int n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position;
		}
#pragma warning restore 0169

		static IntPtr id_getPosition;
		public virtual int Position {
			[Register ("getPosition", "()I", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPosition);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getPosition);
			}
		}

		static Delegate cb_getWantsAllOnMoveCalls;
#pragma warning disable 0169
		static Delegate GetGetWantsAllOnMoveCallsHandler ()
		{
			if (cb_getWantsAllOnMoveCalls == null)
				cb_getWantsAllOnMoveCalls = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWantsAllOnMoveCalls);
			return cb_getWantsAllOnMoveCalls;
		}

		static bool n_GetWantsAllOnMoveCalls (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WantsAllOnMoveCalls;
		}
#pragma warning restore 0169

		static IntPtr id_getWantsAllOnMoveCalls;
		public virtual bool WantsAllOnMoveCalls {
			[Register ("getWantsAllOnMoveCalls", "()Z", "GetGetWantsAllOnMoveCallsHandler")]
			get {
				if (id_getWantsAllOnMoveCalls == IntPtr.Zero)
					id_getWantsAllOnMoveCalls = JNIEnv.GetMethodID (class_ref, "getWantsAllOnMoveCalls", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getWantsAllOnMoveCalls);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getWantsAllOnMoveCalls);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_close);
		}

		static Delegate cb_copyStringToBuffer_ILandroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetCopyStringToBuffer_ILandroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_copyStringToBuffer_ILandroid_database_CharArrayBuffer_ == null)
				cb_copyStringToBuffer_ILandroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_CopyStringToBuffer_ILandroid_database_CharArrayBuffer_);
			return cb_copyStringToBuffer_ILandroid_database_CharArrayBuffer_;
		}

		static void n_CopyStringToBuffer_ILandroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p1 = Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CopyStringToBuffer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_copyStringToBuffer_ILandroid_database_CharArrayBuffer_;
		[Register ("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", "GetCopyStringToBuffer_ILandroid_database_CharArrayBuffer_Handler")]
		public virtual void CopyStringToBuffer (int p0, global::Android.Database.CharArrayBuffer p1)
		{
			if (id_copyStringToBuffer_ILandroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_copyStringToBuffer_ILandroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_copyStringToBuffer_ILandroid_database_CharArrayBuffer_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_copyStringToBuffer_ILandroid_database_CharArrayBuffer_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_deactivate;
#pragma warning disable 0169
		static Delegate GetDeactivateHandler ()
		{
			if (cb_deactivate == null)
				cb_deactivate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Deactivate);
			return cb_deactivate;
		}

		static void n_Deactivate (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deactivate ();
		}
#pragma warning restore 0169

		static IntPtr id_deactivate;
		[Register ("deactivate", "()V", "GetDeactivateHandler")]
		public virtual void Deactivate ()
		{
			if (id_deactivate == IntPtr.Zero)
				id_deactivate = JNIEnv.GetMethodID (class_ref, "deactivate", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_deactivate);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_deactivate);
		}

		static Delegate cb_getBlob_I;
#pragma warning disable 0169
		static Delegate GetGetBlob_IHandler ()
		{
			if (cb_getBlob_I == null)
				cb_getBlob_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetBlob_I);
			return cb_getBlob_I;
		}

		static IntPtr n_GetBlob_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBlob (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getBlob_I;
		[Register ("getBlob", "(I)[B", "GetGetBlob_IHandler")]
		public virtual byte[] GetBlob (int p0)
		{
			if (id_getBlob_I == IntPtr.Zero)
				id_getBlob_I = JNIEnv.GetMethodID (class_ref, "getBlob", "(I)[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBlob_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getBlob_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getColumnIndex_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetColumnIndex_Ljava_lang_String_Handler ()
		{
			if (cb_getColumnIndex_Ljava_lang_String_ == null)
				cb_getColumnIndex_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetColumnIndex_Ljava_lang_String_);
			return cb_getColumnIndex_Ljava_lang_String_;
		}

		static int n_GetColumnIndex_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetColumnIndex (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getColumnIndex_Ljava_lang_String_;
		[Register ("getColumnIndex", "(Ljava/lang/String;)I", "GetGetColumnIndex_Ljava_lang_String_Handler")]
		public virtual int GetColumnIndex (string p0)
		{
			if (id_getColumnIndex_Ljava_lang_String_ == IntPtr.Zero)
				id_getColumnIndex_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getColumnIndex", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getColumnIndex_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getColumnIndex_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getColumnIndexOrThrow_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetColumnIndexOrThrow_Ljava_lang_String_Handler ()
		{
			if (cb_getColumnIndexOrThrow_Ljava_lang_String_ == null)
				cb_getColumnIndexOrThrow_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetColumnIndexOrThrow_Ljava_lang_String_);
			return cb_getColumnIndexOrThrow_Ljava_lang_String_;
		}

		static int n_GetColumnIndexOrThrow_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetColumnIndexOrThrow (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getColumnIndexOrThrow_Ljava_lang_String_;
		[Register ("getColumnIndexOrThrow", "(Ljava/lang/String;)I", "GetGetColumnIndexOrThrow_Ljava_lang_String_Handler")]
		public virtual int GetColumnIndexOrThrow (string p0)
		{
			if (id_getColumnIndexOrThrow_Ljava_lang_String_ == IntPtr.Zero)
				id_getColumnIndexOrThrow_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getColumnIndexOrThrow_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getColumnIndexOrThrow_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getColumnName_I;
#pragma warning disable 0169
		static Delegate GetGetColumnName_IHandler ()
		{
			if (cb_getColumnName_I == null)
				cb_getColumnName_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetColumnName_I);
			return cb_getColumnName_I;
		}

		static IntPtr n_GetColumnName_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetColumnName (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getColumnName_I;
		[Register ("getColumnName", "(I)Ljava/lang/String;", "GetGetColumnName_IHandler")]
		public virtual string GetColumnName (int p0)
		{
			if (id_getColumnName_I == IntPtr.Zero)
				id_getColumnName_I = JNIEnv.GetMethodID (class_ref, "getColumnName", "(I)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getColumnName_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getColumnName_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getColumnNames;
#pragma warning disable 0169
		static Delegate GetGetColumnNamesHandler ()
		{
			if (cb_getColumnNames == null)
				cb_getColumnNames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColumnNames);
			return cb_getColumnNames;
		}

		static IntPtr n_GetColumnNames (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetColumnNames ());
		}
#pragma warning restore 0169

		static IntPtr id_getColumnNames;
		[Register ("getColumnNames", "()[Ljava/lang/String;", "GetGetColumnNamesHandler")]
		public virtual string[] GetColumnNames ()
		{
			if (id_getColumnNames == IntPtr.Zero)
				id_getColumnNames = JNIEnv.GetMethodID (class_ref, "getColumnNames", "()[Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getColumnNames), JniHandleOwnership.TransferLocalRef, typeof (string));
			else
				return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getColumnNames), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_getDouble_I;
#pragma warning disable 0169
		static Delegate GetGetDouble_IHandler ()
		{
			if (cb_getDouble_I == null)
				cb_getDouble_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetDouble_I);
			return cb_getDouble_I;
		}

		static double n_GetDouble_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDouble (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDouble_I;
		[Register ("getDouble", "(I)D", "GetGetDouble_IHandler")]
		public virtual double GetDouble (int p0)
		{
			if (id_getDouble_I == IntPtr.Zero)
				id_getDouble_I = JNIEnv.GetMethodID (class_ref, "getDouble", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getDouble_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getDouble_I, new JValue (p0));
		}

		static Delegate cb_getFloat_I;
#pragma warning disable 0169
		static Delegate GetGetFloat_IHandler ()
		{
			if (cb_getFloat_I == null)
				cb_getFloat_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float>) n_GetFloat_I);
			return cb_getFloat_I;
		}

		static float n_GetFloat_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetFloat (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getFloat_I;
		[Register ("getFloat", "(I)F", "GetGetFloat_IHandler")]
		public virtual float GetFloat (int p0)
		{
			if (id_getFloat_I == IntPtr.Zero)
				id_getFloat_I = JNIEnv.GetMethodID (class_ref, "getFloat", "(I)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_getFloat_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getFloat_I, new JValue (p0));
		}

		static Delegate cb_getInt_I;
#pragma warning disable 0169
		static Delegate GetGetInt_IHandler ()
		{
			if (cb_getInt_I == null)
				cb_getInt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetInt_I);
			return cb_getInt_I;
		}

		static int n_GetInt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetInt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getInt_I;
		[Register ("getInt", "(I)I", "GetGetInt_IHandler")]
		public virtual int GetInt (int p0)
		{
			if (id_getInt_I == IntPtr.Zero)
				id_getInt_I = JNIEnv.GetMethodID (class_ref, "getInt", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getInt_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getInt_I, new JValue (p0));
		}

		static Delegate cb_getLong_I;
#pragma warning disable 0169
		static Delegate GetGetLong_IHandler ()
		{
			if (cb_getLong_I == null)
				cb_getLong_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetLong_I);
			return cb_getLong_I;
		}

		static long n_GetLong_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLong (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getLong_I;
		[Register ("getLong", "(I)J", "GetGetLong_IHandler")]
		public virtual long GetLong (int p0)
		{
			if (id_getLong_I == IntPtr.Zero)
				id_getLong_I = JNIEnv.GetMethodID (class_ref, "getLong", "(I)J");

			if (GetType () == ThresholdType)
				return JNIEnv.CallLongMethod  (Handle, id_getLong_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getLong_I, new JValue (p0));
		}

		static Delegate cb_getShort_I;
#pragma warning disable 0169
		static Delegate GetGetShort_IHandler ()
		{
			if (cb_getShort_I == null)
				cb_getShort_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, short>) n_GetShort_I);
			return cb_getShort_I;
		}

		static short n_GetShort_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetShort (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getShort_I;
		[Register ("getShort", "(I)S", "GetGetShort_IHandler")]
		public virtual short GetShort (int p0)
		{
			if (id_getShort_I == IntPtr.Zero)
				id_getShort_I = JNIEnv.GetMethodID (class_ref, "getShort", "(I)S");

			if (GetType () == ThresholdType)
				return JNIEnv.CallShortMethod  (Handle, id_getShort_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, id_getShort_I, new JValue (p0));
		}

		static Delegate cb_getString_I;
#pragma warning disable 0169
		static Delegate GetGetString_IHandler ()
		{
			if (cb_getString_I == null)
				cb_getString_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetString_I);
			return cb_getString_I;
		}

		static IntPtr n_GetString_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetString (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getString_I;
		[Register ("getString", "(I)Ljava/lang/String;", "GetGetString_IHandler")]
		public virtual string GetString (int p0)
		{
			if (id_getString_I == IntPtr.Zero)
				id_getString_I = JNIEnv.GetMethodID (class_ref, "getString", "(I)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getString_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isNull_I;
#pragma warning disable 0169
		static Delegate GetIsNull_IHandler ()
		{
			if (cb_isNull_I == null)
				cb_isNull_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsNull_I);
			return cb_isNull_I;
		}

		static bool n_IsNull_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNull (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isNull_I;
		[Register ("isNull", "(I)Z", "GetIsNull_IHandler")]
		public virtual bool IsNull (int p0)
		{
			if (id_isNull_I == IntPtr.Zero)
				id_isNull_I = JNIEnv.GetMethodID (class_ref, "isNull", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_isNull_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isNull_I, new JValue (p0));
		}

		static Delegate cb_move_I;
#pragma warning disable 0169
		static Delegate GetMove_IHandler ()
		{
			if (cb_move_I == null)
				cb_move_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Move_I);
			return cb_move_I;
		}

		static bool n_Move_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Move (p0);
		}
#pragma warning restore 0169

		static IntPtr id_move_I;
		[Register ("move", "(I)Z", "GetMove_IHandler")]
		public virtual bool Move (int p0)
		{
			if (id_move_I == IntPtr.Zero)
				id_move_I = JNIEnv.GetMethodID (class_ref, "move", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_move_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_move_I, new JValue (p0));
		}

		static Delegate cb_moveToFirst;
#pragma warning disable 0169
		static Delegate GetMoveToFirstHandler ()
		{
			if (cb_moveToFirst == null)
				cb_moveToFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_MoveToFirst);
			return cb_moveToFirst;
		}

		static bool n_MoveToFirst (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MoveToFirst ();
		}
#pragma warning restore 0169

		static IntPtr id_moveToFirst;
		[Register ("moveToFirst", "()Z", "GetMoveToFirstHandler")]
		public virtual bool MoveToFirst ()
		{
			if (id_moveToFirst == IntPtr.Zero)
				id_moveToFirst = JNIEnv.GetMethodID (class_ref, "moveToFirst", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_moveToFirst);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_moveToFirst);
		}

		static Delegate cb_moveToLast;
#pragma warning disable 0169
		static Delegate GetMoveToLastHandler ()
		{
			if (cb_moveToLast == null)
				cb_moveToLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_MoveToLast);
			return cb_moveToLast;
		}

		static bool n_MoveToLast (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MoveToLast ();
		}
#pragma warning restore 0169

		static IntPtr id_moveToLast;
		[Register ("moveToLast", "()Z", "GetMoveToLastHandler")]
		public virtual bool MoveToLast ()
		{
			if (id_moveToLast == IntPtr.Zero)
				id_moveToLast = JNIEnv.GetMethodID (class_ref, "moveToLast", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_moveToLast);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_moveToLast);
		}

		static Delegate cb_moveToNext;
#pragma warning disable 0169
		static Delegate GetMoveToNextHandler ()
		{
			if (cb_moveToNext == null)
				cb_moveToNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_MoveToNext);
			return cb_moveToNext;
		}

		static bool n_MoveToNext (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MoveToNext ();
		}
#pragma warning restore 0169

		static IntPtr id_moveToNext;
		[Register ("moveToNext", "()Z", "GetMoveToNextHandler")]
		public virtual bool MoveToNext ()
		{
			if (id_moveToNext == IntPtr.Zero)
				id_moveToNext = JNIEnv.GetMethodID (class_ref, "moveToNext", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_moveToNext);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_moveToNext);
		}

		static Delegate cb_moveToPosition_I;
#pragma warning disable 0169
		static Delegate GetMoveToPosition_IHandler ()
		{
			if (cb_moveToPosition_I == null)
				cb_moveToPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_MoveToPosition_I);
			return cb_moveToPosition_I;
		}

		static bool n_MoveToPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MoveToPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_moveToPosition_I;
		[Register ("moveToPosition", "(I)Z", "GetMoveToPosition_IHandler")]
		public virtual bool MoveToPosition (int p0)
		{
			if (id_moveToPosition_I == IntPtr.Zero)
				id_moveToPosition_I = JNIEnv.GetMethodID (class_ref, "moveToPosition", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_moveToPosition_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_moveToPosition_I, new JValue (p0));
		}

		static Delegate cb_moveToPrevious;
#pragma warning disable 0169
		static Delegate GetMoveToPreviousHandler ()
		{
			if (cb_moveToPrevious == null)
				cb_moveToPrevious = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_MoveToPrevious);
			return cb_moveToPrevious;
		}

		static bool n_MoveToPrevious (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MoveToPrevious ();
		}
#pragma warning restore 0169

		static IntPtr id_moveToPrevious;
		[Register ("moveToPrevious", "()Z", "GetMoveToPreviousHandler")]
		public virtual bool MoveToPrevious ()
		{
			if (id_moveToPrevious == IntPtr.Zero)
				id_moveToPrevious = JNIEnv.GetMethodID (class_ref, "moveToPrevious", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_moveToPrevious);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_moveToPrevious);
		}

		static Delegate cb_registerContentObserver_Landroid_database_ContentObserver_;
#pragma warning disable 0169
		static Delegate GetRegisterContentObserver_Landroid_database_ContentObserver_Handler ()
		{
			if (cb_registerContentObserver_Landroid_database_ContentObserver_ == null)
				cb_registerContentObserver_Landroid_database_ContentObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterContentObserver_Landroid_database_ContentObserver_);
			return cb_registerContentObserver_Landroid_database_ContentObserver_;
		}

		static void n_RegisterContentObserver_Landroid_database_ContentObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ContentObserver p0 = Java.Lang.Object.GetObject<global::Android.Database.ContentObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterContentObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerContentObserver_Landroid_database_ContentObserver_;
		[Register ("registerContentObserver", "(Landroid/database/ContentObserver;)V", "GetRegisterContentObserver_Landroid_database_ContentObserver_Handler")]
		public virtual void RegisterContentObserver (global::Android.Database.ContentObserver p0)
		{
			if (id_registerContentObserver_Landroid_database_ContentObserver_ == IntPtr.Zero)
				id_registerContentObserver_Landroid_database_ContentObserver_ = JNIEnv.GetMethodID (class_ref, "registerContentObserver", "(Landroid/database/ContentObserver;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_registerContentObserver_Landroid_database_ContentObserver_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_registerContentObserver_Landroid_database_ContentObserver_, new JValue (p0));
		}

		static Delegate cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
#pragma warning disable 0169
		static Delegate GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler ()
		{
			if (cb_registerDataSetObserver_Landroid_database_DataSetObserver_ == null)
				cb_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterDataSetObserver_Landroid_database_DataSetObserver_);
			return cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
		}

		static void n_RegisterDataSetObserver_Landroid_database_DataSetObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.DataSetObserver p0 = Java.Lang.Object.GetObject<global::Android.Database.DataSetObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterDataSetObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerDataSetObserver_Landroid_database_DataSetObserver_;
		[Register ("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", "GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler")]
		public virtual void RegisterDataSetObserver (global::Android.Database.DataSetObserver p0)
		{
			if (id_registerDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
				id_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID (class_ref, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_registerDataSetObserver_Landroid_database_DataSetObserver_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_registerDataSetObserver_Landroid_database_DataSetObserver_, new JValue (p0));
		}

		static Delegate cb_replaceCursor_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetReplaceCursor_Landroid_database_Cursor_Handler ()
		{
			if (cb_replaceCursor_Landroid_database_Cursor_ == null)
				cb_replaceCursor_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReplaceCursor_Landroid_database_Cursor_);
			return cb_replaceCursor_Landroid_database_Cursor_;
		}

		static void n_ReplaceCursor_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReplaceCursor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_replaceCursor_Landroid_database_Cursor_;
		[Register ("replaceCursor", "(Landroid/database/Cursor;)V", "GetReplaceCursor_Landroid_database_Cursor_Handler")]
		protected virtual void ReplaceCursor (global::Android.Database.ICursor p0)
		{
			if (id_replaceCursor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_replaceCursor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "replaceCursor", "(Landroid/database/Cursor;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_replaceCursor_Landroid_database_Cursor_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_replaceCursor_Landroid_database_Cursor_, new JValue (p0));
		}

		static Delegate cb_requery;
#pragma warning disable 0169
		static Delegate GetRequeryHandler ()
		{
			if (cb_requery == null)
				cb_requery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Requery);
			return cb_requery;
		}

		static bool n_Requery (IntPtr jnienv, IntPtr native__this)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Requery ();
		}
#pragma warning restore 0169

		static IntPtr id_requery;
		[Register ("requery", "()Z", "GetRequeryHandler")]
		public virtual bool Requery ()
		{
			if (id_requery == IntPtr.Zero)
				id_requery = JNIEnv.GetMethodID (class_ref, "requery", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_requery);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_requery);
		}

		static Delegate cb_respond_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRespond_Landroid_os_Bundle_Handler ()
		{
			if (cb_respond_Landroid_os_Bundle_ == null)
				cb_respond_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Respond_Landroid_os_Bundle_);
			return cb_respond_Landroid_os_Bundle_;
		}

		static IntPtr n_Respond_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Respond (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_respond_Landroid_os_Bundle_;
		[Register ("respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetRespond_Landroid_os_Bundle_Handler")]
		public virtual global::Android.OS.Bundle Respond (global::Android.OS.Bundle p0)
		{
			if (id_respond_Landroid_os_Bundle_ == IntPtr.Zero)
				id_respond_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");

			global::Android.OS.Bundle __ret;
			if (GetType () == ThresholdType)
				__ret = Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_respond_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_respond_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_Handler ()
		{
			if (cb_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_ == null)
				cb_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_);
			return cb_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_;
		}

		static void n_SetNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentResolver p0 = Java.Lang.Object.GetObject<global::Android.Content.ContentResolver> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetNotificationUri (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_;
		[Register ("setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", "GetSetNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_Handler")]
		public virtual void SetNotificationUri (global::Android.Content.ContentResolver p0, global::Android.Net.Uri p1)
		{
			if (id_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_ == IntPtr.Zero)
				id_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
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
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
#pragma warning disable 0169
		static Delegate GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler ()
		{
			if (cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == null)
				cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_);
			return cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		}

		static void n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UACursorWrapper __this = Java.Lang.Object.GetObject<UACursorWrapper> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.DataSetObserver p0 = Java.Lang.Object.GetObject<global::Android.Database.DataSetObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterDataSetObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		[Register ("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", "GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler")]
		public virtual void UnregisterDataSetObserver (global::Android.Database.DataSetObserver p0)
		{
			if (id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
				id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID (class_ref, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_unregisterDataSetObserver_Landroid_database_DataSetObserver_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_unregisterDataSetObserver_Landroid_database_DataSetObserver_, new JValue (p0));
		}

	}
}
