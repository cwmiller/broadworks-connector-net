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
    /// <see cref="UserMWIDeliveryToMobileEndpointGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""958b78cc2a785d78259c1e8a474eb40d:352""}]")]
    public class UserMWIDeliveryToMobileEndpointGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserMWIDeliveryToMobileEndpointGetResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:352")]
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
