using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the call center reporting scheduled report in the system that uses a
    /// given system level report template.
    /// The response is either a SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6381""}]")]
    public class SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse>
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6381")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

    }
}
