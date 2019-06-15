using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserNumberPortabilityAnnouncementGetRequest.
    /// The response contains the user Number Portability attributes.
        /// <see cref="UserNumberPortabilityAnnouncementGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserNumberPortabilityAnnouncementGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _enable;

        [XmlElement(ElementName = "enable", IsNullable = false, Namespace = "")]
        public bool Enable {
            get => _enable;
            set {
                EnableSpecified = true;
                _enable = value;
            }
        }

        [XmlIgnore]
        public bool EnableSpecified { get; set; }
        
    }
}
