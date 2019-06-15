using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of call center reporting data template query filter values that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterReportDataTemplateQueryFilterValueReplacementList 
    {

        
        private List<string> _filterValue;

        [XmlElement(ElementName = "filterValue", IsNullable = false, Namespace = "")]
        public List<string> FilterValue {
            get => _filterValue;
            set {
                FilterValueSpecified = true;
                _filterValue = value;
            }
        }

        [XmlIgnore]
        public bool FilterValueSpecified { get; set; }
        
    }
}
