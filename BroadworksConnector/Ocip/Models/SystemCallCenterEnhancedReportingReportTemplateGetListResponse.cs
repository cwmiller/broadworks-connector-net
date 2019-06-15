using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterEnhancedReportingReportTemplateGetListRequest.
    /// Contains a table with column headings: "Name", "Description", "Is Custom", "Type" and "Enabled"
        /// <see cref="SystemCallCenterEnhancedReportingReportTemplateGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallCenterEnhancedReportingReportTemplateGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _reportTemplateTable;

        [XmlElement(ElementName = "reportTemplateTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ReportTemplateTable {
            get => _reportTemplateTable;
            set {
                ReportTemplateTableSpecified = true;
                _reportTemplateTable = value;
            }
        }

        [XmlIgnore]
        public bool ReportTemplateTableSpecified { get; set; }
        
    }
}
