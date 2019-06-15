using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a file repository.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFileRepositoryDeviceModifyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
        private string _rootDirectory;

        [XmlElement(ElementName = "rootDirectory", IsNullable = true, Namespace = "")]
        public string RootDirectory {
            get => _rootDirectory;
            set {
                RootDirectorySpecified = true;
                _rootDirectory = value;
            }
        }

        [XmlIgnore]
        public bool RootDirectorySpecified { get; set; }
        
        private bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
        public bool Secure {
            get => _secure;
            set {
                SecureSpecified = true;
                _secure = value;
            }
        }

        [XmlIgnore]
        public bool SecureSpecified { get; set; }
        
        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        public string NetAddress {
            get => _netAddress;
            set {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        public bool NetAddressSpecified { get; set; }
        
        private bool _ftpPassive;

        [XmlElement(ElementName = "ftpPassive", IsNullable = false, Namespace = "")]
        public bool FtpPassive {
            get => _ftpPassive;
            set {
                FtpPassiveSpecified = true;
                _ftpPassive = value;
            }
        }

        [XmlIgnore]
        public bool FtpPassiveSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.FileRepositoryProtocol22 _protocol;

        [XmlElement(ElementName = "protocol", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.FileRepositoryProtocol22 Protocol {
            get => _protocol;
            set {
                ProtocolSpecified = true;
                _protocol = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolSpecified { get; set; }
        
        private int? _port;

        [XmlElement(ElementName = "port", IsNullable = true, Namespace = "")]
        public int? Port {
            get => _port;
            set {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        public bool PortSpecified { get; set; }
        
        private bool _ftpRemoteVerification;

        [XmlElement(ElementName = "ftpRemoteVerification", IsNullable = false, Namespace = "")]
        public bool FtpRemoteVerification {
            get => _ftpRemoteVerification;
            set {
                FtpRemoteVerificationSpecified = true;
                _ftpRemoteVerification = value;
            }
        }

        [XmlIgnore]
        public bool FtpRemoteVerificationSpecified { get; set; }
        
    }
}
