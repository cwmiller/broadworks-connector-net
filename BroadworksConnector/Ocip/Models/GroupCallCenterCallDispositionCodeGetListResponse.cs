using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterCallDispositionCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _dispositionCodesTable;

        [XmlElement(ElementName = "dispositionCodesTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable DispositionCodesTable
        {
            get => _dispositionCodesTable;
            set
            {
                DispositionCodesTableSpecified = true;
                _dispositionCodesTable = value;
            }
        }

        [XmlIgnore]
        public bool DispositionCodesTableSpecified { get; set; }
    }
}
