using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPushNotificationGetRequest.
    /// 
    /// Replaced by: UserPushNotificationResponse24
    /// <see cref="UserPushNotificationGetRequest"/>
    /// <see cref="UserPushNotificationResponse24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:46398""}]")]
    public class UserPushNotificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _sendPushNotificationForClickToDial;

        [XmlElement(ElementName = "sendPushNotificationForClickToDial", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:46398")]
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
        protected bool SendPushNotificationForClickToDialSpecified { get; set; }

    }
}
