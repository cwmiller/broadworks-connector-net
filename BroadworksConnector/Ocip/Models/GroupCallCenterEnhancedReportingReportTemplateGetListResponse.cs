using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterEnhancedReportingReportTemplateGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _reportTemplateTable;

        [XmlElement(ElementName = "reportTemplateTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable ReportTemplateTable
        {
            get => _reportTemplateTable;
            set
            {
                ReportTemplateTableSpecified = true;
                _reportTemplateTable = value;
            }
        }

        [XmlIgnore]
        public bool ReportTemplateTableSpecified { get; set; }
    }
}
