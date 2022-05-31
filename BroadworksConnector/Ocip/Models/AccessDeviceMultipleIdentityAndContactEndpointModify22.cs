using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Access device end point used in the context of modify that can have more than one contact defined.
    /// The endpoint is identified by its linePort (public Identity) and possibly a private Identity.
    /// Only Static Registration capable devices may have more than one contact defined.
    /// Port numbers are only used by devices with static line ordering.
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// privateIdentity
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// useHotline
    /// hotlineContact
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:376""}]")]
    public class AccessDeviceMultipleIdentityAndContactEndpointModify22
    {

        protected BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:376")]
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

        protected string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:376")]
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

        protected string _privateIdentity;

        [XmlElement(ElementName = "privateIdentity", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:376")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementContactList22 _contactList;

        [XmlElement(ElementName = "contactList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:376")]
        public BroadWorksConnector.Ocip.Models.ReplacementContactList22 ContactList
        {
            get => _contactList;
            set
            {
                ContactListSpecified = true;
                _contactList = value;
            }
        }

        [XmlIgnore]
        protected bool ContactListSpecified { get; set; }

        protected int _portNumber;

        [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:376")]
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

        protected bool _useHotline;

        [XmlElement(ElementName = "useHotline", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:376")]
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

        protected string _hotlineContact;

        [XmlElement(ElementName = "hotlineContact", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:376")]
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
