using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderRoutingProfileGetRequest.
    /// <see cref="ServiceProviderRoutingProfileGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4783""}]")]
    public class ServiceProviderRoutingProfileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _routingProfile;

        [XmlElement(ElementName = "routingProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4783")]
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
        public bool RoutingProfileSpecified { get; set; }

    }
}
