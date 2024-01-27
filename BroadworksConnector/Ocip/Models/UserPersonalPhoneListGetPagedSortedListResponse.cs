using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserPersonalPhoneListGetPagedSortedListRequest.
    /// The response contains a user's personal phone list. The response
    /// contains a table with column headings: "Name" and "Phone Number".
    /// <see cref="UserPersonalPhoneListGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2909""}]")]
    public class UserPersonalPhoneListGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2909")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _personalPhoneListTable;

        [XmlElement(ElementName = "personalPhoneListTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2909")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PersonalPhoneListTable
        {
            get => _personalPhoneListTable;
            set
            {
                PersonalPhoneListTableSpecified = true;
                _personalPhoneListTable = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalPhoneListTableSpecified { get; set; }

    }
}
