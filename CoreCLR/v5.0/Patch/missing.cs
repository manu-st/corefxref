// This is to provide the missing functionality System.Reflection.Assembly.get_Location()
namespace Helpers {
	public class Reflection {
		public static string GetAssemblyLocation(System.Reflection.Assembly ass) {
			throw new System.NotImplementedException();
		}
	}
}

namespace System.Drawing {
	public class Icon {
	}
}

namespace System.CodeDom.Compiler {

	public class CompilerErrorCollection {
  		public int Add(CompilerError value) {
			return 0;
        }
	}

	public class CodeDomProvider {
	}

	public class CompilerError {
   		public string ErrorText {
            get {
                return null;
            }
            set {
            }
        }

		   public bool IsWarning {
            get {
                return false;
            }
            set {
            }
        }

	}
}

namespace System.Security {
	// SuppressUnmanagedCodeSecurityAttribute:
 	//  Indicates that the target P/Invoke method(s) should skip the per-call
	//  security checked for unmanaged code permission.
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false )] 
	[System.Runtime.InteropServices.ComVisible(true)]
	sealed public class SuppressUnmanagedCodeSecurityAttribute : System.Attribute
	{
	}
}


namespace System.ComponentModel {

	[AttributeUsageAttribute(AttributeTargets.All)]
	public class CategoryAttribute : System.Attribute {
	}

	[AttributeUsageAttribute(AttributeTargets.All)]
	public sealed class BrowsableAttribute : Attribute {
		private bool browsable = true;
		public BrowsableAttribute(bool browsable) {
			this.browsable = browsable;
		}
	}
}

namespace Microsoft.CSharp {
	using System.CodeDom.Compiler;

    public class CSharpCodeProvider: CodeDomProvider {
	}

}

namespace System.Net.Security {

	using System.IO;
	using System.Security.Cryptography.X509Certificates;
	using System.Net.Security;
	using System.Security.Authentication;

	public delegate bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors);

	public class SslStream : Stream {
		public SslStream(Stream innerStream) {
		}
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen) {
		}
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) {
		}

		public override bool CanRead { get; }
		public override bool CanSeek { get; }
		public override bool CanTimeout { get; }
		public override bool CanWrite { get; }
		public virtual bool CheckCertRevocationStatus { get; }
		public virtual int CipherStrength { get; }
		public virtual int HashStrength { get; }
		public virtual int KeyExchangeStrength { get; }
		public override long Length { get; }
		public override long Position { get; set; }
		public override int ReadTimeout { get; set; }
		public override int WriteTimeout { get; set; }
		public override void Flush() {
		}
		public override int Read(byte[] buffer, int offset, int count) {
			return -1;
		}
		public override long Seek(long offset, SeekOrigin origin) {
			return -1;
		}
		public override void SetLength(long value) {
		}
		public void Write(byte[] buffer) {
		}
		public override void Write(byte[] buffer, int offset, int count) {
		}

		public virtual void AuthenticateAsClient(string targetHost) {
		}
    	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) {
		}
		
	}
}
