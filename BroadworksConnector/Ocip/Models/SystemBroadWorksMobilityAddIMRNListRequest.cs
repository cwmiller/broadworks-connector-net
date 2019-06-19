using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Adds BroadWorks Mobility IMRN numbers to the system. It is possible to add either:
    /// a single number, a list of numbers, or a range of numbers, or any combination thereof.
    /// The response is either a SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:652""}]")]
    public class SystemBroadWorksMobilityAddIMRNListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private List<string> _imrnNumber = new List<string>();

        [XmlElement(ElementName = "imrnNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:652")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> ImrnNumber
        {
            get => _imrnNumber;
            set
            {
                ImrnNumberSpecified = true;
                _imrnNumber = value;
            }
        }

        [XmlIgnore]
        public bool ImrnNumberSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.DNRange> _numberRange = new List<BroadWorksConnector.Ocip.Models.DNRange>();

        [XmlElement(ElementName = "numberRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:652")]
        public List<BroadWorksConnector.Ocip.Models.DNRange> NumberRange
        {
            get => _numberRange;
            set
            {
                NumberRangeSpecified = true;
                _numberRange = value;
            }
        }

        [XmlIgnore]
        public bool NumberRangeSpecified { get; set; }

    }
}
