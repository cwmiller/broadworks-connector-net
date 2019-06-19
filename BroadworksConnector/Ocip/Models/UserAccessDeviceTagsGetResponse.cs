using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAccessDeviceTagsGetRequest.
    /// The response contains a table with columns: "Tag Name", and "Tag Value".
    /// <see cref="UserAccessDeviceTagsGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:254""}]")]
    public class UserAccessDeviceTagsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceTagsTable;

        [XmlElement(ElementName = "deviceTagsTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:254")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceTagsTable
        {
            get => _deviceTagsTable;
            set
            {
                DeviceTagsTableSpecified = true;
                _deviceTagsTable = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTagsTableSpecified { get; set; }

    }
}
