namespace javax.xml.@namespace
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.@namespace.NamespaceContext_))]
	public interface NamespaceContext  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getPrefix(java.lang.String arg0);
		global::java.lang.String getNamespaceURI(java.lang.String arg0);
		global::java.util.Iterator getPrefixes(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.@namespace.NamespaceContext))]
	public sealed partial class NamespaceContext_ : java.lang.Object, NamespaceContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NamespaceContext_()
		{
			InitJNI();
		}
		internal NamespaceContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix30700;
		 global::java.lang.String javax.xml.@namespace.NamespaceContext.getPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.@namespace.NamespaceContext_._getPrefix30700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.@namespace.NamespaceContext_.staticClass, global::javax.xml.@namespace.NamespaceContext_._getPrefix30700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI30701;
		 global::java.lang.String javax.xml.@namespace.NamespaceContext.getNamespaceURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.@namespace.NamespaceContext_._getNamespaceURI30701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.@namespace.NamespaceContext_.staticClass, global::javax.xml.@namespace.NamespaceContext_._getNamespaceURI30701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefixes30702;
		 global::java.util.Iterator javax.xml.@namespace.NamespaceContext.getPrefixes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.@namespace.NamespaceContext_._getPrefixes30702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.@namespace.NamespaceContext_.staticClass, global::javax.xml.@namespace.NamespaceContext_._getPrefixes30702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.@namespace.NamespaceContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/@namespace/NamespaceContext"));
			global::javax.xml.@namespace.NamespaceContext_._getPrefix30700 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.NamespaceContext_.staticClass, "getPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::javax.xml.@namespace.NamespaceContext_._getNamespaceURI30701 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.NamespaceContext_.staticClass, "getNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::javax.xml.@namespace.NamespaceContext_._getPrefixes30702 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.NamespaceContext_.staticClass, "getPrefixes", "(Ljava/lang/String;)Ljava/util/Iterator;");
		}
	}
}