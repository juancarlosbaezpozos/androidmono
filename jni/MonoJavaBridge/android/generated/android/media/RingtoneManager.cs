namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RingtoneManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RingtoneManager()
		{
			InitJNI();
		}
		protected RingtoneManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isDefault5073;
		public static bool isDefault(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._isDefault5073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setType5074;
		public virtual void setType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.RingtoneManager._setType5074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._setType5074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inferStreamType5075;
		public virtual int inferStreamType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.RingtoneManager._inferStreamType5075);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._inferStreamType5075);
		}
		internal static global::MonoJavaBridge.MethodId _setStopPreviousRingtone5076;
		public virtual void setStopPreviousRingtone(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.RingtoneManager._setStopPreviousRingtone5076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._setStopPreviousRingtone5076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopPreviousRingtone5077;
		public virtual void stopPreviousRingtone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.RingtoneManager._stopPreviousRingtone5077);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._stopPreviousRingtone5077);
		}
		internal static global::MonoJavaBridge.MethodId _getStopPreviousRingtone5078;
		public virtual bool getStopPreviousRingtone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.RingtoneManager._getStopPreviousRingtone5078);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getStopPreviousRingtone5078);
		}
		internal static global::MonoJavaBridge.MethodId _getIncludeDrm5079;
		public virtual bool getIncludeDrm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.RingtoneManager._getIncludeDrm5079);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getIncludeDrm5079);
		}
		internal static global::MonoJavaBridge.MethodId _setIncludeDrm5080;
		public virtual void setIncludeDrm(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.RingtoneManager._setIncludeDrm5080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._setIncludeDrm5080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCursor5081;
		public virtual global::android.database.Cursor getCursor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.media.RingtoneManager._getCursor5081)) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getCursor5081)) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _getRingtone5082;
		public virtual global::android.media.Ringtone getRingtone(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.media.RingtoneManager._getRingtone5082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.media.Ringtone;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getRingtone5082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.media.Ringtone;
		}
		internal static global::MonoJavaBridge.MethodId _getRingtone5083;
		public static global::android.media.Ringtone getRingtone(android.content.Context arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getRingtone5083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.media.Ringtone;
		}
		internal static global::MonoJavaBridge.MethodId _getRingtoneUri5084;
		public virtual global::android.net.Uri getRingtoneUri(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.media.RingtoneManager._getRingtoneUri5084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getRingtoneUri5084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _getRingtonePosition5085;
		public virtual int getRingtonePosition(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.RingtoneManager._getRingtonePosition5085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getRingtonePosition5085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getValidRingtoneUri5086;
		public static global::android.net.Uri getValidRingtoneUri(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getValidRingtoneUri5086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _getActualDefaultRingtoneUri5087;
		public static global::android.net.Uri getActualDefaultRingtoneUri(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getActualDefaultRingtoneUri5087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _setActualDefaultRingtoneUri5088;
		public static void setActualDefaultRingtoneUri(android.content.Context arg0, int arg1, android.net.Uri arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._setActualDefaultRingtoneUri5088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultType5089;
		public static int getDefaultType(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getDefaultType5089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultUri5090;
		public static global::android.net.Uri getDefaultUri(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getDefaultUri5090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _RingtoneManager5091;
		public RingtoneManager(android.app.Activity arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._RingtoneManager5091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RingtoneManager5092;
		public RingtoneManager(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._RingtoneManager5092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int TYPE_RINGTONE
		{
			get
			{
				return 1;
			}
		}
		public static int TYPE_NOTIFICATION
		{
			get
			{
				return 2;
			}
		}
		public static int TYPE_ALARM
		{
			get
			{
				return 4;
			}
		}
		public static int TYPE_ALL
		{
			get
			{
				return 7;
			}
		}
		public static global::java.lang.String ACTION_RINGTONE_PICKER
		{
			get
			{
				return "android.intent.action.RINGTONE_PICKER";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_SHOW_DEFAULT
		{
			get
			{
				return "android.intent.extra.ringtone.SHOW_DEFAULT";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_SHOW_SILENT
		{
			get
			{
				return "android.intent.extra.ringtone.SHOW_SILENT";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_INCLUDE_DRM
		{
			get
			{
				return "android.intent.extra.ringtone.INCLUDE_DRM";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_EXISTING_URI
		{
			get
			{
				return "android.intent.extra.ringtone.EXISTING_URI";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_DEFAULT_URI
		{
			get
			{
				return "android.intent.extra.ringtone.DEFAULT_URI";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_TYPE
		{
			get
			{
				return "android.intent.extra.ringtone.TYPE";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_TITLE
		{
			get
			{
				return "android.intent.extra.ringtone.TITLE";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_PICKED_URI
		{
			get
			{
				return "android.intent.extra.ringtone.PICKED_URI";
			}
		}
		public static int ID_COLUMN_INDEX
		{
			get
			{
				return 0;
			}
		}
		public static int TITLE_COLUMN_INDEX
		{
			get
			{
				return 1;
			}
		}
		public static int URI_COLUMN_INDEX
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.RingtoneManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/RingtoneManager"));
			global::android.media.RingtoneManager._isDefault5073 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "isDefault", "(Landroid/net/Uri;)Z");
			global::android.media.RingtoneManager._setType5074 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "setType", "(I)V");
			global::android.media.RingtoneManager._inferStreamType5075 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "inferStreamType", "()I");
			global::android.media.RingtoneManager._setStopPreviousRingtone5076 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "setStopPreviousRingtone", "(Z)V");
			global::android.media.RingtoneManager._stopPreviousRingtone5077 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "stopPreviousRingtone", "()V");
			global::android.media.RingtoneManager._getStopPreviousRingtone5078 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getStopPreviousRingtone", "()Z");
			global::android.media.RingtoneManager._getIncludeDrm5079 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getIncludeDrm", "()Z");
			global::android.media.RingtoneManager._setIncludeDrm5080 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "setIncludeDrm", "(Z)V");
			global::android.media.RingtoneManager._getCursor5081 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getCursor", "()Landroid/database/Cursor;");
			global::android.media.RingtoneManager._getRingtone5082 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getRingtone", "(I)Landroid/media/Ringtone;");
			global::android.media.RingtoneManager._getRingtone5083 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getRingtone", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/Ringtone;");
			global::android.media.RingtoneManager._getRingtoneUri5084 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getRingtoneUri", "(I)Landroid/net/Uri;");
			global::android.media.RingtoneManager._getRingtonePosition5085 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getRingtonePosition", "(Landroid/net/Uri;)I");
			global::android.media.RingtoneManager._getValidRingtoneUri5086 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getValidRingtoneUri", "(Landroid/content/Context;)Landroid/net/Uri;");
			global::android.media.RingtoneManager._getActualDefaultRingtoneUri5087 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getActualDefaultRingtoneUri", "(Landroid/content/Context;I)Landroid/net/Uri;");
			global::android.media.RingtoneManager._setActualDefaultRingtoneUri5088 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "setActualDefaultRingtoneUri", "(Landroid/content/Context;ILandroid/net/Uri;)V");
			global::android.media.RingtoneManager._getDefaultType5089 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getDefaultType", "(Landroid/net/Uri;)I");
			global::android.media.RingtoneManager._getDefaultUri5090 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getDefaultUri", "(I)Landroid/net/Uri;");
			global::android.media.RingtoneManager._RingtoneManager5091 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "<init>", "(Landroid/app/Activity;)V");
			global::android.media.RingtoneManager._RingtoneManager5092 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
