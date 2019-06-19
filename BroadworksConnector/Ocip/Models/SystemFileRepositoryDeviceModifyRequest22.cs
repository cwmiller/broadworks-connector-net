using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9386""}]")]
    public class SystemFileRepositoryDeviceModifyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9386")]
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
        public bool NameSpecified { get; set; }

        private string _rootDirectory;

        [XmlElement(ElementName = "rootDirectory", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9386")]
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
        public bool RootDirectorySpecified { get; set; }

        private bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9386")]
        public bool Secure
        {
            get => _secure;
            set
            {
                SecureSpecified = true;
                _secure = value;
            }
        }

        [XmlIgnore]
        public bool SecureSpecified { get; set; }

        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9386")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NetAddress
        {
            get => _netAddress;
            set
            {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        public bool NetAddressSpecified { get; set; }

        private bool _ftpPassive;

        [XmlElement(ElementName = "ftpPassive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9386")]
        public bool FtpPassive
        {
            get => _ftpPassive;
            set
            {
                FtpPassiveSpecified = true;
                _ftpPassive = value;
            }
        }

        [XmlIgnore]
        public bool FtpPassiveSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.FileRepositoryProtocol22 _protocol;

        [XmlElement(ElementName = "protocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9386")]
        public BroadWorksConnector.Ocip.Models.FileRepositoryProtocol22 Protocol
        {
            get => _protocol;
            set
            {
                ProtocolSpecified = true;
                _protocol = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolSpecified { get; set; }

        private int? _port;

        [XmlElement(ElementName = "port", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9386")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int? Port
        {
            get => _port;
            set
            {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        public bool PortSpecified { get; set; }

        private bool _ftpRemoteVerification;

        [XmlElement(ElementName = "ftpRemoteVerification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9386")]
        public bool FtpRemoteVerification
        {
            get => _ftpRemoteVerification;
            set
            {
                FtpRemoteVerificationSpecified = true;
                _ftpRemoteVerification = value;
            }
        }

        [XmlIgnore]
        public bool FtpRemoteVerificationSpecified { get; set; }

    }
}
