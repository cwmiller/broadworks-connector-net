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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d36df8c109e3ea7324f79031368c661:345""}]")]
    public class GroupGroupPagingGetOriginatorListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _originatorTable;

        [XmlElement(ElementName = "originatorTable", IsNullable = false, Namespace = "")]
        [Group(@"0d36df8c109e3ea7324f79031368c661:345")]
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
        public bool OriginatorTableSpecified { get; set; }

    }
}
