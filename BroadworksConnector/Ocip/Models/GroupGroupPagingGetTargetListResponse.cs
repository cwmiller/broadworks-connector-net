using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupGroupPagingGetTargetListRequest.
    /// Contains a table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address".
    /// <see cref="GroupGroupPagingGetTargetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d36df8c109e3ea7324f79031368c661:388""}]")]
    public class GroupGroupPagingGetTargetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _targetTable;

        [XmlElement(ElementName = "targetTable", IsNullable = false, Namespace = "")]
        [Group(@"0d36df8c109e3ea7324f79031368c661:388")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TargetTable
        {
            get => _targetTable;
            set
            {
                TargetTableSpecified = true;
                _targetTable = value;
            }
        }

        [XmlIgnore]
        protected bool TargetTableSpecified { get; set; }

    }
}
