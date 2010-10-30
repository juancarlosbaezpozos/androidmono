namespace android.speech
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.speech.RecognitionListener_))]
	public partial interface RecognitionListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onError(int arg0);
		void onEvent(int arg0, android.os.Bundle arg1);
		void onReadyForSpeech(android.os.Bundle arg0);
		void onBeginningOfSpeech();
		void onRmsChanged(float arg0);
		void onBufferReceived(byte[] arg0);
		void onEndOfSpeech();
		void onResults(android.os.Bundle arg0);
		void onPartialResults(android.os.Bundle arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.speech.RecognitionListener))]
	internal sealed partial class RecognitionListener_ : java.lang.Object, RecognitionListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RecognitionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onError11646;
		void android.speech.RecognitionListener.onError(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionListener_.staticClass, "onError", "(I)V", ref global::android.speech.RecognitionListener_._onError11646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onEvent11647;
		void android.speech.RecognitionListener.onEvent(int arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionListener_.staticClass, "onEvent", "(ILandroid/os/Bundle;)V", ref global::android.speech.RecognitionListener_._onEvent11647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onReadyForSpeech11648;
		void android.speech.RecognitionListener.onReadyForSpeech(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionListener_.staticClass, "onReadyForSpeech", "(Landroid/os/Bundle;)V", ref global::android.speech.RecognitionListener_._onReadyForSpeech11648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBeginningOfSpeech11649;
		void android.speech.RecognitionListener.onBeginningOfSpeech()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionListener_.staticClass, "onBeginningOfSpeech", "()V", ref global::android.speech.RecognitionListener_._onBeginningOfSpeech11649);
		}
		internal static global::MonoJavaBridge.MethodId _onRmsChanged11650;
		void android.speech.RecognitionListener.onRmsChanged(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionListener_.staticClass, "onRmsChanged", "(F)V", ref global::android.speech.RecognitionListener_._onRmsChanged11650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBufferReceived11651;
		void android.speech.RecognitionListener.onBufferReceived(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionListener_.staticClass, "onBufferReceived", "([B)V", ref global::android.speech.RecognitionListener_._onBufferReceived11651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onEndOfSpeech11652;
		void android.speech.RecognitionListener.onEndOfSpeech()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionListener_.staticClass, "onEndOfSpeech", "()V", ref global::android.speech.RecognitionListener_._onEndOfSpeech11652);
		}
		internal static global::MonoJavaBridge.MethodId _onResults11653;
		void android.speech.RecognitionListener.onResults(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionListener_.staticClass, "onResults", "(Landroid/os/Bundle;)V", ref global::android.speech.RecognitionListener_._onResults11653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPartialResults11654;
		void android.speech.RecognitionListener.onPartialResults(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionListener_.staticClass, "onPartialResults", "(Landroid/os/Bundle;)V", ref global::android.speech.RecognitionListener_._onPartialResults11654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static RecognitionListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.RecognitionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/RecognitionListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}