namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocalServerSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LocalServerSocket()
		{
			InitJNI();
		}
		protected LocalServerSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close7620;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalServerSocket._close7620);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._close7620);
		}
		internal static global::MonoJavaBridge.MethodId _accept7621;
		public virtual global::android.net.LocalSocket accept() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalServerSocket._accept7621)) as android.net.LocalSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._accept7621)) as android.net.LocalSocket;
		}
		public new global::java.io.FileDescriptor FileDescriptor
		{
			get
			{
				return getFileDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor7622;
		public virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalServerSocket._getFileDescriptor7622)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._getFileDescriptor7622)) as java.io.FileDescriptor;
		}
		public new global::android.net.LocalSocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress7623;
		public virtual global::android.net.LocalSocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalServerSocket._getLocalSocketAddress7623)) as android.net.LocalSocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._getLocalSocketAddress7623)) as android.net.LocalSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _LocalServerSocket7624;
		public LocalServerSocket(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._LocalServerSocket7624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LocalServerSocket7625;
		public LocalServerSocket(java.io.FileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._LocalServerSocket7625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.LocalServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/LocalServerSocket"));
			global::android.net.LocalServerSocket._close7620 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "close", "()V");
			global::android.net.LocalServerSocket._accept7621 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "accept", "()Landroid/net/LocalSocket;");
			global::android.net.LocalServerSocket._getFileDescriptor7622 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::android.net.LocalServerSocket._getLocalSocketAddress7623 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;");
			global::android.net.LocalServerSocket._LocalServerSocket7624 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.net.LocalServerSocket._LocalServerSocket7625 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
		}
	}
}