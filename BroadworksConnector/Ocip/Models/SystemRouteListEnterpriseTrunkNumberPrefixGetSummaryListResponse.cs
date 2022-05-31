using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest.
    /// The column headings are "Number Prefix", "Service Provider Id", "Is Enterprise", "User Id", "Enterprise Trunk",
    /// "Is Active", "Reseller Id" ", “Extension Range Start” and “Extension Range End”.
    /// <see cref="SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3f28429898a57a7f7846d3877b22df9f:767""}]")]
    public class SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _prefixSummaryTable;

        [XmlElement(ElementName = "prefixSummaryTable", IsNullable = false, Namespace = "")]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:767")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PrefixSummaryTable
        {
            get => _prefixSummaryTable;
            set
            {
                PrefixSummaryTableSpecified = true;
                _prefixSummaryTable = value;
            }
        }

        [XmlIgnore]
        protected bool PrefixSummaryTableSpecified { get; set; }

    }
}
