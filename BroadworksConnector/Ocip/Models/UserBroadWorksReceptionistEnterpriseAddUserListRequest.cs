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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb12998f4f9e45cedde01f08569f4c7c:97""}]")]
    public class UserBroadWorksReceptionistEnterpriseAddUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:97")]
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

        private List<string> _monitoredUserId = new List<string>();

        [XmlElement(ElementName = "monitoredUserId", IsNullable = false, Namespace = "")]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:97")]
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
