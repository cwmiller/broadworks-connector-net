using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a static entry in the Diameter Peer Table.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20674""}]")]
    public class SystemBwDiameterPeerAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance _instance;

        [XmlElement(ElementName = "instance", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20674")]
        public BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance Instance
        {
            get => _instance;
            set
            {
                InstanceSpecified = true;
                _instance = value;
            }
        }

        [XmlIgnore]
        protected bool InstanceSpecified { get; set; }

        private string _identity;

        [XmlElement(ElementName = "identity", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20674")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Identity
        {
            get => _identity;
            set
            {
                IdentitySpecified = true;
                _identity = value;
            }
        }

        [XmlIgnore]
        protected bool IdentitySpecified { get; set; }

        private string _ipAddress;

        [XmlElement(ElementName = "ipAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20674")]
        [MinLength(1)]
        [MaxLength(39)]
        public string IpAddress
        {
            get => _ipAddress;
            set
            {
                IpAddressSpecified = true;
                _ipAddress = value;
            }
        }

        [XmlIgnore]
        protected bool IpAddressSpecified { get; set; }

        private int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20674")]
        [MinInclusive(1025)]
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

        private bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20674")]
        public bool Enabled
        {
            get => _enabled;
            set
            {
                EnabledSpecified = true;
                _enabled = value;
            }
        }

        [XmlIgnore]
        protected bool EnabledSpecified { get; set; }

    }
}
