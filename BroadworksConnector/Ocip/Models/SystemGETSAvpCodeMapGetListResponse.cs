using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGETSAvpCodeMapGetListRequest.
    /// The table columns are: "AVP Code" and "Vendor ID".
        /// <see cref="SystemGETSAvpCodeMapGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGETSAvpCodeMapGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _avpCodeTable;

        [XmlElement(ElementName = "avpCodeTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AvpCodeTable {
            get => _avpCodeTable;
            set {
                AvpCodeTableSpecified = true;
                _avpCodeTable = value;
            }
        }

        [XmlIgnore]
        public bool AvpCodeTableSpecified { get; set; }
        
    }
}
