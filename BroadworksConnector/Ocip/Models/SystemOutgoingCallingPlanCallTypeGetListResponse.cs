using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOutgoingCallingPlanCallTypeGetListRequest.
        /// <see cref="SystemOutgoingCallingPlanCallTypeGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOutgoingCallingPlanCallTypeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallType> _callType;

        [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallType> CallType {
            get => _callType;
            set {
                CallTypeSpecified = true;
                _callType = value;
            }
        }

        [XmlIgnore]
        public bool CallTypeSpecified { get; set; }
        
    }
}
