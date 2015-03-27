using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/bH", DoNotGenerateAcw=true)]
	public partial class BH : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/bH", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BH); }
		}

		protected BH (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/constructor[@name='bH' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BH () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BH)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "")]
		public static string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string A (global::Android.Content.Context p0, string p1)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void A (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_b_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("b", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string B (global::Android.Content.Context p0, string p1)
		{
			if (id_b_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_b_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='b' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("b", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void B (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_b_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_c_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='c' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("c", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string C (global::Android.Content.Context p0, string p1)
		{
			if (id_c_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_c_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_c_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='c' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("c", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void C (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_c_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_d_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='d' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string D (global::Android.Content.Context p0, string p1)
		{
			if (id_d_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_d_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_d_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='d' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("d", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void D (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_d_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_e_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='e' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string E (global::Android.Content.Context p0, string p1)
		{
			if (id_e_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_e_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_e_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='e' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("e", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void E (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_e_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_f_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='f' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("f", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string F (global::Android.Content.Context p0, string p1)
		{
			if (id_f_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_f_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "f", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_f_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_f_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='f' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("f", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void F (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_f_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_f_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "f", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_f_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_g_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='g' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("g", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string G (global::Android.Content.Context p0, string p1)
		{
			if (id_g_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_g_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "g", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_g_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_g_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bH']/method[@name='g' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("g", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void G (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_g_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_g_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "g", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_g_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}
}
