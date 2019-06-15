using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserPersonalAssistantCallToNumberGetListRequest.
    /// Contains a list of assigned Call to Numbers".
        /// <see cref="UserPersonalAssistantCallToNumberGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPersonalAssistantCallToNumberGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.CallToNumber> _callToNumber;

        [XmlElement(ElementName = "callToNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CallToNumber> CallToNumber {
            get => _callToNumber;
            set {
                CallToNumberSpecified = true;
                _callToNumber = value;
            }
        }

        [XmlIgnore]
        public bool CallToNumberSpecified { get; set; }
        
    }
}
