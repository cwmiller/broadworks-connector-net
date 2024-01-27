using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserGroupCommonPhoneListGetPagedSortedListRequest.
    /// The response contains the group's common phone list. The response
    /// contains a table with column headings: "Name" and "Phone Number".
    /// <see cref="UserGroupCommonPhoneListGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2361""}]")]
    public class UserGroupCommonPhoneListGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2361")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _groupCommonPhoneListTable;

        [XmlElement(ElementName = "groupCommonPhoneListTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2361")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupCommonPhoneListTable
        {
            get => _groupCommonPhoneListTable;
            set
            {
                GroupCommonPhoneListTableSpecified = true;
                _groupCommonPhoneListTable = value;
            }
        }

        [XmlIgnore]
        protected bool GroupCommonPhoneListTableSpecified { get; set; }

    }
}
