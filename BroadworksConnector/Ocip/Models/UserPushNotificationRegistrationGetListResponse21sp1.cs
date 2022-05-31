using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPushNotificationRegistrationGetListRequest21sp1.
    /// 
    /// A registration has more than one row in the response when the registration includes more than one token
    /// and/or one or more event.  There can be one more tokens per registration ID and there can be one or more
    /// events per token.
    /// 
    /// Registration Date uses the format "yyyy-MM-dd'T'HH:mm:ss.SSSZ" in the time zone of the requested user.
    /// Example: 2010-10-01T09:30:00:000-0400.
    /// <see cref="UserPushNotificationRegistrationGetListRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3506""}]")]
    public class UserPushNotificationRegistrationGetListResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3506")]
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

        protected List<BroadWorksConnector.Ocip.Models.PushNotificationRegistrationData> _pushNotificationRegistrationData = new List<BroadWorksConnector.Ocip.Models.PushNotificationRegistrationData>();

        [XmlElement(ElementName = "pushNotificationRegistrationData", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3506")]
        public List<BroadWorksConnector.Ocip.Models.PushNotificationRegistrationData> PushNotificationRegistrationData
        {
            get => _pushNotificationRegistrationData;
            set
            {
                PushNotificationRegistrationDataSpecified = true;
                _pushNotificationRegistrationData = value;
            }
        }

        [XmlIgnore]
        protected bool PushNotificationRegistrationDataSpecified { get; set; }

    }
}
