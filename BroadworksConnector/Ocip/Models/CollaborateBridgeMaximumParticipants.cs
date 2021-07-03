using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Maximum number of Collaborate bridge participants. Can either be unlimited or limited to a value between 3 and 999999.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1104""}]")]
    public class CollaborateBridgeMaximumParticipants
    {

        private bool _unlimited;

        [XmlElement(ElementName = "unlimited", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1104")]
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

        private int _quantity;

        [XmlElement(ElementName = "quantity", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1104")]
        [MinInclusive(3)]
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
