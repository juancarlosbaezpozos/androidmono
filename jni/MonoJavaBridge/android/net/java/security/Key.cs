namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Key : java.io.Serializable
	{ 
		global::java.lang.String getAlgorithm(); 
		byte[] getEncoded(); 
		global::java.lang.String getFormat(); 
	} 

	public partial class Key_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Key.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Key : java.lang.Object, Key
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Key() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.__Key), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.security.__Key(@__env); 
			} 
		} 
		internal __Key(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAlgorithm12437; 
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.__Key)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.__Key._getAlgorithm12437)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.__Key.staticClass, global::java.security.__Key._getAlgorithm12437)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded12438; 
		 byte[] java.security.Key.getEncoded() 
		{ 
			if (GetType() == typeof(java.security.__Key)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.security.__Key._getEncoded12438)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.__Key.staticClass, global::java.security.__Key._getEncoded12438)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFormat12439; 
		 global::java.lang.String java.security.Key.getFormat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.__Key)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.__Key._getFormat12439)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.__Key.staticClass, global::java.security.__Key._getFormat12439)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.__Key.staticClass = @__class; 
			global::java.security.__Key._getAlgorithm12437 = @__env.GetMethodID(global::java.security.__Key.staticClass, "java.security.Key.getAlgorithm", "()Ljava/lang/String;"); 
			global::java.security.__Key._getEncoded12438 = @__env.GetMethodID(global::java.security.__Key.staticClass, "java.security.Key.getEncoded", "()[B"); 
			global::java.security.__Key._getFormat12439 = @__env.GetMethodID(global::java.security.__Key.staticClass, "java.security.Key.getFormat", "()Ljava/lang/String;"); 
		} 
	} 
} 
