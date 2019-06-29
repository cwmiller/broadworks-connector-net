using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest.
    /// The column headings are "Phone Number", "Group Id" and "Mobile Network".
    /// <see cref="ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:607""}]")]
    public class ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumbersSummaryTable;

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumbersSummaryTable", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:607")]
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
