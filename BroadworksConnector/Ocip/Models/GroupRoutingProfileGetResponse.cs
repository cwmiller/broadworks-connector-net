using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupRoutingProfileGetRequest.
    /// <see cref="GroupRoutingProfileGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:7023""}]")]
    public class GroupRoutingProfileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _routingProfile;

        [XmlElement(ElementName = "routingProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:7023")]
        [MinLength(4)]
        [MaxLength(12)]
        public string RoutingProfile
        {
            get => _routingProfile;
            set
            {
                RoutingProfileSpecified = true;
                _routingProfile = value;
            }
        }

        [XmlIgnore]
        protected bool RoutingProfileSpecified { get; set; }

    }
}
