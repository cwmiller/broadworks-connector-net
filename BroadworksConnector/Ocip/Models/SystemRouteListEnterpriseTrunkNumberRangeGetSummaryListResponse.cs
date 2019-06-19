using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest.
    /// The column headings are "Number Range Start", "Number Range End", "Service Provider Id", "Is Enterprise", "User Id", "Enterprise Trunk", "Is Active", "Reseller Id".
    /// <see cref="SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3f28429898a57a7f7846d3877b22df9f:759""}]")]
    public class SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _numberRangeSummaryTable;

        [XmlElement(ElementName = "numberRangeSummaryTable", IsNullable = false, Namespace = "")]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:759")]
        public BroadWorksConnector.Ocip.Models.C.OCITable NumberRangeSummaryTable
        {
            get => _numberRangeSummaryTable;
            set
            {
                NumberRangeSummaryTableSpecified = true;
                _numberRangeSummaryTable = value;
            }
        }

        [XmlIgnore]
        public bool NumberRangeSummaryTableSpecified { get; set; }

    }
}
