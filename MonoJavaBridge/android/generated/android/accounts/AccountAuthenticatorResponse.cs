namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccountAuthenticatorResponse : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccountAuthenticatorResponse(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1292;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.accounts.AccountAuthenticatorResponse._writeToParcel1292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1293;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, "describeContents", "()I", ref global::android.accounts.AccountAuthenticatorResponse._describeContents1293);
		}
		internal static global::MonoJavaBridge.MethodId _onResult1294;
		public virtual void onResult(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, "onResult", "(Landroid/os/Bundle;)V", ref global::android.accounts.AccountAuthenticatorResponse._onResult1294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestContinued1295;
		public virtual void onRequestContinued()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, "onRequestContinued", "()V", ref global::android.accounts.AccountAuthenticatorResponse._onRequestContinued1295);
		}
		internal static global::MonoJavaBridge.MethodId _onError1296;
		public virtual void onError(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, "onError", "(ILjava/lang/String;)V", ref global::android.accounts.AccountAuthenticatorResponse._onError1296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AccountAuthenticatorResponse1297;
		public AccountAuthenticatorResponse(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AccountAuthenticatorResponse._AccountAuthenticatorResponse1297.native == global::System.IntPtr.Zero)
				global::android.accounts.AccountAuthenticatorResponse._AccountAuthenticatorResponse1297 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorResponse.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._AccountAuthenticatorResponse1297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1298;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.accounts.AccountAuthenticatorResponse.staticClass, _CREATOR1298)) as android.os.Parcelable_Creator;
			}
		}
		static AccountAuthenticatorResponse()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountAuthenticatorResponse.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountAuthenticatorResponse"));
			global::android.accounts.AccountAuthenticatorResponse._CREATOR1298 = @__env.GetStaticFieldIDNoThrow(global::android.accounts.AccountAuthenticatorResponse.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}