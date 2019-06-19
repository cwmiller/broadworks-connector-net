using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A replacement list of direct route parameters.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4e1b40cd187e65e0dc647394b1e74e3c:113"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""4e1b40cd187e65e0dc647394b1e74e3c:114"",""optional"":true}]}]")]
    public class DirectRouteReplacementIdentityList
    {

        private string _dtgIdentity;

        [XmlElement(ElementName = "dtgIdentity", IsNullable = false, Namespace = "")]
        [Group(@"4e1b40cd187e65e0dc647394b1e74e3c:114")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DtgIdentity
        {
            get => _dtgIdentity;
            set
            {
                DtgIdentitySpecified = true;
                _dtgIdentity = value;
            }
        }

        [XmlIgnore]
        public bool DtgIdentitySpecified { get; set; }

        private string _trunkIdentity;

        [XmlElement(ElementName = "trunkIdentity", IsNullable = false, Namespace = "")]
        [Group(@"4e1b40cd187e65e0dc647394b1e74e3c:114")]
        [MinLength(1)]
        [MaxLength(161)]
        public string TrunkIdentity
        {
            get => _trunkIdentity;
            set
            {
                TrunkIdentitySpecified = true;
                _trunkIdentity = value;
            }
        }

        [XmlIgnore]
        public bool TrunkIdentitySpecified { get; set; }

    }
}
