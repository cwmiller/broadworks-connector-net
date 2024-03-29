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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3281""}]")]
    public class FileRepositoryProtocolFTP16
    {

        protected bool _ftpPassive;

        [XmlElement(ElementName = "ftpPassive", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3281")]
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
        protected bool FtpPassiveSpecified { get; set; }

        protected string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3281")]
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
        protected bool NetAddressSpecified { get; set; }

        protected bool _ftpRemoteVerification;

        [XmlElement(ElementName = "ftpRemoteVerification", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3281")]
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
        protected bool FtpRemoteVerificationSpecified { get; set; }

    }
}
