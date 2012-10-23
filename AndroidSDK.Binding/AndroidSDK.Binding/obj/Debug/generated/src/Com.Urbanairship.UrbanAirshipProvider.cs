using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship {

	[global::Android.Runtime.Register ("com/urbanairship/UrbanAirshipProvider", DoNotGenerateAcw=true)]
	public partial class UrbanAirshipProvider : global::Android.Content.ContentProvider {


		[Register ("COLUMN_NAME_KEY")]
		public const string ColumnNameKey = (string) "_id";

		[Register ("COLUMN_NAME_TIMESTAMP")]
		public const string ColumnNameTimestamp = (string) "timestamp";

		[Register ("DB_CHANGE_ACTION_KEY")]
		public const string DbChangeActionKey = (string) "com.urbanairship.DB_CHANGE_ACTION";

		[Register ("DB_CHANGE_KEYS_KEY")]
		public const string DbChangeKeysKey = (string) "com.urbanairship.DB_CHANGE_KEYS";

		[Register ("DELETE_ACTION")]
		public const string DeleteAction = (string) "delete";

		[Register ("INSERT_ACTION")]
		public const string InsertAction = (string) "insert";

		[Register ("KEYS_DELIMITER")]
		public const string KeysDelimiter = (string) "|";

		[Register ("REPLACE_ACTION")]
		public const string ReplaceAction = (string) "replace";

		[Register ("UPDATE_ACTION")]
		public const string UpdateAction = (string) "update";
		[global::Android.Runtime.Register ("com/urbanairship/UrbanAirshipProvider$DatabaseHelper", DoNotGenerateAcw=true)]
		public partial class DatabaseHelper : global::Android.Database.Sqlite.SQLiteOpenHelper {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/UrbanAirshipProvider$DatabaseHelper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DatabaseHelper); }
			}

			protected DatabaseHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_ILjava_lang_String_;
			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;ILjava/lang/String;)V", "")]
			public DatabaseHelper (global::Android.Content.Context p0, string p1, int p2, string p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				IntPtr native_p3 = JNIEnv.NewString (p3);;
				if (GetType () != typeof (DatabaseHelper)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;ILjava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p3);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;ILjava/lang/String;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_ILjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}

			static Delegate cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
#pragma warning disable 0169
			static Delegate GetOnCreate_Landroid_database_sqlite_SQLiteDatabase_Handler ()
			{
				if (cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == null)
					cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_database_sqlite_SQLiteDatabase_);
				return cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
			}

			static void n_OnCreate_Landroid_database_sqlite_SQLiteDatabase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				DatabaseHelper __this = Java.Lang.Object.GetObject<DatabaseHelper> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCreate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
			[Register ("onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", "GetOnCreate_Landroid_database_sqlite_SQLiteDatabase_Handler")]
			public override void OnCreate (global::Android.Database.Sqlite.SQLiteDatabase p0)
			{
				if (id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
					id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onCreate_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
			}

			static Delegate cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
#pragma warning disable 0169
			static Delegate GetOnUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler ()
			{
				if (cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == null)
					cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnUpgrade_Landroid_database_sqlite_SQLiteDatabase_II);
				return cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
			}

			static void n_OnUpgrade_Landroid_database_sqlite_SQLiteDatabase_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				DatabaseHelper __this = Java.Lang.Object.GetObject<DatabaseHelper> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUpgrade (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
			[Register ("onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", "GetOnUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler")]
			public override void OnUpgrade (global::Android.Database.Sqlite.SQLiteDatabase p0, int p1, int p2)
			{
				if (id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == IntPtr.Zero)
					id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNIEnv.GetMethodID (class_ref, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II, new JValue (p0), new JValue (p1), new JValue (p2));
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/UrbanAirshipProvider$DatabaseModel", DoNotGenerateAcw=true)]
		public abstract partial class DatabaseModel : global::Java.Lang.Object {


			static IntPtr COLUMN_NAME_KEY_INDEX_jfieldId;

			[Register ("COLUMN_NAME_KEY_INDEX")]
			protected int ColumnNameKeyIndex {
				get {
					if (COLUMN_NAME_KEY_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_KEY_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_KEY_INDEX", "I");
					return JNIEnv.GetIntField (Handle, COLUMN_NAME_KEY_INDEX_jfieldId);
				}
				set {
					if (COLUMN_NAME_KEY_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_KEY_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_KEY_INDEX", "I");
					JNIEnv.SetField (Handle, COLUMN_NAME_KEY_INDEX_jfieldId, value);
				}
			}

			static IntPtr COLUMN_NAME_TIMESTAMP_INDEX_jfieldId;

			[Register ("COLUMN_NAME_TIMESTAMP_INDEX")]
			protected int ColumnNameTimestampIndex {
				get {
					if (COLUMN_NAME_TIMESTAMP_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_TIMESTAMP_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_TIMESTAMP_INDEX", "I");
					return JNIEnv.GetIntField (Handle, COLUMN_NAME_TIMESTAMP_INDEX_jfieldId);
				}
				set {
					if (COLUMN_NAME_TIMESTAMP_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_TIMESTAMP_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_TIMESTAMP_INDEX", "I");
					JNIEnv.SetField (Handle, COLUMN_NAME_TIMESTAMP_INDEX_jfieldId, value);
				}
			}

			static IntPtr dbHelper_jfieldId;

			[Register ("dbHelper")]
			protected global::Com.Urbanairship.UrbanAirshipProvider.DatabaseHelper DbHelper {
				get {
					if (dbHelper_jfieldId == IntPtr.Zero)
						dbHelper_jfieldId = JNIEnv.GetFieldID (class_ref, "dbHelper", "Lcom/urbanairship/UrbanAirshipProvider$DatabaseHelper;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, dbHelper_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.UrbanAirshipProvider.DatabaseHelper> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (dbHelper_jfieldId == IntPtr.Zero)
						dbHelper_jfieldId = JNIEnv.GetFieldID (class_ref, "dbHelper", "Lcom/urbanairship/UrbanAirshipProvider$DatabaseHelper;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, dbHelper_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/UrbanAirshipProvider$DatabaseModel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DatabaseModel); }
			}

			protected DatabaseModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_urbanairship_UrbanAirshipProvider_;
			[Register (".ctor", "(Lcom/urbanairship/UrbanAirshipProvider;)V", "")]
			public DatabaseModel (global::Com.Urbanairship.UrbanAirshipProvider __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (DatabaseModel)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_urbanairship_UrbanAirshipProvider_ == IntPtr.Zero)
					id_ctor_Lcom_urbanairship_UrbanAirshipProvider_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/UrbanAirshipProvider;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_UrbanAirshipProvider_, new JValue (__self)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_getBaseUri;
#pragma warning disable 0169
			static Delegate GetGetBaseUriHandler ()
			{
				if (cb_getBaseUri == null)
					cb_getBaseUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseUri);
				return cb_getBaseUri;
			}

			static IntPtr n_GetBaseUri (IntPtr jnienv, IntPtr native__this)
			{
				DatabaseModel __this = Java.Lang.Object.GetObject<DatabaseModel> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BaseUri);
			}
#pragma warning restore 0169

			public abstract global::Android.Net.Uri BaseUri { [Register ("getBaseUri", "()Landroid/net/Uri;", "GetGetBaseUriHandler")] get; }

			static Delegate cb_getNotificationColumnName;
#pragma warning disable 0169
			static Delegate GetGetNotificationColumnNameHandler ()
			{
				if (cb_getNotificationColumnName == null)
					cb_getNotificationColumnName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationColumnName);
				return cb_getNotificationColumnName;
			}

			static IntPtr n_GetNotificationColumnName (IntPtr jnienv, IntPtr native__this)
			{
				DatabaseModel __this = Java.Lang.Object.GetObject<DatabaseModel> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.NotificationColumnName);
			}
#pragma warning restore 0169

			static IntPtr id_getNotificationColumnName;
			public virtual string NotificationColumnName {
				[Register ("getNotificationColumnName", "()Ljava/lang/String;", "GetGetNotificationColumnNameHandler")]
				get {
					if (id_getNotificationColumnName == IntPtr.Zero)
						id_getNotificationColumnName = JNIEnv.GetMethodID (class_ref, "getNotificationColumnName", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNotificationColumnName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getNotificationColumnName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getReadableDatabase;
#pragma warning disable 0169
			static Delegate GetGetReadableDatabaseHandler ()
			{
				if (cb_getReadableDatabase == null)
					cb_getReadableDatabase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReadableDatabase);
				return cb_getReadableDatabase;
			}

			static IntPtr n_GetReadableDatabase (IntPtr jnienv, IntPtr native__this)
			{
				DatabaseModel __this = Java.Lang.Object.GetObject<DatabaseModel> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ReadableDatabase);
			}
#pragma warning restore 0169

			static IntPtr id_getReadableDatabase;
			public virtual global::Android.Database.Sqlite.SQLiteDatabase ReadableDatabase {
				[Register ("getReadableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", "GetGetReadableDatabaseHandler")]
				get {
					if (id_getReadableDatabase == IntPtr.Zero)
						id_getReadableDatabase = JNIEnv.GetMethodID (class_ref, "getReadableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;");

					if (GetType () == ThresholdType)
						return Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallObjectMethod  (Handle, id_getReadableDatabase), JniHandleOwnership.TransferLocalRef);
					else
						return Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getReadableDatabase), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getTableName;
#pragma warning disable 0169
			static Delegate GetGetTableNameHandler ()
			{
				if (cb_getTableName == null)
					cb_getTableName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTableName);
				return cb_getTableName;
			}

			static IntPtr n_GetTableName (IntPtr jnienv, IntPtr native__this)
			{
				DatabaseModel __this = Java.Lang.Object.GetObject<DatabaseModel> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.TableName);
			}
#pragma warning restore 0169

			public abstract string TableName { [Register ("getTableName", "()Ljava/lang/String;", "GetGetTableNameHandler")] get; }

			static Delegate cb_getWritableDatabase;
#pragma warning disable 0169
			static Delegate GetGetWritableDatabaseHandler ()
			{
				if (cb_getWritableDatabase == null)
					cb_getWritableDatabase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWritableDatabase);
				return cb_getWritableDatabase;
			}

			static IntPtr n_GetWritableDatabase (IntPtr jnienv, IntPtr native__this)
			{
				DatabaseModel __this = Java.Lang.Object.GetObject<DatabaseModel> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.WritableDatabase);
			}
#pragma warning restore 0169

			static IntPtr id_getWritableDatabase;
			public virtual global::Android.Database.Sqlite.SQLiteDatabase WritableDatabase {
				[Register ("getWritableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", "GetGetWritableDatabaseHandler")]
				get {
					if (id_getWritableDatabase == IntPtr.Zero)
						id_getWritableDatabase = JNIEnv.GetMethodID (class_ref, "getWritableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;");

					if (GetType () == ThresholdType)
						return Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallObjectMethod  (Handle, id_getWritableDatabase), JniHandleOwnership.TransferLocalRef);
					else
						return Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getWritableDatabase), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_bindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_;
#pragma warning disable 0169
			static Delegate GetBindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_Handler ()
			{
				if (cb_bindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_ == null)
					cb_bindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_BindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_);
				return cb_bindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_;
			}

			static void n_BindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				DatabaseModel __this = Java.Lang.Object.GetObject<DatabaseModel> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.DatabaseUtils.InsertHelper p0 = Java.Lang.Object.GetObject<global::Android.Database.DatabaseUtils.InsertHelper> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.ContentValues p1 = Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.BindValuesToInsertHelper (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_bindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_;
			[Register ("bindValuesToInsertHelper", "(Landroid/database/DatabaseUtils$InsertHelper;Landroid/content/ContentValues;)V", "GetBindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_Handler")]
			public virtual void BindValuesToInsertHelper (global::Android.Database.DatabaseUtils.InsertHelper p0, global::Android.Content.ContentValues p1)
			{
				if (id_bindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_ == IntPtr.Zero)
					id_bindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "bindValuesToInsertHelper", "(Landroid/database/DatabaseUtils$InsertHelper;Landroid/content/ContentValues;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_bindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_bindValuesToInsertHelper_Landroid_database_DatabaseUtils_InsertHelper_Landroid_content_ContentValues_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_findColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_;
#pragma warning disable 0169
			static Delegate GetFindColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_Handler ()
			{
				if (cb_findColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_ == null)
					cb_findColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FindColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_);
				return cb_findColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_;
			}

			static void n_FindColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				DatabaseModel __this = Java.Lang.Object.GetObject<DatabaseModel> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.DatabaseUtils.InsertHelper p0 = Java.Lang.Object.GetObject<global::Android.Database.DatabaseUtils.InsertHelper> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.FindColumnIndexes (p0);
			}
#pragma warning restore 0169

			static IntPtr id_findColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_;
			[Register ("findColumnIndexes", "(Landroid/database/DatabaseUtils$InsertHelper;)V", "GetFindColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_Handler")]
			public virtual void FindColumnIndexes (global::Android.Database.DatabaseUtils.InsertHelper p0)
			{
				if (id_findColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_ == IntPtr.Zero)
					id_findColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_ = JNIEnv.GetMethodID (class_ref, "findColumnIndexes", "(Landroid/database/DatabaseUtils$InsertHelper;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_findColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_findColumnIndexes_Landroid_database_DatabaseUtils_InsertHelper_, new JValue (p0));
			}

			static Delegate cb_getInsertHelper_Landroid_database_sqlite_SQLiteDatabase_;
#pragma warning disable 0169
			static Delegate GetGetInsertHelper_Landroid_database_sqlite_SQLiteDatabase_Handler ()
			{
				if (cb_getInsertHelper_Landroid_database_sqlite_SQLiteDatabase_ == null)
					cb_getInsertHelper_Landroid_database_sqlite_SQLiteDatabase_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInsertHelper_Landroid_database_sqlite_SQLiteDatabase_);
				return cb_getInsertHelper_Landroid_database_sqlite_SQLiteDatabase_;
			}

			static IntPtr n_GetInsertHelper_Landroid_database_sqlite_SQLiteDatabase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				DatabaseModel __this = Java.Lang.Object.GetObject<DatabaseModel> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInsertHelper (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getInsertHelper_Landroid_database_sqlite_SQLiteDatabase_;
			[Register ("getInsertHelper", "(Landroid/database/sqlite/SQLiteDatabase;)Landroid/database/DatabaseUtils$InsertHelper;", "GetGetInsertHelper_Landroid_database_sqlite_SQLiteDatabase_Handler")]
			public virtual global::Android.Database.DatabaseUtils.InsertHelper GetInsertHelper (global::Android.Database.Sqlite.SQLiteDatabase p0)
			{
				if (id_getInsertHelper_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
					id_getInsertHelper_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "getInsertHelper", "(Landroid/database/sqlite/SQLiteDatabase;)Landroid/database/DatabaseUtils$InsertHelper;");

				global::Android.Database.DatabaseUtils.InsertHelper __ret;
				if (GetType () == ThresholdType)
					__ret = Java.Lang.Object.GetObject<global::Android.Database.DatabaseUtils.InsertHelper> (JNIEnv.CallObjectMethod  (Handle, id_getInsertHelper_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = Java.Lang.Object.GetObject<global::Android.Database.DatabaseUtils.InsertHelper> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getInsertHelper_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_notify_arrayLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetNotify_arrayLjava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_notify_arrayLjava_lang_String_Ljava_lang_String_ == null)
					cb_notify_arrayLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Notify_arrayLjava_lang_String_Ljava_lang_String_);
				return cb_notify_arrayLjava_lang_String_Ljava_lang_String_;
			}

			static void n_Notify_arrayLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				DatabaseModel __this = Java.Lang.Object.GetObject<DatabaseModel> (native__this, JniHandleOwnership.DoNotTransfer);
				string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Notify (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			static IntPtr id_notify_arrayLjava_lang_String_Ljava_lang_String_;
			[Register ("notify", "([Ljava/lang/String;Ljava/lang/String;)V", "GetNotify_arrayLjava_lang_String_Ljava_lang_String_Handler")]
			public virtual void Notify (string[] p0, string p1)
			{
				if (id_notify_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_notify_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notify", "([Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notify_arrayLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notify_arrayLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/UrbanAirshipProvider$DatabaseModel", DoNotGenerateAcw=true)]
		internal partial class DatabaseModelInvoker : DatabaseModel {

			public DatabaseModelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (DatabaseModelInvoker); }
			}

			static IntPtr id_getBaseUri;
			public override global::Android.Net.Uri BaseUri {
				[Register ("getBaseUri", "()Landroid/net/Uri;", "GetGetBaseUriHandler")]
				get {
					if (id_getBaseUri == IntPtr.Zero)
						id_getBaseUri = JNIEnv.GetMethodID (class_ref, "getBaseUri", "()Landroid/net/Uri;");
					return Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getBaseUri), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getTableName;
			public override string TableName {
				[Register ("getTableName", "()Ljava/lang/String;", "GetGetTableNameHandler")]
				get {
					if (id_getTableName == IntPtr.Zero)
						id_getTableName = JNIEnv.GetMethodID (class_ref, "getTableName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTableName), JniHandleOwnership.TransferLocalRef);
				}
			}

		}


		[global::Android.Runtime.Register ("com/urbanairship/UrbanAirshipProvider$Preferences", DoNotGenerateAcw=true)]
		public partial class Preferences : global::Com.Urbanairship.UrbanAirshipProvider.DatabaseModel {


			[Register ("COLUMN_NAME_VALUE")]
			public const string ColumnNameValue = (string) "value";

			static IntPtr COLUMN_NAME_VALUE_INDEX_jfieldId;

			[Register ("COLUMN_NAME_VALUE_INDEX")]
			protected int ColumnNameValueIndex {
				get {
					if (COLUMN_NAME_VALUE_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_VALUE_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_VALUE_INDEX", "I");
					return JNIEnv.GetIntField (Handle, COLUMN_NAME_VALUE_INDEX_jfieldId);
				}
				set {
					if (COLUMN_NAME_VALUE_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_VALUE_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_VALUE_INDEX", "I");
					JNIEnv.SetField (Handle, COLUMN_NAME_VALUE_INDEX_jfieldId, value);
				}
			}

			[Register ("CONTENT_ITEM_TYPE")]
			public const string ContentItemType = (string) "vnd.urbanairship.cursor.item/preference";

			[Register ("CONTENT_TYPE")]
			public const string ContentType = (string) "vnd.urbanairship.cursor.dir/preference";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/UrbanAirshipProvider$Preferences", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Preferences); }
			}

			protected Preferences (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_urbanairship_UrbanAirshipProvider_Landroid_content_Context_;
			[Register (".ctor", "(Lcom/urbanairship/UrbanAirshipProvider;Landroid/content/Context;)V", "")]
			public Preferences (global::Com.Urbanairship.UrbanAirshipProvider __self, global::Android.Content.Context p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Preferences)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", new JValue (__self), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_urbanairship_UrbanAirshipProvider_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lcom_urbanairship_UrbanAirshipProvider_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/UrbanAirshipProvider;Landroid/content/Context;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_UrbanAirshipProvider_Landroid_content_Context_, new JValue (__self), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_getBaseUri;
#pragma warning disable 0169
			static Delegate GetGetBaseUriHandler ()
			{
				if (cb_getBaseUri == null)
					cb_getBaseUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseUri);
				return cb_getBaseUri;
			}

			static IntPtr n_GetBaseUri (IntPtr jnienv, IntPtr native__this)
			{
				Preferences __this = Java.Lang.Object.GetObject<Preferences> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BaseUri);
			}
#pragma warning restore 0169

			static IntPtr id_getBaseUri;
			public override global::Android.Net.Uri BaseUri {
				[Register ("getBaseUri", "()Landroid/net/Uri;", "GetGetBaseUriHandler")]
				get {
					if (id_getBaseUri == IntPtr.Zero)
						id_getBaseUri = JNIEnv.GetMethodID (class_ref, "getBaseUri", "()Landroid/net/Uri;");

					if (GetType () == ThresholdType)
						return Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getBaseUri), JniHandleOwnership.TransferLocalRef);
					else
						return Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getBaseUri), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getTableName;
#pragma warning disable 0169
			static Delegate GetGetTableNameHandler ()
			{
				if (cb_getTableName == null)
					cb_getTableName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTableName);
				return cb_getTableName;
			}

			static IntPtr n_GetTableName (IntPtr jnienv, IntPtr native__this)
			{
				Preferences __this = Java.Lang.Object.GetObject<Preferences> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.TableName);
			}
#pragma warning restore 0169

			static IntPtr id_getTableName;
			public override string TableName {
				[Register ("getTableName", "()Ljava/lang/String;", "GetGetTableNameHandler")]
				get {
					if (id_getTableName == IntPtr.Zero)
						id_getTableName = JNIEnv.GetMethodID (class_ref, "getTableName", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTableName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTableName), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/UrbanAirshipProvider$RichPush", DoNotGenerateAcw=true)]
		public partial class RichPush : global::Com.Urbanairship.UrbanAirshipProvider.DatabaseModel {


			[Register ("COLUMN_NAME_DELETED")]
			public const string ColumnNameDeleted = (string) "deleted";

			static IntPtr COLUMN_NAME_DELETED_INDEX_jfieldId;

			[Register ("COLUMN_NAME_DELETED_INDEX")]
			protected int ColumnNameDeletedIndex {
				get {
					if (COLUMN_NAME_DELETED_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_DELETED_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_DELETED_INDEX", "I");
					return JNIEnv.GetIntField (Handle, COLUMN_NAME_DELETED_INDEX_jfieldId);
				}
				set {
					if (COLUMN_NAME_DELETED_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_DELETED_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_DELETED_INDEX", "I");
					JNIEnv.SetField (Handle, COLUMN_NAME_DELETED_INDEX_jfieldId, value);
				}
			}

			[Register ("COLUMN_NAME_EXTRA")]
			public const string ColumnNameExtra = (string) "extra";

			static IntPtr COLUMN_NAME_EXTRA_INDEX_jfieldId;

			[Register ("COLUMN_NAME_EXTRA_INDEX")]
			protected int ColumnNameExtraIndex {
				get {
					if (COLUMN_NAME_EXTRA_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_EXTRA_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_EXTRA_INDEX", "I");
					return JNIEnv.GetIntField (Handle, COLUMN_NAME_EXTRA_INDEX_jfieldId);
				}
				set {
					if (COLUMN_NAME_EXTRA_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_EXTRA_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_EXTRA_INDEX", "I");
					JNIEnv.SetField (Handle, COLUMN_NAME_EXTRA_INDEX_jfieldId, value);
				}
			}

			[Register ("COLUMN_NAME_MESSAGE_BODY_URL")]
			public const string ColumnNameMessageBodyUrl = (string) "message_body_url";

			static IntPtr COLUMN_NAME_MESSAGE_BODY_URL_INDEX_jfieldId;

			[Register ("COLUMN_NAME_MESSAGE_BODY_URL_INDEX")]
			protected int ColumnNameMessageBodyUrlIndex {
				get {
					if (COLUMN_NAME_MESSAGE_BODY_URL_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_MESSAGE_BODY_URL_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_MESSAGE_BODY_URL_INDEX", "I");
					return JNIEnv.GetIntField (Handle, COLUMN_NAME_MESSAGE_BODY_URL_INDEX_jfieldId);
				}
				set {
					if (COLUMN_NAME_MESSAGE_BODY_URL_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_MESSAGE_BODY_URL_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_MESSAGE_BODY_URL_INDEX", "I");
					JNIEnv.SetField (Handle, COLUMN_NAME_MESSAGE_BODY_URL_INDEX_jfieldId, value);
				}
			}

			[Register ("COLUMN_NAME_MESSAGE_ID")]
			public const string ColumnNameMessageId = (string) "message_id";

			static IntPtr COLUMN_NAME_MESSAGE_ID_INDEX_jfieldId;

			[Register ("COLUMN_NAME_MESSAGE_ID_INDEX")]
			protected int ColumnNameMessageIdIndex {
				get {
					if (COLUMN_NAME_MESSAGE_ID_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_MESSAGE_ID_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_MESSAGE_ID_INDEX", "I");
					return JNIEnv.GetIntField (Handle, COLUMN_NAME_MESSAGE_ID_INDEX_jfieldId);
				}
				set {
					if (COLUMN_NAME_MESSAGE_ID_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_MESSAGE_ID_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_MESSAGE_ID_INDEX", "I");
					JNIEnv.SetField (Handle, COLUMN_NAME_MESSAGE_ID_INDEX_jfieldId, value);
				}
			}

			[Register ("COLUMN_NAME_MESSAGE_READ_URL")]
			public const string ColumnNameMessageReadUrl = (string) "message_read_url";

			static IntPtr COLUMN_NAME_MESSAGE_READ_URL_INDEX_jfieldId;

			[Register ("COLUMN_NAME_MESSAGE_READ_URL_INDEX")]
			protected int ColumnNameMessageReadUrlIndex {
				get {
					if (COLUMN_NAME_MESSAGE_READ_URL_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_MESSAGE_READ_URL_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_MESSAGE_READ_URL_INDEX", "I");
					return JNIEnv.GetIntField (Handle, COLUMN_NAME_MESSAGE_READ_URL_INDEX_jfieldId);
				}
				set {
					if (COLUMN_NAME_MESSAGE_READ_URL_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_MESSAGE_READ_URL_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_MESSAGE_READ_URL_INDEX", "I");
					JNIEnv.SetField (Handle, COLUMN_NAME_MESSAGE_READ_URL_INDEX_jfieldId, value);
				}
			}

			[Register ("COLUMN_NAME_MESSAGE_URL")]
			public const string ColumnNameMessageUrl = (string) "message_url";

			static IntPtr COLUMN_NAME_MESSAGE_URL_INDEX_jfieldId;

			[Register ("COLUMN_NAME_MESSAGE_URL_INDEX")]
			protected int ColumnNameMessageUrlIndex {
				get {
					if (COLUMN_NAME_MESSAGE_URL_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_MESSAGE_URL_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_MESSAGE_URL_INDEX", "I");
					return JNIEnv.GetIntField (Handle, COLUMN_NAME_MESSAGE_URL_INDEX_jfieldId);
				}
				set {
					if (COLUMN_NAME_MESSAGE_URL_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_MESSAGE_URL_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_MESSAGE_URL_INDEX", "I");
					JNIEnv.SetField (Handle, COLUMN_NAME_MESSAGE_URL_INDEX_jfieldId, value);
				}
			}

			[Register ("COLUMN_NAME_TITLE")]
			public const string ColumnNameTitle = (string) "title";

			static IntPtr COLUMN_NAME_TITLE_INDEX_jfieldId;

			[Register ("COLUMN_NAME_TITLE_INDEX")]
			protected int ColumnNameTitleIndex {
				get {
					if (COLUMN_NAME_TITLE_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_TITLE_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_TITLE_INDEX", "I");
					return JNIEnv.GetIntField (Handle, COLUMN_NAME_TITLE_INDEX_jfieldId);
				}
				set {
					if (COLUMN_NAME_TITLE_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_TITLE_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_TITLE_INDEX", "I");
					JNIEnv.SetField (Handle, COLUMN_NAME_TITLE_INDEX_jfieldId, value);
				}
			}

			[Register ("COLUMN_NAME_UNREAD")]
			public const string ColumnNameUnread = (string) "unread";

			static IntPtr COLUMN_NAME_UNREAD_INDEX_jfieldId;

			[Register ("COLUMN_NAME_UNREAD_INDEX")]
			protected int ColumnNameUnreadIndex {
				get {
					if (COLUMN_NAME_UNREAD_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_UNREAD_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_UNREAD_INDEX", "I");
					return JNIEnv.GetIntField (Handle, COLUMN_NAME_UNREAD_INDEX_jfieldId);
				}
				set {
					if (COLUMN_NAME_UNREAD_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_UNREAD_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_UNREAD_INDEX", "I");
					JNIEnv.SetField (Handle, COLUMN_NAME_UNREAD_INDEX_jfieldId, value);
				}
			}

			[Register ("COLUMN_NAME_UNREAD_ORIG")]
			public const string ColumnNameUnreadOrig = (string) "unread_orig";

			static IntPtr COLUMN_NAME_UNREAD_ORIG_INDEX_jfieldId;

			[Register ("COLUMN_NAME_UNREAD_ORIG_INDEX")]
			protected int ColumnNameUnreadOrigIndex {
				get {
					if (COLUMN_NAME_UNREAD_ORIG_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_UNREAD_ORIG_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_UNREAD_ORIG_INDEX", "I");
					return JNIEnv.GetIntField (Handle, COLUMN_NAME_UNREAD_ORIG_INDEX_jfieldId);
				}
				set {
					if (COLUMN_NAME_UNREAD_ORIG_INDEX_jfieldId == IntPtr.Zero)
						COLUMN_NAME_UNREAD_ORIG_INDEX_jfieldId = JNIEnv.GetFieldID (class_ref, "COLUMN_NAME_UNREAD_ORIG_INDEX", "I");
					JNIEnv.SetField (Handle, COLUMN_NAME_UNREAD_ORIG_INDEX_jfieldId, value);
				}
			}

			[Register ("CONTENT_ITEM_TYPE")]
			public const string ContentItemType = (string) "vnd.urbanairship.cursor.item/richpush";

			[Register ("CONTENT_TYPE")]
			public const string ContentType = (string) "vnd.urbanairship.cursor.dir/richpush";

			[Register ("NOTIFICATION_ACTION")]
			public const string NotificationAction = (string) "com.urbanairship.richpush.DB_CHANGE";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/UrbanAirshipProvider$RichPush", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RichPush); }
			}

			protected RichPush (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_urbanairship_UrbanAirshipProvider_Landroid_content_Context_;
			[Register (".ctor", "(Lcom/urbanairship/UrbanAirshipProvider;Landroid/content/Context;)V", "")]
			public RichPush (global::Com.Urbanairship.UrbanAirshipProvider __self, global::Android.Content.Context p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (RichPush)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", new JValue (__self), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_urbanairship_UrbanAirshipProvider_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lcom_urbanairship_UrbanAirshipProvider_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/UrbanAirshipProvider;Landroid/content/Context;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_UrbanAirshipProvider_Landroid_content_Context_, new JValue (__self), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_getBaseUri;
#pragma warning disable 0169
			static Delegate GetGetBaseUriHandler ()
			{
				if (cb_getBaseUri == null)
					cb_getBaseUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseUri);
				return cb_getBaseUri;
			}

			static IntPtr n_GetBaseUri (IntPtr jnienv, IntPtr native__this)
			{
				RichPush __this = Java.Lang.Object.GetObject<RichPush> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BaseUri);
			}
#pragma warning restore 0169

			static IntPtr id_getBaseUri;
			public override global::Android.Net.Uri BaseUri {
				[Register ("getBaseUri", "()Landroid/net/Uri;", "GetGetBaseUriHandler")]
				get {
					if (id_getBaseUri == IntPtr.Zero)
						id_getBaseUri = JNIEnv.GetMethodID (class_ref, "getBaseUri", "()Landroid/net/Uri;");

					if (GetType () == ThresholdType)
						return Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getBaseUri), JniHandleOwnership.TransferLocalRef);
					else
						return Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getBaseUri), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getTableName;
#pragma warning disable 0169
			static Delegate GetGetTableNameHandler ()
			{
				if (cb_getTableName == null)
					cb_getTableName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTableName);
				return cb_getTableName;
			}

			static IntPtr n_GetTableName (IntPtr jnienv, IntPtr native__this)
			{
				RichPush __this = Java.Lang.Object.GetObject<RichPush> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.TableName);
			}
#pragma warning restore 0169

			static IntPtr id_getTableName;
			public override string TableName {
				[Register ("getTableName", "()Ljava/lang/String;", "GetGetTableNameHandler")]
				get {
					if (id_getTableName == IntPtr.Zero)
						id_getTableName = JNIEnv.GetMethodID (class_ref, "getTableName", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTableName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTableName), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/UrbanAirshipProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrbanAirshipProvider); }
		}

		protected UrbanAirshipProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public UrbanAirshipProvider () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UrbanAirshipProvider)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getAuthorityString;
		public static string AuthorityString {
			[Register ("getAuthorityString", "()Ljava/lang/String;", "GetGetAuthorityStringHandler")]
			get {
				if (id_getAuthorityString == IntPtr.Zero)
					id_getAuthorityString = JNIEnv.GetStaticMethodID (class_ref, "getAuthorityString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAuthorityString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPreferencesContentUri;
		public static global::Android.Net.Uri PreferencesContentUri {
			[Register ("getPreferencesContentUri", "()Landroid/net/Uri;", "GetGetPreferencesContentUriHandler")]
			get {
				if (id_getPreferencesContentUri == IntPtr.Zero)
					id_getPreferencesContentUri = JNIEnv.GetStaticMethodID (class_ref, "getPreferencesContentUri", "()Landroid/net/Uri;");
				return Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPreferencesContentUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRichPushContentUri;
		public static global::Android.Net.Uri RichPushContentUri {
			[Register ("getRichPushContentUri", "()Landroid/net/Uri;", "GetGetRichPushContentUriHandler")]
			get {
				if (id_getRichPushContentUri == IntPtr.Zero)
					id_getRichPushContentUri = JNIEnv.GetStaticMethodID (class_ref, "getRichPushContentUri", "()Landroid/net/Uri;");
				return Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRichPushContentUri), JniHandleOwnership.TransferLocalRef);
			}
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
			UrbanAirshipProvider __this = Java.Lang.Object.GetObject<UrbanAirshipProvider> (native__this, JniHandleOwnership.DoNotTransfer);
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
		public override int Delete (global::Android.Net.Uri p0, string p1, string[] p2)
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

		static Delegate cb_getDatabaseModel_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetDatabaseModel_Landroid_net_Uri_Handler ()
		{
			if (cb_getDatabaseModel_Landroid_net_Uri_ == null)
				cb_getDatabaseModel_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDatabaseModel_Landroid_net_Uri_);
			return cb_getDatabaseModel_Landroid_net_Uri_;
		}

		static IntPtr n_GetDatabaseModel_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UrbanAirshipProvider __this = Java.Lang.Object.GetObject<UrbanAirshipProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDatabaseModel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDatabaseModel_Landroid_net_Uri_;
		[Register ("getDatabaseModel", "(Landroid/net/Uri;)Lcom/urbanairship/UrbanAirshipProvider$DatabaseModel;", "GetGetDatabaseModel_Landroid_net_Uri_Handler")]
		public virtual global::Com.Urbanairship.UrbanAirshipProvider.DatabaseModel GetDatabaseModel (global::Android.Net.Uri p0)
		{
			if (id_getDatabaseModel_Landroid_net_Uri_ == IntPtr.Zero)
				id_getDatabaseModel_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getDatabaseModel", "(Landroid/net/Uri;)Lcom/urbanairship/UrbanAirshipProvider$DatabaseModel;");

			global::Com.Urbanairship.UrbanAirshipProvider.DatabaseModel __ret;
			if (GetType () == ThresholdType)
				__ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.UrbanAirshipProvider.DatabaseModel> (JNIEnv.CallObjectMethod  (Handle, id_getDatabaseModel_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.UrbanAirshipProvider.DatabaseModel> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDatabaseModel_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getType_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetType_Landroid_net_Uri_Handler ()
		{
			if (cb_getType_Landroid_net_Uri_ == null)
				cb_getType_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetType_Landroid_net_Uri_);
			return cb_getType_Landroid_net_Uri_;
		}

		static IntPtr n_GetType_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UrbanAirshipProvider __this = Java.Lang.Object.GetObject<UrbanAirshipProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getType_Landroid_net_Uri_;
		[Register ("getType", "(Landroid/net/Uri;)Ljava/lang/String;", "GetGetType_Landroid_net_Uri_Handler")]
		public override string GetType (global::Android.Net.Uri p0)
		{
			if (id_getType_Landroid_net_Uri_ == IntPtr.Zero)
				id_getType_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getType_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getType_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_init;
		[Register ("init", "()V", "")]
		public static void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetStaticMethodID (class_ref, "init", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_init);
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
			UrbanAirshipProvider __this = Java.Lang.Object.GetObject<UrbanAirshipProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p1 = Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
		[Register ("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", "GetInsert_Landroid_net_Uri_Landroid_content_ContentValues_Handler")]
		public override global::Android.Net.Uri Insert (global::Android.Net.Uri p0, global::Android.Content.ContentValues p1)
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

		static Delegate cb_onCreate;
#pragma warning disable 0169
		static Delegate GetOnCreateHandler ()
		{
			if (cb_onCreate == null)
				cb_onCreate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnCreate);
			return cb_onCreate;
		}

		static bool n_OnCreate (IntPtr jnienv, IntPtr native__this)
		{
			UrbanAirshipProvider __this = Java.Lang.Object.GetObject<UrbanAirshipProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnCreate ();
		}
#pragma warning restore 0169

		static IntPtr id_onCreate;
		[Register ("onCreate", "()Z", "GetOnCreateHandler")]
		public override bool OnCreate ()
		{
			if (id_onCreate == IntPtr.Zero)
				id_onCreate = JNIEnv.GetMethodID (class_ref, "onCreate", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_onCreate);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onCreate);
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
			UrbanAirshipProvider __this = Java.Lang.Object.GetObject<UrbanAirshipProvider> (native__this, JniHandleOwnership.DoNotTransfer);
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
		public override global::Android.Database.ICursor Query (global::Android.Net.Uri p0, string[] p1, string p2, string[] p3, string p4)
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

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			UrbanAirshipProvider __this = Java.Lang.Object.GetObject<UrbanAirshipProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_shutdown);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_shutdown);
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
			UrbanAirshipProvider __this = Java.Lang.Object.GetObject<UrbanAirshipProvider> (native__this, JniHandleOwnership.DoNotTransfer);
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
		public override int Update (global::Android.Net.Uri p0, global::Android.Content.ContentValues p1, string p2, string[] p3)
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
}
