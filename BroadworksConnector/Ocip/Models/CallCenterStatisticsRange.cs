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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7710""}]")]
    public class CallCenterStatisticsRange
    {

        protected string _start;

        [XmlElement(ElementName = "start", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7710")]
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
        [Group(@"4d65d3449061c568639c8cc1e2492285:7710")]
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
