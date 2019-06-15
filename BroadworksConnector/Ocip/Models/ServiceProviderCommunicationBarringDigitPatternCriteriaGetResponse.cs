using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderCommunicationBarringDigitPatternCriteriaGetRequest.
    /// The response contains the Digit Pattern Criteria information.
        /// <see cref="ServiceProviderCommunicationBarringDigitPatternCriteriaGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderCommunicationBarringDigitPatternCriteriaGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
    }
}
