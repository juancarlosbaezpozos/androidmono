namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMError_))]
	public interface DOMError  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.w3c.dom.DOMLocator getLocation();
		global::java.lang.String getMessage();
		global::java.lang.String getType();
		short getSeverity();
		global::java.lang.Object getRelatedException();
		global::java.lang.Object getRelatedData();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMError))]
	public sealed partial class DOMError_ : java.lang.Object, DOMError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DOMError_()
		{
			InitJNI();
		}
		internal DOMError_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLocation34221;
		 global::org.w3c.dom.DOMLocator org.w3c.dom.DOMError.getLocation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMLocator>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_._getLocation34221)) as org.w3c.dom.DOMLocator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMLocator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_.staticClass, global::org.w3c.dom.DOMError_._getLocation34221)) as org.w3c.dom.DOMLocator;
		}
		internal static global::MonoJavaBridge.MethodId _getMessage34222;
		 global::java.lang.String org.w3c.dom.DOMError.getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_._getMessage34222)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_.staticClass, global::org.w3c.dom.DOMError_._getMessage34222)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34223;
		 global::java.lang.String org.w3c.dom.DOMError.getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_._getType34223)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_.staticClass, global::org.w3c.dom.DOMError_._getType34223)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSeverity34224;
		 short org.w3c.dom.DOMError.getSeverity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.DOMError_._getSeverity34224);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.DOMError_.staticClass, global::org.w3c.dom.DOMError_._getSeverity34224);
		}
		internal static global::MonoJavaBridge.MethodId _getRelatedException34225;
		 global::java.lang.Object org.w3c.dom.DOMError.getRelatedException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_._getRelatedException34225)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_.staticClass, global::org.w3c.dom.DOMError_._getRelatedException34225)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getRelatedData34226;
		 global::java.lang.Object org.w3c.dom.DOMError.getRelatedData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_._getRelatedData34226)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMError_.staticClass, global::org.w3c.dom.DOMError_._getRelatedData34226)) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMError_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMError"));
			global::org.w3c.dom.DOMError_._getLocation34221 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMError_.staticClass, "getLocation", "()Lorg/w3c/dom/DOMLocator;");
			global::org.w3c.dom.DOMError_._getMessage34222 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMError_.staticClass, "getMessage", "()Ljava/lang/String;");
			global::org.w3c.dom.DOMError_._getType34223 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMError_.staticClass, "getType", "()Ljava/lang/String;");
			global::org.w3c.dom.DOMError_._getSeverity34224 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMError_.staticClass, "getSeverity", "()S");
			global::org.w3c.dom.DOMError_._getRelatedException34225 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMError_.staticClass, "getRelatedException", "()Ljava/lang/Object;");
			global::org.w3c.dom.DOMError_._getRelatedData34226 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMError_.staticClass, "getRelatedData", "()Ljava/lang/Object;");
		}
	}
}