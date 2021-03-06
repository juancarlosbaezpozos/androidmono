namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PaintDrawable : android.graphics.drawable.ShapeDrawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PaintDrawable()
		{
			InitJNI();
		}
		protected PaintDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setCornerRadii4127;
		public virtual void setCornerRadii(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.PaintDrawable._setCornerRadii4127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._setCornerRadii4127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCornerRadius4128;
		public virtual void setCornerRadius(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.PaintDrawable._setCornerRadius4128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._setCornerRadius4128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflateTag4129;
		protected override bool inflateTag(java.lang.String arg0, android.content.res.Resources arg1, org.xmlpull.v1.XmlPullParser arg2, android.util.AttributeSet arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.PaintDrawable._inflateTag4129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._inflateTag4129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _PaintDrawable4130;
		public PaintDrawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._PaintDrawable4130);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PaintDrawable4131;
		public PaintDrawable(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._PaintDrawable4131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.PaintDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/PaintDrawable"));
			global::android.graphics.drawable.PaintDrawable._setCornerRadii4127 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PaintDrawable.staticClass, "setCornerRadii", "([F)V");
			global::android.graphics.drawable.PaintDrawable._setCornerRadius4128 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PaintDrawable.staticClass, "setCornerRadius", "(F)V");
			global::android.graphics.drawable.PaintDrawable._inflateTag4129 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PaintDrawable.staticClass, "inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Z");
			global::android.graphics.drawable.PaintDrawable._PaintDrawable4130 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PaintDrawable.staticClass, "<init>", "()V");
			global::android.graphics.drawable.PaintDrawable._PaintDrawable4131 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PaintDrawable.staticClass, "<init>", "(I)V");
		}
	}
}
