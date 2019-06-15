using System;
using System.Xml.Serialization;
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
     
    public class SystemApplicationControllerAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
        private string _subscriberId;

        [XmlElement(ElementName = "subscriberId", IsNullable = false, Namespace = "")]
        public string SubscriberId {
            get => _subscriberId;
            set {
                SubscriberIdSpecified = true;
                _subscriberId = value;
            }
        }

        [XmlIgnore]
        public bool SubscriberIdSpecified { get; set; }
        
        private string _channelSetId;

        [XmlElement(ElementName = "channelSetId", IsNullable = false, Namespace = "")]
        public string ChannelSetId {
            get => _channelSetId;
            set {
                ChannelSetIdSpecified = true;
                _channelSetId = value;
            }
        }

        [XmlIgnore]
        public bool ChannelSetIdSpecified { get; set; }
        
    }
}
