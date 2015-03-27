using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bA']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/bA", DoNotGenerateAcw=true)]
	public sealed partial class BA : global::Java.Lang.Object {


		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bA']/field[@name='b']"
		[Register ("b")]
		public static global::Java.Nio.Charset.Charset B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Ljava/nio/charset/Charset;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/bA", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BA); }
		}

		internal BA (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bA']/constructor[@name='bA' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BA () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BA)) {
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

		static IntPtr id_a_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bA']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("a", "([Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static string A (global::Java.Lang.Object[] p0)
		{
			if (id_a_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_a_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "a", "([Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bA']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Z", "")]
		public static bool A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_util_Collection_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bA']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.Collection'] and parameter[2][@type='char']]"
		[Register ("a", "(Ljava/util/Collection;C)Ljava/lang/String;", "")]
		public static string A (global::System.Collections.ICollection p0, char p1)
		{
			if (id_a_Ljava_util_Collection_C == IntPtr.Zero)
				id_a_Ljava_util_Collection_C = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/util/Collection;C)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_util_Collection_C, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
