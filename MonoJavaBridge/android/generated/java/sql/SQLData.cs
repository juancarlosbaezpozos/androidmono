namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.SQLData_))]
	public partial interface SQLData  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getSQLTypeName();
		void readSQL(java.sql.SQLInput arg0, java.lang.String arg1);
		void writeSQL(java.sql.SQLOutput arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.SQLData))]
	internal sealed partial class SQLData_ : java.lang.Object, SQLData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSQLTypeName24967;
		global::java.lang.String java.sql.SQLData.getSQLTypeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.SQLData_.staticClass, "getSQLTypeName", "()Ljava/lang/String;", ref global::java.sql.SQLData_._getSQLTypeName24967) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readSQL24968;
		void java.sql.SQLData.readSQL(java.sql.SQLInput arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLData_.staticClass, "readSQL", "(Ljava/sql/SQLInput;Ljava/lang/String;)V", ref global::java.sql.SQLData_._readSQL24968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeSQL24969;
		void java.sql.SQLData.writeSQL(java.sql.SQLOutput arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLData_.staticClass, "writeSQL", "(Ljava/sql/SQLOutput;)V", ref global::java.sql.SQLData_._writeSQL24969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SQLData_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLData"));
		}
		internal static void InitJNI()
		{
		}
	}
}