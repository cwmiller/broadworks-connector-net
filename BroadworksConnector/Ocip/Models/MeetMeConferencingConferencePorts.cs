using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Number of conference ports. Can either be unlimited or limited to a value between 0 and 999999.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:1042""}]")]
    public class MeetMeConferencingConferencePorts
    {

        private bool _unlimited;

        [XmlElement(ElementName = "unlimited", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:1042")]
        public bool Unlimited
        {
            get => _unlimited;
            set
            {
                UnlimitedSpecified = true;
                _unlimited = value;
            }
        }

        [XmlIgnore]
        public bool UnlimitedSpecified { get; set; }

        private int _quantity;

        [XmlElement(ElementName = "quantity", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:1042")]
        [MinInclusive(0)]
        [MaxInclusive(999999)]
        public int Quantity
        {
            get => _quantity;
            set
            {
                QuantitySpecified = true;
                _quantity = value;
            }
        }

        [XmlIgnore]
        public bool QuantitySpecified { get; set; }

    }
}
