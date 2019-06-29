using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListRequest.
    /// The response contains a table with columns: "Mobile Number", "Mobile Network", "Mobile Country Code",
    /// "Mobile National Prefix".
    /// The "Mobile Number" column contains a single DN.
    /// The "Mobile Network" column contains the Mobile Network the number belongs to.
    /// The "Mobile Country Code" column indicates the dialing prefix for the mobile number.
    /// The "Mobile National Prefix" column indicates the digit sequence to be dialed before the mobile number.
    /// <see cref="EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:268""}]")]
    public class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _availableMobileSubscriberDirectoryNumberTable;

        [XmlElement(ElementName = "availableMobileSubscriberDirectoryNumberTable", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:268")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AvailableMobileSubscriberDirectoryNumberTable
        {
            get => _availableMobileSubscriberDirectoryNumberTable;
            set
            {
                AvailableMobileSubscriberDirectoryNumberTableSpecified = true;
                _availableMobileSubscriberDirectoryNumberTable = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableMobileSubscriberDirectoryNumberTableSpecified { get; set; }

    }
}
