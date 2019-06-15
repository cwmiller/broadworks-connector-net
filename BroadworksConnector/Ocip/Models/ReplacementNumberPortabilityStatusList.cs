using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Number Portability Query Statuses that replaces a previously
    /// configured list. By convention, an element of this type may be set
    /// to nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementNumberPortabilityStatusList 
    {

        
        private List<string> _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        public List<string> Status {
            get => _status;
            set {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        public bool StatusSpecified { get; set; }
        
    }
}
