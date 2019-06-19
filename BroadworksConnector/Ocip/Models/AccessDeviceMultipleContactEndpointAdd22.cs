using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Access device end point used in the context of add that can have more than one contact defined.
    /// Only Static Registration capabable devices may have more than one contact defined.
    /// Port numbers are only used by devices with static line ordering.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:171""}]")]
    public class AccessDeviceMultipleContactEndpointAdd22
    {

        private BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:171")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:171")]
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

        private List<BroadWorksConnector.Ocip.Models.SIPContactInfo> _contact = new List<BroadWorksConnector.Ocip.Models.SIPContactInfo>();

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:171")]
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
        public bool ContactSpecified { get; set; }

        private int _portNumber;

        [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:171")]
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
        public bool PortNumberSpecified { get; set; }

    }
}
