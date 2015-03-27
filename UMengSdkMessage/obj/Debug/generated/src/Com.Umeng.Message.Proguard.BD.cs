using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bD']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/bD", DoNotGenerateAcw=true)]
	public partial class BD : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/bD", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BD); }
		}

		protected BD (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bD']/constructor[@name='bD' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public BD (global::Android.Content.Context p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (BD)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_A);
			return cb_a;
		}

		static bool n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.BD __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.BD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bD']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "GetAHandler")]
		public virtual bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_a);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()Z"));
		}

		static Delegate cb_a_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_content_Context_Handler ()
		{
			if (cb_a_Landroid_content_Context_ == null)
				cb_a_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Landroid_content_Context_);
			return cb_a_Landroid_content_Context_;
		}

		static IntPtr n_A_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.BD __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.BD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<global::Java.Lang.Class, global::System.Collections.Generic.IList<global::Java.Lang.Class>>.ToLocalJniHandle (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bD']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)Ljava/util/HashMap;", "GetA_Landroid_content_Context_Handler")]
		public virtual global::System.Collections.Generic.IDictionary<global::Java.Lang.Class, global::System.Collections.Generic.IList<global::Java.Lang.Class>> A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Context;)Ljava/util/HashMap;");

			global::System.Collections.Generic.IDictionary<global::Java.Lang.Class, global::System.Collections.Generic.IList<global::Java.Lang.Class>> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaDictionary<global::Java.Lang.Class, global::System.Collections.Generic.IList<global::Java.Lang.Class>>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaDictionary<global::Java.Lang.Class, global::System.Collections.Generic.IList<global::Java.Lang.Class>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/content/Context;)Ljava/util/HashMap;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_ClassLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bD']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.ClassLoader']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/ClassLoader;)V", "")]
		public static void A (global::Android.Content.Context p0, global::Java.Lang.ClassLoader p1)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_ClassLoader_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_ClassLoader_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/ClassLoader;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_ClassLoader_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_a_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_Class_Handler ()
		{
			if (cb_a_Ljava_lang_Class_ == null)
				cb_a_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_Class_);
			return cb_a_Ljava_lang_Class_;
		}

		static IntPtr n_A_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.BD __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.BD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bD']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("a", "(Ljava/lang/Class;)Ljava/lang/String;", "GetA_Ljava_lang_Class_Handler")]
		public virtual string A (global::Java.Lang.Class p0)
		{
			if (id_a_Ljava_lang_Class_ == IntPtr.Zero)
				id_a_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Class;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/Class;)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_B);
			return cb_b;
		}

		static bool n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.BD __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.BD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.B ();
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bD']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "GetBHandler")]
		public virtual bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_b);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()Z"));
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_C);
			return cb_c;
		}

		static IntPtr n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.BD __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.BD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.C ());
		}
#pragma warning restore 0169

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bD']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/ClassLoader;", "GetCHandler")]
		public virtual global::Java.Lang.ClassLoader C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/ClassLoader;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "c", "()Ljava/lang/ClassLoader;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}
