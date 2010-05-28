namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AlignmentSpan_Standard : java.lang.Object, AlignmentSpan, ParcelableSpan
	{ 
		internal static global::java.lang.Class staticClass; 
		static AlignmentSpan_Standard() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.AlignmentSpan_Standard), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.AlignmentSpan_Standard(@__env); 
			} 
		} 
		protected AlignmentSpan_Standard(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7287; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AlignmentSpan_Standard)) 
				@__env.CallVoidMethod(this, global::android.text.style.AlignmentSpan_Standard._writeToParcel7287, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._writeToParcel7287, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7288; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AlignmentSpan_Standard)) 
				return @__env.CallIntMethod(this, global::android.text.style.AlignmentSpan_Standard._describeContents7288); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._describeContents7288); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAlignment7289; 
		public virtual global::android.text.Layout.Alignment getAlignment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AlignmentSpan_Standard)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.style.AlignmentSpan_Standard._getAlignment7289)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._getAlignment7289)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7290; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AlignmentSpan_Standard)) 
				return @__env.CallIntMethod(this, global::android.text.style.AlignmentSpan_Standard._getSpanTypeId7290); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._getSpanTypeId7290); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AlignmentSpan_Standard7291; 
		public AlignmentSpan_Standard(android.text.Layout.Alignment arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard7291, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AlignmentSpan_Standard7292; 
		public AlignmentSpan_Standard(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard7292, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.AlignmentSpan_Standard.staticClass = @__class; 
			global::android.text.style.AlignmentSpan_Standard._writeToParcel7287 = @__env.GetMethodID(global::android.text.style.AlignmentSpan_Standard.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.AlignmentSpan_Standard._describeContents7288 = @__env.GetMethodID(global::android.text.style.AlignmentSpan_Standard.staticClass, "describeContents", "()I"); 
			global::android.text.style.AlignmentSpan_Standard._getAlignment7289 = @__env.GetMethodID(global::android.text.style.AlignmentSpan_Standard.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;"); 
			global::android.text.style.AlignmentSpan_Standard._getSpanTypeId7290 = @__env.GetMethodID(global::android.text.style.AlignmentSpan_Standard.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard7291 = @__env.GetMethodID(global::android.text.style.AlignmentSpan_Standard.staticClass, "<init>", "(Landroid/text/Layout$Alignment;)V"); 
			global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard7292 = @__env.GetMethodID(global::android.text.style.AlignmentSpan_Standard.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
