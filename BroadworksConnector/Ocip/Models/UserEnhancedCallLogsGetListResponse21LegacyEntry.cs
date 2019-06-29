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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7302""}]")]
    public class UserEnhancedCallLogsGetListResponse21LegacyEntry
    {

        private List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry> _callLog = new List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry>();

        [XmlElement(ElementName = "callLog", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7302")]
        public List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry> CallLog
        {
            get => _callLog;
            set
            {
                CallLogSpecified = true;
                _callLog = value;
            }
        }

        [XmlIgnore]
        protected bool CallLogSpecified { get; set; }

    }
}
