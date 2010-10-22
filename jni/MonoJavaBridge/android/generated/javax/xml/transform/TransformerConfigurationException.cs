namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TransformerConfigurationException : javax.xml.transform.TransformerException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TransformerConfigurationException()
		{
			InitJNI();
		}
		protected TransformerConfigurationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException30866;
		public TransformerConfigurationException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30866);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException30867;
		public TransformerConfigurationException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException30868;
		public TransformerConfigurationException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException30869;
		public TransformerConfigurationException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException30870;
		public TransformerConfigurationException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException30871;
		public TransformerConfigurationException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1, java.lang.Throwable arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerConfigurationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerConfigurationException"));
			global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30866 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "()V");
			global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30867 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30868 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30869 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30870 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;)V");
			global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30871 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Ljava/lang/Throwable;)V");
		}
	}
}