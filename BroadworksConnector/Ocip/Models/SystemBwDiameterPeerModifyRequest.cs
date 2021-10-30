using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the attributes of an entry in the Diameter Peer Table.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2776""}]")]
    public class SystemBwDiameterPeerModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance _instance;

        [XmlElement(ElementName = "instance", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2776")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2776")]
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

        [XmlElement(ElementName = "ipAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2776")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2776")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2776")]
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

        private bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2776")]
        public bool Secure
        {
            get => _secure;
            set
            {
                SecureSpecified = true;
                _secure = value;
            }
        }

        [XmlIgnore]
        protected bool SecureSpecified { get; set; }

    }
}
