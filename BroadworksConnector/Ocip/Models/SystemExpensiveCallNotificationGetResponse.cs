using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemExpensiveCallNotificationGetRequest.
    /// <see cref="SystemExpensiveCallNotificationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9811""}]")]
    public class SystemExpensiveCallNotificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enablePostAnnouncementDelayTimer;

        [XmlElement(ElementName = "enablePostAnnouncementDelayTimer", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9811")]
        public bool EnablePostAnnouncementDelayTimer
        {
            get => _enablePostAnnouncementDelayTimer;
            set
            {
                EnablePostAnnouncementDelayTimerSpecified = true;
                _enablePostAnnouncementDelayTimer = value;
            }
        }

        [XmlIgnore]
        protected bool EnablePostAnnouncementDelayTimerSpecified { get; set; }

        protected int _postAnnouncementDelaySeconds;

        [XmlElement(ElementName = "postAnnouncementDelaySeconds", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9811")]
        [MinInclusive(0)]
        [MaxInclusive(20)]
        public int PostAnnouncementDelaySeconds
        {
            get => _postAnnouncementDelaySeconds;
            set
            {
                PostAnnouncementDelaySecondsSpecified = true;
                _postAnnouncementDelaySeconds = value;
            }
        }

        [XmlIgnore]
        protected bool PostAnnouncementDelaySecondsSpecified { get; set; }

    }
}
