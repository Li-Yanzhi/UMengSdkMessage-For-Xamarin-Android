using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']"
	[global::Android.Runtime.Register ("com/umeng/message/MessageStore", DoNotGenerateAcw=true)]
	public partial class MessageStore : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='ActionType']"
		[Register ("ActionType")]
		public const string ActionType = (string) "ActionType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='ArrivalTime']"
		[Register ("ArrivalTime")]
		public const string ArrivalTime = (string) "ArrivalTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='Id']"
		[Register ("Id")]
		public const string Id = (string) "_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='Json']"
		[Register ("Json")]
		public const string Json = (string) "Json";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='MsgId']"
		[Register ("MsgId")]
		public const string MsgId = (string) "MsdId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='SdkVersion']"
		[Register ("SdkVersion")]
		public const string SdkVersion = (string) "SdkVersion";

		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='instance']"
		[Register ("instance")]
		public static global::Com.Umeng.Message.MessageStore Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/umeng/message/MessageStore;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageStore> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/umeng/message/MessageStore;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore.MessageStoreHelper']"
		[global::Android.Runtime.Register ("com/umeng/message/MessageStore$MessageStoreHelper", DoNotGenerateAcw=true)]
		public partial class MessageStoreHelper : global::Android.Database.Sqlite.SQLiteOpenHelper {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/message/MessageStore$MessageStoreHelper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessageStoreHelper); }
			}

			protected MessageStoreHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_umeng_message_MessageStore_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore.MessageStoreHelper']/constructor[@name='MessageStore.MessageStoreHelper' and count(parameter)=2 and parameter[1][@type='com.umeng.message.MessageStore'] and parameter[2][@type='android.content.Context']]"
			[Register (".ctor", "(Lcom/umeng/message/MessageStore;Landroid/content/Context;)V", "")]
			public MessageStoreHelper (global::Com.Umeng.Message.MessageStore __self, global::Android.Content.Context p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MessageStoreHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lcom_umeng_message_MessageStore_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lcom_umeng_message_MessageStore_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/message/MessageStore;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_message_MessageStore_Landroid_content_Context_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_umeng_message_MessageStore_Landroid_content_Context_, new JValue (__self), new JValue (p1));
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
				global::Com.Umeng.Message.MessageStore.MessageStoreHelper __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageStore.MessageStoreHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCreate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore.MessageStoreHelper']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
			[Register ("onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", "GetOnCreate_Landroid_database_sqlite_SQLiteDatabase_Handler")]
			public override void OnCreate (global::Android.Database.Sqlite.SQLiteDatabase p0)
			{
				if (id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
					id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V"), new JValue (p0));
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
				global::Com.Umeng.Message.MessageStore.MessageStoreHelper __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageStore.MessageStoreHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUpgrade (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore.MessageStoreHelper']/method[@name='onUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", "GetOnUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler")]
			public override void OnUpgrade (global::Android.Database.Sqlite.SQLiteDatabase p0, int p1, int p2)
			{
				if (id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == IntPtr.Zero)
					id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNIEnv.GetMethodID (class_ref, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/MessageStore", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageStore); }
		}

		protected MessageStore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/umeng/message/MessageStore;", "")]
		public static global::Com.Umeng.Message.MessageStore GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/umeng/message/MessageStore;");
			global::Com.Umeng.Message.MessageStore __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageStore> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
