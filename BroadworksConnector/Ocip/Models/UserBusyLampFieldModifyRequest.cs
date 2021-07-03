using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the settings for the busy lamp field service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4faeca417998d23ce2ff6b0b43212aa6:203""}]")]
    public class UserBusyLampFieldModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:203")]
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

        private string _listURI;

        [XmlElement(ElementName = "listURI", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:203")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ListURI
        {
            get => _listURI;
            set
            {
                ListURISpecified = true;
                _listURI = value;
            }
        }

        [XmlIgnore]
        protected bool ListURISpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _monitoredUserIdList;

        [XmlElement(ElementName = "monitoredUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:203")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList MonitoredUserIdList
        {
            get => _monitoredUserIdList;
            set
            {
                MonitoredUserIdListSpecified = true;
                _monitoredUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool MonitoredUserIdListSpecified { get; set; }

        private bool _enableCallParkNotification;

        [XmlElement(ElementName = "enableCallParkNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:203")]
        public bool EnableCallParkNotification
        {
            get => _enableCallParkNotification;
            set
            {
                EnableCallParkNotificationSpecified = true;
                _enableCallParkNotification = value;
            }
        }

        [XmlIgnore]
        protected bool EnableCallParkNotificationSpecified { get; set; }

    }
}
