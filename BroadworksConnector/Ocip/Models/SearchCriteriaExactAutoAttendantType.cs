using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular auto-attendant type.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactAutoAttendantType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private BroadWorksConnector.Ocip.Models.AutoAttendantType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantType Type {
            get => _type;
            set {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        public bool TypeSpecified { get; set; }
        
    }
}
