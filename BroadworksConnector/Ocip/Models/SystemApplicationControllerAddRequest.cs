using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add an application controller, which is a server where remote
    /// application resides and controls the Route Point.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2360""}]")]
    public class SystemApplicationControllerAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2360")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        protected string _subscriberId;

        [XmlElement(ElementName = "subscriberId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2360")]
        [MinLength(1)]
        [MaxLength(161)]
        public string SubscriberId
        {
            get => _subscriberId;
            set
            {
                SubscriberIdSpecified = true;
                _subscriberId = value;
            }
        }

        [XmlIgnore]
        protected bool SubscriberIdSpecified { get; set; }

        protected string _channelSetId;

        [XmlElement(ElementName = "channelSetId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2360")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ChannelSetId
        {
            get => _channelSetId;
            set
            {
                ChannelSetIdSpecified = true;
                _channelSetId = value;
            }
        }

        [XmlIgnore]
        protected bool ChannelSetIdSpecified { get; set; }

    }
}
