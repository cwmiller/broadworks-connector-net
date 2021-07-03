using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest.
    /// The response contains a table with columns: "Number Range Start", "Number Range End", "Group Id", "User Id",
    /// "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension", "Department",
    /// "Email Address", "Enterprise Trunk", "Is Active" and "Extension Length".
    /// The "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number",
    /// "Extension", "Department" and "Email Address" columns contains the corresponding attributes of the user possessing the number range.
    /// The "Enterprise Trunk" column contains the enterprise trunk the user possessing the number range belongs to.
    /// The "Is Active" column indicates if the number range has been activated.
    /// The “Extension Length” column indicates the length of the extension for the enterpris trunk number range.
    /// <see cref="EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3f28429898a57a7f7846d3877b22df9f:200""}]")]
    public class EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _numberRangeSummaryTable;

        [XmlElement(ElementName = "numberRangeSummaryTable", IsNullable = false, Namespace = "")]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:200")]
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
