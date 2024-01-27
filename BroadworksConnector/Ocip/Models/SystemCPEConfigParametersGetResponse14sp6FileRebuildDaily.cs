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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:25911""}]")]
    public class SystemCPEConfigParametersGetResponse14sp6FileRebuildDaily
    {

        protected int _startHour;

        [XmlElement(ElementName = "startHour", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:25911")]
        [MinInclusive(0)]
        [MaxInclusive(23)]
        public int StartHour
        {
            get => _startHour;
            set
            {
                StartHourSpecified = true;
                _startHour = value;
            }
        }

        [XmlIgnore]
        protected bool StartHourSpecified { get; set; }

        protected int _startMinute;

        [XmlElement(ElementName = "startMinute", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:25911")]
        [MinInclusive(0)]
        [MaxInclusive(59)]
        public int StartMinute
        {
            get => _startMinute;
            set
            {
                StartMinuteSpecified = true;
                _startMinute = value;
            }
        }

        [XmlIgnore]
        protected bool StartMinuteSpecified { get; set; }

    }
}
