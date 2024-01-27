using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSMPPGetRequest.
    /// <see cref="SystemSMPPGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:35522""}]")]
    public class SystemSMPPGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _primarySMPPServerNetAddress;

        [XmlElement(ElementName = "primarySMPPServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:35522")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PrimarySMPPServerNetAddress
        {
            get => _primarySMPPServerNetAddress;
            set
            {
                PrimarySMPPServerNetAddressSpecified = true;
                _primarySMPPServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool PrimarySMPPServerNetAddressSpecified { get; set; }

        protected int _primarySMPPPort;

        [XmlElement(ElementName = "primarySMPPPort", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:35522")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int PrimarySMPPPort
        {
            get => _primarySMPPPort;
            set
            {
                PrimarySMPPPortSpecified = true;
                _primarySMPPPort = value;
            }
        }

        [XmlIgnore]
        protected bool PrimarySMPPPortSpecified { get; set; }

        protected string _secondarySMPPServerNetAddress;

        [XmlElement(ElementName = "secondarySMPPServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:35522")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SecondarySMPPServerNetAddress
        {
            get => _secondarySMPPServerNetAddress;
            set
            {
                SecondarySMPPServerNetAddressSpecified = true;
                _secondarySMPPServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SecondarySMPPServerNetAddressSpecified { get; set; }

        protected int _secondarySMPPPort;

        [XmlElement(ElementName = "secondarySMPPPort", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:35522")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int SecondarySMPPPort
        {
            get => _secondarySMPPPort;
            set
            {
                SecondarySMPPPortSpecified = true;
                _secondarySMPPPort = value;
            }
        }

        [XmlIgnore]
        protected bool SecondarySMPPPortSpecified { get; set; }

        protected string _systemId;

        [XmlElement(ElementName = "systemId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:35522")]
        [MinLength(1)]
        [MaxLength(16)]
        public string SystemId
        {
            get => _systemId;
            set
            {
                SystemIdSpecified = true;
                _systemId = value;
            }
        }

        [XmlIgnore]
        protected bool SystemIdSpecified { get; set; }

        protected string _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:35522")]
        [MinLength(1)]
        [MaxLength(8)]
        public string Password
        {
            get => _password;
            set
            {
                PasswordSpecified = true;
                _password = value;
            }
        }

        [XmlIgnore]
        protected bool PasswordSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SMPPVersion _version;

        [XmlElement(ElementName = "version", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:35522")]
        public BroadWorksConnector.Ocip.Models.SMPPVersion Version
        {
            get => _version;
            set
            {
                VersionSpecified = true;
                _version = value;
            }
        }

        [XmlIgnore]
        protected bool VersionSpecified { get; set; }

    }
}
