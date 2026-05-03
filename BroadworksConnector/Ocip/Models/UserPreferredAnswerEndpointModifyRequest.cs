using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to configure a user's Preferred Answer Endpoint for Auto-Answer and Forced Answer.
    /// Setting preferredAnswerEndpoint to nil will clear the user's configured Preferred Answer Endpoint.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3495""}]")]
    public class UserPreferredAnswerEndpointModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3495")]
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

        protected BroadWorksConnector.Ocip.Models.AccessDeviceEndpointKey _preferredAnswerEndpoint;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "preferredAnswerEndpoint", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3495")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointKey PreferredAnswerEndpoint
        {
            get => _preferredAnswerEndpoint;
            set
            {
                PreferredAnswerEndpointSpecified = true;
                _preferredAnswerEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool PreferredAnswerEndpointSpecified { get; set; }

    }
}
