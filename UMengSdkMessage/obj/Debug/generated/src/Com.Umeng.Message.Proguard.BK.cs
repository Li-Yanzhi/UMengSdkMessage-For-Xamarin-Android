using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bK']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/bK", DoNotGenerateAcw=true)]
	public partial class BK : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bK']/field[@name='a']"
		[Register ("a")]
		public const string A = (string) "0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bK']/field[@name='b']"
		[Register ("b")]
		public const string B = (string) "1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bK']/field[@name='c']"
		[Register ("c")]
		public const string C = (string) "2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bK']/field[@name='d']"
		[Register ("d")]
		public const string D = (string) "3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bK']/field[@name='e']"
		[Register ("e")]
		public const string E = (string) "4";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bK']/field[@name='f']"
		[Register ("f")]
		public const string F = (string) "5";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/bK", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BK); }
		}

		protected BK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bK']/constructor[@name='bK' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BK () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BK)) {
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

	}
}
