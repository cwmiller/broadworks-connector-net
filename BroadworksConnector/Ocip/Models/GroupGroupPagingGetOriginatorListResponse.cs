using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupGroupPagingGetOriginatorListRequest.
    /// Contains a table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address".
    /// <see cref="GroupGroupPagingGetOriginatorListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8ede928f2a9c1318573ba9c7a105655c:353""}]")]
    public class GroupGroupPagingGetOriginatorListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _originatorTable;

        [XmlElement(ElementName = "originatorTable", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:353")]
        public BroadWorksConnector.Ocip.Models.C.OCITable OriginatorTable
        {
            get => _originatorTable;
            set
            {
                OriginatorTableSpecified = true;
                _originatorTable = value;
            }
        }

        [XmlIgnore]
        protected bool OriginatorTableSpecified { get; set; }

    }
}
