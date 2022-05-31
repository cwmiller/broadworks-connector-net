using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Statistics Range
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7724""}]")]
    public class CallCenterStatisticsRange
    {

        protected string _start;

        [XmlElement(ElementName = "start", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7724")]
        public string Start
        {
            get => _start;
            set
            {
                StartSpecified = true;
                _start = value;
            }
        }

        [XmlIgnore]
        protected bool StartSpecified { get; set; }

        protected string _end;

        [XmlElement(ElementName = "end", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7724")]
        public string End
        {
            get => _end;
            set
            {
                EndSpecified = true;
                _end = value;
            }
        }

        [XmlIgnore]
        protected bool EndSpecified { get; set; }

    }
}
