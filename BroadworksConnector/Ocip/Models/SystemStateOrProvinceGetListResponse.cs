using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a 2 column table with column headings 'Key' and 'Display Name' and a row
    /// for each state or province.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemStateOrProvinceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _stateOrProvinceTable;

        [XmlElement(ElementName = "stateOrProvinceTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable StateOrProvinceTable {
            get => _stateOrProvinceTable;
            set {
                StateOrProvinceTableSpecified = true;
                _stateOrProvinceTable = value;
            }
        }

        [XmlIgnore]
        public bool StateOrProvinceTableSpecified { get; set; }
        
    }
}
