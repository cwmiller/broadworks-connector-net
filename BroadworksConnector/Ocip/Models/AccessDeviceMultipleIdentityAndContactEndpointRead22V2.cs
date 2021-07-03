using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Access device end point that can have multiple contacts.
    /// The endpoint is identified by its linePort (public Identity) and possibly a private Identity.
    /// Port numbers are only used by devices with static line ordering.
    /// The following elements are only used in XS data mode and not returned in AS data mode:
    /// privateIdentity
    /// The following elements are only used in AS data mode and a value false is returned in the XS mode:
    /// supportVisualDeviceManagement
    /// useHotline
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// hotlineContact
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:450""}]")]
    public class AccessDeviceMultipleIdentityAndContactEndpointRead22V2
    {

        private BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:450")]
        public BroadWorksConnector.Ocip.Models.AccessDevice AccessDevice
        {
            get => _accessDevice;
            set
            {
                AccessDeviceSpecified = true;
                _accessDevice = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceSpecified { get; set; }

        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:450")]
        [MinLength(1)]
        [MaxLength(161)]
        public string LinePort
        {
            get => _linePort;
            set
            {
                LinePortSpecified = true;
                _linePort = value;
            }
        }

        [XmlIgnore]
        protected bool LinePortSpecified { get; set; }

        private string _privateIdentity;

        [XmlElement(ElementName = "privateIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:450")]
        [MinLength(1)]
        [MaxLength(161)]
        public string PrivateIdentity
        {
            get => _privateIdentity;
            set
            {
                PrivateIdentitySpecified = true;
                _privateIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool PrivateIdentitySpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SIPContactInfo> _contact = new List<BroadWorksConnector.Ocip.Models.SIPContactInfo>();

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:450")]
        public List<BroadWorksConnector.Ocip.Models.SIPContactInfo> Contact
        {
            get => _contact;
            set
            {
                ContactSpecified = true;
                _contact = value;
            }
        }

        [XmlIgnore]
        protected bool ContactSpecified { get; set; }

        private bool _staticRegistrationCapable;

        [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:450")]
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

        private bool _useDomain;

        [XmlElement(ElementName = "useDomain", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:450")]
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

        private int _portNumber;

        [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:450")]
        [MinInclusive(1)]
        [MaxInclusive(1024)]
        public int PortNumber
        {
            get => _portNumber;
            set
            {
                PortNumberSpecified = true;
                _portNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PortNumberSpecified { get; set; }

        private bool _supportVisualDeviceManagement;

        [XmlElement(ElementName = "supportVisualDeviceManagement", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:450")]
        public bool SupportVisualDeviceManagement
        {
            get => _supportVisualDeviceManagement;
            set
            {
                SupportVisualDeviceManagementSpecified = true;
                _supportVisualDeviceManagement = value;
            }
        }

        [XmlIgnore]
        protected bool SupportVisualDeviceManagementSpecified { get; set; }

        private bool _useHotline;

        [XmlElement(ElementName = "useHotline", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:450")]
        public bool UseHotline
        {
            get => _useHotline;
            set
            {
                UseHotlineSpecified = true;
                _useHotline = value;
            }
        }

        [XmlIgnore]
        protected bool UseHotlineSpecified { get; set; }

        private string _hotlineContact;

        [XmlElement(ElementName = "hotlineContact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:450")]
        [MinLength(1)]
        [MaxLength(161)]
        public string HotlineContact
        {
            get => _hotlineContact;
            set
            {
                HotlineContactSpecified = true;
                _hotlineContact = value;
            }
        }

        [XmlIgnore]
        protected bool HotlineContactSpecified { get; set; }

    }
}
