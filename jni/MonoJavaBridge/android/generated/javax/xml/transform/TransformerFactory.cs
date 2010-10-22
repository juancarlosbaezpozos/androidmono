namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.transform.TransformerFactory_))]
	public abstract partial class TransformerFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TransformerFactory()
		{
			InitJNI();
		}
		protected TransformerFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30887;
		public static global::javax.xml.transform.TransformerFactory newInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.transform.TransformerFactory.staticClass, global::javax.xml.transform.TransformerFactory._newInstance30887)) as javax.xml.transform.TransformerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30888;
		public static global::javax.xml.transform.TransformerFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.transform.TransformerFactory.staticClass, global::javax.xml.transform.TransformerFactory._newInstance30888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.transform.TransformerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute30889;
		public abstract global::java.lang.Object getAttribute(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setFeature30890;
		public abstract void setFeature(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getFeature30891;
		public abstract bool getFeature(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setAttribute30892;
		public abstract void setAttribute(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _newTransformer30893;
		public abstract global::javax.xml.transform.Transformer newTransformer();
		internal static global::MonoJavaBridge.MethodId _newTransformer30894;
		public abstract global::javax.xml.transform.Transformer newTransformer(javax.xml.transform.Source arg0);
		internal static global::MonoJavaBridge.MethodId _setURIResolver30895;
		public abstract void setURIResolver(javax.xml.transform.URIResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getURIResolver30896;
		public abstract global::javax.xml.transform.URIResolver getURIResolver();
		internal static global::MonoJavaBridge.MethodId _setErrorListener30897;
		public abstract void setErrorListener(javax.xml.transform.ErrorListener arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorListener30898;
		public abstract global::javax.xml.transform.ErrorListener getErrorListener();
		internal static global::MonoJavaBridge.MethodId _newTemplates30899;
		public abstract global::javax.xml.transform.Templates newTemplates(javax.xml.transform.Source arg0);
		internal static global::MonoJavaBridge.MethodId _getAssociatedStylesheet30900;
		public abstract global::javax.xml.transform.Source getAssociatedStylesheet(javax.xml.transform.Source arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		internal static global::MonoJavaBridge.MethodId _TransformerFactory30901;
		protected TransformerFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactory.staticClass, global::javax.xml.transform.TransformerFactory._TransformerFactory30901);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerFactory"));
			global::javax.xml.transform.TransformerFactory._newInstance30887 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "newInstance", "()Ljavax/xml/transform/TransformerFactory;");
			global::javax.xml.transform.TransformerFactory._newInstance30888 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/transform/TransformerFactory;");
			global::javax.xml.transform.TransformerFactory._getAttribute30889 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.transform.TransformerFactory._setFeature30890 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.transform.TransformerFactory._getFeature30891 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.transform.TransformerFactory._setAttribute30892 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.transform.TransformerFactory._newTransformer30893 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "newTransformer", "()Ljavax/xml/transform/Transformer;");
			global::javax.xml.transform.TransformerFactory._newTransformer30894 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "newTransformer", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Transformer;");
			global::javax.xml.transform.TransformerFactory._setURIResolver30895 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V");
			global::javax.xml.transform.TransformerFactory._getURIResolver30896 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;");
			global::javax.xml.transform.TransformerFactory._setErrorListener30897 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V");
			global::javax.xml.transform.TransformerFactory._getErrorListener30898 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;");
			global::javax.xml.transform.TransformerFactory._newTemplates30899 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "newTemplates", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Templates;");
			global::javax.xml.transform.TransformerFactory._getAssociatedStylesheet30900 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "getAssociatedStylesheet", "(Ljavax/xml/transform/Source;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/transform/Source;");
			global::javax.xml.transform.TransformerFactory._TransformerFactory30901 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.TransformerFactory))]
	public sealed partial class TransformerFactory_ : javax.xml.transform.TransformerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TransformerFactory_()
		{
			InitJNI();
		}
		internal TransformerFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute30902;
		public override global::java.lang.Object getAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_._getAttribute30902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_.staticClass, global::javax.xml.transform.TransformerFactory_._getAttribute30902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature30903;
		public override void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_._setFeature30903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_.staticClass, global::javax.xml.transform.TransformerFactory_._setFeature30903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature30904;
		public override bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_._getFeature30904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_.staticClass, global::javax.xml.transform.TransformerFactory_._getFeature30904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute30905;
		public override void setAttribute(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_._setAttribute30905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_.staticClass, global::javax.xml.transform.TransformerFactory_._setAttribute30905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newTransformer30906;
		public override global::javax.xml.transform.Transformer newTransformer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_._newTransformer30906)) as javax.xml.transform.Transformer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_.staticClass, global::javax.xml.transform.TransformerFactory_._newTransformer30906)) as javax.xml.transform.Transformer;
		}
		internal static global::MonoJavaBridge.MethodId _newTransformer30907;
		public override global::javax.xml.transform.Transformer newTransformer(javax.xml.transform.Source arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_._newTransformer30907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.transform.Transformer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_.staticClass, global::javax.xml.transform.TransformerFactory_._newTransformer30907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.transform.Transformer;
		}
		internal static global::MonoJavaBridge.MethodId _setURIResolver30908;
		public override void setURIResolver(javax.xml.transform.URIResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_._setURIResolver30908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_.staticClass, global::javax.xml.transform.TransformerFactory_._setURIResolver30908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getURIResolver30909;
		public override global::javax.xml.transform.URIResolver getURIResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.URIResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_._getURIResolver30909)) as javax.xml.transform.URIResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.URIResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_.staticClass, global::javax.xml.transform.TransformerFactory_._getURIResolver30909)) as javax.xml.transform.URIResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setErrorListener30910;
		public override void setErrorListener(javax.xml.transform.ErrorListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_._setErrorListener30910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_.staticClass, global::javax.xml.transform.TransformerFactory_._setErrorListener30910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorListener30911;
		public override global::javax.xml.transform.ErrorListener getErrorListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.ErrorListener>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_._getErrorListener30911)) as javax.xml.transform.ErrorListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.ErrorListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_.staticClass, global::javax.xml.transform.TransformerFactory_._getErrorListener30911)) as javax.xml.transform.ErrorListener;
		}
		internal static global::MonoJavaBridge.MethodId _newTemplates30912;
		public override global::javax.xml.transform.Templates newTemplates(javax.xml.transform.Source arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Templates>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_._newTemplates30912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.transform.Templates;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Templates>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_.staticClass, global::javax.xml.transform.TransformerFactory_._newTemplates30912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.transform.Templates;
		}
		internal static global::MonoJavaBridge.MethodId _getAssociatedStylesheet30913;
		public override global::javax.xml.transform.Source getAssociatedStylesheet(javax.xml.transform.Source arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Source>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_._getAssociatedStylesheet30913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.xml.transform.Source;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.Source>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactory_.staticClass, global::javax.xml.transform.TransformerFactory_._getAssociatedStylesheet30913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.xml.transform.Source;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerFactory"));
			global::javax.xml.transform.TransformerFactory_._getAttribute30902 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.transform.TransformerFactory_._setFeature30903 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.transform.TransformerFactory_._getFeature30904 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.transform.TransformerFactory_._setAttribute30905 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.transform.TransformerFactory_._newTransformer30906 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory_.staticClass, "newTransformer", "()Ljavax/xml/transform/Transformer;");
			global::javax.xml.transform.TransformerFactory_._newTransformer30907 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory_.staticClass, "newTransformer", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Transformer;");
			global::javax.xml.transform.TransformerFactory_._setURIResolver30908 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory_.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V");
			global::javax.xml.transform.TransformerFactory_._getURIResolver30909 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory_.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;");
			global::javax.xml.transform.TransformerFactory_._setErrorListener30910 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory_.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V");
			global::javax.xml.transform.TransformerFactory_._getErrorListener30911 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory_.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;");
			global::javax.xml.transform.TransformerFactory_._newTemplates30912 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory_.staticClass, "newTemplates", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Templates;");
			global::javax.xml.transform.TransformerFactory_._getAssociatedStylesheet30913 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactory_.staticClass, "getAssociatedStylesheet", "(Ljavax/xml/transform/Source;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/transform/Source;");
		}
	}
}