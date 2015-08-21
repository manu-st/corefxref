namespace System.Windows.Forms {
	public class Window : Form { }
	public class Form : Control { }
	public class Control : IDisposable {
		public IntPtr Handle { get { return (IntPtr) 0; } }
		public bool IsDisposed { get; }
		public void Dispose() { }
		public event EventHandler Disposed { add { } remove { } } 
		public void Show() { }
	}

	public class ApplicationContext : IDisposable {
		Form mainForm;
		public ApplicationContext() : this(null) { }
		public ApplicationContext(Form mainForm) { this.mainForm = mainForm; }
		public Form MainForm { get { return mainForm; } }
		public void Dispose() { }
		public void Show() { }
	}

	public sealed class Application {
		public static void DoEvents() { }
		public static bool FilterMessage(ref Message message) { return false; }
	}

	public struct Message {
		public IntPtr HWnd { get { return (IntPtr) 0; } set { } }
		public int Msg { get { return 0; } set { } }
		public IntPtr WParam { get { return (IntPtr) 0; } set { } }
		public IntPtr LParam { get { return (IntPtr) 0; } set { } }
		public IntPtr Result { get { return (IntPtr) 0; } set { } }
	}
}
