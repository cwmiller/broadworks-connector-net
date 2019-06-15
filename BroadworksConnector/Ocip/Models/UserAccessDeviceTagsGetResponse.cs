using System;
using System.Xml.Serialization;
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
     
    public class UserAccessDeviceTagsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceTagsTable;

        [XmlElement(ElementName = "deviceTagsTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceTagsTable {
            get => _deviceTagsTable;
            set {
                DeviceTagsTableSpecified = true;
                _deviceTagsTable = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTagsTableSpecified { get; set; }
        
    }
}
