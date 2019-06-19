using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseCallCenterEnhancedReportingReportTemplateGetListRequest.
    /// Contains a table with column headings: "Name", "Description", "Type" and "Enabled".
    /// <see cref="EnterpriseCallCenterEnhancedReportingReportTemplateGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1407""}]")]
    public class EnterpriseCallCenterEnhancedReportingReportTemplateGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _reportTemplateTable;

        [XmlElement(ElementName = "reportTemplateTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1407")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ReportTemplateTable
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
