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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:7285""}]")]
    public class GroupRoutingProfileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _routingProfile;

        [XmlElement(ElementName = "routingProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7285")]
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
