namespace android.speech
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SpeechRecognizer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SpeechRecognizer()
		{
			InitJNI();
		}
		protected SpeechRecognizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _destroy11646;
		public virtual void destroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.SpeechRecognizer._destroy11646);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._destroy11646);
		}
		internal static global::MonoJavaBridge.MethodId _cancel11647;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.SpeechRecognizer._cancel11647);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._cancel11647);
		}
		internal static global::MonoJavaBridge.MethodId _startListening11648;
		public virtual void startListening(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.SpeechRecognizer._startListening11648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._startListening11648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopListening11649;
		public virtual void stopListening() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.SpeechRecognizer._stopListening11649);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._stopListening11649);
		}
		internal static global::MonoJavaBridge.MethodId _isRecognitionAvailable11650;
		public static bool isRecognitionAvailable(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._isRecognitionAvailable11650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createSpeechRecognizer11651;
		public static global::android.speech.SpeechRecognizer createSpeechRecognizer(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._createSpeechRecognizer11651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.speech.SpeechRecognizer;
		}
		internal static global::MonoJavaBridge.MethodId _createSpeechRecognizer11652;
		public static global::android.speech.SpeechRecognizer createSpeechRecognizer(android.content.Context arg0, android.content.ComponentName arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._createSpeechRecognizer11652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.speech.SpeechRecognizer;
		}
		internal static global::MonoJavaBridge.MethodId _setRecognitionListener11653;
		public virtual void setRecognitionListener(android.speech.RecognitionListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.SpeechRecognizer._setRecognitionListener11653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._setRecognitionListener11653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.lang.String RESULTS_RECOGNITION
		{
			get
			{
				return "results_recognition";
			}
		}
		public static int ERROR_NETWORK_TIMEOUT
		{
			get
			{
				return 1;
			}
		}
		public static int ERROR_NETWORK
		{
			get
			{
				return 2;
			}
		}
		public static int ERROR_AUDIO
		{
			get
			{
				return 3;
			}
		}
		public static int ERROR_SERVER
		{
			get
			{
				return 4;
			}
		}
		public static int ERROR_CLIENT
		{
			get
			{
				return 5;
			}
		}
		public static int ERROR_SPEECH_TIMEOUT
		{
			get
			{
				return 6;
			}
		}
		public static int ERROR_NO_MATCH
		{
			get
			{
				return 7;
			}
		}
		public static int ERROR_RECOGNIZER_BUSY
		{
			get
			{
				return 8;
			}
		}
		public static int ERROR_INSUFFICIENT_PERMISSIONS
		{
			get
			{
				return 9;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.SpeechRecognizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/SpeechRecognizer"));
			global::android.speech.SpeechRecognizer._destroy11646 = @__env.GetMethodIDNoThrow(global::android.speech.SpeechRecognizer.staticClass, "destroy", "()V");
			global::android.speech.SpeechRecognizer._cancel11647 = @__env.GetMethodIDNoThrow(global::android.speech.SpeechRecognizer.staticClass, "cancel", "()V");
			global::android.speech.SpeechRecognizer._startListening11648 = @__env.GetMethodIDNoThrow(global::android.speech.SpeechRecognizer.staticClass, "startListening", "(Landroid/content/Intent;)V");
			global::android.speech.SpeechRecognizer._stopListening11649 = @__env.GetMethodIDNoThrow(global::android.speech.SpeechRecognizer.staticClass, "stopListening", "()V");
			global::android.speech.SpeechRecognizer._isRecognitionAvailable11650 = @__env.GetStaticMethodIDNoThrow(global::android.speech.SpeechRecognizer.staticClass, "isRecognitionAvailable", "(Landroid/content/Context;)Z");
			global::android.speech.SpeechRecognizer._createSpeechRecognizer11651 = @__env.GetStaticMethodIDNoThrow(global::android.speech.SpeechRecognizer.staticClass, "createSpeechRecognizer", "(Landroid/content/Context;)Landroid/speech/SpeechRecognizer;");
			global::android.speech.SpeechRecognizer._createSpeechRecognizer11652 = @__env.GetStaticMethodIDNoThrow(global::android.speech.SpeechRecognizer.staticClass, "createSpeechRecognizer", "(Landroid/content/Context;Landroid/content/ComponentName;)Landroid/speech/SpeechRecognizer;");
			global::android.speech.SpeechRecognizer._setRecognitionListener11653 = @__env.GetMethodIDNoThrow(global::android.speech.SpeechRecognizer.staticClass, "setRecognitionListener", "(Landroid/speech/RecognitionListener;)V");
		}
	}
}