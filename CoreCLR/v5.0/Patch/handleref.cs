using System;
namespace System.Runtime.InteropServices {
	public struct HandleRef {
		public HandleRef(Object wrapper, IntPtr handle) { }
		public Object Wrapper { get { return null; } }
		public IntPtr Handle { get { return (IntPtr) 0; } }
	}
}
