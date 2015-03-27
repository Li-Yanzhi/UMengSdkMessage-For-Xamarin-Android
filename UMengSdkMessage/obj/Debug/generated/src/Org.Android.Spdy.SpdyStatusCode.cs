using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdyStatusCode", DoNotGenerateAcw=true)]
	public sealed partial class SpdyStatusCode : global::Java.Lang.Enum {


		static IntPtr SPDY_CANCEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_CANCEL']"
		[Register ("SPDY_CANCEL")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyCancel {
			get {
				if (SPDY_CANCEL_jfieldId == IntPtr.Zero)
					SPDY_CANCEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_CANCEL", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_CANCEL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_CANCEL_jfieldId == IntPtr.Zero)
					SPDY_CANCEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_CANCEL", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_CANCEL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_FLOW_CONTROL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_FLOW_CONTROL_ERROR']"
		[Register ("SPDY_FLOW_CONTROL_ERROR")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyFlowControlError {
			get {
				if (SPDY_FLOW_CONTROL_ERROR_jfieldId == IntPtr.Zero)
					SPDY_FLOW_CONTROL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_FLOW_CONTROL_ERROR", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_FLOW_CONTROL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_FLOW_CONTROL_ERROR_jfieldId == IntPtr.Zero)
					SPDY_FLOW_CONTROL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_FLOW_CONTROL_ERROR", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_FLOW_CONTROL_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_FRAME_TOO_LARGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_FRAME_TOO_LARGE']"
		[Register ("SPDY_FRAME_TOO_LARGE")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyFrameTooLarge {
			get {
				if (SPDY_FRAME_TOO_LARGE_jfieldId == IntPtr.Zero)
					SPDY_FRAME_TOO_LARGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_FRAME_TOO_LARGE", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_FRAME_TOO_LARGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_FRAME_TOO_LARGE_jfieldId == IntPtr.Zero)
					SPDY_FRAME_TOO_LARGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_FRAME_TOO_LARGE", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_FRAME_TOO_LARGE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_INTERNAL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_INTERNAL_ERROR']"
		[Register ("SPDY_INTERNAL_ERROR")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyInternalError {
			get {
				if (SPDY_INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					SPDY_INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_INTERNAL_ERROR", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_INTERNAL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					SPDY_INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_INTERNAL_ERROR", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_INTERNAL_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_INVALID_CREDENTIALS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_INVALID_CREDENTIALS']"
		[Register ("SPDY_INVALID_CREDENTIALS")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyInvalidCredentials {
			get {
				if (SPDY_INVALID_CREDENTIALS_jfieldId == IntPtr.Zero)
					SPDY_INVALID_CREDENTIALS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_INVALID_CREDENTIALS", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_INVALID_CREDENTIALS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_INVALID_CREDENTIALS_jfieldId == IntPtr.Zero)
					SPDY_INVALID_CREDENTIALS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_INVALID_CREDENTIALS", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_INVALID_CREDENTIALS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_INVALID_STREAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_INVALID_STREAM']"
		[Register ("SPDY_INVALID_STREAM")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyInvalidStream {
			get {
				if (SPDY_INVALID_STREAM_jfieldId == IntPtr.Zero)
					SPDY_INVALID_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_INVALID_STREAM", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_INVALID_STREAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_INVALID_STREAM_jfieldId == IntPtr.Zero)
					SPDY_INVALID_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_INVALID_STREAM", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_INVALID_STREAM_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_OK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_OK']"
		[Register ("SPDY_OK")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyOk {
			get {
				if (SPDY_OK_jfieldId == IntPtr.Zero)
					SPDY_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_OK", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_OK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_OK_jfieldId == IntPtr.Zero)
					SPDY_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_OK", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_OK_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_PROTOCOL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_PROTOCOL_ERROR']"
		[Register ("SPDY_PROTOCOL_ERROR")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyProtocolError {
			get {
				if (SPDY_PROTOCOL_ERROR_jfieldId == IntPtr.Zero)
					SPDY_PROTOCOL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_PROTOCOL_ERROR", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_PROTOCOL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_PROTOCOL_ERROR_jfieldId == IntPtr.Zero)
					SPDY_PROTOCOL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_PROTOCOL_ERROR", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_PROTOCOL_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_REFUSED_STREAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_REFUSED_STREAM']"
		[Register ("SPDY_REFUSED_STREAM")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyRefusedStream {
			get {
				if (SPDY_REFUSED_STREAM_jfieldId == IntPtr.Zero)
					SPDY_REFUSED_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_REFUSED_STREAM", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_REFUSED_STREAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_REFUSED_STREAM_jfieldId == IntPtr.Zero)
					SPDY_REFUSED_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_REFUSED_STREAM", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_REFUSED_STREAM_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_STREAM_ALREADY_CLOSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_STREAM_ALREADY_CLOSED']"
		[Register ("SPDY_STREAM_ALREADY_CLOSED")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyStreamAlreadyClosed {
			get {
				if (SPDY_STREAM_ALREADY_CLOSED_jfieldId == IntPtr.Zero)
					SPDY_STREAM_ALREADY_CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_STREAM_ALREADY_CLOSED", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_STREAM_ALREADY_CLOSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_STREAM_ALREADY_CLOSED_jfieldId == IntPtr.Zero)
					SPDY_STREAM_ALREADY_CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_STREAM_ALREADY_CLOSED", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_STREAM_ALREADY_CLOSED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_STREAM_IN_USE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_STREAM_IN_USE']"
		[Register ("SPDY_STREAM_IN_USE")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyStreamInUse {
			get {
				if (SPDY_STREAM_IN_USE_jfieldId == IntPtr.Zero)
					SPDY_STREAM_IN_USE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_STREAM_IN_USE", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_STREAM_IN_USE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_STREAM_IN_USE_jfieldId == IntPtr.Zero)
					SPDY_STREAM_IN_USE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_STREAM_IN_USE", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_STREAM_IN_USE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_STREAM_REQUESTCANCELLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_STREAM_REQUESTCANCELLED']"
		[Register ("SPDY_STREAM_REQUESTCANCELLED")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyStreamRequestcancelled {
			get {
				if (SPDY_STREAM_REQUESTCANCELLED_jfieldId == IntPtr.Zero)
					SPDY_STREAM_REQUESTCANCELLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_STREAM_REQUESTCANCELLED", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_STREAM_REQUESTCANCELLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_STREAM_REQUESTCANCELLED_jfieldId == IntPtr.Zero)
					SPDY_STREAM_REQUESTCANCELLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_STREAM_REQUESTCANCELLED", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_STREAM_REQUESTCANCELLED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_STREAM_TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_STREAM_TIMEOUT']"
		[Register ("SPDY_STREAM_TIMEOUT")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyStreamTimeout {
			get {
				if (SPDY_STREAM_TIMEOUT_jfieldId == IntPtr.Zero)
					SPDY_STREAM_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_STREAM_TIMEOUT", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_STREAM_TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_STREAM_TIMEOUT_jfieldId == IntPtr.Zero)
					SPDY_STREAM_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_STREAM_TIMEOUT", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_STREAM_TIMEOUT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SPDY_UNSUPPORTED_VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/field[@name='SPDY_UNSUPPORTED_VERSION']"
		[Register ("SPDY_UNSUPPORTED_VERSION")]
		public static global::Org.Android.Spdy.SpdyStatusCode SpdyUnsupportedVersion {
			get {
				if (SPDY_UNSUPPORTED_VERSION_jfieldId == IntPtr.Zero)
					SPDY_UNSUPPORTED_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_UNSUPPORTED_VERSION", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_UNSUPPORTED_VERSION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SPDY_UNSUPPORTED_VERSION_jfieldId == IntPtr.Zero)
					SPDY_UNSUPPORTED_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_UNSUPPORTED_VERSION", "Lorg/android/spdy/SpdyStatusCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SPDY_UNSUPPORTED_VERSION_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdyStatusCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyStatusCode); }
		}

		internal SpdyStatusCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/android/spdy/SpdyStatusCode;", "")]
		public static global::Org.Android.Spdy.SpdyStatusCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/android/spdy/SpdyStatusCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Android.Spdy.SpdyStatusCode __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyStatusCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStatusCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/android/spdy/SpdyStatusCode;", "")]
		public static global::Org.Android.Spdy.SpdyStatusCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/android/spdy/SpdyStatusCode;");
			return (global::Org.Android.Spdy.SpdyStatusCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.Spdy.SpdyStatusCode));
		}

	}
}
