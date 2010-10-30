namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Date : java.util.Date
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Date(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString24609;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.Date.staticClass, "toString", "()Ljava/lang/String;", ref global::java.sql.Date._toString24609) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf24610;
		public static global::java.sql.Date valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.Date._valueOf24610.native == global::System.IntPtr.Zero)
				global::java.sql.Date._valueOf24610 = @__env.GetStaticMethodIDNoThrow(global::java.sql.Date.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/sql/Date;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.Date.staticClass, global::java.sql.Date._valueOf24610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		public new long Time
		{
			set
			{
				setTime(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTime24611;
		public override void setTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Date.staticClass, "setTime", "(J)V", ref global::java.sql.Date._setTime24611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Hours
		{
			get
			{
				return getHours();
			}
			set
			{
				setHours(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHours24612;
		public override int getHours()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Date.staticClass, "getHours", "()I", ref global::java.sql.Date._getHours24612);
		}
		public new int Minutes
		{
			get
			{
				return getMinutes();
			}
			set
			{
				setMinutes(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinutes24613;
		public override int getMinutes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Date.staticClass, "getMinutes", "()I", ref global::java.sql.Date._getMinutes24613);
		}
		public new int Seconds
		{
			get
			{
				return getSeconds();
			}
			set
			{
				setSeconds(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSeconds24614;
		public override int getSeconds()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Date.staticClass, "getSeconds", "()I", ref global::java.sql.Date._getSeconds24614);
		}
		internal static global::MonoJavaBridge.MethodId _setHours24615;
		public override void setHours(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Date.staticClass, "setHours", "(I)V", ref global::java.sql.Date._setHours24615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinutes24616;
		public override void setMinutes(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Date.staticClass, "setMinutes", "(I)V", ref global::java.sql.Date._setMinutes24616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSeconds24617;
		public override void setSeconds(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Date.staticClass, "setSeconds", "(I)V", ref global::java.sql.Date._setSeconds24617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Date24618;
		public Date(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.Date._Date24618.native == global::System.IntPtr.Zero)
				global::java.sql.Date._Date24618 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Date.staticClass, global::java.sql.Date._Date24618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date24619;
		public Date(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.Date._Date24619.native == global::System.IntPtr.Zero)
				global::java.sql.Date._Date24619 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "<init>", "(J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Date.staticClass, global::java.sql.Date._Date24619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Date()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Date.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Date"));
		}
		internal static void InitJNI()
		{
		}
	}
}