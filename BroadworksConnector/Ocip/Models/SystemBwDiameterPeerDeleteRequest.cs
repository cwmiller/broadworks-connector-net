using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Remove a Diameter peer.  A peer cannot be removed if is referenced by a Realm Routing Table entry.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2377""}]")]
    public class SystemBwDiameterPeerDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance _instance;

        [XmlElement(ElementName = "instance", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2377")]
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
        public bool InstanceSpecified { get; set; }

        private string _identity;

        [XmlElement(ElementName = "identity", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2377")]
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
        public bool IdentitySpecified { get; set; }

    }
}
