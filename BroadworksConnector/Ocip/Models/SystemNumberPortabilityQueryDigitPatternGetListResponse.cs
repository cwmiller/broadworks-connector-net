using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemNumberPortabilityQueryDigitPatternGetListRequest.
    /// Contains a table with column headings:
    /// "Digit Pattern", "Status".
        /// <see cref="SystemNumberPortabilityQueryDigitPatternGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberPortabilityQueryDigitPatternGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _statusDigitPatternTable;

        [XmlElement(ElementName = "statusDigitPatternTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable StatusDigitPatternTable {
            get => _statusDigitPatternTable;
            set {
                StatusDigitPatternTableSpecified = true;
                _statusDigitPatternTable = value;
            }
        }

        [XmlIgnore]
        public bool StatusDigitPatternTableSpecified { get; set; }
        
    }
}
