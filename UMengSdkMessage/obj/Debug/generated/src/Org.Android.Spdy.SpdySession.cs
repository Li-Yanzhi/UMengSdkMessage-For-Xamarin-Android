using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdySession", DoNotGenerateAcw=true)]
	public sealed partial class SpdySession : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdySession", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdySession); }
		}

		internal SpdySession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_clearAllStreamCb;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='clearAllStreamCb' and count(parameter)=0]"
		[Register ("clearAllStreamCb", "()V", "")]
		public void ClearAllStreamCb ()
		{
			if (id_clearAllStreamCb == IntPtr.Zero)
				id_clearAllStreamCb = JNIEnv.GetMethodID (class_ref, "clearAllStreamCb", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_clearAllStreamCb);
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()I", "")]
		public int Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_close);
		}

		static IntPtr id_getAllStreamCb;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='getAllStreamCb' and count(parameter)=0]"
		[Register ("getAllStreamCb", "()[Lorg/android/spdy/SpdyStreamContext;", "")]
		public global::Org.Android.Spdy.SpdyStreamContext[] GetAllStreamCb ()
		{
			if (id_getAllStreamCb == IntPtr.Zero)
				id_getAllStreamCb = JNIEnv.GetMethodID (class_ref, "getAllStreamCb", "()[Lorg/android/spdy/SpdyStreamContext;");
			return (global::Org.Android.Spdy.SpdyStreamContext[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllStreamCb), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.Spdy.SpdyStreamContext));
		}

		static IntPtr id_sendHeaders_ILorg_android_spdy_SpdyRequest_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='sendHeaders' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='org.android.spdy.SpdyRequest'] and parameter[3][@type='boolean']]"
		[Register ("sendHeaders", "(ILorg/android/spdy/SpdyRequest;Z)I", "")]
		public int SendHeaders (int p0, global::Org.Android.Spdy.SpdyRequest p1, bool p2)
		{
			if (id_sendHeaders_ILorg_android_spdy_SpdyRequest_Z == IntPtr.Zero)
				id_sendHeaders_ILorg_android_spdy_SpdyRequest_Z = JNIEnv.GetMethodID (class_ref, "sendHeaders", "(ILorg/android/spdy/SpdyRequest;Z)I");
			int __ret = JNIEnv.CallIntMethod  (Handle, id_sendHeaders_ILorg_android_spdy_SpdyRequest_Z, new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static IntPtr id_setOption_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='setOption' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setOption", "(II)I", "")]
		public int SetOption (int p0, int p1)
		{
			if (id_setOption_II == IntPtr.Zero)
				id_setOption_II = JNIEnv.GetMethodID (class_ref, "setOption", "(II)I");
			return JNIEnv.CallIntMethod  (Handle, id_setOption_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_streamReset_JLorg_android_spdy_SpdyStatusCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='streamReset' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='org.android.spdy.SpdyStatusCode']]"
		[Register ("streamReset", "(JLorg/android/spdy/SpdyStatusCode;)I", "")]
		public int StreamReset (long p0, global::Org.Android.Spdy.SpdyStatusCode p1)
		{
			if (id_streamReset_JLorg_android_spdy_SpdyStatusCode_ == IntPtr.Zero)
				id_streamReset_JLorg_android_spdy_SpdyStatusCode_ = JNIEnv.GetMethodID (class_ref, "streamReset", "(JLorg/android/spdy/SpdyStatusCode;)I");
			int __ret = JNIEnv.CallIntMethod  (Handle, id_streamReset_JLorg_android_spdy_SpdyStatusCode_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_streamSendData_IarrayBIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='streamSendData' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("streamSendData", "(I[BIIZ)I", "")]
		public int StreamSendData (int p0, byte[] p1, int p2, int p3, bool p4)
		{
			if (id_streamSendData_IarrayBIIZ == IntPtr.Zero)
				id_streamSendData_IarrayBIIZ = JNIEnv.GetMethodID (class_ref, "streamSendData", "(I[BIIZ)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_streamSendData_IarrayBIIZ, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_streamSendData_ILjava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='streamSendData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("streamSendData", "(ILjava/io/InputStream;)I", "")]
		public int StreamSendData (int p0, global::System.IO.Stream p1)
		{
			if (id_streamSendData_ILjava_io_InputStream_ == IntPtr.Zero)
				id_streamSendData_ILjava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "streamSendData", "(ILjava/io/InputStream;)I");
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_streamSendData_ILjava_io_InputStream_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_streamSendData_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='streamSendData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("streamSendData", "(ILjava/lang/String;)I", "")]
		public int StreamSendData (int p0, string p1)
		{
			if (id_streamSendData_ILjava_lang_String_ == IntPtr.Zero)
				id_streamSendData_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "streamSendData", "(ILjava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_streamSendData_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_submitPing;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='submitPing' and count(parameter)=0]"
		[Register ("submitPing", "()I", "")]
		public int SubmitPing ()
		{
			if (id_submitPing == IntPtr.Zero)
				id_submitPing = JNIEnv.GetMethodID (class_ref, "submitPing", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_submitPing);
		}

		static IntPtr id_submitRequest_Lorg_android_spdy_SpdyRequest_Lorg_android_spdy_SpdyDataProvider_Ljava_lang_Object_Lorg_android_spdy_Spdycb_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='submitRequest' and count(parameter)=4 and parameter[1][@type='org.android.spdy.SpdyRequest'] and parameter[2][@type='org.android.spdy.SpdyDataProvider'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.android.spdy.Spdycb']]"
		[Register ("submitRequest", "(Lorg/android/spdy/SpdyRequest;Lorg/android/spdy/SpdyDataProvider;Ljava/lang/Object;Lorg/android/spdy/Spdycb;)I", "")]
		public int SubmitRequest (global::Org.Android.Spdy.SpdyRequest p0, global::Org.Android.Spdy.SpdyDataProvider p1, global::Java.Lang.Object p2, global::Org.Android.Spdy.ISpdycb p3)
		{
			if (id_submitRequest_Lorg_android_spdy_SpdyRequest_Lorg_android_spdy_SpdyDataProvider_Ljava_lang_Object_Lorg_android_spdy_Spdycb_ == IntPtr.Zero)
				id_submitRequest_Lorg_android_spdy_SpdyRequest_Lorg_android_spdy_SpdyDataProvider_Ljava_lang_Object_Lorg_android_spdy_Spdycb_ = JNIEnv.GetMethodID (class_ref, "submitRequest", "(Lorg/android/spdy/SpdyRequest;Lorg/android/spdy/SpdyDataProvider;Ljava/lang/Object;Lorg/android/spdy/Spdycb;)I");
			int __ret = JNIEnv.CallIntMethod  (Handle, id_submitRequest_Lorg_android_spdy_SpdyRequest_Lorg_android_spdy_SpdyDataProvider_Ljava_lang_Object_Lorg_android_spdy_Spdycb_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			return __ret;
		}

	}
}
