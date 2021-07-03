using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10250"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10254""}]}]")]
    public class SystemFileRepositoryDeviceAddRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10250")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private string _rootDirectory;

        [XmlElement(ElementName = "rootDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10250")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RootDirectory
        {
            get => _rootDirectory;
            set
            {
                RootDirectorySpecified = true;
                _rootDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool RootDirectorySpecified { get; set; }

        private int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10250")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int Port
        {
            get => _port;
            set
            {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        protected bool PortSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.FileRepositoryProtocolWebDAV20 _protocolWebDAV;

        [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10254")]
        public BroadWorksConnector.Ocip.Models.FileRepositoryProtocolWebDAV20 ProtocolWebDAV
        {
            get => _protocolWebDAV;
            set
            {
                ProtocolWebDAVSpecified = true;
                _protocolWebDAV = value;
            }
        }

        [XmlIgnore]
        protected bool ProtocolWebDAVSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 _protocolFTP;

        [XmlElement(ElementName = "protocolFTP", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10254")]
        public BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 ProtocolFTP
        {
            get => _protocolFTP;
            set
            {
                ProtocolFTPSpecified = true;
                _protocolFTP = value;
            }
        }

        [XmlIgnore]
        protected bool ProtocolFTPSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 _protocolSFTP;

        [XmlElement(ElementName = "protocolSFTP", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10254")]
        public BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 ProtocolSFTP
        {
            get => _protocolSFTP;
            set
            {
                ProtocolSFTPSpecified = true;
                _protocolSFTP = value;
            }
        }

        [XmlIgnore]
        protected bool ProtocolSFTPSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 _protocolFTPS;

        [XmlElement(ElementName = "protocolFTPS", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10254")]
        public BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 ProtocolFTPS
        {
            get => _protocolFTPS;
            set
            {
                ProtocolFTPSSpecified = true;
                _protocolFTPS = value;
            }
        }

        [XmlIgnore]
        protected bool ProtocolFTPSSpecified { get; set; }

    }
}
