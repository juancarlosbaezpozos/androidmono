namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PermissionGroupInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PermissionGroupInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3983;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.PermissionGroupInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.PermissionGroupInfo._toString3983) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3984;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PermissionGroupInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.PermissionGroupInfo._writeToParcel3984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3985;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PermissionGroupInfo.staticClass, "describeContents", "()I", ref global::android.content.pm.PermissionGroupInfo._describeContents3985);
		}
		internal static global::MonoJavaBridge.MethodId _loadDescription3986;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.PermissionGroupInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.content.pm.PermissionGroupInfo._loadDescription3986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _PermissionGroupInfo3987;
		public PermissionGroupInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo3987.native == global::System.IntPtr.Zero)
				global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo3987 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo3987);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PermissionGroupInfo3988;
		public PermissionGroupInfo(android.content.pm.PermissionGroupInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo3988.native == global::System.IntPtr.Zero)
				global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo3988 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "<init>", "(Landroid/content/pm/PermissionGroupInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo3988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes3989;
		public int descriptionRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _descriptionRes3989);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nonLocalizedDescription3990;
		public global::java.lang.CharSequence nonLocalizedDescription
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _nonLocalizedDescription3990)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3991;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PermissionGroupInfo.staticClass, _CREATOR3991)) as android.os.Parcelable_Creator;
			}
		}
		static PermissionGroupInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PermissionGroupInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PermissionGroupInfo"));
			global::android.content.pm.PermissionGroupInfo._descriptionRes3989 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "descriptionRes", "I");
			global::android.content.pm.PermissionGroupInfo._nonLocalizedDescription3990 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "nonLocalizedDescription", "Ljava/lang/CharSequence;");
			global::android.content.pm.PermissionGroupInfo._CREATOR3991 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}