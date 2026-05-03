using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with MWI Delivery to Mobile Endpoint service.
    /// The response is either a UserMWIDeliveryToMobileEndpointGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserMWIDeliveryToMobileEndpointGetRequest23 in AS data mode.
    /// <see cref="UserMWIDeliveryToMobileEndpointGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserMWIDeliveryToMobileEndpointGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:21146""}]")]
    public class UserMWIDeliveryToMobileEndpointGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserMWIDeliveryToMobileEndpointGetResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:21146")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

    }
}
