using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupScheduleUsageRequest.
    /// The response contains a list of service names.
    /// The response contains the usage for the requested schedule.
    /// The usage table has columns "Service Name", and "Instance Name".
    /// The Service Name values correspond to string values of the GroupService and UserService data types.
        /// <see cref="GroupScheduleUsageRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupScheduleUsageResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _usageTable;

        [XmlElement(ElementName = "usageTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UsageTable {
            get => _usageTable;
            set {
                UsageTableSpecified = true;
                _usageTable = value;
            }
        }

        [XmlIgnore]
        public bool UsageTableSpecified { get; set; }
        
    }
}
