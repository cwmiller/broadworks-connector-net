using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Diameter routing peer.  The realm must refer to a Diameter routing realm whose action is relay.  The destinationPeerIdentity must refer to an existing Diameter peer whose mode is active.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2797""}]")]
    public class SystemBwDiameterRoutingPeerAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance _instance;

        [XmlElement(ElementName = "instance", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2797")]
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

        private string _realm;

        [XmlElement(ElementName = "realm", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2797")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Realm
        {
            get => _realm;
            set
            {
                RealmSpecified = true;
                _realm = value;
            }
        }

        [XmlIgnore]
        protected bool RealmSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BwDiameterApplicationId _applicationId;

        [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2797")]
        public BroadWorksConnector.Ocip.Models.BwDiameterApplicationId ApplicationId
        {
            get => _applicationId;
            set
            {
                ApplicationIdSpecified = true;
                _applicationId = value;
            }
        }

        [XmlIgnore]
        protected bool ApplicationIdSpecified { get; set; }

        private string _identity;

        [XmlElement(ElementName = "identity", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2797")]
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

        private int _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2797")]
        [MinInclusive(0)]
        [MaxInclusive(65535)]
        public int Priority
        {
            get => _priority;
            set
            {
                PrioritySpecified = true;
                _priority = value;
            }
        }

        [XmlIgnore]
        protected bool PrioritySpecified { get; set; }

        private int _weight;

        [XmlElement(ElementName = "weight", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2797")]
        [MinInclusive(0)]
        [MaxInclusive(65535)]
        public int Weight
        {
            get => _weight;
            set
            {
                WeightSpecified = true;
                _weight = value;
            }
        }

        [XmlIgnore]
        protected bool WeightSpecified { get; set; }

    }
}
