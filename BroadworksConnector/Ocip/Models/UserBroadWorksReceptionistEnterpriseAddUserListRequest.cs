using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add users to the BroadWorks Receptionist - Enterprise monitored user list.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""44477d346d2631b033071e12af214ac8:97""}]")]
    public class UserBroadWorksReceptionistEnterpriseAddUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"44477d346d2631b033071e12af214ac8:97")]
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

        protected List<string> _monitoredUserId = new List<string>();

        [XmlElement(ElementName = "monitoredUserId", IsNullable = false, Namespace = "")]
        [Group(@"44477d346d2631b033071e12af214ac8:97")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> MonitoredUserId
        {
            get => _monitoredUserId;
            set
            {
                MonitoredUserIdSpecified = true;
                _monitoredUserId = value;
            }
        }

        [XmlIgnore]
        protected bool MonitoredUserIdSpecified { get; set; }

    }
}
