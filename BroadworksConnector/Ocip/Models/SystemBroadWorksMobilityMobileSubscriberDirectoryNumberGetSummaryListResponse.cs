using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest.
    /// The response contains a table with columns: "Mobile Number", "Mobile Network", "Service Provider Id",
    /// "Is Enterprise", "Group Id", "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", "Phone Number", "Extension" and "Reseller Id".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// <see cref="SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:1237""}]")]
    public class SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumbersSummaryTable;

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumbersSummaryTable", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1237")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumbersSummaryTable
        {
            get => _mobileSubscriberDirectoryNumbersSummaryTable;
            set
            {
                MobileSubscriberDirectoryNumbersSummaryTableSpecified = true;
                _mobileSubscriberDirectoryNumbersSummaryTable = value;
            }
        }

        [XmlIgnore]
        protected bool MobileSubscriberDirectoryNumbersSummaryTableSpecified { get; set; }

    }
}
