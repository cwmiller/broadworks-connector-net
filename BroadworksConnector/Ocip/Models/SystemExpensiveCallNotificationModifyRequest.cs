using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the expensive call notification service parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9946""}]")]
    public class SystemExpensiveCallNotificationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enablePostAnnouncementDelayTimer;

        [XmlElement(ElementName = "enablePostAnnouncementDelayTimer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9946")]
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
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9946")]
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
