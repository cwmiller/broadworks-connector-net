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
    /// 
    /// Replaced by: UserPushNotificationRegistrationGetListRequest21sp1
    /// <see cref="UserPushNotificationRegistrationGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserPushNotificationRegistrationGetListRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:14154"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:14155""}]}]")]
    public class UserPushNotificationRegistrationGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _registrationId;

        [XmlElement(ElementName = "registrationId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14155")]
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
        protected bool RegistrationIdSpecified { get; set; }

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14155")]
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
