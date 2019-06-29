using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest.
    /// The response contains a table with columns: "Number Prefix", "User Id",
    /// "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
    /// "Department", "Email Address", "Enterprise Trunk" and "Is Active".
    /// The "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number",
    /// "Extension", "Department" and "Email Address" columns contains the corresponding attributes of the user possessing the number range.
    /// The "Enterprise Trunk" column contains the enterprise trunk the user possessing the number range belongs to.
    /// The "Is Active" column indicates if the number prefix has been activated.
    /// <see cref="GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3f28429898a57a7f7846d3877b22df9f:286""}]")]
    public class GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _numberPrefixSummaryTable;

        [XmlElement(ElementName = "numberPrefixSummaryTable", IsNullable = false, Namespace = "")]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:286")]
        public BroadWorksConnector.Ocip.Models.C.OCITable NumberPrefixSummaryTable
        {
            get => _numberPrefixSummaryTable;
            set
            {
                NumberPrefixSummaryTableSpecified = true;
                _numberPrefixSummaryTable = value;
            }
        }

        [XmlIgnore]
        protected bool NumberPrefixSummaryTableSpecified { get; set; }

    }
}
