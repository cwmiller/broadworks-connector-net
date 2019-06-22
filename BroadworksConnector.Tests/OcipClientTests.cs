using BroadWorksConnector.Ocip;
using System;
using Xunit;

namespace BroadWorksConnector.Tests
{
    /// <summary>
    /// Tests OcipClient
    /// </summary>
    public class OcipClientTests
    {
        [Fact]
        public void TestDefaultOptions()
        {
            var client = new OcipClient("tcp://bwas", "username", "password");
            Assert.Equal(ServerVersion.R14sp4, client.Options.MinServerVersion);
        }

        [Fact]
        public void TestSetOptions()
        {
            var client = new OcipClient("tcp://bwas", "username", "password", new OcipClientOptions()
            {
                MinServerVersion = ServerVersion.R22
            });

            Assert.Equal(ServerVersion.R22, client.Options.MinServerVersion);
        }

        [Fact]
        public void TestHttpTransport()
        {
            var client = new OcipClient("http://bwas/webservice/services/ProvisioningService?wsdl", "username", "password");
            Assert.IsType<SoapTransport>(client.Transport);
        }

        [Fact]
        public void TestHttpsTransport()
        {
            var client = new OcipClient("https://bwas/webservice/services/ProvisioningService?wsdl", "username", "password");
            Assert.IsType<SoapTransport>(client.Transport);
        }

        [Fact]
        public void TestTcpTransport()
        {
            var client = new OcipClient("tcp://bwas", "username", "password");
            Assert.IsType<TcpTransport>(client.Transport);
        }

        [Fact]
        public void TestSslTransport()
        {
            var client = new OcipClient("tls://bwas", "username", "password");
            Assert.IsType<TcpTransport>(client.Transport);
        }

        [Fact]
        public void TestUnhandledScheme()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new OcipClient("ftp://bwas", "username", "password");
            });
        }

        [Fact]
        public void TestUnspecifiedScheme()
        {
            Assert.Throws<UriFormatException>(() =>
            {
                new OcipClient("bwas", "username", "password");
            });
        }
    }
}
