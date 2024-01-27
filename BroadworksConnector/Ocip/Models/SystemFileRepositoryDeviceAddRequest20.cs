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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10368"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10372""}]}]")]
    public class SystemFileRepositoryDeviceAddRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10368")]
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

        protected string _rootDirectory;

        [XmlElement(ElementName = "rootDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10368")]
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

        protected int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10368")]
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

        protected BroadWorksConnector.Ocip.Models.FileRepositoryProtocolWebDAV20 _protocolWebDAV;

        [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10372")]
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

        protected BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 _protocolFTP;

        [XmlElement(ElementName = "protocolFTP", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10372")]
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

        protected BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 _protocolSFTP;

        [XmlElement(ElementName = "protocolSFTP", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10372")]
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

        protected BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 _protocolFTPS;

        [XmlElement(ElementName = "protocolFTPS", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10372")]
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
