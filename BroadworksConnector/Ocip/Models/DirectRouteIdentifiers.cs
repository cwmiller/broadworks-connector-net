using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Direct Route identifiers.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""448c1807ef39a1a06e7d8d4d16ecaa31:99"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""448c1807ef39a1a06e7d8d4d16ecaa31:100""}]}]")]
    public class DirectRouteIdentifiers
    {

        protected string _dtgIdentity;

        [XmlElement(ElementName = "dtgIdentity", IsNullable = false, Namespace = "")]
        [Group(@"448c1807ef39a1a06e7d8d4d16ecaa31:100")]
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
        protected bool DtgIdentitySpecified { get; set; }

        protected string _trunkIdentity;

        [XmlElement(ElementName = "trunkIdentity", IsNullable = false, Namespace = "")]
        [Group(@"448c1807ef39a1a06e7d8d4d16ecaa31:100")]
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
        protected bool TrunkIdentitySpecified { get; set; }

    }
}
