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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3429""}]")]
    public class UserPushNotificationGetResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _sendPushNotificationForClickToDial;

        [XmlElement(ElementName = "sendPushNotificationForClickToDial", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3429")]
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

        private bool _sendPushNotificationForGroupPaging;

        [XmlElement(ElementName = "sendPushNotificationForGroupPaging", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3429")]
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
