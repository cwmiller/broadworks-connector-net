using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the Call Me Now permissions for Pinhole digit patterns for a user.
    /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse or an ErrorResponse.
    /// <see cref="UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:1382""}]")]
    public class UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1382")]
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
