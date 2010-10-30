namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ConnPerRouteBean : java.lang.Object, ConnPerRoute
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConnPerRouteBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int DefaultMax
		{
			get
			{
				return getDefaultMax();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultMax32192;
		public int getDefaultMax()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "getDefaultMax", "()I", ref global::org.apache.http.conn.@params.ConnPerRouteBean._getDefaultMax32192);
		}
		public new int DefaultMaxPerRoute
		{
			set
			{
				setDefaultMaxPerRoute(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultMaxPerRoute32193;
		public void setDefaultMaxPerRoute(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "setDefaultMaxPerRoute", "(I)V", ref global::org.apache.http.conn.@params.ConnPerRouteBean._setDefaultMaxPerRoute32193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxForRoute32194;
		public void setMaxForRoute(org.apache.http.conn.routing.HttpRoute arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "setMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;I)V", ref global::org.apache.http.conn.@params.ConnPerRouteBean._setMaxForRoute32194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxForRoute32195;
		public int getMaxForRoute(org.apache.http.conn.routing.HttpRoute arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "getMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;)I", ref global::org.apache.http.conn.@params.ConnPerRouteBean._getMaxForRoute32195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Map MaxForRoutes
		{
			set
			{
				setMaxForRoutes(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxForRoutes32196;
		public void setMaxForRoutes(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "setMaxForRoutes", "(Ljava/util/Map;)V", ref global::org.apache.http.conn.@params.ConnPerRouteBean._setMaxForRoutes32196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConnPerRouteBean32197;
		public ConnPerRouteBean(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnPerRouteBean._ConnPerRouteBean32197.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnPerRouteBean._ConnPerRouteBean32197 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnPerRouteBean.staticClass, global::org.apache.http.conn.@params.ConnPerRouteBean._ConnPerRouteBean32197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConnPerRouteBean32198;
		public ConnPerRouteBean() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnPerRouteBean._ConnPerRouteBean32198.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnPerRouteBean._ConnPerRouteBean32198 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnPerRouteBean.staticClass, global::org.apache.http.conn.@params.ConnPerRouteBean._ConnPerRouteBean32198);
			Init(@__env, handle);
		}
		public static int DEFAULT_MAX_CONNECTIONS_PER_ROUTE
		{
			get
			{
				return 2;
			}
		}
		static ConnPerRouteBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnPerRouteBean"));
		}
		internal static void InitJNI()
		{
		}
	}
}