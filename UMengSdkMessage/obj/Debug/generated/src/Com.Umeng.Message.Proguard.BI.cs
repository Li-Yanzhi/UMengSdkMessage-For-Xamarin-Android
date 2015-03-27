using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bI']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/bI", DoNotGenerateAcw=true)]
	public partial class BI : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/bI", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BI); }
		}

		protected BI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_ClassLoader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bI']/constructor[@name='bI' and count(parameter)=1 and parameter[1][@type='java.lang.ClassLoader']]"
		[Register (".ctor", "(Ljava/lang/ClassLoader;)V", "")]
		public BI (global::Java.Lang.ClassLoader p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BI)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/ClassLoader;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/ClassLoader;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Ljava_lang_ClassLoader_ == IntPtr.Zero)
				id_ctor_Ljava_lang_ClassLoader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/ClassLoader;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_ClassLoader_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_ClassLoader_, new JValue (p0));
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_ClassLoader_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bI']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.ClassLoader'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Class[]'] and parameter[5][@type='java.lang.Object[]']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/ClassLoader;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object A (global::Android.Content.Context p0, global::Java.Lang.ClassLoader p1, string p2, global::Java.Lang.Class[] p3, global::Java.Lang.Object[] p4)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_ClassLoader_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_ClassLoader_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/ClassLoader;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_ClassLoader_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_ClassLoader_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bI']/method[@name='a' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.ClassLoader'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Class[]'] and parameter[6][@type='java.lang.Object[]']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object A (global::Android.Content.Context p0, global::Java.Lang.ClassLoader p1, string p2, string p3, global::Java.Lang.Class[] p4, global::Java.Lang.Object[] p5)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_ClassLoader_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_ClassLoader_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_ClassLoader_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			return __ret;
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bI']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Class[]'] and parameter[5][@type='java.lang.Object[]']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object A (global::Android.Content.Context p0, global::Java.Lang.Object p1, string p2, global::Java.Lang.Class[] p3, global::Java.Lang.Object[] p4)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate cb_a_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_Handler ()
		{
			if (cb_a_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == null)
				cb_a_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_);
			return cb_a_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		}

		static IntPtr n_A_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Umeng.Message.Proguard.BI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.BI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class[] p2 = (global::Java.Lang.Class[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Class));
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0, p1, p2, p3));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bI']/method[@name='a' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class[]'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "GetA_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object A (global::Android.Content.Context p0, string p1, global::Java.Lang.Class[] p2, global::Java.Lang.Object[] p3)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_a_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/content/Context;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;"), new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate cb_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_Handler ()
		{
			if (cb_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == null)
				cb_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_);
			return cb_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		}

		static IntPtr n_A_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Umeng.Message.Proguard.BI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.BI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class[] p3 = (global::Java.Lang.Class[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Class));
			global::Java.Lang.Object[] p4 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0, p1, p2, p3, p4));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bI']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Class[]'] and parameter[5][@type='java.lang.Object[]']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "GetA_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object A (global::Android.Content.Context p0, string p1, string p2, global::Java.Lang.Class[] p3, global::Java.Lang.Object[] p4)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;"), new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bI']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;", "")]
		public static global::Java.Lang.Reflect.Field A (global::Java.Lang.Class p0, string p1)
		{
			if (id_a_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Java.Lang.Reflect.Field __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_Class_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='bI']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object A (global::Java.Lang.Object p0, string p1)
		{
			if (id_a_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_Object_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
