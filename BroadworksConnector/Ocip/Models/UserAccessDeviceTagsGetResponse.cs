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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:324""}]")]
    public class UserAccessDeviceTagsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceTagsTable;

        [XmlElement(ElementName = "deviceTagsTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:324")]
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
        protected bool DeviceTagsTableSpecified { get; set; }

    }
}
