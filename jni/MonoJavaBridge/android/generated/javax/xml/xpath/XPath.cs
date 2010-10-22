namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.xpath.XPath_))]
	public interface XPath  : global::MonoJavaBridge.IJavaObject 
	{
		global::javax.xml.xpath.XPathExpression compile(java.lang.String arg0);
		void reset();
		void setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver arg0);
		global::javax.xml.xpath.XPathVariableResolver getXPathVariableResolver();
		void setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver arg0);
		global::javax.xml.xpath.XPathFunctionResolver getXPathFunctionResolver();
		void setNamespaceContext(javax.xml.@namespace.NamespaceContext arg0);
		global::javax.xml.@namespace.NamespaceContext getNamespaceContext();
		global::java.lang.Object evaluate(java.lang.String arg0, java.lang.Object arg1, javax.xml.@namespace.QName arg2);
		global::java.lang.String evaluate(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object evaluate(java.lang.String arg0, org.xml.sax.InputSource arg1, javax.xml.@namespace.QName arg2);
		global::java.lang.String evaluate(java.lang.String arg0, org.xml.sax.InputSource arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.xpath.XPath))]
	public sealed partial class XPath_ : java.lang.Object, XPath
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XPath_()
		{
			InitJNI();
		}
		internal XPath_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compile31161;
		 global::javax.xml.xpath.XPathExpression javax.xml.xpath.XPath.compile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathExpression>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._compile31161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.xpath.XPathExpression;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathExpression>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._compile31161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.xpath.XPathExpression;
		}
		internal static global::MonoJavaBridge.MethodId _reset31162;
		 void javax.xml.xpath.XPath.reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._reset31162);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._reset31162);
		}
		internal static global::MonoJavaBridge.MethodId _setXPathVariableResolver31163;
		 void javax.xml.xpath.XPath.setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._setXPathVariableResolver31163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._setXPathVariableResolver31163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getXPathVariableResolver31164;
		 global::javax.xml.xpath.XPathVariableResolver javax.xml.xpath.XPath.getXPathVariableResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathVariableResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._getXPathVariableResolver31164)) as javax.xml.xpath.XPathVariableResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathVariableResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._getXPathVariableResolver31164)) as javax.xml.xpath.XPathVariableResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setXPathFunctionResolver31165;
		 void javax.xml.xpath.XPath.setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._setXPathFunctionResolver31165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._setXPathFunctionResolver31165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getXPathFunctionResolver31166;
		 global::javax.xml.xpath.XPathFunctionResolver javax.xml.xpath.XPath.getXPathFunctionResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathFunctionResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._getXPathFunctionResolver31166)) as javax.xml.xpath.XPathFunctionResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.xpath.XPathFunctionResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._getXPathFunctionResolver31166)) as javax.xml.xpath.XPathFunctionResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setNamespaceContext31167;
		 void javax.xml.xpath.XPath.setNamespaceContext(javax.xml.@namespace.NamespaceContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._setNamespaceContext31167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._setNamespaceContext31167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceContext31168;
		 global::javax.xml.@namespace.NamespaceContext javax.xml.xpath.XPath.getNamespaceContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.@namespace.NamespaceContext>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._getNamespaceContext31168)) as javax.xml.@namespace.NamespaceContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.@namespace.NamespaceContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._getNamespaceContext31168)) as javax.xml.@namespace.NamespaceContext;
		}
		internal static global::MonoJavaBridge.MethodId _evaluate31169;
		 global::java.lang.Object javax.xml.xpath.XPath.evaluate(java.lang.String arg0, java.lang.Object arg1, javax.xml.@namespace.QName arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._evaluate31169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._evaluate31169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _evaluate31170;
		 global::java.lang.String javax.xml.xpath.XPath.evaluate(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._evaluate31170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._evaluate31170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _evaluate31171;
		 global::java.lang.Object javax.xml.xpath.XPath.evaluate(java.lang.String arg0, org.xml.sax.InputSource arg1, javax.xml.@namespace.QName arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._evaluate31171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._evaluate31171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _evaluate31172;
		 global::java.lang.String javax.xml.xpath.XPath.evaluate(java.lang.String arg0, org.xml.sax.InputSource arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_._evaluate31172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPath_.staticClass, global::javax.xml.xpath.XPath_._evaluate31172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPath_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPath"));
			global::javax.xml.xpath.XPath_._compile31161 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "compile", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathExpression;");
			global::javax.xml.xpath.XPath_._reset31162 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "reset", "()V");
			global::javax.xml.xpath.XPath_._setXPathVariableResolver31163 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V");
			global::javax.xml.xpath.XPath_._getXPathVariableResolver31164 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "getXPathVariableResolver", "()Ljavax/xml/xpath/XPathVariableResolver;");
			global::javax.xml.xpath.XPath_._setXPathFunctionResolver31165 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V");
			global::javax.xml.xpath.XPath_._getXPathFunctionResolver31166 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "getXPathFunctionResolver", "()Ljavax/xml/xpath/XPathFunctionResolver;");
			global::javax.xml.xpath.XPath_._setNamespaceContext31167 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "setNamespaceContext", "(Ljavax/xml/@namespace/NamespaceContext;)V");
			global::javax.xml.xpath.XPath_._getNamespaceContext31168 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "getNamespaceContext", "()Ljavax/xml/@namespace/NamespaceContext;");
			global::javax.xml.xpath.XPath_._evaluate31169 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "evaluate", "(Ljava/lang/String;Ljava/lang/Object;Ljavax/xml/@namespace/QName;)Ljava/lang/Object;");
			global::javax.xml.xpath.XPath_._evaluate31170 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "evaluate", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;");
			global::javax.xml.xpath.XPath_._evaluate31171 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "evaluate", "(Ljava/lang/String;Lorg/xml/sax/InputSource;Ljavax/xml/@namespace/QName;)Ljava/lang/Object;");
			global::javax.xml.xpath.XPath_._evaluate31172 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPath_.staticClass, "evaluate", "(Ljava/lang/String;Lorg/xml/sax/InputSource;)Ljava/lang/String;");
		}
	}
}