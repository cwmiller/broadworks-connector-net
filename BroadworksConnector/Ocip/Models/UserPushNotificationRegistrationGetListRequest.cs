using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a table containing all of the push notification registrations for a user by
    /// either registration id or user id.
    /// The response is either UserPushNotificationRegistrationGetListResponse or ErrorResponse.
    /// <see cref="UserPushNotificationRegistrationGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3441"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3442""}]}]")]
    public class UserPushNotificationRegistrationGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _registrationId;

        [XmlElement(ElementName = "registrationId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3442")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string RegistrationId
        {
            get => _registrationId;
            set
            {
                RegistrationIdSpecified = true;
                _registrationId = value;
            }
        }

        [XmlIgnore]
        public bool RegistrationIdSpecified { get; set; }

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3442")]
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
        public bool UserIdSpecified { get; set; }

    }
}
