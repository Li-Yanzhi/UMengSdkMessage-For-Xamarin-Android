using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPublickey']"
	[global::Android.Runtime.Register ("org/android/spdy/SslPublickey", DoNotGenerateAcw=true)]
	public partial class SslPublickey : global::Java.Lang.Object {


		static IntPtr error_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPublickey']/field[@name='error']"
		[Register ("error")]
		public int Error {
			get {
				if (error_jfieldId == IntPtr.Zero)
					error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "I");
				return JNIEnv.GetIntField (Handle, error_jfieldId);
			}
			set {
				if (error_jfieldId == IntPtr.Zero)
					error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "I");
				JNIEnv.SetField (Handle, error_jfieldId, value);
			}
		}

		static IntPtr exponent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPublickey']/field[@name='exponent']"
		[Register ("exponent")]
		public IList<byte> Exponent {
			get {
				if (exponent_jfieldId == IntPtr.Zero)
					exponent_jfieldId = JNIEnv.GetFieldID (class_ref, "exponent", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, exponent_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (exponent_jfieldId == IntPtr.Zero)
					exponent_jfieldId = JNIEnv.GetFieldID (class_ref, "exponent", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, exponent_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr module_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPublickey']/field[@name='module']"
		[Register ("module")]
		public IList<byte> Module {
			get {
				if (module_jfieldId == IntPtr.Zero)
					module_jfieldId = JNIEnv.GetFieldID (class_ref, "module", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, module_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (module_jfieldId == IntPtr.Zero)
					module_jfieldId = JNIEnv.GetFieldID (class_ref, "module", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, module_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr seqnum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPublickey']/field[@name='seqnum']"
		[Register ("seqnum")]
		public int Seqnum {
			get {
				if (seqnum_jfieldId == IntPtr.Zero)
					seqnum_jfieldId = JNIEnv.GetFieldID (class_ref, "seqnum", "I");
				return JNIEnv.GetIntField (Handle, seqnum_jfieldId);
			}
			set {
				if (seqnum_jfieldId == IntPtr.Zero)
					seqnum_jfieldId = JNIEnv.GetFieldID (class_ref, "seqnum", "I");
				JNIEnv.SetField (Handle, seqnum_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SslPublickey", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SslPublickey); }
		}

		protected SslPublickey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPublickey']/constructor[@name='SslPublickey' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SslPublickey () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SslPublickey)) {
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
