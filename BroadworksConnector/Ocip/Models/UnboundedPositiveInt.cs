using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Unbounded Quantity. Can either be unlimited or a positive int quantity.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:5198""}]")]
    public class UnboundedPositiveInt
    {

        private bool _unlimited;

        [XmlElement(ElementName = "unlimited", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:5198")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:5198")]
        [MinInclusive(1)]
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
