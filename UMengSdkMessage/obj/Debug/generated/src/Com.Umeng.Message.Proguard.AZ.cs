using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aZ']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/aZ", DoNotGenerateAcw=true)]
	public sealed partial class AZ : global::Java.Lang.Enum {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aZ']/field[@name='a']"
		[Register ("a")]
		public static global::Com.Umeng.Message.Proguard.AZ A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lcom/umeng/message/proguard/aZ;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AZ> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lcom/umeng/message/proguard/aZ;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, a_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aZ']/field[@name='b']"
		[Register ("b")]
		public static global::Com.Umeng.Message.Proguard.AZ B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/umeng/message/proguard/aZ;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AZ> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/umeng/message/proguard/aZ;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aZ']/field[@name='c']"
		[Register ("c")]
		public static global::Com.Umeng.Message.Proguard.AZ C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/umeng/message/proguard/aZ;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AZ> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/umeng/message/proguard/aZ;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aZ']/field[@name='d']"
		[Register ("d")]
		public static global::Com.Umeng.Message.Proguard.AZ D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lcom/umeng/message/proguard/aZ;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, d_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AZ> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lcom/umeng/message/proguard/aZ;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, d_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/aZ", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AZ); }
		}

		internal AZ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aZ']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/message/proguard/aZ;", "")]
		public static global::Com.Umeng.Message.Proguard.AZ ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/message/proguard/aZ;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Umeng.Message.Proguard.AZ __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AZ> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aZ']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/umeng/message/proguard/aZ;", "")]
		public static global::Com.Umeng.Message.Proguard.AZ[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/message/proguard/aZ;");
			return (global::Com.Umeng.Message.Proguard.AZ[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Message.Proguard.AZ));
		}

	}
}
