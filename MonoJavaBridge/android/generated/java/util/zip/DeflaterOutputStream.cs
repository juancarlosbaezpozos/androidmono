namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DeflaterOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DeflaterOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write28384;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.DeflaterOutputStream.staticClass, "write", "([BII)V", ref global::java.util.zip.DeflaterOutputStream._write28384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write28385;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.DeflaterOutputStream.staticClass, "write", "(I)V", ref global::java.util.zip.DeflaterOutputStream._write28385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close28386;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.DeflaterOutputStream.staticClass, "close", "()V", ref global::java.util.zip.DeflaterOutputStream._close28386);
		}
		internal static global::MonoJavaBridge.MethodId _finish28387;
		public virtual void finish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.DeflaterOutputStream.staticClass, "finish", "()V", ref global::java.util.zip.DeflaterOutputStream._finish28387);
		}
		internal static global::MonoJavaBridge.MethodId _deflate28388;
		protected virtual void deflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.DeflaterOutputStream.staticClass, "deflate", "()V", ref global::java.util.zip.DeflaterOutputStream._deflate28388);
		}
		internal static global::MonoJavaBridge.MethodId _DeflaterOutputStream28389;
		public DeflaterOutputStream(java.io.OutputStream arg0, java.util.zip.Deflater arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28389.native == global::System.IntPtr.Zero)
				global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28389 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DeflaterOutputStream28390;
		public DeflaterOutputStream(java.io.OutputStream arg0, java.util.zip.Deflater arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28390.native == global::System.IntPtr.Zero)
				global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28390 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DeflaterOutputStream28391;
		public DeflaterOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28391.native == global::System.IntPtr.Zero)
				global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28391 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DeflaterOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.DeflaterOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/DeflaterOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}