using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPushNotificationGetRequest24.
    /// <see cref="UserPushNotificationGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3435""}]")]
    public class UserPushNotificationGetResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _sendPushNotificationForClickToDial;

        [XmlElement(ElementName = "sendPushNotificationForClickToDial", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3435")]
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

        protected bool _sendPushNotificationForGroupPaging;

        [XmlElement(ElementName = "sendPushNotificationForGroupPaging", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3435")]
        public bool SendPushNotificationForGroupPaging
        {
            get => _sendPushNotificationForGroupPaging;
            set
            {
                SendPushNotificationForGroupPagingSpecified = true;
                _sendPushNotificationForGroupPaging = value;
            }
        }

        [XmlIgnore]
        protected bool SendPushNotificationForGroupPagingSpecified { get; set; }

    }
}
