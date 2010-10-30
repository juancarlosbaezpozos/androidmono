namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AndroidTestRunner : junit.runner.BaseTestRunner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AndroidTestRunner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _runTest12150;
		public virtual void runTest()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "runTest", "()V", ref global::android.test.AndroidTestRunner._runTest12150);
		}
		internal static global::MonoJavaBridge.MethodId _runTest12151;
		public virtual void runTest(junit.framework.TestResult arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "runTest", "(Ljunit/framework/TestResult;)V", ref global::android.test.AndroidTestRunner._runTest12151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.Context Context
		{
			set
			{
				setContext(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setContext12152;
		public virtual void setContext(android.content.Context arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "setContext", "(Landroid/content/Context;)V", ref global::android.test.AndroidTestRunner._setContext12152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTestClassName12153;
		public virtual void setTestClassName(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "setTestClassName", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.test.AndroidTestRunner._setTestClassName12153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::junit.framework.Test Test
		{
			set
			{
				setTest(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTest12154;
		public virtual void setTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "setTest", "(Ljunit/framework/Test;)V", ref global::android.test.AndroidTestRunner._setTest12154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearTestListeners12155;
		public virtual void clearTestListeners()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "clearTestListeners", "()V", ref global::android.test.AndroidTestRunner._clearTestListeners12155);
		}
		internal static global::MonoJavaBridge.MethodId _addTestListener12156;
		public virtual void addTestListener(junit.framework.TestListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "addTestListener", "(Ljunit/framework/TestListener;)V", ref global::android.test.AndroidTestRunner._addTestListener12156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createTestResult12157;
		protected virtual global::junit.framework.TestResult createTestResult()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.AndroidTestRunner.staticClass, "createTestResult", "()Ljunit/framework/TestResult;", ref global::android.test.AndroidTestRunner._createTestResult12157) as junit.framework.TestResult;
		}
		public new global::java.util.List TestCases
		{
			get
			{
				return getTestCases();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTestCases12158;
		public virtual global::java.util.List getTestCases()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.test.AndroidTestRunner.staticClass, "getTestCases", "()Ljava/util/List;", ref global::android.test.AndroidTestRunner._getTestCases12158) as java.util.List;
		}
		public new global::java.lang.String TestClassName
		{
			get
			{
				return getTestClassName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTestClassName12159;
		public virtual global::java.lang.String getTestClassName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.AndroidTestRunner.staticClass, "getTestClassName", "()Ljava/lang/String;", ref global::android.test.AndroidTestRunner._getTestClassName12159) as java.lang.String;
		}
		public new global::junit.framework.TestResult TestResult
		{
			get
			{
				return getTestResult();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTestResult12160;
		public virtual global::junit.framework.TestResult getTestResult()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.AndroidTestRunner.staticClass, "getTestResult", "()Ljunit/framework/TestResult;", ref global::android.test.AndroidTestRunner._getTestResult12160) as junit.framework.TestResult;
		}
		public new global::android.app.Instrumentation Instrumentation
		{
			set
			{
				setInstrumentation(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setInstrumentation12161;
		public virtual void setInstrumentation(android.app.Instrumentation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "setInstrumentation", "(Landroid/app/Instrumentation;)V", ref global::android.test.AndroidTestRunner._setInstrumentation12161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.app.Instrumentation Instrumentaiton
		{
			set
			{
				setInstrumentaiton(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setInstrumentaiton12162;
		public virtual void setInstrumentaiton(android.app.Instrumentation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "setInstrumentaiton", "(Landroid/app/Instrumentation;)V", ref global::android.test.AndroidTestRunner._setInstrumentaiton12162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadSuiteClass12163;
		protected override global::java.lang.Class loadSuiteClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.test.AndroidTestRunner.staticClass, "loadSuiteClass", "(Ljava/lang/String;)Ljava/lang/Class;", ref global::android.test.AndroidTestRunner._loadSuiteClass12163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _testStarted12164;
		public override void testStarted(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "testStarted", "(Ljava/lang/String;)V", ref global::android.test.AndroidTestRunner._testStarted12164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testEnded12165;
		public override void testEnded(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "testEnded", "(Ljava/lang/String;)V", ref global::android.test.AndroidTestRunner._testEnded12165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testFailed12166;
		public override void testFailed(int arg0, junit.framework.Test arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V", ref global::android.test.AndroidTestRunner._testFailed12166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _runFailed12167;
		protected override void runFailed(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestRunner.staticClass, "runFailed", "(Ljava/lang/String;)V", ref global::android.test.AndroidTestRunner._runFailed12167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AndroidTestRunner12168;
		public AndroidTestRunner() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.AndroidTestRunner._AndroidTestRunner12168.native == global::System.IntPtr.Zero)
				global::android.test.AndroidTestRunner._AndroidTestRunner12168 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._AndroidTestRunner12168);
			Init(@__env, handle);
		}
		static AndroidTestRunner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.AndroidTestRunner.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/AndroidTestRunner"));
		}
		internal static void InitJNI()
		{
		}
	}
}