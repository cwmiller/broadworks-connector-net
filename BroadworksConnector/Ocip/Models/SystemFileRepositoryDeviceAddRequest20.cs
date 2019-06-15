using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a new file repository.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFileRepositoryDeviceAddRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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

        [XmlElement(ElementName = "rootDirectory", IsNullable = false, Namespace = "")]
        public string RootDirectory {
            get => _rootDirectory;
            set {
                RootDirectorySpecified = true;
                _rootDirectory = value;
            }
        }

        [XmlIgnore]
        public bool RootDirectorySpecified { get; set; }
        
        private int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        public int Port {
            get => _port;
            set {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        public bool PortSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.FileRepositoryProtocolWebDAV20 _protocolWebDAV;

        [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.FileRepositoryProtocolWebDAV20 ProtocolWebDAV {
            get => _protocolWebDAV;
            set {
                ProtocolWebDAVSpecified = true;
                _protocolWebDAV = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolWebDAVSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 _protocolFTP;

        [XmlElement(ElementName = "protocolFTP", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 ProtocolFTP {
            get => _protocolFTP;
            set {
                ProtocolFTPSpecified = true;
                _protocolFTP = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolFTPSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 _protocolSFTP;

        [XmlElement(ElementName = "protocolSFTP", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 ProtocolSFTP {
            get => _protocolSFTP;
            set {
                ProtocolSFTPSpecified = true;
                _protocolSFTP = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolSFTPSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 _protocolFTPS;

        [XmlElement(ElementName = "protocolFTPS", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 ProtocolFTPS {
            get => _protocolFTPS;
            set {
                ProtocolFTPSSpecified = true;
                _protocolFTPS = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolFTPSSpecified { get; set; }
        
    }
}
