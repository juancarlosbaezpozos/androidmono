namespace java.security.acl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AclNotFoundException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AclNotFoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AclNotFoundException23451;
		public AclNotFoundException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.AclNotFoundException._AclNotFoundException23451.native == global::System.IntPtr.Zero)
				global::java.security.acl.AclNotFoundException._AclNotFoundException23451 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclNotFoundException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.acl.AclNotFoundException.staticClass, global::java.security.acl.AclNotFoundException._AclNotFoundException23451);
			Init(@__env, handle);
		}
		static AclNotFoundException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.AclNotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/AclNotFoundException"));
		}
		internal static void InitJNI()
		{
		}
	}
}