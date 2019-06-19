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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:44006""}]")]
    public class FileRepositoryProtocolFTP
    {

        private bool _ftpPassive;

        [XmlElement(ElementName = "ftpPassive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44006")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44006")]
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

    }
}
