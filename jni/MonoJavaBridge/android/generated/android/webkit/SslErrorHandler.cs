namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SslErrorHandler : android.os.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SslErrorHandler()
		{
			InitJNI();
		}
		protected SslErrorHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cancel10360;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.SslErrorHandler._cancel10360);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.SslErrorHandler.staticClass, global::android.webkit.SslErrorHandler._cancel10360);
		}
		internal static global::MonoJavaBridge.MethodId _handleMessage10361;
		public override void handleMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.SslErrorHandler._handleMessage10361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.SslErrorHandler.staticClass, global::android.webkit.SslErrorHandler._handleMessage10361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _proceed10362;
		public virtual void proceed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.SslErrorHandler._proceed10362);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.SslErrorHandler.staticClass, global::android.webkit.SslErrorHandler._proceed10362);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.SslErrorHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/SslErrorHandler"));
			global::android.webkit.SslErrorHandler._cancel10360 = @__env.GetMethodIDNoThrow(global::android.webkit.SslErrorHandler.staticClass, "cancel", "()V");
			global::android.webkit.SslErrorHandler._handleMessage10361 = @__env.GetMethodIDNoThrow(global::android.webkit.SslErrorHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
			global::android.webkit.SslErrorHandler._proceed10362 = @__env.GetMethodIDNoThrow(global::android.webkit.SslErrorHandler.staticClass, "proceed", "()V");
		}
	}
}
