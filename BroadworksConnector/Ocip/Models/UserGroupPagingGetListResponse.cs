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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8ede928f2a9c1318573ba9c7a105655c:595""}]")]
    public class UserGroupPagingGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _pagingGroupTable;

        [XmlElement(ElementName = "pagingGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:595")]
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
