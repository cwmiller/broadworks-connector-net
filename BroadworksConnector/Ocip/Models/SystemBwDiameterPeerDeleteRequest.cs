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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2780""}]")]
    public class SystemBwDiameterPeerDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance _instance;

        [XmlElement(ElementName = "instance", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2780")]
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

        protected string _identity;

        [XmlElement(ElementName = "identity", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2780")]
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

    }
}
