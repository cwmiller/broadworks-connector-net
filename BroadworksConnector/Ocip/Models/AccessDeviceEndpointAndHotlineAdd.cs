using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Access device end point used in the context of add.
    /// Port numbers are only used by devices with static line ordering.
    /// The following element is only used in AS data mode and ignored in XS data mode:
    /// pathHeader
    /// useHotline, use value false in XS data mode
    /// hotlineContact
    /// 
    /// The following element is only used in XS data mode and ignored in AS data mode:
    /// privateIdentity
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:67""}]")]
    public class AccessDeviceEndpointAndHotlineAdd
    {

        protected BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:67")]
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
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:67")]
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

        [XmlElement(ElementName = "privateIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:67")]
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

        protected string _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:67")]
        [MinLength(1)]
        [MaxLength(1020)]
        public string Contact
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

        protected string _pathHeader;

        [XmlElement(ElementName = "pathHeader", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:67")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string PathHeader
        {
            get => _pathHeader;
            set
            {
                PathHeaderSpecified = true;
                _pathHeader = value;
            }
        }

        [XmlIgnore]
        protected bool PathHeaderSpecified { get; set; }

        protected int _portNumber;

        [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:67")]
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
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:67")]
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

        [XmlElement(ElementName = "hotlineContact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:67")]
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
