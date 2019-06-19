using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserEnterpriseCommonPhoneListGetPagedSortedListRequest. The response
    /// contains the enterprise's common phone list. The response contains a
    /// table with column headings: "Name" and "Phone Number".
    /// <see cref="UserEnterpriseCommonPhoneListGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1653""}]")]
    public class UserEnterpriseCommonPhoneListGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1653")]
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

        private BroadWorksConnector.Ocip.Models.C.OCITable _enterpriseCommonPhoneListTable;

        [XmlElement(ElementName = "enterpriseCommonPhoneListTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1653")]
        public BroadWorksConnector.Ocip.Models.C.OCITable EnterpriseCommonPhoneListTable
        {
            get => _enterpriseCommonPhoneListTable;
            set
            {
                EnterpriseCommonPhoneListTableSpecified = true;
                _enterpriseCommonPhoneListTable = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseCommonPhoneListTableSpecified { get; set; }

    }
}
