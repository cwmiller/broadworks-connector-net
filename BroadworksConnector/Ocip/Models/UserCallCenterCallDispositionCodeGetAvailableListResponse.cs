using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallCenterCallDispositionCodeGetAvailableListRequest.
    /// This list may include Group/Enterprise level codes in addition to the Call Center level codes,
    /// depending on the call center disposition codes settings.
    /// Only active codes are included in the list.
    /// Contains a table with column headings: "Code", "Description" and "Level".
    /// Level column can be any of the values in the data type CallDispositionCodeLevel.
        /// <see cref="UserCallCenterCallDispositionCodeGetAvailableListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterCallDispositionCodeGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _dispositionCodesTable;

        [XmlElement(ElementName = "dispositionCodesTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DispositionCodesTable {
            get => _dispositionCodesTable;
            set {
                DispositionCodesTableSpecified = true;
                _dispositionCodesTable = value;
            }
        }

        [XmlIgnore]
        public bool DispositionCodesTableSpecified { get; set; }
        
    }
}
