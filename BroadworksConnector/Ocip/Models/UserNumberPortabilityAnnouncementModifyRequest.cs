using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Number Portability Announcement attributes for the user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6abb48a2d0672804f15670b4afa7ec02:75""}]")]
    public class UserNumberPortabilityAnnouncementModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"6abb48a2d0672804f15670b4afa7ec02:75")]
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

        protected bool _enable;

        [XmlElement(ElementName = "enable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6abb48a2d0672804f15670b4afa7ec02:75")]
        public bool Enable
        {
            get => _enable;
            set
            {
                EnableSpecified = true;
                _enable = value;
            }
        }

        [XmlIgnore]
        protected bool EnableSpecified { get; set; }

    }
}
