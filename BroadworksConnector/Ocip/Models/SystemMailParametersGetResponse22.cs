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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11596""}]")]
    public class SystemMailParametersGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _primaryServerNetAddress;

        [XmlElement(ElementName = "primaryServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11596")]
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
        protected bool PrimaryServerNetAddressSpecified { get; set; }

        protected string _secondaryServerNetAddress;

        [XmlElement(ElementName = "secondaryServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11596")]
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
        protected bool SecondaryServerNetAddressSpecified { get; set; }

        protected string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11596")]
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
        protected bool DefaultFromAddressSpecified { get; set; }

        protected string _defaultSubject;

        [XmlElement(ElementName = "defaultSubject", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11596")]
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
        protected bool DefaultSubjectSpecified { get; set; }

        protected bool _supportDNSSRVForMailServerAccess;

        [XmlElement(ElementName = "supportDNSSRVForMailServerAccess", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11596")]
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
        protected bool SupportDNSSRVForMailServerAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SMTPSecureMode _secureMode;

        [XmlElement(ElementName = "secureMode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11596")]
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
        protected bool SecureModeSpecified { get; set; }

        protected int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11596")]
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

    }
}
