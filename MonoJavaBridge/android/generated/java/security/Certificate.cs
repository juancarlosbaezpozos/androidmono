namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.Certificate_))]
	public partial interface Certificate  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String toString(bool arg0);
		void decode(java.io.InputStream arg0);
		void encode(java.io.OutputStream arg0);
		global::java.security.PublicKey getPublicKey();
		global::java.lang.String getFormat();
		global::java.security.Principal getGuarantor();
		global::java.security.Principal getPrincipal();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Certificate))]
	internal sealed partial class Certificate_ : java.lang.Object, Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString22912;
		global::java.lang.String java.security.Certificate.toString(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Certificate_.staticClass, "toString", "(Z)Ljava/lang/String;", ref global::java.security.Certificate_._toString22912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _decode22913;
		void java.security.Certificate.decode(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Certificate_.staticClass, "decode", "(Ljava/io/InputStream;)V", ref global::java.security.Certificate_._decode22913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _encode22914;
		void java.security.Certificate.encode(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Certificate_.staticClass, "encode", "(Ljava/io/OutputStream;)V", ref global::java.security.Certificate_._encode22914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey22915;
		global::java.security.PublicKey java.security.Certificate.getPublicKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;", ref global::java.security.Certificate_._getPublicKey22915) as java.security.PublicKey;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat22916;
		global::java.lang.String java.security.Certificate.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Certificate_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.Certificate_._getFormat22916) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getGuarantor22917;
		global::java.security.Principal java.security.Certificate.getGuarantor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.security.Certificate_.staticClass, "getGuarantor", "()Ljava/security/Principal;", ref global::java.security.Certificate_._getGuarantor22917) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipal22918;
		global::java.security.Principal java.security.Certificate.getPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.security.Certificate_.staticClass, "getPrincipal", "()Ljava/security/Principal;", ref global::java.security.Certificate_._getPrincipal22918) as java.security.Principal;
		}
		static Certificate_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Certificate"));
		}
		internal static void InitJNI()
		{
		}
	}
}