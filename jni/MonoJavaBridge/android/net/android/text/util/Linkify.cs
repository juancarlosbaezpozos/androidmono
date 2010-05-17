namespace android.text.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Linkify : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Linkify() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.util.Linkify), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.util.Linkify(@__env); 
			} 
		} 
		protected Linkify(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface MatchFilter 
		{ 
			bool acceptMatch(java.lang.CharSequence arg0, int arg1, int arg2); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface TransformFilter 
		{ 
			java.lang.String transformUrl(java.util.regex.Matcher arg0, java.lang.String arg1); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLinks7095; 
		public static bool addLinks(android.widget.TextView arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, _addLinks7095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLinks7096; 
		public static void addLinks(android.widget.TextView arg0, java.util.regex.Pattern arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.util.Linkify.staticClass, _addLinks7096, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLinks7097; 
		public static void addLinks(android.widget.TextView arg0, java.util.regex.Pattern arg1, java.lang.String arg2, android.text.util.Linkify.MatchFilter arg3, android.text.util.Linkify.TransformFilter arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.util.Linkify.staticClass, _addLinks7097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLinks7098; 
		public static bool addLinks(android.text.Spannable arg0, java.util.regex.Pattern arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, _addLinks7098, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLinks7099; 
		public static bool addLinks(android.text.Spannable arg0, java.util.regex.Pattern arg1, java.lang.String arg2, android.text.util.Linkify.MatchFilter arg3, android.text.util.Linkify.TransformFilter arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, _addLinks7099, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLinks7100; 
		public static bool addLinks(android.text.Spannable arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, _addLinks7100, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Linkify7101; 
		public Linkify()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.util.Linkify.staticClass, _Linkify7101, this); 
		} 
		public static int WEB_URLS
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int EMAIL_ADDRESSES
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int PHONE_NUMBERS
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int MAP_ADDRESSES
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int ALL
		{ 
			get 
			{ 
				return 15; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _sUrlMatchFilter7102; 
		public static android.text.util.Linkify.MatchFilter sUrlMatchFilter
		{ 
			get 
			{ 
				return default(android.text.util.Linkify.MatchFilter); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _sPhoneNumberMatchFilter7103; 
		public static android.text.util.Linkify.MatchFilter sPhoneNumberMatchFilter
		{ 
			get 
			{ 
				return default(android.text.util.Linkify.MatchFilter); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _sPhoneNumberTransformFilter7104; 
		public static android.text.util.Linkify.TransformFilter sPhoneNumberTransformFilter
		{ 
			get 
			{ 
				return default(android.text.util.Linkify.TransformFilter); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.util.Linkify.staticClass = @__class; 
			global::android.text.util.Linkify._addLinks7095 = @__env.GetStaticMethodID(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/widget/TextView;I)Z"); 
			global::android.text.util.Linkify._addLinks7096 = @__env.GetStaticMethodID(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;)V"); 
			global::android.text.util.Linkify._addLinks7097 = @__env.GetStaticMethodID(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;Landroid/text/util/Linkify$MatchFilter;Landroid/text/util/Linkify$TransformFilter;)V"); 
			global::android.text.util.Linkify._addLinks7098 = @__env.GetStaticMethodID(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;)Z"); 
			global::android.text.util.Linkify._addLinks7099 = @__env.GetStaticMethodID(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;Landroid/text/util/Linkify$MatchFilter;Landroid/text/util/Linkify$TransformFilter;)Z"); 
			global::android.text.util.Linkify._addLinks7100 = @__env.GetStaticMethodID(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/text/Spannable;I)Z"); 
			global::android.text.util.Linkify._Linkify7101 = @__env.GetMethodID(global::android.text.util.Linkify.staticClass, "<init>", "()V"); 
		} 
	} 
} 