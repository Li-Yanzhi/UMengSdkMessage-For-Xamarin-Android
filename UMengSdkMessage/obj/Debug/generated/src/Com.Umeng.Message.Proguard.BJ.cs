using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bJ']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/bJ", DoNotGenerateAcw=true)]
	public partial class BJ : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/bJ", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BJ); }
		}

		protected BJ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bJ']/constructor[@name='bJ' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BJ () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BJ)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bJ']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lorg/android/du/CpuType;", "")]
		public static global::Org.Android.DU.CpuType A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Lorg/android/du/CpuType;");
			return global::Java.Lang.Object.GetObject<global::Org.Android.DU.CpuType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bJ']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static global::Java.IO.File A (global::Android.Content.Context p0, string p1)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bJ']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static bool A (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_a_Landroid_content_Context_Lorg_android_du_CpuType_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bJ']/method[@name='a' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.du.CpuType'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Lorg/android/du/CpuType;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static bool A (global::Android.Content.Context p0, global::Org.Android.DU.CpuType p1, string p2, string p3)
		{
			if (id_a_Landroid_content_Context_Lorg_android_du_CpuType_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Lorg_android_du_CpuType_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Lorg/android/du/CpuType;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Landroid_content_Context_Lorg_android_du_CpuType_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_a_Ljava_io_File_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bJ']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='android.content.Context']]"
		[Register ("a", "(Ljava/io/File;Landroid/content/Context;)Ljava/security/cert/Certificate;", "")]
		public static global::Java.Security.Cert.Certificate A (global::Java.IO.File p0, global::Android.Content.Context p1)
		{
			if (id_a_Ljava_io_File_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Ljava_io_File_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/io/File;Landroid/content/Context;)Ljava/security/cert/Certificate;");
			global::Java.Security.Cert.Certificate __ret = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.Certificate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_io_File_Landroid_content_Context_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bJ']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static bool A (string p0, string p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
