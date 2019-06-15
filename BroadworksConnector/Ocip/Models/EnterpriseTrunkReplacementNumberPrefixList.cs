using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of prefixes that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseTrunkReplacementNumberPrefixList 
    {

        
        private List<string> _numberPrefix;

        [XmlElement(ElementName = "numberPrefix", IsNullable = false, Namespace = "")]
        public List<string> NumberPrefix {
            get => _numberPrefix;
            set {
                NumberPrefixSpecified = true;
                _numberPrefix = value;
            }
        }

        [XmlIgnore]
        public bool NumberPrefixSpecified { get; set; }
        
    }
}
