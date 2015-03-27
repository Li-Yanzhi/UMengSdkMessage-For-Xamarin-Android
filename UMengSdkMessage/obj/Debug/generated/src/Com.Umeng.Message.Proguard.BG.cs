using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bG']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/bG", DoNotGenerateAcw=true)]
	public sealed partial class BG : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/bG", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BG); }
		}

		internal BG (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bG']/method[@name='a' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("a", "([B)[B", "")]
		public static byte[] A (byte[] p0)
		{
			if (id_a_arrayB == IntPtr.Zero)
				id_a_arrayB = JNIEnv.GetStaticMethodID (class_ref, "a", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_b_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bG']/method[@name='b' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("b", "([B)Ljava/lang/String;", "")]
		public static string B (byte[] p0)
		{
			if (id_b_arrayB == IntPtr.Zero)
				id_b_arrayB = JNIEnv.GetStaticMethodID (class_ref, "b", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
