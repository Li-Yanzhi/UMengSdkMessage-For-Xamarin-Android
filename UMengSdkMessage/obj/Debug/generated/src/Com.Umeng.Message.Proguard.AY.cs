using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aY']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/aY", DoNotGenerateAcw=true)]
	public partial class AY : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/aY", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AY); }
		}

		protected AY (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Lcom_umeng_message_proguard_aT_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aY']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.umeng.message.proguard.aT'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Lcom/umeng/message/proguard/aT;Ljava/lang/String;)V", "")]
		public void A (global::Com.Umeng.Message.Proguard.AT p0, string p1)
		{
			if (id_a_Lcom_umeng_message_proguard_aT_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Lcom_umeng_message_proguard_aT_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/umeng/message/proguard/aT;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_umeng_message_proguard_aT_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_a_Lcom_umeng_message_proguard_aV_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aY']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.umeng.message.proguard.aV']]"
		[Register ("a", "(Lcom/umeng/message/proguard/aV;)Lcom/umeng/message/proguard/aV;", "")]
		public global::Com.Umeng.Message.Proguard.AV A (global::Com.Umeng.Message.Proguard.AV p0)
		{
			if (id_a_Lcom_umeng_message_proguard_aV_ == IntPtr.Zero)
				id_a_Lcom_umeng_message_proguard_aV_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/umeng/message/proguard/aV;)Lcom/umeng/message/proguard/aV;");
			global::Com.Umeng.Message.Proguard.AV __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AV> (JNIEnv.CallObjectMethod  (Handle, id_a_Lcom_umeng_message_proguard_aV_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aY']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("a", "(Ljava/lang/Object;)V", "")]
		public void A (global::Java.Lang.Object p0)
		{
			if (id_a_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Object_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aY']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "")]
		public int A (string p0, string p1, string p2)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aY']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/umeng/message/proguard/aZ;", "")]
		public global::Com.Umeng.Message.Proguard.AZ B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lcom/umeng/message/proguard/aZ;");
			return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AZ> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aY']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_c);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aY']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "")]
		public void D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_d);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aY']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()J", "")]
		public long E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_e);
		}

	}
}
