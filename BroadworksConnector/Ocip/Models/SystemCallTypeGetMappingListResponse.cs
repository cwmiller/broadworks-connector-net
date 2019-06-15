using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallTypeGetMappingListRequest. The table columns are:
    /// "Country Code", "Digit Map" and "Call Type".
        /// <see cref="SystemCallTypeGetMappingListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallTypeGetMappingListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _callTypeMapping;

        [XmlElement(ElementName = "callTypeMapping", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallTypeMapping {
            get => _callTypeMapping;
            set {
                CallTypeMappingSpecified = true;
                _callTypeMapping = value;
            }
        }

        [XmlIgnore]
        public bool CallTypeMappingSpecified { get; set; }
        
    }
}
