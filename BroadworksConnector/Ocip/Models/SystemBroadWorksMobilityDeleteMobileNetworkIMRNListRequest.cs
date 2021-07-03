using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Remove BroadWorks Mobility IMRN numbers from a Mobile Network.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:727""}]")]
    public class SystemBroadWorksMobilityDeleteMobileNetworkIMRNListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _mobileNetworkName;

        [XmlElement(ElementName = "mobileNetworkName", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:727")]
        [MinLength(1)]
        [MaxLength(80)]
        public string MobileNetworkName
        {
            get => _mobileNetworkName;
            set
            {
                MobileNetworkNameSpecified = true;
                _mobileNetworkName = value;
            }
        }

        [XmlIgnore]
        protected bool MobileNetworkNameSpecified { get; set; }

        private List<string> _imrnNumber = new List<string>();

        [XmlElement(ElementName = "imrnNumber", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:727")]
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
        protected bool ImrnNumberSpecified { get; set; }

    }
}
