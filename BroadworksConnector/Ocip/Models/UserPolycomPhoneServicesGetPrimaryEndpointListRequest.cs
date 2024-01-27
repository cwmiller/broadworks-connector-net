using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user's list of device profiles on which the user is the primary user.
    /// The response is either a UserPolycomPhoneServicesGetPrimaryEndpointListResponse or an ErrorResponse.
    /// <see cref="UserPolycomPhoneServicesGetPrimaryEndpointListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ff29a940e42c5c9737f7438c4e6eea9d:100""}]")]
    public class UserPolycomPhoneServicesGetPrimaryEndpointListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserPolycomPhoneServicesGetPrimaryEndpointListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ff29a940e42c5c9737f7438c4e6eea9d:100")]
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
