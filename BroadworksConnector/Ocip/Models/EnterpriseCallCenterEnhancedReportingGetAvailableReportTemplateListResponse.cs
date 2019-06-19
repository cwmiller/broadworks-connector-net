using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListRequest.
    /// Contains a table with column headings: "Name", "Description" and "Level", "Is Agent Required",
    /// "Is Call Center Required", "Is Call Center Dnis Required", "Is Real Time Report", "Is Sampling Period Required",
    /// "Call Completion Threshold Parameter", "Short Duration Threshold Parameter",
    /// "Service Level Threshold Parameter", "Service Level Inclusions Parameter", "Service Level Objective Threshold Parameter",
    /// "Abandoned Call Threshold Parameter", "Service Level Threshold Parameter Number",
    /// "Abandoned Call Threshold Parameter Number" and "Scope".
    /// The possible values for "Level" are "System" and "Enterprise".
    /// The possible values for "Is Agent Required", "Is Call Center Required", "Is Call Center Dnis Required", "Is Real Time Report" and
    /// "Is Sampling Period Required" are "true" and "false".
    /// The possible values for "Call Completion Threshold Parameter", "Short Duration Threshold Parameter",
    /// "Service Level Threshold Parameter", "Service Level Inclusions Parameter", "Service Level Objective Threshold Parameter"
    /// and "Abandoned Call Threshold Parameter" are "Required", "Hidden" and "Does Not Apply".
    /// The possible values for "Scope" are "Supervisor Only" and "Supervisor and Agent".
    /// <see cref="EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1277""}]")]
    public class EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _reportTemplateTable;

        [XmlElement(ElementName = "reportTemplateTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1277")]
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
