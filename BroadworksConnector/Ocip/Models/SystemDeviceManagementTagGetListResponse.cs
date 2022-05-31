using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceManagementTagGetListRequest.
    /// Contains a table of custom configuration tags managed by the Device Management System.
    /// In AS data mode, the column headings are: "Tag Name", "Tag Value", "Is Overridable".
    /// In XS data mode, the column headings are: "Tag Name", "Tag Value", "Is Overridable", "Is Encrypted".
    /// <see cref="SystemDeviceManagementTagGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8021""}]")]
    public class SystemDeviceManagementTagGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _tagsTable;

        [XmlElement(ElementName = "tagsTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8021")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TagsTable
        {
            get => _tagsTable;
            set
            {
                TagsTableSpecified = true;
                _tagsTable = value;
            }
        }

        [XmlIgnore]
        protected bool TagsTableSpecified { get; set; }

    }
}
