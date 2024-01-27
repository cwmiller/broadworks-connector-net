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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:1759""}]")]
    public class UserEnterpriseCommonPhoneListGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1759")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _enterpriseCommonPhoneListTable;

        [XmlElement(ElementName = "enterpriseCommonPhoneListTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1759")]
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
        protected bool EnterpriseCommonPhoneListTableSpecified { get; set; }

    }
}
