using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aW']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/aW", DoNotGenerateAcw=true)]
	public sealed partial class AW : global::Java.Lang.Enum {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/aW", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AW); }
		}

		internal AW (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aW']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()I", "")]
		public int A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_a);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aW']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/message/proguard/aW;", "")]
		public static global::Com.Umeng.Message.Proguard.AW ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/message/proguard/aW;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Umeng.Message.Proguard.AW __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AW> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aW']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/umeng/message/proguard/aW;", "")]
		public static global::Com.Umeng.Message.Proguard.AW[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/message/proguard/aW;");
			return (global::Com.Umeng.Message.Proguard.AW[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Message.Proguard.AW));
		}

	}
}
