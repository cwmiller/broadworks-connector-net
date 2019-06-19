using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest.
    /// The response contains a table with columns: "Number Prefix", "Group Id", "User Id",
    /// "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension", "Department",
    /// "Email Address", "Enterprise Trunk" and "Is Active".
    /// The "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number",
    /// "Extension", "Department" and "Email Address" columns contains the corresponding attributes of the user possessing the number range.
    /// The "Enterprise Trunk" column contains the enterprise trunk the user possessing the number range belongs to.
    /// The "Is Active" column indicates if the number range has been activated.
    /// <see cref="EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3f28429898a57a7f7846d3877b22df9f:123""}]")]
    public class EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _prefixSummaryTable;

        [XmlElement(ElementName = "prefixSummaryTable", IsNullable = false, Namespace = "")]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:123")]
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
        public bool PrefixSummaryTableSpecified { get; set; }

    }
}
