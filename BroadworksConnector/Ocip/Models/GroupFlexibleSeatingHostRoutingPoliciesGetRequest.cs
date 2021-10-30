using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a flexible seating host’s routing policies
    /// The response is either a GroupFlexibleSeatingHostRoutingPoliciesGetResponse or an ErrorResponse.
    /// <see cref="GroupFlexibleSeatingHostRoutingPoliciesGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""43afb2158d313a1d1a148124d7caba1e:314""}]")]
    public class GroupFlexibleSeatingHostRoutingPoliciesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupFlexibleSeatingHostRoutingPoliciesGetResponse>
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:314")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

    }
}
