using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMailParametersGetListRequest22.
    /// Contains a list of system Mail parameters.
    /// <see cref="SystemMailParametersGetListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10555""}]")]
    public class SystemMailParametersGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _primaryServerNetAddress;

        [XmlElement(ElementName = "primaryServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10555")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PrimaryServerNetAddress
        {
            get => _primaryServerNetAddress;
            set
            {
                PrimaryServerNetAddressSpecified = true;
                _primaryServerNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool PrimaryServerNetAddressSpecified { get; set; }

        private string _secondaryServerNetAddress;

        [XmlElement(ElementName = "secondaryServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10555")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SecondaryServerNetAddress
        {
            get => _secondaryServerNetAddress;
            set
            {
                SecondaryServerNetAddressSpecified = true;
                _secondaryServerNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool SecondaryServerNetAddressSpecified { get; set; }

        private string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10555")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultFromAddress
        {
            get => _defaultFromAddress;
            set
            {
                DefaultFromAddressSpecified = true;
                _defaultFromAddress = value;
            }
        }

        [XmlIgnore]
        public bool DefaultFromAddressSpecified { get; set; }

        private string _defaultSubject;

        [XmlElement(ElementName = "defaultSubject", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10555")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultSubject
        {
            get => _defaultSubject;
            set
            {
                DefaultSubjectSpecified = true;
                _defaultSubject = value;
            }
        }

        [XmlIgnore]
        public bool DefaultSubjectSpecified { get; set; }

        private bool _supportDNSSRVForMailServerAccess;

        [XmlElement(ElementName = "supportDNSSRVForMailServerAccess", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10555")]
        public bool SupportDNSSRVForMailServerAccess
        {
            get => _supportDNSSRVForMailServerAccess;
            set
            {
                SupportDNSSRVForMailServerAccessSpecified = true;
                _supportDNSSRVForMailServerAccess = value;
            }
        }

        [XmlIgnore]
        public bool SupportDNSSRVForMailServerAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SMTPSecureMode _secureMode;

        [XmlElement(ElementName = "secureMode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10555")]
        public BroadWorksConnector.Ocip.Models.SMTPSecureMode SecureMode
        {
            get => _secureMode;
            set
            {
                SecureModeSpecified = true;
                _secureMode = value;
            }
        }

        [XmlIgnore]
        public bool SecureModeSpecified { get; set; }

        private int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10555")]
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
        public bool PortSpecified { get; set; }

    }
}
