using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterReportDataTemplateQueryFilterValueReplacementList
    {
        private List<string> _filterValue;

        [XmlElement(ElementName = "filterValue", IsNullable = false, Namespace = "")]
        public List<string> FilterValue
        {
            get => _filterValue;
            set
            {
                FilterValueSpecified = true;
                _filterValue = value;
            }
        }

        [XmlIgnore]
        public bool FilterValueSpecified { get; set; }
    }
}
