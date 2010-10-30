namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccessibleObject : java.lang.Object, AnnotatedElement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccessibleObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation20999;
		public virtual global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.AccessibleObject.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.AccessibleObject._getAnnotation20999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotationPresent21000;
		public virtual bool isAnnotationPresent(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.AccessibleObject.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z", ref global::java.lang.reflect.AccessibleObject._isAnnotationPresent21000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.annotation.Annotation[] Annotations
		{
			get
			{
				return getAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotations21001;
		public virtual global::java.lang.annotation.Annotation[] getAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.AccessibleObject.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.AccessibleObject._getAnnotations21001) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations21002;
		public virtual global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.AccessibleObject.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.AccessibleObject._getDeclaredAnnotations21002) as java.lang.annotation.Annotation[];
		}
		internal static global::MonoJavaBridge.MethodId _setAccessible21003;
		public static void setAccessible(java.lang.reflect.AccessibleObject[] arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.AccessibleObject._setAccessible21003.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.AccessibleObject._setAccessible21003 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.AccessibleObject.staticClass, "setAccessible", "([Ljava/lang/reflect/AccessibleObject;Z)V");
			@__env.CallStaticVoidMethod(java.lang.reflect.AccessibleObject.staticClass, global::java.lang.reflect.AccessibleObject._setAccessible21003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool Accessible
		{
			set
			{
				setAccessible(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAccessible21004;
		public virtual void setAccessible(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.reflect.AccessibleObject.staticClass, "setAccessible", "(Z)V", ref global::java.lang.reflect.AccessibleObject._setAccessible21004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAccessible21005;
		public virtual bool isAccessible()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.AccessibleObject.staticClass, "isAccessible", "()Z", ref global::java.lang.reflect.AccessibleObject._isAccessible21005);
		}
		internal static global::MonoJavaBridge.MethodId _AccessibleObject21006;
		protected AccessibleObject() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.AccessibleObject._AccessibleObject21006.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.AccessibleObject._AccessibleObject21006 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.AccessibleObject.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.AccessibleObject.staticClass, global::java.lang.reflect.AccessibleObject._AccessibleObject21006);
			Init(@__env, handle);
		}
		static AccessibleObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.AccessibleObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/AccessibleObject"));
		}
		internal static void InitJNI()
		{
		}
	}
}