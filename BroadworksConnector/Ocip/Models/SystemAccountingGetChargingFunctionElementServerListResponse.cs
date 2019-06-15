using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccountingGetChargingFunctionElementServerListRequest. The accounting charging function element Server table column
    /// headings are: "Address", "Extended Net Address", "Type", "Description".
        /// <see cref="SystemAccountingGetChargingFunctionElementServerListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccountingGetChargingFunctionElementServerListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _chargingFunctionElementServerTable;

        [XmlElement(ElementName = "chargingFunctionElementServerTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ChargingFunctionElementServerTable {
            get => _chargingFunctionElementServerTable;
            set {
                ChargingFunctionElementServerTableSpecified = true;
                _chargingFunctionElementServerTable = value;
            }
        }

        [XmlIgnore]
        public bool ChargingFunctionElementServerTableSpecified { get; set; }
        
    }
}
