using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bB']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/bB", DoNotGenerateAcw=true)]
	public partial class BB : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/bB", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BB); }
		}

		protected BB (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bB']/constructor[@name='bB' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BB () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BB)) {
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

		static IntPtr id_a_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bB']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("a", "(Ljava/lang/Runnable;)V", "")]
		public static void A (global::Java.Lang.IRunnable p0)
		{
			if (id_a_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_a_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Runnable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_Runnable_, new JValue (p0));
		}

	}
}
