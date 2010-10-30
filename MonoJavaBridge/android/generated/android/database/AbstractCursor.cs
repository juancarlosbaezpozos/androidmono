namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.AbstractCursor_))]
	public abstract partial class AbstractCursor : java.lang.Object, CrossProcessCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class SelfContentObserver : android.database.ContentObserver
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SelfContentObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _deliverSelfNotifications4344;
			public override bool deliverSelfNotifications()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.SelfContentObserver.staticClass, "deliverSelfNotifications", "()Z", ref global::android.database.AbstractCursor.SelfContentObserver._deliverSelfNotifications4344);
			}
			internal static global::MonoJavaBridge.MethodId _onChange4345;
			public override void onChange(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.SelfContentObserver.staticClass, "onChange", "(Z)V", ref global::android.database.AbstractCursor.SelfContentObserver._onChange4345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SelfContentObserver4346;
			public SelfContentObserver(android.database.AbstractCursor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.database.AbstractCursor.SelfContentObserver._SelfContentObserver4346.native == global::System.IntPtr.Zero)
					global::android.database.AbstractCursor.SelfContentObserver._SelfContentObserver4346 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "<init>", "(Landroid/database/AbstractCursor;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.AbstractCursor.SelfContentObserver.staticClass, global::android.database.AbstractCursor.SelfContentObserver._SelfContentObserver4346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static SelfContentObserver()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.AbstractCursor.SelfContentObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractCursor$SelfContentObserver"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize4347;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "finalize", "()V", ref global::android.database.AbstractCursor._finalize4347);
		}
		internal static global::MonoJavaBridge.MethodId _getShort4348;
		public abstract short getShort(int arg0);
		internal static global::MonoJavaBridge.MethodId _getInt4349;
		public abstract int getInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong4350;
		public abstract long getLong(int arg0);
		internal static global::MonoJavaBridge.MethodId _getFloat4351;
		public abstract float getFloat(int arg0);
		internal static global::MonoJavaBridge.MethodId _getDouble4352;
		public abstract double getDouble(int arg0);
		internal static global::MonoJavaBridge.MethodId _close4353;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "close", "()V", ref global::android.database.AbstractCursor._close4353);
		}
		internal static global::MonoJavaBridge.MethodId _getString4354;
		public abstract global::java.lang.String getString(int arg0);
		internal static global::MonoJavaBridge.MethodId _isFirst4355;
		public virtual bool isFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "isFirst", "()Z", ref global::android.database.AbstractCursor._isFirst4355);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed4356;
		public virtual bool isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "isClosed", "()Z", ref global::android.database.AbstractCursor._isClosed4356);
		}
		internal static global::MonoJavaBridge.MethodId _getPosition4357;
		public virtual int getPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractCursor.staticClass, "getPosition", "()I", ref global::android.database.AbstractCursor._getPosition4357);
		}
		internal static global::MonoJavaBridge.MethodId _getExtras4358;
		public virtual global::android.os.Bundle getExtras()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.AbstractCursor.staticClass, "getExtras", "()Landroid/os/Bundle;", ref global::android.database.AbstractCursor._getExtras4358) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver4359;
		public virtual void registerContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.AbstractCursor._registerContentObserver4359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver4360;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.AbstractCursor._unregisterContentObserver4360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWindow4361;
		public virtual global::android.database.CursorWindow getWindow()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.AbstractCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;", ref global::android.database.AbstractCursor._getWindow4361) as android.database.CursorWindow;
		}
		internal static global::MonoJavaBridge.MethodId _getCount4362;
		public abstract int getCount();
		internal static global::MonoJavaBridge.MethodId _move4363;
		public virtual bool move(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "move", "(I)Z", ref global::android.database.AbstractCursor._move4363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition4364;
		public virtual bool moveToPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "moveToPosition", "(I)Z", ref global::android.database.AbstractCursor._moveToPosition4364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst4365;
		public virtual bool moveToFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "moveToFirst", "()Z", ref global::android.database.AbstractCursor._moveToFirst4365);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast4366;
		public virtual bool moveToLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "moveToLast", "()Z", ref global::android.database.AbstractCursor._moveToLast4366);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext4367;
		public virtual bool moveToNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "moveToNext", "()Z", ref global::android.database.AbstractCursor._moveToNext4367);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious4368;
		public virtual bool moveToPrevious()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "moveToPrevious", "()Z", ref global::android.database.AbstractCursor._moveToPrevious4368);
		}
		internal static global::MonoJavaBridge.MethodId _isLast4369;
		public virtual bool isLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "isLast", "()Z", ref global::android.database.AbstractCursor._isLast4369);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst4370;
		public virtual bool isBeforeFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "isBeforeFirst", "()Z", ref global::android.database.AbstractCursor._isBeforeFirst4370);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast4371;
		public virtual bool isAfterLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "isAfterLast", "()Z", ref global::android.database.AbstractCursor._isAfterLast4371);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex4372;
		public virtual int getColumnIndex(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I", ref global::android.database.AbstractCursor._getColumnIndex4372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow4373;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractCursor.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I", ref global::android.database.AbstractCursor._getColumnIndexOrThrow4373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName4374;
		public virtual global::java.lang.String getColumnName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.AbstractCursor.staticClass, "getColumnName", "(I)Ljava/lang/String;", ref global::android.database.AbstractCursor._getColumnName4374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4375;
		public abstract global::java.lang.String[] getColumnNames();
		internal static global::MonoJavaBridge.MethodId _getColumnCount4376;
		public virtual int getColumnCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractCursor.staticClass, "getColumnCount", "()I", ref global::android.database.AbstractCursor._getColumnCount4376);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4377;
		public virtual byte[] getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.AbstractCursor.staticClass, "getBlob", "(I)[B", ref global::android.database.AbstractCursor._getBlob4377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer4378;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", ref global::android.database.AbstractCursor._copyStringToBuffer4378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull4379;
		public abstract bool isNull(int arg0);
		internal static global::MonoJavaBridge.MethodId _deactivate4380;
		public virtual void deactivate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "deactivate", "()V", ref global::android.database.AbstractCursor._deactivate4380);
		}
		internal static global::MonoJavaBridge.MethodId _requery4381;
		public virtual bool requery()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "requery", "()Z", ref global::android.database.AbstractCursor._requery4381);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4382;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.AbstractCursor._registerDataSetObserver4382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver4383;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.AbstractCursor._unregisterDataSetObserver4383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri4384;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", ref global::android.database.AbstractCursor._setNotificationUri4384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls4385;
		public virtual bool getWantsAllOnMoveCalls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "getWantsAllOnMoveCalls", "()Z", ref global::android.database.AbstractCursor._getWantsAllOnMoveCalls4385);
		}
		internal static global::MonoJavaBridge.MethodId _respond4386;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.AbstractCursor.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", ref global::android.database.AbstractCursor._respond4386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _onChange4387;
		protected virtual void onChange(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "onChange", "(Z)V", ref global::android.database.AbstractCursor._onChange4387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMove4388;
		public virtual bool onMove(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "onMove", "(II)Z", ref global::android.database.AbstractCursor._onMove4388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fillWindow4389;
		public virtual void fillWindow(int arg0, android.database.CursorWindow arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "fillWindow", "(ILandroid/database/CursorWindow;)V", ref global::android.database.AbstractCursor._fillWindow4389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isFieldUpdated4390;
		protected virtual bool isFieldUpdated(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "isFieldUpdated", "(I)Z", ref global::android.database.AbstractCursor._isFieldUpdated4390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUpdatedField4391;
		protected virtual global::java.lang.Object getUpdatedField(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.AbstractCursor.staticClass, "getUpdatedField", "(I)Ljava/lang/Object;", ref global::android.database.AbstractCursor._getUpdatedField4391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkPosition4392;
		protected virtual void checkPosition()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "checkPosition", "()V", ref global::android.database.AbstractCursor._checkPosition4392);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractCursor4393;
		public AbstractCursor() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.AbstractCursor._AbstractCursor4393.native == global::System.IntPtr.Zero)
				global::android.database.AbstractCursor._AbstractCursor4393 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._AbstractCursor4393);
			Init(@__env, handle);
		}
		static AbstractCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractCursor"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.AbstractCursor))]
	internal sealed partial class AbstractCursor_ : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractCursor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort4394;
		public override short getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.AbstractCursor_.staticClass, "getShort", "(I)S", ref global::android.database.AbstractCursor_._getShort4394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4395;
		public override int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractCursor_.staticClass, "getInt", "(I)I", ref global::android.database.AbstractCursor_._getInt4395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4396;
		public override long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.AbstractCursor_.staticClass, "getLong", "(I)J", ref global::android.database.AbstractCursor_._getLong4396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4397;
		public override float getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.AbstractCursor_.staticClass, "getFloat", "(I)F", ref global::android.database.AbstractCursor_._getFloat4397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4398;
		public override double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.AbstractCursor_.staticClass, "getDouble", "(I)D", ref global::android.database.AbstractCursor_._getDouble4398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString4399;
		public override global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.AbstractCursor_.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.database.AbstractCursor_._getString4399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCount4400;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractCursor_.staticClass, "getCount", "()I", ref global::android.database.AbstractCursor_._getCount4400);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4401;
		public override global::java.lang.String[] getColumnNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.AbstractCursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;", ref global::android.database.AbstractCursor_._getColumnNames4401) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _isNull4402;
		public override bool isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor_.staticClass, "isNull", "(I)Z", ref global::android.database.AbstractCursor_._isNull4402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AbstractCursor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractCursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractCursor"));
		}
		internal static void InitJNI()
		{
		}
	}
}