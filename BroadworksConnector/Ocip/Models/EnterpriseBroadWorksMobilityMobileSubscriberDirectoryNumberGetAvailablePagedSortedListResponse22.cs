using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListRequest22.
    /// The response contains the number of entries that would be returned if the response was not page size restricted.
    /// Contains a table with columns: "Mobile Number", "Mobile Network", "Mobile Country Code", "Mobile National Prefix".
    /// The "Mobile Number" column contains a single DN.
    /// The "Mobile Network" column contains the Mobile Network the number belongs to.
    /// The "Mobile Country Code" column indicates the dialing prefix for the mobile number.
    /// The "Mobile National Prefix" column indicates the digit sequence to be dialed before the mobile number.
    /// <see cref="EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:285""}]")]
    public class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:285")]
        public int TotalNumberOfRows
        {
            get => _totalNumberOfRows;
            set
            {
                TotalNumberOfRowsSpecified = true;
                _totalNumberOfRows = value;
            }
        }

        [XmlIgnore]
        protected bool TotalNumberOfRowsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _availableMobileSubscriberDirectoryNumberTable;

        [XmlElement(ElementName = "availableMobileSubscriberDirectoryNumberTable", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:285")]
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
