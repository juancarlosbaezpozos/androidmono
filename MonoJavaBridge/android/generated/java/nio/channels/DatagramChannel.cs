namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.DatagramChannel_))]
	public abstract partial class DatagramChannel : java.nio.channels.spi.AbstractSelectableChannel, ByteChannel, ScatteringByteChannel, GatheringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DatagramChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22421;
		public virtual long write(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.DatagramChannel._write22421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22422;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _write22423;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _send22424;
		public abstract int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1);
		internal static global::MonoJavaBridge.MethodId _read22425;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read22426;
		public virtual long read(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.DatagramChannel._read22426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read22427;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _open22428;
		public static global::java.nio.channels.DatagramChannel open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.DatagramChannel._open22428.native == global::System.IntPtr.Zero)
				global::java.nio.channels.DatagramChannel._open22428 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "open", "()Ljava/nio/channels/DatagramChannel;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._open22428)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect22429;
		public abstract global::java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0);
		internal static global::MonoJavaBridge.MethodId _socket22430;
		public abstract global::java.net.DatagramSocket socket();
		internal static global::MonoJavaBridge.MethodId _disconnect22431;
		public abstract global::java.nio.channels.DatagramChannel disconnect();
		internal static global::MonoJavaBridge.MethodId _isConnected22432;
		public abstract bool isConnected();
		internal static global::MonoJavaBridge.MethodId _receive22433;
		public abstract global::java.net.SocketAddress receive(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _validOps22434;
		public sealed override int validOps()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.DatagramChannel.staticClass, "validOps", "()I", ref global::java.nio.channels.DatagramChannel._validOps22434);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramChannel22435;
		protected DatagramChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.DatagramChannel._DatagramChannel22435.native == global::System.IntPtr.Zero)
				global::java.nio.channels.DatagramChannel._DatagramChannel22435 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._DatagramChannel22435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DatagramChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.DatagramChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/DatagramChannel"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.DatagramChannel))]
	internal sealed partial class DatagramChannel_ : java.nio.channels.DatagramChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DatagramChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22436;
		public override int write(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.DatagramChannel_._write22436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22437;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.DatagramChannel_._write22437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _send22438;
		public override int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I", ref global::java.nio.channels.DatagramChannel_._send22438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _read22439;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.DatagramChannel_._read22439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22440;
		public override int read(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.DatagramChannel_._read22440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect22441;
		public override global::java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;", ref global::java.nio.channels.DatagramChannel_._connect22441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _socket22442;
		public override global::java.net.DatagramSocket socket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "socket", "()Ljava/net/DatagramSocket;", ref global::java.nio.channels.DatagramChannel_._socket22442) as java.net.DatagramSocket;
		}
		internal static global::MonoJavaBridge.MethodId _disconnect22443;
		public override global::java.nio.channels.DatagramChannel disconnect()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "disconnect", "()Ljava/nio/channels/DatagramChannel;", ref global::java.nio.channels.DatagramChannel_._disconnect22443) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected22444;
		public override bool isConnected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "isConnected", "()Z", ref global::java.nio.channels.DatagramChannel_._isConnected22444);
		}
		internal static global::MonoJavaBridge.MethodId _receive22445;
		public override global::java.net.SocketAddress receive(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;", ref global::java.nio.channels.DatagramChannel_._receive22445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22446;
		protected override void implCloseSelectableChannel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "implCloseSelectableChannel", "()V", ref global::java.nio.channels.DatagramChannel_._implCloseSelectableChannel22446);
		}
		internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22447;
		protected override void implConfigureBlocking(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "implConfigureBlocking", "(Z)V", ref global::java.nio.channels.DatagramChannel_._implConfigureBlocking22447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static DatagramChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.DatagramChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/DatagramChannel"));
		}
		internal static void InitJNI()
		{
		}
	}
}