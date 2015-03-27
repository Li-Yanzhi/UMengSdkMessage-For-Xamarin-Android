using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='bL']"
	[Register ("com/umeng/message/proguard/bL", "", "Com.Umeng.Message.Proguard.IBLInvoker")]
	public partial interface IBL : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='bL']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "GetA_Ljava_lang_String_Handler:Com.Umeng.Message.Proguard.IBLInvoker, UMengSdkMessage")]
		void A (string p0);

	}

	[global::Android.Runtime.Register ("com/umeng/message/proguard/bL", DoNotGenerateAcw=true)]
	internal class IBLInvoker : global::Java.Lang.Object, IBL {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/message/proguard/bL");
		IntPtr class_ref;

		public static IBL GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBL> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.message.proguard.bL"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBLInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IBLInvoker); }
		}

		static Delegate cb_a_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_;
		}

		static void n_A_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.IBL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IBL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_lang_String_;
		public void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.IBL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IBL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
