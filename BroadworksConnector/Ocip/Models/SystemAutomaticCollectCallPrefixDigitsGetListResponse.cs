using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemAutomaticCollectCallPrefixDigitsGetListRequest.
    /// Contains a table with column headings: "Country Code", "Prefix".
    /// <see cref="SystemAutomaticCollectCallPrefixDigitsGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d5db1a19a0aeda6f13d1f1c609efa0a:144""}]")]
    public class SystemAutomaticCollectCallPrefixDigitsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _prefixTable;

        [XmlElement(ElementName = "prefixTable", IsNullable = false, Namespace = "")]
        [Group(@"0d5db1a19a0aeda6f13d1f1c609efa0a:144")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PrefixTable
        {
            get => _prefixTable;
            set
            {
                PrefixTableSpecified = true;
                _prefixTable = value;
            }
        }

        [XmlIgnore]
        protected bool PrefixTableSpecified { get; set; }

    }
}
