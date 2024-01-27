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

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3505""}]")]
    public class MeetMeConferencingConferencePorts
    {

        protected bool _unlimited;

        [XmlElement(ElementName = "unlimited", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3505")]
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
        protected bool UnlimitedSpecified { get; set; }

        protected int _quantity;

        [XmlElement(ElementName = "quantity", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3505")]
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
        protected bool QuantitySpecified { get; set; }

    }
}
