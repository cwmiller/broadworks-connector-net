using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemNumberPortabilityQueryStatusGetListRequest.
    /// Contains a table with column headings:
    /// "Status and Treatment File Name".
        /// <see cref="SystemNumberPortabilityQueryStatusGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberPortabilityQueryStatusGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _statusTable;

        [XmlElement(ElementName = "statusTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable StatusTable {
            get => _statusTable;
            set {
                StatusTableSpecified = true;
                _statusTable = value;
            }
        }

        [XmlIgnore]
        public bool StatusTableSpecified { get; set; }
        
    }
}
