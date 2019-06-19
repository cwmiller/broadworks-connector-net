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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2868""}]")]
    public class UserPersonalPhoneListGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2868")]
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
        public bool TotalNumberOfRowsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _personalPhoneListTable;

        [XmlElement(ElementName = "personalPhoneListTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2868")]
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
        public bool PersonalPhoneListTableSpecified { get; set; }

    }
}
