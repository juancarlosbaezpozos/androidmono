namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConsoleMessage : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConsoleMessage()
		{
			InitJNI();
		}
		protected ConsoleMessage(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class MessageLevel : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MessageLevel()
			{
				InitJNI();
			}
			internal MessageLevel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values15929;
			public static global::android.webkit.ConsoleMessage.MessageLevel[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.ConsoleMessage.MessageLevel>(@__env.CallStaticObjectMethod(android.webkit.ConsoleMessage.MessageLevel.staticClass, global::android.webkit.ConsoleMessage.MessageLevel._values15929)) as android.webkit.ConsoleMessage.MessageLevel[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf15930;
			public static global::android.webkit.ConsoleMessage.MessageLevel valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.ConsoleMessage.MessageLevel.staticClass, global::android.webkit.ConsoleMessage.MessageLevel._valueOf15930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.ConsoleMessage.MessageLevel;
			}
			internal static global::MonoJavaBridge.FieldId _DEBUG15931;
			public static global::android.webkit.ConsoleMessage.MessageLevel DEBUG
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, _DEBUG15931)) as android.webkit.ConsoleMessage.MessageLevel;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ERROR15932;
			public static global::android.webkit.ConsoleMessage.MessageLevel ERROR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, _ERROR15932)) as android.webkit.ConsoleMessage.MessageLevel;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LOG15933;
			public static global::android.webkit.ConsoleMessage.MessageLevel LOG
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, _LOG15933)) as android.webkit.ConsoleMessage.MessageLevel;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIP15934;
			public static global::android.webkit.ConsoleMessage.MessageLevel TIP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, _TIP15934)) as android.webkit.ConsoleMessage.MessageLevel;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WARNING15935;
			public static global::android.webkit.ConsoleMessage.MessageLevel WARNING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, _WARNING15935)) as android.webkit.ConsoleMessage.MessageLevel;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.ConsoleMessage.MessageLevel.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/ConsoleMessage$MessageLevel"));
				global::android.webkit.ConsoleMessage.MessageLevel._values15929 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "values", "()[Landroid/webkit/ConsoleMessage/MessageLevel;");
				global::android.webkit.ConsoleMessage.MessageLevel._valueOf15930 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/ConsoleMessage$MessageLevel;");
				global::android.webkit.ConsoleMessage.MessageLevel._DEBUG15931 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "DEBUG", "Landroid/webkit/ConsoleMessage$MessageLevel;");
				global::android.webkit.ConsoleMessage.MessageLevel._ERROR15932 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "ERROR", "Landroid/webkit/ConsoleMessage$MessageLevel;");
				global::android.webkit.ConsoleMessage.MessageLevel._LOG15933 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "LOG", "Landroid/webkit/ConsoleMessage$MessageLevel;");
				global::android.webkit.ConsoleMessage.MessageLevel._TIP15934 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "TIP", "Landroid/webkit/ConsoleMessage$MessageLevel;");
				global::android.webkit.ConsoleMessage.MessageLevel._WARNING15935 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "WARNING", "Landroid/webkit/ConsoleMessage$MessageLevel;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _lineNumber15936;
		public virtual int lineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.ConsoleMessage._lineNumber15936);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._lineNumber15936);
		}
		internal static global::MonoJavaBridge.MethodId _message15937;
		public virtual global::java.lang.String message() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.ConsoleMessage._message15937)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._message15937)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _sourceId15938;
		public virtual global::java.lang.String sourceId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.ConsoleMessage._sourceId15938)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._sourceId15938)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _messageLevel15939;
		public virtual global::android.webkit.ConsoleMessage.MessageLevel messageLevel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.ConsoleMessage._messageLevel15939)) as android.webkit.ConsoleMessage.MessageLevel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._messageLevel15939)) as android.webkit.ConsoleMessage.MessageLevel;
		}
		internal static global::MonoJavaBridge.MethodId _ConsoleMessage15940;
		public ConsoleMessage(java.lang.String arg0, java.lang.String arg1, int arg2, android.webkit.ConsoleMessage.MessageLevel arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._ConsoleMessage15940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.ConsoleMessage.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/ConsoleMessage"));
			global::android.webkit.ConsoleMessage._lineNumber15936 = @__env.GetMethodIDNoThrow(global::android.webkit.ConsoleMessage.staticClass, "lineNumber", "()I");
			global::android.webkit.ConsoleMessage._message15937 = @__env.GetMethodIDNoThrow(global::android.webkit.ConsoleMessage.staticClass, "message", "()Ljava/lang/String;");
			global::android.webkit.ConsoleMessage._sourceId15938 = @__env.GetMethodIDNoThrow(global::android.webkit.ConsoleMessage.staticClass, "sourceId", "()Ljava/lang/String;");
			global::android.webkit.ConsoleMessage._messageLevel15939 = @__env.GetMethodIDNoThrow(global::android.webkit.ConsoleMessage.staticClass, "messageLevel", "()Landroid/webkit/ConsoleMessage$MessageLevel;");
			global::android.webkit.ConsoleMessage._ConsoleMessage15940 = @__env.GetMethodIDNoThrow(global::android.webkit.ConsoleMessage.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILandroid/webkit/ConsoleMessage$MessageLevel;)V");
		}
	}
}