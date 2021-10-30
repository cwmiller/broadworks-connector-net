using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to remove a push notification registration.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3464""}]")]
    public class UserPushNotificationRegistrationDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _registrationId;

        [XmlElement(ElementName = "registrationId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3464")]
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

    }
}
