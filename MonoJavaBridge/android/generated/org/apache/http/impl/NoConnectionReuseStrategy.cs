namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoConnectionReuseStrategy : java.lang.Object, ConnectionReuseStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoConnectionReuseStrategy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _keepAlive32667;
		public virtual bool keepAlive(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.NoConnectionReuseStrategy.staticClass, "keepAlive", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", ref global::org.apache.http.impl.NoConnectionReuseStrategy._keepAlive32667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _NoConnectionReuseStrategy32668;
		public NoConnectionReuseStrategy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.NoConnectionReuseStrategy._NoConnectionReuseStrategy32668.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.NoConnectionReuseStrategy._NoConnectionReuseStrategy32668 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.NoConnectionReuseStrategy.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.NoConnectionReuseStrategy.staticClass, global::org.apache.http.impl.NoConnectionReuseStrategy._NoConnectionReuseStrategy32668);
			Init(@__env, handle);
		}
		static NoConnectionReuseStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.NoConnectionReuseStrategy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/NoConnectionReuseStrategy"));
		}
		internal static void InitJNI()
		{
		}
	}
}