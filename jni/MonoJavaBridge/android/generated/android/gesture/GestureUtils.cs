namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GestureUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GestureUtils()
		{
			InitJNI();
		}
		internal GestureUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _computeOrientedBoundingBox4976;
		public static global::android.gesture.OrientedBoundingBox computeOrientedBoundingBox(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._computeOrientedBoundingBox4976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.gesture.OrientedBoundingBox;
		}
		internal static global::MonoJavaBridge.MethodId _computeOrientedBoundingBox4977;
		public static global::android.gesture.OrientedBoundingBox computeOrientedBoundingBox(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._computeOrientedBoundingBox4977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.gesture.OrientedBoundingBox;
		}
		internal static global::MonoJavaBridge.MethodId _spatialSampling4978;
		public static float[] spatialSampling(android.gesture.Gesture arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._spatialSampling4978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _spatialSampling4979;
		public static float[] spatialSampling(android.gesture.Gesture arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._spatialSampling4979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _temporalSampling4980;
		public static float[] temporalSampling(android.gesture.GestureStroke arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._temporalSampling4980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as float[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureUtils"));
			global::android.gesture.GestureUtils._computeOrientedBoundingBox4976 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureUtils.staticClass, "computeOrientedBoundingBox", "(Ljava/util/ArrayList;)Landroid/gesture/OrientedBoundingBox;");
			global::android.gesture.GestureUtils._computeOrientedBoundingBox4977 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureUtils.staticClass, "computeOrientedBoundingBox", "([F)Landroid/gesture/OrientedBoundingBox;");
			global::android.gesture.GestureUtils._spatialSampling4978 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureUtils.staticClass, "spatialSampling", "(Landroid/gesture/Gesture;I)[F");
			global::android.gesture.GestureUtils._spatialSampling4979 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureUtils.staticClass, "spatialSampling", "(Landroid/gesture/Gesture;IZ)[F");
			global::android.gesture.GestureUtils._temporalSampling4980 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureUtils.staticClass, "temporalSampling", "(Landroid/gesture/GestureStroke;I)[F");
		}
	}
}