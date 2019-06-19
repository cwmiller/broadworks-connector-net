using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Attributes of the FTP protocol when the file repository interface is using FTP.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2373""}]")]
    public class FileRepositoryProtocolFTP16
    {

        private bool _ftpPassive;

        [XmlElement(ElementName = "ftpPassive", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2373")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2373")]
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

        private bool _ftpRemoteVerification;

        [XmlElement(ElementName = "ftpRemoteVerification", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2373")]
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
