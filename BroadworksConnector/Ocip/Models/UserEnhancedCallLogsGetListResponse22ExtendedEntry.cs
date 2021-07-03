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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:13283""}]")]
    public class UserEnhancedCallLogsGetListResponse22ExtendedEntry
    {

        private List<BroadWorksConnector.Ocip.Models.ExtendedMixedCallLogsEntry22> _extendedCallLog = new List<BroadWorksConnector.Ocip.Models.ExtendedMixedCallLogsEntry22>();

        [XmlElement(ElementName = "extendedCallLog", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:13283")]
        public List<BroadWorksConnector.Ocip.Models.ExtendedMixedCallLogsEntry22> ExtendedCallLog
        {
            get => _extendedCallLog;
            set
            {
                ExtendedCallLogSpecified = true;
                _extendedCallLog = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedCallLogSpecified { get; set; }

    }
}
