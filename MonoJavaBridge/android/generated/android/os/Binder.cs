namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Binder : java.lang.Object, IBinder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Binder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize9539;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Binder.staticClass, "finalize", "()V", ref global::android.os.Binder._finalize9539);
		}
		internal static global::MonoJavaBridge.MethodId _dump9540;
		protected virtual void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Binder.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", ref global::android.os.Binder._dump9540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dump9541;
		public virtual void dump(java.io.FileDescriptor arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Binder.staticClass, "dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", ref global::android.os.Binder._dump9541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String InterfaceDescriptor
		{
			get
			{
				return getInterfaceDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaceDescriptor9542;
		public virtual global::java.lang.String getInterfaceDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.Binder.staticClass, "getInterfaceDescriptor", "()Ljava/lang/String;", ref global::android.os.Binder._getInterfaceDescriptor9542) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _pingBinder9543;
		public virtual bool pingBinder()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Binder.staticClass, "pingBinder", "()Z", ref global::android.os.Binder._pingBinder9543);
		}
		internal static global::MonoJavaBridge.MethodId _isBinderAlive9544;
		public virtual bool isBinderAlive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Binder.staticClass, "isBinderAlive", "()Z", ref global::android.os.Binder._isBinderAlive9544);
		}
		internal static global::MonoJavaBridge.MethodId _queryLocalInterface9545;
		public virtual global::android.os.IInterface queryLocalInterface(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IInterface>(this, global::android.os.Binder.staticClass, "queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;", ref global::android.os.Binder._queryLocalInterface9545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IInterface;
		}
		internal static global::MonoJavaBridge.MethodId _transact9546;
		public virtual bool transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Binder.staticClass, "transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", ref global::android.os.Binder._transact9546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _linkToDeath9547;
		public virtual void linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Binder.staticClass, "linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V", ref global::android.os.Binder._linkToDeath9547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void linkToDeath(global::android.os.IBinder_DeathRecipientDelegate arg0, int arg1)
		{
			linkToDeath((global::android.os.IBinder_DeathRecipientDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _unlinkToDeath9548;
		public virtual bool unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Binder.staticClass, "unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z", ref global::android.os.Binder._unlinkToDeath9548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool unlinkToDeath(global::android.os.IBinder_DeathRecipientDelegate arg0, int arg1)
		{
			return unlinkToDeath((global::android.os.IBinder_DeathRecipientDelegateWrapper)arg0, arg1);
		}
		public static int CallingPid
		{
			get
			{
				return getCallingPid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallingPid9549;
		public static int getCallingPid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._getCallingPid9549.native == global::System.IntPtr.Zero)
				global::android.os.Binder._getCallingPid9549 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "getCallingPid", "()I");
			return @__env.CallStaticIntMethod(android.os.Binder.staticClass, global::android.os.Binder._getCallingPid9549);
		}
		public static int CallingUid
		{
			get
			{
				return getCallingUid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallingUid9550;
		public static int getCallingUid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._getCallingUid9550.native == global::System.IntPtr.Zero)
				global::android.os.Binder._getCallingUid9550 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "getCallingUid", "()I");
			return @__env.CallStaticIntMethod(android.os.Binder.staticClass, global::android.os.Binder._getCallingUid9550);
		}
		internal static global::MonoJavaBridge.MethodId _clearCallingIdentity9551;
		public static long clearCallingIdentity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._clearCallingIdentity9551.native == global::System.IntPtr.Zero)
				global::android.os.Binder._clearCallingIdentity9551 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "clearCallingIdentity", "()J");
			return @__env.CallStaticLongMethod(android.os.Binder.staticClass, global::android.os.Binder._clearCallingIdentity9551);
		}
		internal static global::MonoJavaBridge.MethodId _restoreCallingIdentity9552;
		public static void restoreCallingIdentity(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._restoreCallingIdentity9552.native == global::System.IntPtr.Zero)
				global::android.os.Binder._restoreCallingIdentity9552 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "restoreCallingIdentity", "(J)V");
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._restoreCallingIdentity9552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flushPendingCommands9553;
		public static void flushPendingCommands()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._flushPendingCommands9553.native == global::System.IntPtr.Zero)
				global::android.os.Binder._flushPendingCommands9553 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "flushPendingCommands", "()V");
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._flushPendingCommands9553);
		}
		internal static global::MonoJavaBridge.MethodId _joinThreadPool9554;
		public static void joinThreadPool()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._joinThreadPool9554.native == global::System.IntPtr.Zero)
				global::android.os.Binder._joinThreadPool9554 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "joinThreadPool", "()V");
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._joinThreadPool9554);
		}
		internal static global::MonoJavaBridge.MethodId _attachInterface9555;
		public virtual void attachInterface(android.os.IInterface arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Binder.staticClass, "attachInterface", "(Landroid/os/IInterface;Ljava/lang/String;)V", ref global::android.os.Binder._attachInterface9555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void attachInterface(global::android.os.IInterfaceDelegate arg0, java.lang.String arg1)
		{
			attachInterface((global::android.os.IInterfaceDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _onTransact9556;
		protected virtual bool onTransact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Binder.staticClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", ref global::android.os.Binder._onTransact9556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _Binder9557;
		public Binder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._Binder9557.native == global::System.IntPtr.Zero)
				global::android.os.Binder._Binder9557 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Binder.staticClass, global::android.os.Binder._Binder9557);
			Init(@__env, handle);
		}
		static Binder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Binder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Binder"));
		}
		internal static void InitJNI()
		{
		}
	}
}