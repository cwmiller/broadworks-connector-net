using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceTypeGetRequest.
    /// Replaced By: SystemDeviceTypeGetResponse14sp3
    /// <see cref="SystemDeviceTypeGetRequest"/>
    /// <see cref="SystemDeviceTypeGetResponse14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:26513""}]")]
    public class SystemDeviceTypeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isObsolete;

        [XmlElement(ElementName = "isObsolete", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:26513")]
        public bool IsObsolete
        {
            get => _isObsolete;
            set
            {
                IsObsoleteSpecified = true;
                _isObsolete = value;
            }
        }

        [XmlIgnore]
        protected bool IsObsoleteSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SignalingAddressType _profile;

        [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:26513")]
        public BroadWorksConnector.Ocip.Models.SignalingAddressType Profile
        {
            get => _profile;
            set
            {
                ProfileSpecified = true;
                _profile = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileSpecified { get; set; }

        protected string _webBasedConfigURL;

        [XmlElement(ElementName = "webBasedConfigURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:26513")]
        [MinLength(1)]
        [MaxLength(80)]
        public string WebBasedConfigURL
        {
            get => _webBasedConfigURL;
            set
            {
                WebBasedConfigURLSpecified = true;
                _webBasedConfigURL = value;
            }
        }

        [XmlIgnore]
        protected bool WebBasedConfigURLSpecified { get; set; }

        protected bool _staticRegistrationCapable;

        [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:26513")]
        public bool StaticRegistrationCapable
        {
            get => _staticRegistrationCapable;
            set
            {
                StaticRegistrationCapableSpecified = true;
                _staticRegistrationCapable = value;
            }
        }

        [XmlIgnore]
        protected bool StaticRegistrationCapableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CPEDeviceOptions _cpeDeviceOptions;

        [XmlElement(ElementName = "cpeDeviceOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:26513")]
        public BroadWorksConnector.Ocip.Models.CPEDeviceOptions CpeDeviceOptions
        {
            get => _cpeDeviceOptions;
            set
            {
                CpeDeviceOptionsSpecified = true;
                _cpeDeviceOptions = value;
            }
        }

        [XmlIgnore]
        protected bool CpeDeviceOptionsSpecified { get; set; }

        protected List<string> _protocolChoice = new List<string>();

        [XmlElement(ElementName = "protocolChoice", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:26513")]
        [MinLength(1)]
        [MaxLength(20)]
        public List<string> ProtocolChoice
        {
            get => _protocolChoice;
            set
            {
                ProtocolChoiceSpecified = true;
                _protocolChoice = value;
            }
        }

        [XmlIgnore]
        protected bool ProtocolChoiceSpecified { get; set; }

        protected bool _isIpAddressOptional;

        [XmlElement(ElementName = "isIpAddressOptional", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:26513")]
        public bool IsIpAddressOptional
        {
            get => _isIpAddressOptional;
            set
            {
                IsIpAddressOptionalSpecified = true;
                _isIpAddressOptional = value;
            }
        }

        [XmlIgnore]
        protected bool IsIpAddressOptionalSpecified { get; set; }

        protected bool _useDomain;

        [XmlElement(ElementName = "useDomain", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:26513")]
        public bool UseDomain
        {
            get => _useDomain;
            set
            {
                UseDomainSpecified = true;
                _useDomain = value;
            }
        }

        [XmlIgnore]
        protected bool UseDomainSpecified { get; set; }

    }
}
