using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderRouteListEnterpriseTrunkPrefixGetSummaryListRequest.
    /// The column headings are "Number Prefix", "Group Id" ","Is Active", “Extension Range Start” and “Extension Range End”.
    /// <see cref="ServiceProviderRouteListEnterpriseTrunkPrefixGetSummaryListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""500f9871ed90b8ab3fbd262883ab503b:559""}]")]
    public class ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _prefixSummaryTable;

        [XmlElement(ElementName = "prefixSummaryTable", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:559")]
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
