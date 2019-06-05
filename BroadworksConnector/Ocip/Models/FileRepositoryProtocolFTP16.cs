using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class FileRepositoryProtocolFTP16
    {
        private bool _ftpPassive;

        [XmlElement(ElementName = "ftpPassive", IsNullable = false, Namespace = "")]
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
        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
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
        private bool _ftpRemoteVerification;

        [XmlElement(ElementName = "ftpRemoteVerification", IsNullable = false, Namespace = "")]
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
