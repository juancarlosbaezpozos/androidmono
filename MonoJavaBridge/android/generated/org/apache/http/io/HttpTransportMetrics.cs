namespace org.apache.http.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.io.HttpTransportMetrics_))]
	public partial interface HttpTransportMetrics  : global::MonoJavaBridge.IJavaObject 
	{
		void reset();
		long getBytesTransferred();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.io.HttpTransportMetrics))]
	internal sealed partial class HttpTransportMetrics_ : java.lang.Object, HttpTransportMetrics
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpTransportMetrics_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset33469;
		void org.apache.http.io.HttpTransportMetrics.reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.HttpTransportMetrics_.staticClass, "reset", "()V", ref global::org.apache.http.io.HttpTransportMetrics_._reset33469);
		}
		internal static global::MonoJavaBridge.MethodId _getBytesTransferred33470;
		long org.apache.http.io.HttpTransportMetrics.getBytesTransferred()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.io.HttpTransportMetrics_.staticClass, "getBytesTransferred", "()J", ref global::org.apache.http.io.HttpTransportMetrics_._getBytesTransferred33470);
		}
		static HttpTransportMetrics_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.io.HttpTransportMetrics_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/io/HttpTransportMetrics"));
		}
		internal static void InitJNI()
		{
		}
	}
}