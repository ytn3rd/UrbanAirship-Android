using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Util {

	[global::Android.Runtime.Register ("com/urbanairship/util/AsyncImageLoader", DoNotGenerateAcw=true)]
	public partial class AsyncImageLoader : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/util/AsyncImageLoader$Delegate", DoNotGenerateAcw=true)]
		public abstract partial class Delegate : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/util/AsyncImageLoader$Delegate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Delegate); }
			}

			protected Delegate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			[Register (".ctor", "()V", "")]
			public Delegate () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Delegate)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_imageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
			static Delegate GetImageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Handler ()
			{
				if (cb_imageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ == null)
					cb_imageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ImageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_);
				return cb_imageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_;
			}

			static void n_ImageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				Delegate __this = Java.Lang.Object.GetObject<Delegate> (native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable p1 = Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ImageLoaded (p0, p1);
			}
#pragma warning restore 0169

			[Register ("imageLoaded", "(Ljava/lang/String;Landroid/graphics/drawable/Drawable;)V", "GetImageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Handler")]
			public abstract void ImageLoaded (string p0, global::Android.Graphics.Drawables.Drawable p1);

		}

		[global::Android.Runtime.Register ("com/urbanairship/util/AsyncImageLoader$Delegate", DoNotGenerateAcw=true)]
		internal partial class DelegateInvoker : Delegate {

			public DelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (DelegateInvoker); }
			}

			static IntPtr id_imageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_;
			[Register ("imageLoaded", "(Ljava/lang/String;Landroid/graphics/drawable/Drawable;)V", "GetImageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Handler")]
			public override void ImageLoaded (string p0, global::Android.Graphics.Drawables.Drawable p1)
			{
				if (id_imageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_imageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "imageLoaded", "(Ljava/lang/String;Landroid/graphics/drawable/Drawable;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod  (Handle, id_imageLoaded_Ljava_lang_String_Landroid_graphics_drawable_Drawable_, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/util/AsyncImageLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncImageLoader); }
		}

		protected AsyncImageLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_urbanairship_util_AsyncImageLoader_Delegate_;
		[Register (".ctor", "(Ljava/lang/String;Lcom/urbanairship/util/AsyncImageLoader$Delegate;)V", "")]
		public AsyncImageLoader (string p0, global::Com.Urbanairship.Util.AsyncImageLoader.Delegate p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (AsyncImageLoader)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;Lcom/urbanairship/util/AsyncImageLoader$Delegate;)V", new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_Lcom_urbanairship_util_AsyncImageLoader_Delegate_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Lcom_urbanairship_util_AsyncImageLoader_Delegate_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/urbanairship/util/AsyncImageLoader$Delegate;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_Lcom_urbanairship_util_AsyncImageLoader_Delegate_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
