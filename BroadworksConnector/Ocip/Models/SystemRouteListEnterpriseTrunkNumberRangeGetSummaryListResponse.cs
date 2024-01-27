using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest.
    /// The column headings are "Number Range Start", "Number Range End", "Service Provider Id", "Is Enterprise", "User Id", "Enterprise Trunk",
    /// "Is Active", "Reseller Id" and "Extension Length".
    /// <see cref="SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""500f9871ed90b8ab3fbd262883ab503b:803""}]")]
    public class SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _numberRangeSummaryTable;

        [XmlElement(ElementName = "numberRangeSummaryTable", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:803")]
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
        protected bool NumberRangeSummaryTableSpecified { get; set; }

    }
}
