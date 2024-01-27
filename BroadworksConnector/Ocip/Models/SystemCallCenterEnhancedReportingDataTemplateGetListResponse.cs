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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:6029""}]")]
    public class SystemCallCenterEnhancedReportingDataTemplateGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInfo> _info = new List<BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInfo>();

        [XmlElement(ElementName = "info", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6029")]
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
        protected bool InfoSpecified { get; set; }

    }
}
