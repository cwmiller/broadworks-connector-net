using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserGroupPagingGetListRequest.
    /// The groupPagingTable contains columns: "Name", "Phone Number", "Extension" and "Is Active"
    /// The column value for "Is Active" can either be true, or false.
    /// <see cref="UserGroupPagingGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d36df8c109e3ea7324f79031368c661:584""}]")]
    public class UserGroupPagingGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _pagingGroupTable;

        [XmlElement(ElementName = "pagingGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"0d36df8c109e3ea7324f79031368c661:584")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PagingGroupTable
        {
            get => _pagingGroupTable;
            set
            {
                PagingGroupTableSpecified = true;
                _pagingGroupTable = value;
            }
        }

        [XmlIgnore]
        protected bool PagingGroupTableSpecified { get; set; }

    }
}
