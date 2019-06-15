using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemConfigurableFileSystemGetRequest23.
    /// Contains the File System parameters.
        /// <see cref="SystemConfigurableFileSystemGetRequest23"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemConfigurableFileSystemGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _mediaDirectory;

        [XmlElement(ElementName = "mediaDirectory", IsNullable = false, Namespace = "")]
        public string MediaDirectory {
            get => _mediaDirectory;
            set {
                MediaDirectorySpecified = true;
                _mediaDirectory = value;
            }
        }

        [XmlIgnore]
        public bool MediaDirectorySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23ProtocolFile _protocolFile;

        [XmlElement(ElementName = "protocolFile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23ProtocolFile ProtocolFile {
            get => _protocolFile;
            set {
                ProtocolFileSpecified = true;
                _protocolFile = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolFileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23ProtocolWebDAV _protocolWebDAV;

        [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23ProtocolWebDAV ProtocolWebDAV {
            get => _protocolWebDAV;
            set {
                ProtocolWebDAVSpecified = true;
                _protocolWebDAV = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolWebDAVSpecified { get; set; }
        
    }
}
