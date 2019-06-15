using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceManagementGetEventStatusSummaryCountRequest.
    /// The column headings are "Action, "Pending", "Queued Internally", and "Completed"
        /// <see cref="SystemDeviceManagementGetEventStatusSummaryCountRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDeviceManagementGetEventStatusSummaryCountResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _statusCountTable;

        [XmlElement(ElementName = "statusCountTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable StatusCountTable {
            get => _statusCountTable;
            set {
                StatusCountTableSpecified = true;
                _statusCountTable = value;
            }
        }

        [XmlIgnore]
        public bool StatusCountTableSpecified { get; set; }
        
    }
}
