using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDeviceTypeCustomTagGetListRequest.
    /// Contains a table of custom configuration tags managed by the Device Management System on a per-device type basis for a group.
    /// In As data mode, the column headings are:
    /// "Tag Name", "Tag Value", "Actual Tag Value".
    /// In XS data mode, the column headings are:
    /// "Tag Name", "Tag Value", "Actual Tag Value" if request is invoked by an admin without system privileges.
    /// "Tag Name", "Tag Value", "Is Encrypted", "Actual Tag Value" if request is invoked by an admin with system privileges.
    /// <see cref="GroupDeviceTypeCustomTagGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4302""}]")]
    public class GroupDeviceTypeCustomTagGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _groupDeviceTypeCustomTagsTable;

        [XmlElement(ElementName = "groupDeviceTypeCustomTagsTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4302")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupDeviceTypeCustomTagsTable
        {
            get => _groupDeviceTypeCustomTagsTable;
            set
            {
                GroupDeviceTypeCustomTagsTableSpecified = true;
                _groupDeviceTypeCustomTagsTable = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDeviceTypeCustomTagsTableSpecified { get; set; }

    }
}
