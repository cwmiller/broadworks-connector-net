using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterEnhancedReportingDataTemplateGetListRequest.
    /// <see cref="SystemCallCenterEnhancedReportingDataTemplateGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6071""}]")]
    public class SystemCallCenterEnhancedReportingDataTemplateGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInfo> _info = new List<BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInfo>();

        [XmlElement(ElementName = "info", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6071")]
        public List<BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInfo> Info
        {
            get => _info;
            set
            {
                InfoSpecified = true;
                _info = value;
            }
        }

        [XmlIgnore]
        public bool InfoSpecified { get; set; }

    }
}
