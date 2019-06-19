using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7352""}]")]
    public class UserEnhancedCallLogsGetListResponse21sp1ExtendedEntry
    {

        private List<BroadWorksConnector.Ocip.Models.ExtendedMixedCallLogsEntry21sp1> _extendedCallLog = new List<BroadWorksConnector.Ocip.Models.ExtendedMixedCallLogsEntry21sp1>();

        [XmlElement(ElementName = "extendedCallLog", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7352")]
        public List<BroadWorksConnector.Ocip.Models.ExtendedMixedCallLogsEntry21sp1> ExtendedCallLog
        {
            get => _extendedCallLog;
            set
            {
                ExtendedCallLogSpecified = true;
                _extendedCallLog = value;
            }
        }

        [XmlIgnore]
        public bool ExtendedCallLogSpecified { get; set; }

    }
}
