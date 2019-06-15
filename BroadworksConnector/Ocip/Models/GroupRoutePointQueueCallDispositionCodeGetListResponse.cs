using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointQueueCallDispositionCodeGetListRequest.
    /// Contains a table with column headings: "Is Active", "Code", "Description" and "Level".
    /// Level column can be any of the values in the data type CallDispositionCodeLevel.
        /// <see cref="GroupRoutePointQueueCallDispositionCodeGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupRoutePointQueueCallDispositionCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
