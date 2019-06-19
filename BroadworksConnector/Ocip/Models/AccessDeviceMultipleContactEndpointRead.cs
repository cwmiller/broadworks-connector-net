using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Access device end point that can have multiple contacts.
    /// 
    /// Replaced by AccessDeviceMultipleContactEndpointRead19.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:44242""}]")]
    public class AccessDeviceMultipleContactEndpointRead
    {

        private BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44242")]
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
        public bool AccessDeviceSpecified { get; set; }

        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44242")]
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
        public bool LinePortSpecified { get; set; }

        private List<string> _contact = new List<string>();

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44242")]
        [MinLength(1)]
        [MaxLength(1020)]
        public List<string> Contact
        {
            get => _contact;
            set
            {
                ContactSpecified = true;
                _contact = value;
            }
        }

        [XmlIgnore]
        public bool ContactSpecified { get; set; }

        private bool _staticRegistrationCapable;

        [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44242")]
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
        public bool StaticRegistrationCapableSpecified { get; set; }

        private bool _useDomain;

        [XmlElement(ElementName = "useDomain", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44242")]
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
        public bool UseDomainSpecified { get; set; }

    }
}
