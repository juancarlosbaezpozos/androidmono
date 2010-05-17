namespace android.provider 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CallLog : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static CallLog() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.CallLog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.provider.CallLog(@__env); 
			} 
		} 
		protected CallLog(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Calls : java.lang.Object, BaseColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static Calls() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.CallLog.Calls), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.CallLog.Calls(@__env); 
				} 
			} 
			protected Calls(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Calls5870; 
			public Calls()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.CallLog.Calls.staticClass, _Calls5870, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI5871; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_FILTER_URI5872; 
			public static android.net.Uri CONTENT_FILTER_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String DEFAULT_SORT_ORDER
			{ 
				get 
				{ 
					return "date DESC"; 
				} 
			} 
			public static java.lang.String CONTENT_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/calls"; 
				} 
			} 
			public static java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/calls"; 
				} 
			} 
			public static java.lang.String TYPE
			{ 
				get 
				{ 
					return "type"; 
				} 
			} 
			public static int INCOMING_TYPE
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int OUTGOING_TYPE
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
			public static int MISSED_TYPE
			{ 
				get 
				{ 
					return 3; 
				} 
			} 
			public static java.lang.String NUMBER
			{ 
				get 
				{ 
					return "number"; 
				} 
			} 
			public static java.lang.String DATE
			{ 
				get 
				{ 
					return "date"; 
				} 
			} 
			public static java.lang.String DURATION
			{ 
				get 
				{ 
					return "duration"; 
				} 
			} 
			public static java.lang.String NEW
			{ 
				get 
				{ 
					return "new"; 
				} 
			} 
			public static java.lang.String CACHED_NAME
			{ 
				get 
				{ 
					return "name"; 
				} 
			} 
			public static java.lang.String CACHED_NUMBER_TYPE
			{ 
				get 
				{ 
					return "numbertype"; 
				} 
			} 
			public static java.lang.String CACHED_NUMBER_LABEL
			{ 
				get 
				{ 
					return "numberlabel"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.CallLog.Calls.staticClass = @__class; 
				global::android.provider.CallLog.Calls._Calls5870 = @__env.GetMethodID(global::android.provider.CallLog.Calls.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CallLog5873; 
		public CallLog()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.provider.CallLog.staticClass, _CallLog5873, this); 
		} 
		public static java.lang.String AUTHORITY
		{ 
			get 
			{ 
				return "call_log"; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI5874; 
		public static android.net.Uri CONTENT_URI
		{ 
			get 
			{ 
				return default(android.net.Uri); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.provider.CallLog.staticClass = @__class; 
			global::android.provider.CallLog._CallLog5873 = @__env.GetMethodID(global::android.provider.CallLog.staticClass, "<init>", "()V"); 
		} 
	} 
} 