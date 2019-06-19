using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPushNotificationGetRequest.
    /// <see cref="UserPushNotificationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3391""}]")]
    public class UserPushNotificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _sendPushNotificationForClickToDial;

        [XmlElement(ElementName = "sendPushNotificationForClickToDial", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3391")]
        public bool SendPushNotificationForClickToDial
        {
            get => _sendPushNotificationForClickToDial;
            set
            {
                SendPushNotificationForClickToDialSpecified = true;
                _sendPushNotificationForClickToDial = value;
            }
        }

        [XmlIgnore]
        public bool SendPushNotificationForClickToDialSpecified { get; set; }

    }
}
