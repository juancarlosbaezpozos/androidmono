namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteQuery : android.database.sqlite.SQLiteProgram
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteQuery(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString4836;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteQuery.staticClass, "toString", "()Ljava/lang/String;", ref global::android.database.sqlite.SQLiteQuery._toString4836) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close4837;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQuery.staticClass, "close", "()V", ref global::android.database.sqlite.SQLiteQuery._close4837);
		}
		internal static global::MonoJavaBridge.MethodId _bindNull4838;
		public override void bindNull(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQuery.staticClass, "bindNull", "(I)V", ref global::android.database.sqlite.SQLiteQuery._bindNull4838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindLong4839;
		public override void bindLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQuery.staticClass, "bindLong", "(IJ)V", ref global::android.database.sqlite.SQLiteQuery._bindLong4839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindDouble4840;
		public override void bindDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQuery.staticClass, "bindDouble", "(ID)V", ref global::android.database.sqlite.SQLiteQuery._bindDouble4840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindString4841;
		public override void bindString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQuery.staticClass, "bindString", "(ILjava/lang/String;)V", ref global::android.database.sqlite.SQLiteQuery._bindString4841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static SQLiteQuery()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteQuery.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteQuery"));
		}
		internal static void InitJNI()
		{
		}
	}
}