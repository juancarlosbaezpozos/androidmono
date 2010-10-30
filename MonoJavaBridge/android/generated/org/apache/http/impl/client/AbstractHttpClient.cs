namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.client.AbstractHttpClient_))]
	public abstract partial class AbstractHttpClient : java.lang.Object, org.apache.http.client.HttpClient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractHttpClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParams32770;
		public virtual global::org.apache.http.@params.HttpParams getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.impl.client.AbstractHttpClient._getParams32770) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams32771;
		public virtual void setParams(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setParams32771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute32772;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.impl.client.AbstractHttpClient._execute32772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute32773;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.impl.client.AbstractHttpClient._execute32773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute32774;
		public virtual global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;", ref global::org.apache.http.impl.client.AbstractHttpClient._execute32774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute32775;
		public virtual global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2, org.apache.http.protocol.HttpContext arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", ref global::org.apache.http.impl.client.AbstractHttpClient._execute32775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute32776;
		public virtual global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", ref global::org.apache.http.impl.client.AbstractHttpClient._execute32776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute32777;
		public virtual global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;", ref global::org.apache.http.impl.client.AbstractHttpClient._execute32777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute32778;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.impl.client.AbstractHttpClient._execute32778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute32779;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.impl.client.AbstractHttpClient._execute32779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionManager32780;
		public virtual global::org.apache.http.conn.ClientConnectionManager getConnectionManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionManager>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", ref global::org.apache.http.impl.client.AbstractHttpClient._getConnectionManager32780) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _setCookieStore32781;
		public virtual void setCookieStore(org.apache.http.client.CookieStore arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setCookieStore", "(Lorg/apache/http/client/CookieStore;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setCookieStore32781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCredentialsProvider32782;
		public virtual void setCredentialsProvider(org.apache.http.client.CredentialsProvider arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setCredentialsProvider", "(Lorg/apache/http/client/CredentialsProvider;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setCredentialsProvider32782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createHttpParams32783;
		protected abstract global::org.apache.http.@params.HttpParams createHttpParams();
		internal static global::MonoJavaBridge.MethodId _createHttpContext32784;
		protected abstract global::org.apache.http.protocol.HttpContext createHttpContext();
		internal static global::MonoJavaBridge.MethodId _createRequestExecutor32785;
		protected abstract global::org.apache.http.protocol.HttpRequestExecutor createRequestExecutor();
		internal static global::MonoJavaBridge.MethodId _createClientConnectionManager32786;
		protected abstract global::org.apache.http.conn.ClientConnectionManager createClientConnectionManager();
		internal static global::MonoJavaBridge.MethodId _createAuthSchemeRegistry32787;
		protected abstract global::org.apache.http.auth.AuthSchemeRegistry createAuthSchemeRegistry();
		internal static global::MonoJavaBridge.MethodId _createCookieSpecRegistry32788;
		protected abstract global::org.apache.http.cookie.CookieSpecRegistry createCookieSpecRegistry();
		internal static global::MonoJavaBridge.MethodId _createConnectionReuseStrategy32789;
		protected abstract global::org.apache.http.ConnectionReuseStrategy createConnectionReuseStrategy();
		internal static global::MonoJavaBridge.MethodId _createConnectionKeepAliveStrategy32790;
		protected abstract global::org.apache.http.conn.ConnectionKeepAliveStrategy createConnectionKeepAliveStrategy();
		internal static global::MonoJavaBridge.MethodId _createHttpProcessor32791;
		protected abstract global::org.apache.http.protocol.BasicHttpProcessor createHttpProcessor();
		internal static global::MonoJavaBridge.MethodId _createHttpRequestRetryHandler32792;
		protected abstract global::org.apache.http.client.HttpRequestRetryHandler createHttpRequestRetryHandler();
		internal static global::MonoJavaBridge.MethodId _createRedirectHandler32793;
		protected abstract global::org.apache.http.client.RedirectHandler createRedirectHandler();
		internal static global::MonoJavaBridge.MethodId _createTargetAuthenticationHandler32794;
		protected abstract global::org.apache.http.client.AuthenticationHandler createTargetAuthenticationHandler();
		internal static global::MonoJavaBridge.MethodId _createProxyAuthenticationHandler32795;
		protected abstract global::org.apache.http.client.AuthenticationHandler createProxyAuthenticationHandler();
		internal static global::MonoJavaBridge.MethodId _createCookieStore32796;
		protected abstract global::org.apache.http.client.CookieStore createCookieStore();
		internal static global::MonoJavaBridge.MethodId _createCredentialsProvider32797;
		protected abstract global::org.apache.http.client.CredentialsProvider createCredentialsProvider();
		internal static global::MonoJavaBridge.MethodId _createHttpRoutePlanner32798;
		protected abstract global::org.apache.http.conn.routing.HttpRoutePlanner createHttpRoutePlanner();
		internal static global::MonoJavaBridge.MethodId _createUserTokenHandler32799;
		protected abstract global::org.apache.http.client.UserTokenHandler createUserTokenHandler();
		internal static global::MonoJavaBridge.MethodId _getRequestExecutor32800;
		public virtual global::org.apache.http.protocol.HttpRequestExecutor getRequestExecutor()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;", ref global::org.apache.http.impl.client.AbstractHttpClient._getRequestExecutor32800) as org.apache.http.protocol.HttpRequestExecutor;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthSchemes32801;
		public virtual global::org.apache.http.auth.AuthSchemeRegistry getAuthSchemes()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.auth.AuthSchemeRegistry>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getAuthSchemes", "()Lorg/apache/http/auth/AuthSchemeRegistry;", ref global::org.apache.http.impl.client.AbstractHttpClient._getAuthSchemes32801) as org.apache.http.auth.AuthSchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _setAuthSchemes32802;
		public virtual void setAuthSchemes(org.apache.http.auth.AuthSchemeRegistry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setAuthSchemes", "(Lorg/apache/http/auth/AuthSchemeRegistry;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setAuthSchemes32802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCookieSpecs32803;
		public virtual global::org.apache.http.cookie.CookieSpecRegistry getCookieSpecs()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.cookie.CookieSpecRegistry>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getCookieSpecs", "()Lorg/apache/http/cookie/CookieSpecRegistry;", ref global::org.apache.http.impl.client.AbstractHttpClient._getCookieSpecs32803) as org.apache.http.cookie.CookieSpecRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _setCookieSpecs32804;
		public virtual void setCookieSpecs(org.apache.http.cookie.CookieSpecRegistry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setCookieSpecs", "(Lorg/apache/http/cookie/CookieSpecRegistry;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setCookieSpecs32804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionReuseStrategy32805;
		public virtual global::org.apache.http.ConnectionReuseStrategy getConnectionReuseStrategy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.ConnectionReuseStrategy>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;", ref global::org.apache.http.impl.client.AbstractHttpClient._getConnectionReuseStrategy32805) as org.apache.http.ConnectionReuseStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _setReuseStrategy32806;
		public virtual void setReuseStrategy(org.apache.http.ConnectionReuseStrategy arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setReuseStrategy", "(Lorg/apache/http/ConnectionReuseStrategy;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setReuseStrategy32806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionKeepAliveStrategy32807;
		public virtual global::org.apache.http.conn.ConnectionKeepAliveStrategy getConnectionKeepAliveStrategy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ConnectionKeepAliveStrategy>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;", ref global::org.apache.http.impl.client.AbstractHttpClient._getConnectionKeepAliveStrategy32807) as org.apache.http.conn.ConnectionKeepAliveStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _setKeepAliveStrategy32808;
		public virtual void setKeepAliveStrategy(org.apache.http.conn.ConnectionKeepAliveStrategy arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setKeepAliveStrategy", "(Lorg/apache/http/conn/ConnectionKeepAliveStrategy;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setKeepAliveStrategy32808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpRequestRetryHandler32809;
		public virtual global::org.apache.http.client.HttpRequestRetryHandler getHttpRequestRetryHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.HttpRequestRetryHandler>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;", ref global::org.apache.http.impl.client.AbstractHttpClient._getHttpRequestRetryHandler32809) as org.apache.http.client.HttpRequestRetryHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setHttpRequestRetryHandler32810;
		public virtual void setHttpRequestRetryHandler(org.apache.http.client.HttpRequestRetryHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setHttpRequestRetryHandler", "(Lorg/apache/http/client/HttpRequestRetryHandler;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setHttpRequestRetryHandler32810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRedirectHandler32811;
		public virtual global::org.apache.http.client.RedirectHandler getRedirectHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.RedirectHandler>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;", ref global::org.apache.http.impl.client.AbstractHttpClient._getRedirectHandler32811) as org.apache.http.client.RedirectHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setRedirectHandler32812;
		public virtual void setRedirectHandler(org.apache.http.client.RedirectHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setRedirectHandler", "(Lorg/apache/http/client/RedirectHandler;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setRedirectHandler32812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTargetAuthenticationHandler32813;
		public virtual global::org.apache.http.client.AuthenticationHandler getTargetAuthenticationHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.AuthenticationHandler>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", ref global::org.apache.http.impl.client.AbstractHttpClient._getTargetAuthenticationHandler32813) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setTargetAuthenticationHandler32814;
		public virtual void setTargetAuthenticationHandler(org.apache.http.client.AuthenticationHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setTargetAuthenticationHandler", "(Lorg/apache/http/client/AuthenticationHandler;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setTargetAuthenticationHandler32814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getProxyAuthenticationHandler32815;
		public virtual global::org.apache.http.client.AuthenticationHandler getProxyAuthenticationHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.AuthenticationHandler>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", ref global::org.apache.http.impl.client.AbstractHttpClient._getProxyAuthenticationHandler32815) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setProxyAuthenticationHandler32816;
		public virtual void setProxyAuthenticationHandler(org.apache.http.client.AuthenticationHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setProxyAuthenticationHandler", "(Lorg/apache/http/client/AuthenticationHandler;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setProxyAuthenticationHandler32816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCookieStore32817;
		public virtual global::org.apache.http.client.CookieStore getCookieStore()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.CookieStore>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getCookieStore", "()Lorg/apache/http/client/CookieStore;", ref global::org.apache.http.impl.client.AbstractHttpClient._getCookieStore32817) as org.apache.http.client.CookieStore;
		}
		internal static global::MonoJavaBridge.MethodId _getCredentialsProvider32818;
		public virtual global::org.apache.http.client.CredentialsProvider getCredentialsProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.CredentialsProvider>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;", ref global::org.apache.http.impl.client.AbstractHttpClient._getCredentialsProvider32818) as org.apache.http.client.CredentialsProvider;
		}
		internal static global::MonoJavaBridge.MethodId _getRoutePlanner32819;
		public virtual global::org.apache.http.conn.routing.HttpRoutePlanner getRoutePlanner()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.routing.HttpRoutePlanner>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;", ref global::org.apache.http.impl.client.AbstractHttpClient._getRoutePlanner32819) as org.apache.http.conn.routing.HttpRoutePlanner;
		}
		internal static global::MonoJavaBridge.MethodId _setRoutePlanner32820;
		public virtual void setRoutePlanner(org.apache.http.conn.routing.HttpRoutePlanner arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setRoutePlanner", "(Lorg/apache/http/conn/routing/HttpRoutePlanner;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setRoutePlanner32820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUserTokenHandler32821;
		public virtual global::org.apache.http.client.UserTokenHandler getUserTokenHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.UserTokenHandler>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;", ref global::org.apache.http.impl.client.AbstractHttpClient._getUserTokenHandler32821) as org.apache.http.client.UserTokenHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setUserTokenHandler32822;
		public virtual void setUserTokenHandler(org.apache.http.client.UserTokenHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setUserTokenHandler", "(Lorg/apache/http/client/UserTokenHandler;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._setUserTokenHandler32822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpProcessor32823;
		protected virtual global::org.apache.http.protocol.BasicHttpProcessor getHttpProcessor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.protocol.BasicHttpProcessor>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;", ref global::org.apache.http.impl.client.AbstractHttpClient._getHttpProcessor32823) as org.apache.http.protocol.BasicHttpProcessor;
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor32824;
		public virtual void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor32824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor32825;
		public virtual void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V", ref global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor32825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptor32826;
		public virtual global::org.apache.http.HttpResponseInterceptor getResponseInterceptor(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponseInterceptor>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;", ref global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptor32826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpResponseInterceptor;
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptorCount32827;
		public virtual int getResponseInterceptorCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getResponseInterceptorCount", "()I", ref global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptorCount32827);
		}
		internal static global::MonoJavaBridge.MethodId _clearResponseInterceptors32828;
		public virtual void clearResponseInterceptors()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "clearResponseInterceptors", "()V", ref global::org.apache.http.impl.client.AbstractHttpClient._clearResponseInterceptors32828);
		}
		internal static global::MonoJavaBridge.MethodId _removeResponseInterceptorByClass32829;
		public virtual void removeResponseInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "removeResponseInterceptorByClass", "(Ljava/lang/Class;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._removeResponseInterceptorByClass32829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor32830;
		public virtual void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V", ref global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor32830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor32831;
		public virtual void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor32831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptor32832;
		public virtual global::org.apache.http.HttpRequestInterceptor getRequestInterceptor(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequestInterceptor>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;", ref global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptor32832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpRequestInterceptor;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptorCount32833;
		public virtual int getRequestInterceptorCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRequestInterceptorCount", "()I", ref global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptorCount32833);
		}
		internal static global::MonoJavaBridge.MethodId _clearRequestInterceptors32834;
		public virtual void clearRequestInterceptors()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "clearRequestInterceptors", "()V", ref global::org.apache.http.impl.client.AbstractHttpClient._clearRequestInterceptors32834);
		}
		internal static global::MonoJavaBridge.MethodId _removeRequestInterceptorByClass32835;
		public virtual void removeRequestInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "removeRequestInterceptorByClass", "(Ljava/lang/Class;)V", ref global::org.apache.http.impl.client.AbstractHttpClient._removeRequestInterceptorByClass32835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createClientRequestDirector32836;
		protected virtual global::org.apache.http.client.RequestDirector createClientRequestDirector(org.apache.http.protocol.HttpRequestExecutor arg0, org.apache.http.conn.ClientConnectionManager arg1, org.apache.http.ConnectionReuseStrategy arg2, org.apache.http.conn.ConnectionKeepAliveStrategy arg3, org.apache.http.conn.routing.HttpRoutePlanner arg4, org.apache.http.protocol.HttpProcessor arg5, org.apache.http.client.HttpRequestRetryHandler arg6, org.apache.http.client.RedirectHandler arg7, org.apache.http.client.AuthenticationHandler arg8, org.apache.http.client.AuthenticationHandler arg9, org.apache.http.client.UserTokenHandler arg10, org.apache.http.@params.HttpParams arg11)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.RequestDirector>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createClientRequestDirector", "(Lorg/apache/http/protocol/HttpRequestExecutor;Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/ConnectionReuseStrategy;Lorg/apache/http/conn/ConnectionKeepAliveStrategy;Lorg/apache/http/conn/routing/HttpRoutePlanner;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/client/HttpRequestRetryHandler;Lorg/apache/http/client/RedirectHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/UserTokenHandler;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/client/RequestDirector;", ref global::org.apache.http.impl.client.AbstractHttpClient._createClientRequestDirector32836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11)) as org.apache.http.client.RequestDirector;
		}
		internal static global::MonoJavaBridge.MethodId _determineParams32837;
		protected virtual global::org.apache.http.@params.HttpParams determineParams(org.apache.http.HttpRequest arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "determineParams", "(Lorg/apache/http/HttpRequest;)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.impl.client.AbstractHttpClient._determineParams32837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpClient32838;
		protected AbstractHttpClient(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.@params.HttpParams arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.AbstractHttpClient._AbstractHttpClient32838.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.AbstractHttpClient._AbstractHttpClient32838 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._AbstractHttpClient32838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AbstractHttpClient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.AbstractHttpClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/AbstractHttpClient"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.client.AbstractHttpClient))]
	internal sealed partial class AbstractHttpClient_ : org.apache.http.impl.client.AbstractHttpClient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractHttpClient_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createHttpParams32839;
		protected override global::org.apache.http.@params.HttpParams createHttpParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createHttpParams32839) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpContext32840;
		protected override global::org.apache.http.protocol.HttpContext createHttpContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.protocol.HttpContext>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpContext", "()Lorg/apache/http/protocol/HttpContext;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createHttpContext32840) as org.apache.http.protocol.HttpContext;
		}
		internal static global::MonoJavaBridge.MethodId _createRequestExecutor32841;
		protected override global::org.apache.http.protocol.HttpRequestExecutor createRequestExecutor()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createRequestExecutor32841) as org.apache.http.protocol.HttpRequestExecutor;
		}
		internal static global::MonoJavaBridge.MethodId _createClientConnectionManager32842;
		protected override global::org.apache.http.conn.ClientConnectionManager createClientConnectionManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionManager>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createClientConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createClientConnectionManager32842) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _createAuthSchemeRegistry32843;
		protected override global::org.apache.http.auth.AuthSchemeRegistry createAuthSchemeRegistry()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.auth.AuthSchemeRegistry>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createAuthSchemeRegistry", "()Lorg/apache/http/auth/AuthSchemeRegistry;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createAuthSchemeRegistry32843) as org.apache.http.auth.AuthSchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _createCookieSpecRegistry32844;
		protected override global::org.apache.http.cookie.CookieSpecRegistry createCookieSpecRegistry()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.cookie.CookieSpecRegistry>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createCookieSpecRegistry", "()Lorg/apache/http/cookie/CookieSpecRegistry;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createCookieSpecRegistry32844) as org.apache.http.cookie.CookieSpecRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionReuseStrategy32845;
		protected override global::org.apache.http.ConnectionReuseStrategy createConnectionReuseStrategy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.ConnectionReuseStrategy>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionReuseStrategy32845) as org.apache.http.ConnectionReuseStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionKeepAliveStrategy32846;
		protected override global::org.apache.http.conn.ConnectionKeepAliveStrategy createConnectionKeepAliveStrategy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ConnectionKeepAliveStrategy>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionKeepAliveStrategy32846) as org.apache.http.conn.ConnectionKeepAliveStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpProcessor32847;
		protected override global::org.apache.http.protocol.BasicHttpProcessor createHttpProcessor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.protocol.BasicHttpProcessor>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createHttpProcessor32847) as org.apache.http.protocol.BasicHttpProcessor;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRequestRetryHandler32848;
		protected override global::org.apache.http.client.HttpRequestRetryHandler createHttpRequestRetryHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.HttpRequestRetryHandler>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRequestRetryHandler32848) as org.apache.http.client.HttpRequestRetryHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createRedirectHandler32849;
		protected override global::org.apache.http.client.RedirectHandler createRedirectHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.RedirectHandler>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createRedirectHandler32849) as org.apache.http.client.RedirectHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createTargetAuthenticationHandler32850;
		protected override global::org.apache.http.client.AuthenticationHandler createTargetAuthenticationHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.AuthenticationHandler>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createTargetAuthenticationHandler32850) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createProxyAuthenticationHandler32851;
		protected override global::org.apache.http.client.AuthenticationHandler createProxyAuthenticationHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.AuthenticationHandler>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createProxyAuthenticationHandler32851) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createCookieStore32852;
		protected override global::org.apache.http.client.CookieStore createCookieStore()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.CookieStore>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createCookieStore", "()Lorg/apache/http/client/CookieStore;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createCookieStore32852) as org.apache.http.client.CookieStore;
		}
		internal static global::MonoJavaBridge.MethodId _createCredentialsProvider32853;
		protected override global::org.apache.http.client.CredentialsProvider createCredentialsProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.CredentialsProvider>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createCredentialsProvider32853) as org.apache.http.client.CredentialsProvider;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRoutePlanner32854;
		protected override global::org.apache.http.conn.routing.HttpRoutePlanner createHttpRoutePlanner()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.routing.HttpRoutePlanner>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRoutePlanner32854) as org.apache.http.conn.routing.HttpRoutePlanner;
		}
		internal static global::MonoJavaBridge.MethodId _createUserTokenHandler32855;
		protected override global::org.apache.http.client.UserTokenHandler createUserTokenHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.UserTokenHandler>(this, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;", ref global::org.apache.http.impl.client.AbstractHttpClient_._createUserTokenHandler32855) as org.apache.http.client.UserTokenHandler;
		}
		static AbstractHttpClient_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.AbstractHttpClient_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/AbstractHttpClient"));
		}
		internal static void InitJNI()
		{
		}
	}
}