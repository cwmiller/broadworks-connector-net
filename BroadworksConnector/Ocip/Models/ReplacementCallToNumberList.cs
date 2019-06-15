using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Call to Numbers that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
    /// For the callToNumbers, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementCallToNumberList 
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
